using System;
using System.ComponentModel.DataAnnotations;


namespace consoleMailSever.entitys
{
    public class messenges
    {
        [Key]
        public int id { get; set; }
        public string themeOfMsg { get; set; }
        public string senderOfMsg { get; set; }
        public string textOfMsg { get; set; }
        public string fildOfMsg { get; set; }
    }
}
