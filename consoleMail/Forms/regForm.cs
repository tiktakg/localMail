
namespace consoleMail.Forms
{
    public partial class regForm : Form
    {
        public regForm()
        {
            InitializeComponent();
        }

        private void tryReg_button_Click(object sender, EventArgs e)
        {
            if(tools.checkEmptyFiled(login_textBox.Text, password_textBox.Text, firstName_textBox.Text,secondName_textBox.Text))
            {
                bool isNewUserCreated = tools.tryMakeNewUser(
                    login_textBox.Text, password_textBox.Text,
                    firstName_textBox.Text, secondName_textBox.Text,
                    postion_textBox.Text, department_textBox.Text);
            }
        }
    }
}
