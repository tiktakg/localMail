using consoleMail.entitys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace consoleMail.Forms
{
    public partial class authForm : Form
    {
        public authForm()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private async void tryAuth_button_Click(object sender, EventArgs e)
        {
            tryAuth_button.Enabled = false;

            if (tools.checkEmptyFiled(login_textBox.Text, password_textBox.Text))
            {
                user currentUser = tools.isUserExist(login_textBox.Text, password_textBox.Text);
                this.Load += tryAuth_button_Click;

                if (await ReceiveMessage())
                {
                    Hide();
                    mainPageForm mainPageForm = new mainPageForm(currentUser);
                    mainPageForm.Show();
                }

            }
            else
            {
                MessageBox.Show("Какие-то поля пустые!", "Ошибка!");
                tools.findEmptyFiledAndSetColorRed(login_textBox, password_textBox);

            }
            tryAuth_button.Enabled = true;
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Hide();
            startForm startForm = new startForm();
            startForm.Show();
        }

        private async Task<bool> ReceiveMessage()
        {
            string? messege = await clientMail.ReceiveMessageAsync();

            if (messege != "" && messege[0] == '2')
                return true;
            else if (messege != "" && messege[0] == '1')
                MessageBox.Show("Такого пользователя не существует!", "Ошибка!");

            return false;
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox thisTextBox = (TextBox)sender;
            if (thisTextBox.BackColor == Color.Red)
                thisTextBox.BackColor = Color.White;
        }
    }
}
