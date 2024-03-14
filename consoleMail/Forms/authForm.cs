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

        private void tryAuth_button_Click(object sender, EventArgs e)
        {
            if(1==1)
            {
                Hide();
                mainPageForm mainPageForm = new mainPageForm();
                mainPageForm.Show();
            }    
        }
    }
}
