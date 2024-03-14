using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleMail.entitys
{
    internal class msg
    {
        public string ThemeOfMsg { get; set; }
        public string SenderOfMsg { get; set; }
        public string TextOfMsg { get; set; }
        public string FildOfMsg { get; set; }

        public msg(string themeOfMsg, string senderOfMsg, string textOfMsg, string fileOfMsg = "")
        {
            ThemeOfMsg = themeOfMsg;
            SenderOfMsg = senderOfMsg;
            TextOfMsg = textOfMsg;
            FildOfMsg = fileOfMsg;
           
        }
    }
}
