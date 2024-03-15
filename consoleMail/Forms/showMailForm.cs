using consoleMail.entitys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace consoleMail.Forms
{
    public partial class showMailForm : Form
    {
       
        public showMailForm(msg currentMsg)
        {
            InitializeComponent();

            theme_label.Text = "Тема - " + currentMsg.ThemeOfMsg;
            sender_label.Text = "Отправитель - " + currentMsg.SenderOfMsg;
            messege_label.Text = currentMsg.TextOfMsg;
            
            
        }
    }
}
