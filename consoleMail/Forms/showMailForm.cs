using consoleMail.entitys;
using System.Diagnostics;


namespace consoleMail.Forms
{
    public partial class showMailForm : Form
    {
        string filePath = "";

        public showMailForm(msg currentMsg)
        {
            InitializeComponent();

            theme_label.Text = "Тема - " + currentMsg.ThemeOfMsg;
            sender_label.Text = "Отправитель - " + currentMsg.SenderOfMsg;
            priorityOfMsg_label.Text = "Важность - " + currentMsg.Priority;
            messege_label.Text = currentMsg.TextOfMsg;
            filePath = tools.base64ToFile(currentMsg.FileOfMsg, currentMsg.FileExtension,currentMsg.FileName);

            if(filePath == "")
                openFile_button.Enabled = false;
        }     

        private void openFile_button_Click(object sender, EventArgs e)
        {
            if (filePath != "")
            {
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = filePath,
                    UseShellExecute = true
                };
                Process.Start(startInfo);
            }
        }
    }
}
