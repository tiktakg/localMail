using consoleMail.Forms;
using Newtonsoft.Json;

namespace consoleMail
{
    class tools
    {

        static public bool tryMakeNewUser(string login, string passwod, string firstName, string secondName, string postion ="", string department ="")
        {
            user newUser = new user(login, passwod, firstName, secondName,postion,department);
            string jsonUser = JsonConvert.SerializeObject(newUser);

            clientMail.connectToSever();
            clientMail.SendMessageAsync("1" +jsonUser).Wait();
            return true;
           

        }

        static public bool checkEmptyFiled(params string[] textFields)
        {
            foreach (string textField in textFields)
                if (textField is null)
                    return false;
            return true;
        }



     
    }
}
