using consoleMail.entitys;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Logging;
using Newtonsoft.Json;
using System.Diagnostics;

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
        static public void sendMsg(string themeOfMsg, string senderOfMsg, string recieverOfMsg, string textOfMsg, string fileOfMsg, string priority)
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

            msg newMsg = new msg(themeOfMsg, senderOfMsg, recieverOfMsg, textOfMsg, priority, fileOfMsg, fileExtension, fileName);
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

        static public List<string> getMsgWithCurrentPrioprity(string priority, List<msg> allMsg)
        {
            List<string> msgListWithPriority = new List<string>();

            if (priority == "Все")
                return allMsg.Select(t => t.ThemeOfMsg).ToList();


            msgListWithPriority = allMsg.FindAll(p => p.Priority == priority).Select(t => t.ThemeOfMsg).ToList();

            return msgListWithPriority;
        }

        static public List<string> findSortedMsg(string strToFind, List<msg> allMsg)
        {
            return allMsg.Where(m =>
            m.ThemeOfMsg.Contains(strToFind) ||
            m.ReciverOfMsg.Contains(strToFind) ||
            m.TextOfMsg.Contains(strToFind)).Select(t => t.ThemeOfMsg).ToList();
        }
    }
}
