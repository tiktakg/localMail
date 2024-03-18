using Newtonsoft.Json;
using System.Data;
using consoleMail.entitys;
using Windows.UI.Notifications;
using Microsoft.Toolkit.Uwp.Notifications;
using System.Threading.Tasks;
using Windows.Data.Xml.Dom;

namespace consoleMail.Forms
{
    public partial class mainPageForm : Form
    {
        private static user currentUser;
        private static string pathOfFile = "";


        private int countOFMsg = 0;
        List<msg> msgList = new List<msg>();

        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();


        public mainPageForm(user user)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            timer.Interval = 5000;
            timer.Tick += Timer_Tick;
            currentUser = user;

            clientMail.connectToSever();

            allMesseges_listView.View = View.Details;
            allMesseges_listView.Columns.Add("Тема сообщения", 100);
            allMesseges_listView.Columns.Add("Отправитель", 100);
            tools.getAllMsg(currentUser);
            this.Load += isNewMsg;
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            sendMail_button.Enabled = true;
            timer.Stop();
        }

        private void sendMail_button_Click(object sender, EventArgs e)
        {
            if (tools.checkEmptyFiled(theme_textBox.Text, msg_textBox.Text, receiver_textBox.Text))
            {
                sendMail_button.Enabled = false;
                timer.Start();
                tools.sendMsg(theme_textBox.Text, currentUser.Login, receiver_textBox.Text, msg_textBox.Text, pathOfFile, priorityOfMsg_comboBox.Text);
            }
            else
                MessageBox.Show("Какие-то поля пустые!", "Ошибка!");
        }



        private async void isNewMsg(object sender, EventArgs e)
        {
            string messege = await clientMail.ReceiveMessageAsync();
            jsonMsg? jsonMsg = null;

            try
            {
                jsonMsg = JsonConvert.DeserializeObject<jsonMsg>(messege);
                if (jsonMsg.msg != null && tools.prepereMsg(jsonMsg.msg, currentUser.Login))
                {
                   
                    jsonMsg.msg.ThemeOfMsg = jsonMsg.msg.ThemeOfMsg + countOFMsg.ToString();
                    allMesseges_listView.Items.Add(new ListViewItem(new string[] { jsonMsg.msg.ThemeOfMsg, jsonMsg.msg.SenderOfMsg }));

                    msgList.Add(jsonMsg.msg);
                    countOFMsg++;
                   
                    MessageBox.Show($"Тема сообщения - {jsonMsg.msg.ThemeOfMsg} \nОтправитель - {jsonMsg.msg.SenderOfMsg}!", "Сообщение!");
                }
                else if (jsonMsg.getAllMsg != null)
                {

                    foreach (var msg in jsonMsg.getAllMsg)
                    {
                        msg.ThemeOfMsg = msg.ThemeOfMsg + countOFMsg.ToString();
                        msgList.Add(msg);
                        ListViewItem listViewItem = new ListViewItem(new string[] { msg.ThemeOfMsg, msg.SenderOfMsg });

                        allMesseges_listView.Items.Add(listViewItem);
                        countOFMsg++;
                    }


                }
            }
            catch
            {

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
