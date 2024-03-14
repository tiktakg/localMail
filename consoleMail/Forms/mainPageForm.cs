using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace consoleMail.Forms
{
    public partial class mainPageForm : Form
    {
        public mainPageForm()
        {
            InitializeComponent();

            clientMail.connectToSever();
            this.Load += isNewMsg;

        
        }

        private void sendMail_button_Click(object sender, EventArgs e)
        {
            clientMail.SendMessageAsync(msg_textBox.Text);
        }

        private void allUMesseges_listView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            showMailForm showMailForm = new showMailForm(e.Item.Text);
            showMailForm.ShowDialog();
        }

        private async void isNewMsg(object sender, EventArgs e)
        {
            string messege = await clientMail.ReceiveMessageAsync();
            if (messege!="") 
            {
                allUMesseges_listView.Items.Add(messege);
                isNewMsg(this, EventArgs.Empty);
            }
            
        }
    }
}
