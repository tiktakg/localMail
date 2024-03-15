using consoleMail.entitys;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Logging;
using Newtonsoft.Json;

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
        static public void sendMsg(string themeOfMsg, string senderOfMsg,string recieverOfMsg, string textOfMsg, string fileOfMsg = "")
        {
            msg newMsg = new msg(themeOfMsg, senderOfMsg, recieverOfMsg, textOfMsg, fileOfMsg);
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

    }
}
