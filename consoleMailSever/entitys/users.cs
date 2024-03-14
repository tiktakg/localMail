using System.ComponentModel.DataAnnotations;

namespace consoleMailSever.entitys
{
    public class users
    {
        [Key]
        public int id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }

    }
}
