
namespace consoleMail.Forms
{
    public partial class regForm : Form
    {
        static bool isNewUserCreated = false;
        public regForm()
        {
            InitializeComponent();

            clientMail.connectToSever();
           

        }

        private async void tryReg_button_Click(object sender, EventArgs e)
        {

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
                MessageBox.Show("Какие-то поля пустые!", "Ошибка!");

            if (isNewUserCreated)
            {
                string? messege = await clientMail.ReceiveMessageAsync();

                if (messege != "" && messege[0] == '2')
                    MessageBox.Show("Пользователь успешно создан!", "Успешно!");
                else if (messege != "" && messege[0] == '1')
                    MessageBox.Show("Таккой пользователь уже создан!", "Ошибка!");
            }
        }
    }
}
