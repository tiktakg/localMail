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
        internal static string loginOfUser;
        public mainPageForm()
        {
            InitializeComponent();

            clientMail.connectToSever();
            this.Load += isNewMsg;
        }

        private void sendMail_button_Click(object sender, EventArgs e)
        {
            if (tools.checkEmptyFiled(theme_textBox.Text, msg_textBox.Text, receiver_textBox.Text))
                tools.sendMsg(theme_textBox.Text, loginOfUser, receiver_textBox.Text,msg_textBox.Text);
            else
                MessageBox.Show("Какие-то поля пустые!", "Ошибка!");
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
