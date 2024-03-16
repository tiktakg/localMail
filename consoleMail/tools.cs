using consoleMail.entitys;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Logging;
using Newtonsoft.Json;
using System.Diagnostics;

namespace consoleMail
{
    class tools
    {

        static public void  tryMakeNewUser(string login, string passwod, string firstName, string secondName, string postion ="", string department ="")
        {
            user newUser = new user(login, passwod, firstName, secondName,postion,department);
            string jsonUser = JsonConvert.SerializeObject(newUser);

            clientMail.connectToSever();
            clientMail.SendMessageAsync("{\"newUser\":" + jsonUser + "}");


        }
        static public void sendMsg(string themeOfMsg, string senderOfMsg,string recieverOfMsg, string textOfMsg, string fileOfMsg)
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

            msg newMsg = new msg(themeOfMsg, senderOfMsg, recieverOfMsg, textOfMsg, fileOfMsg, fileExtension, fileName);
            string jsonMsg = JsonConvert.SerializeObject(newMsg);

            clientMail.SendMessageAsync("{\"msg\":" + jsonMsg + "}").Wait();
        }

        static public bool checkEmptyFiled(params string[] textFields)
        {
            foreach (string textField in textFields)
                if (textField =="")
                    return false;

            return true;
        }

        static public void isUserExist(string loginOfUser, string passwordOfUser)
        {

            user newUser = new user(loginOfUser, passwordOfUser,"","","");
            string jsonUser = JsonConvert.SerializeObject(newUser);

            clientMail.connectToSever();
            clientMail.SendMessageAsync("{\"findUser\":" + jsonUser + "}");

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
        static public string base64ToFile(string base64String, string fileExtension,string fileName)
        {
            if(base64String == "")
                return "";

            byte[] bytes = Convert.FromBase64String(base64String);

            string newPathOfFile = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            string filePath = Path.Combine(newPathOfFile, fileName + "." + fileExtension);
            File.WriteAllBytes(filePath, bytes);

          

            return filePath;
        }
    }
}
