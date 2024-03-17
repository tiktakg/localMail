using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleMailSever.entitys
{


    internal class jsonMsg
    {
        public users newUser { get; set; }
        public users findUser { get; set; }
        public messenges msg { get; set; }
        public users getAllMsg {  get; set; }

    }
}
