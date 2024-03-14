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
        }

        private async void tryAuth_button_Click(object sender, EventArgs e)
        {
            
            if (tools.checkEmptyFiled(login_textBox.Text, password_textBox.Text))
            {
                tools.isUserExist(login_textBox.Text, password_textBox.Text);
                this.Load += tryAuth_button_Click;

               
                if (await ReceiveMessage())
                {
                    Hide();
                    mainPageForm mainPageForm = new mainPageForm();
                    mainPageForm.Show();
                }
             
            }
            else
                MessageBox.Show("Какие-то поля пустые!", "Ошибка!");
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
    }
}
