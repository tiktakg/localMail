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
        public string reciverOfMsg { get; set; }
        public string textOfMsg { get; set; }
        public string priority { get; set; }
        public string fileOfMsg { get; set; }
        public string fileExtension { get; set; }
        public string fileName { get; set; }

    }
}
