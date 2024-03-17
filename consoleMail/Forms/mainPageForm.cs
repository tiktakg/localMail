using Newtonsoft.Json;
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

using consoleMail.entitys;

namespace consoleMail.Forms
{
    public partial class mainPageForm : Form
    {
        private static user currentUser;
        private static string pathOfFile = "";


        private int countOFMsg = 0;
        List<msg> msgList = new List<msg>();


        public mainPageForm(user user)
        {
            InitializeComponent();

            currentUser = user;

            clientMail.connectToSever();

            tools.getAllMsg(currentUser);
            this.Load += isNewMsg;
        }

        private void sendMail_button_Click(object sender, EventArgs e)
        {
            if (tools.checkEmptyFiled(theme_textBox.Text, msg_textBox.Text, receiver_textBox.Text))
                tools.sendMsg(theme_textBox.Text, currentUser.Login, receiver_textBox.Text, msg_textBox.Text, pathOfFile, priorityOfMsg_comboBox.Text);
            else
                MessageBox.Show("Какие-то поля пустые!", "Ошибка!");
        }



        private async void isNewMsg(object sender, EventArgs e)
        {
            string messege = await clientMail.ReceiveMessageAsync();



            jsonMsg? jsonMsg = JsonConvert.DeserializeObject<jsonMsg>(messege);

            if (jsonMsg.msg != null && tools.prepereMsg(jsonMsg.msg, currentUser.Login))
            {
                jsonMsg.msg.ThemeOfMsg = jsonMsg.msg.ThemeOfMsg + countOFMsg.ToString();
                allMesseges_listView.Items.Add(jsonMsg.msg.ThemeOfMsg);
                msgList.Add(jsonMsg.msg);
                countOFMsg++;
            }
            else if (jsonMsg.getAllMsg != null)
            {

                foreach (var msg in jsonMsg.getAllMsg)
                {
                    msg.ThemeOfMsg = msg.ThemeOfMsg + countOFMsg.ToString();
                    msgList.Add(msg);
                    allMesseges_listView.Items.Add(msg.ThemeOfMsg);
                    countOFMsg++;
                }


            }

            isNewMsg(this, EventArgs.Empty);

        }

        private void attachFile_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();

            pathOfFile = openFileDialog.FileName;

            if (pathOfFile != "")
                nameOfFile_label.Text = pathOfFile.Substring(pathOfFile.LastIndexOf("\\") + 1);
            else
                nameOfFile_label.Text = "Файл не выбран";
        }

        private void sortMsg_textBox_TextChanged(object sender, EventArgs e)
        {
            List<string> sortedMsg = tools.findSortedMsg(sortMsg_textBox.Text.Replace(" ", ""), msgList);

            allMesseges_listView.Items.Clear();
            allMesseges_listView.Items.AddRange(sortedMsg.Select(msg => new ListViewItem(msg)).ToArray());
        }
        private void priorityOfMsgToSort_comboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            List<string> msgListWithCurrentPriority = tools.getMsgWithCurrentPrioprity(priorityOfMsgToSort_comboBox.SelectedItem.ToString(), msgList);
            allMesseges_listView.Items.Clear();
            allMesseges_listView.Items.AddRange(msgListWithCurrentPriority.Select(msg => new ListViewItem(msg)).ToArray());
        }

        private void allMesseges_listView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = allMesseges_listView.HitTest(e.Location).Item;

            msg selectedMsg = msgList.Find(t => t.ThemeOfMsg == item.Text);
            showMailForm showMailForm = new showMailForm(selectedMsg);
            showMailForm.ShowDialog();
        }
    }
}
