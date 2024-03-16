using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleMail.entitys
{
    public class msg
    {
        public string ThemeOfMsg { get; set; }
        public string SenderOfMsg { get; set; }
        public string ReciverOfMsg { get; set; }
        public string TextOfMsg { get; set; }
        public string Priority {  get; set; }
        public string FileOfMsg { get; set; }
        public string FileExtension { get; set; }
        public string FileName {  get; set; }
        public int Id {  get; set; }




        public msg(string themeOfMsg, string senderOfMsg,string reciverOfMsg, string textOfMsg,string priority, string fileOfMsg = "", string fileExtension = "", string fileName = "")
        {
            ThemeOfMsg = themeOfMsg;
            SenderOfMsg = senderOfMsg;
            ReciverOfMsg = reciverOfMsg;
            TextOfMsg = textOfMsg;
            Priority = priority;
            FileOfMsg = fileOfMsg;
            FileExtension = fileExtension;
            FileName = fileName;
         
        }
    }
}
