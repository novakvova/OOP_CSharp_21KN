using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModalDialogSpeak.MyForms
{
    public partial class LoginForm : Form
    {
        public string OutEmail 
        { 
            get
            {
                return txtEmail.Text;
            }
        }
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLoginRequest_Click(object sender, EventArgs e)
        {
            //string email = txtEmail.Text;
            //string password = txtPassword.Text;
            this.DialogResult = DialogResult.OK;
            //MessageBox.Show($"Привіт командос :) {email} - {password}");
        }
    }
}
