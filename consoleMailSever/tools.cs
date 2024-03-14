using consoleMailSever.entitys;
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
    }
}
