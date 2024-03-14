using consoleMail.Forms;

namespace consoleMail
{
    public partial class startForm : Form
    {
        public startForm()
        {
            InitializeComponent();


        }

        private void auth_button_Click(object sender, EventArgs e)
        {
            Hide();
            authForm authForm = new authForm();
            authForm.Show();
        }

        private void reg_button_Click(object sender, EventArgs e)
        {
            Hide();
            regForm authForm = new regForm();
            authForm.Show();
        }
    }
}
