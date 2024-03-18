using consoleMail.entitys;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Logging;
using Newtonsoft.Json;
using System.Diagnostics;
using System.IO;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace consoleMail
{
    class tools
    {

        static public void tryMakeNewUser(string login, string passwod, string firstName, string secondName, string postion = "", string department = "")
        {
            user newUser = new user(login, passwod, firstName, secondName, postion, department);
            string jsonUser = JsonConvert.SerializeObject(newUser);

            clientMail.connectToSever();
            clientMail.SendMessageAsync("{\"newUser\":" + jsonUser + "}");


        }

        static public void sendMsg(string themeOfMsg, string senderOfMsg, string recieverOfMsg, string textOfMsg, string fileOfMsg, string priority, DateTime dateOfMsg)
        {
            string fileExtension = "";
            string fileName = "";

            if (fileOfMsg != "")
            {

                fileExtension = fileOfMsg.Substring(fileOfMsg.LastIndexOf(".") + 1);
                fileName = fileOfMsg.Substring(fileOfMsg.LastIndexOf("\\") + 1);
                fileName = fileName.Substring(0, fileName.LastIndexOf("."));
                fileOfMsg = FileToBase64(fileOfMsg);
            }

            msg newMsg = new msg(themeOfMsg, senderOfMsg, recieverOfMsg, textOfMsg, priority, fileOfMsg, fileExtension, fileName, dateOfMsg);
            string jsonMsg = JsonConvert.SerializeObject(newMsg);

            clientMail.SendMessageAsync("{\"msg\":" + jsonMsg + "}").Wait();
        }

        static public bool checkEmptyFiled(params string[] textFields)
        {
            foreach (string textField in textFields)
                if (textField == "")
                    return false;

            return true;
        }
        static public List<TextBox> findEmptyFiledAndSetColorRed(params TextBox[] textFields)
        {
            List<TextBox> emptyFields = new List<TextBox>();

            foreach (var textField in textFields)
                if (textField.Text == "")
                {
                    textField.BackColor = Color.Red;
                    emptyFields.Add(textField);
                }

            return emptyFields;
        }

        static public user isUserExist(string loginOfUser, string passwordOfUser)
        {

            user newUser = new user(loginOfUser, passwordOfUser, "", "", "");
            string jsonUser = JsonConvert.SerializeObject(newUser);

            clientMail.connectToSever();
            clientMail.SendMessageAsync("{\"findUser\":" + jsonUser + "}");

            return newUser;

        }

        static public bool prepereMsg(msg newMsg, string userLogin)
        {
            if (newMsg.ReciverOfMsg == userLogin)
                return true;
            return false;
        }



        static private string FileToBase64(string fileName)
        {
            byte[] bytes = File.ReadAllBytes(fileName);
            return Convert.ToBase64String(bytes);
        }
        static public string base64ToFile(string base64String, string fileExtension, string fileName)
        {
            if (base64String == "")
                return "";

            byte[] bytes = Convert.FromBase64String(base64String);

            string newPathOfFile = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            string filePath = Path.Combine(newPathOfFile, fileName + "." + fileExtension);

            File.WriteAllBytes(filePath, bytes);

            return filePath;
        }

        static public List<msg> getAllMsg(user currentUser)
        {
            string jsonUser = JsonConvert.SerializeObject(currentUser);
            clientMail.SendMessageAsync("{\"getAllMsg\":" + jsonUser + "}");

            return new List<msg>();
        }

        static public List<msg> getMsgWithCurrentPrioprity(string priority, List<msg> allMsg)
        {
            List<msg> msgListWithPriority = new List<msg>();

            if (priority == "Все")
                return allMsg.ToList();


            msgListWithPriority = allMsg.FindAll(p => p.Priority == priority).ToList();

            return msgListWithPriority;
        }

        static public List<msg> findSortedMsg(string strToFind, List<msg> allMsg)
        {
            return allMsg.Where(m =>
            m.ThemeOfMsg.Contains(strToFind) ||
            m.SenderOfMsg.Contains(strToFind) ||
            m.TextOfMsg.Contains(strToFind)).ToList();
        }

        static public string getHostFromFile(string hostNameFromUser)
        {
            string newPathOfFile = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filePath = Path.Combine(newPathOfFile, "fileOfHostName.txt");
            string firstLine = "";

            if (File.Exists(filePath))
            {

                try
                {
                    if (hostNameFromUser == "")
                        using (StreamReader reader = new StreamReader(filePath))
                        {
                            firstLine = reader.ReadLine();
                            return firstLine;
                        }
                    else
                    {
                        using (StreamWriter writer = new StreamWriter(filePath, false))
                        {
                            writer.Write(hostNameFromUser);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ошибка при чтении файла: " + ex.Message);
                }


            }
            else
            {
                using (StreamWriter writer = File.CreateText(filePath))
                {
                    writer.WriteLine(hostNameFromUser);
                }
            }


            return hostNameFromUser;
        }

        internal static List<msg> getMsgWithSortDate(string sortedDate, List<msg> allMsg)
        {

            List<msg> allDate = null;

            if (sortedDate == "Все")
                allDate = allMsg.ToList();
            else if (sortedDate == "Самые последние")
                allDate = allMsg.OrderBy(m => DateTime.TryParseExact(m.DateOfMsg, "MM-dd-yyyy", null, System.Globalization.DateTimeStyles.None, out var parsedDate) ? parsedDate : DateTime.MaxValue)
                .ToList();
            else if (sortedDate == "Самые первые")
                allDate = allMsg
                .OrderByDescending(m => DateTime.TryParseExact(m.DateOfMsg, "MM-dd-yyyy", null, System.Globalization.DateTimeStyles.None, out var parsedDate) ? parsedDate : DateTime.MinValue)
                .ToList();

            return allDate;

        }

        internal static List<msg> getMsgWithCurrentDate(string currentDate, List<msg> allMsg)
        {
            DateTime parseDateTime = DateTime.Parse(currentDate);
            currentDate = parseDateTime.ToString("MM-dd-yyyy");
            return allMsg.FindAll(p => p.DateOfMsg == currentDate);
        }
    }
}
