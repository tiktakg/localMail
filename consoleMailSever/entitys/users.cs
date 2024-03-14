using System.ComponentModel.DataAnnotations;

namespace consoleMailSever.entitys
{
    public class users
    {
        [Key]
        public int id;
        public string userDataId { get; set; }
        public string login { get; set; }
        public string password { get; set; }
     
    }
}
