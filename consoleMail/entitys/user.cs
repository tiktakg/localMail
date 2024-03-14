using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleMail.entitys
{
    public class user
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }

        public user(string login, string password, string firstName, string secondName, string position = "", string department = "")
        {
            Login = login;
            Password = password;
            FirstName = firstName;
            SecondName = secondName;
            Position = position;
            Department = department;
        }
    }
}
