using consoleMailSever.entitys;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleMailSever
{
    internal class tools
    {

        static public List<users> getALlUsers()
        {
            using (DBContext DB = new DBContext())
            {
                return DB.users.ToList();
            }
        }

        static public bool tryAddNewUser(users newUser, List<users> allUsers)
        {
            foreach (users user in allUsers)
                if (user.Login == newUser.Login)
                    return false;


            using (DBContext DB = new DBContext())
            {
                DB.users.Add(newUser);
                DB.SaveChanges();
                return true;
            }
        }
        static public bool isUserExist(users findUser)
        {
            List<users> allUsers = getALlUsers();

            foreach (var user in allUsers)
                if (user.Login == findUser.Login & user.Password == findUser.Password)
                    return true;

            return false;
        }

        static public string getAllMsgForCurrentUser(users currentUser)
        {
            List<messenges> ListOfmsgForCurrentUser = new List<messenges>();
            using (DBContext DB = new DBContext())
            {
                var allMsg = DB.msg.ToList();

                foreach (var msg in allMsg)
                    if (msg.reciverOfMsg == currentUser.Login)
                        ListOfmsgForCurrentUser.Add(msg);
            }

            return JsonConvert.SerializeObject(ListOfmsgForCurrentUser);

        }

        static public void saveMsgToDb(messenges msg)
        {
            using (DBContext DB = new DBContext())
            {
                DB.msg.Add(msg);
                DB.SaveChanges();
            }
        }
    }
}
