using consoleMail.Forms;
using System.Windows.Forms;

namespace consoleMail
{
    public partial class startForm : Form
    {
        public startForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void auth_button_Click(object sender, EventArgs e)
        {
            if (!checkAndConnectToHost())
                return;

            Hide();
            authForm authForm = new authForm();
            authForm.Show();
        }

        private void reg_button_Click(object sender, EventArgs e)
        {
            if (!checkAndConnectToHost())
                return;

            Hide();
            regForm authForm = new regForm();
            authForm.Show();
        }
        private void ipOfHost_textBox_Leave(object sender, EventArgs e)
        {
            if (ipOfHost_textBox.Text == "")
                ipOfHost_textBox.Text = "Введите ip адрес сервера!";
        }
        private void ipOfHost_textBox_MouseHover(object sender, EventArgs e)
        {
            if (ipOfHost_textBox.Text == "Введите ip адрес сервера!")
                ipOfHost_textBox.Text = "";
        }

        private bool checkAndConnectToHost()
        {
            if (ipOfHost_textBox.Text != "Введите ip адрес сервера!")
                clientMail.host = ipOfHost_textBox.Text;
            else if (clientMail.isHostNameSet())
            {
                MessageBox.Show("Ip адрес сервера не введен!", "Ошибка!");
                return false;
            }

            clientMail.connectToSever();
            
            if(!clientMail.isConnectToServer())
            {
                MessageBox.Show("Ip адрес сервера не существует!", "Ошибка!");
                return false;
            }
            return true;
        }
    }
}
