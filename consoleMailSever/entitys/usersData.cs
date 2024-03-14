using System.ComponentModel.DataAnnotations;

namespace consoleMailSever.entitys
{
    public class usersData
    {
        [Key]
        public int id;
        public string firstName { get; set; }
        public string secondName { get; set; }
        public string position { get; set; }
        public string department { get; set; }
    }
}
