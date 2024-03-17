
using System.Diagnostics;

namespace consoleMail.Forms
{
    public partial class regForm : Form
    {
        static bool isNewUserCreated = false;
        public regForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;


            clientMail.connectToSever();

        }

        private async void tryReg_button_Click(object sender, EventArgs e)
        {

            tryReg_button.Enabled = false;
            if (tools.checkEmptyFiled(login_textBox.Text, password_textBox.Text, firstName_textBox.Text, secondName_textBox.Text))
            {
                tools.tryMakeNewUser(
                     login_textBox.Text, password_textBox.Text,
                     firstName_textBox.Text, secondName_textBox.Text,
                     postion_textBox.Text, department_textBox.Text);

                this.Load += tryReg_button_Click;
                isNewUserCreated = true;
            }
            else
            {
                MessageBox.Show("Какие-то поля пустые!", "Ошибка!");
                tools.findEmptyFiledAndSetColorRed(login_textBox, password_textBox, firstName_textBox, secondName_textBox);
            }

            if (isNewUserCreated)
            {
                string? messege = await clientMail.ReceiveMessageAsync();

                if (messege != "" && messege[0] == '2')
                    MessageBox.Show("Пользователь успешно создан!", "Успешно!");
                else if (messege != "" && messege[0] == '1')
                    MessageBox.Show("Такой пользователь уже создан!", "Ошибка!");
            }
            tryReg_button.Enabled = true;
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Hide();
            startForm startForm = new startForm();
            startForm.Show();
        }

      
        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox thisTextBox = (TextBox)sender;
            if (thisTextBox.BackColor == Color.Red)
                thisTextBox.BackColor = Color.White;
        }
    }
}
