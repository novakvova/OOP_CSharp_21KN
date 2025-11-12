using ModalDialogSpeak.MyForms;
using System.Drawing.Drawing2D;

namespace ModalDialogSpeak
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //string yourEmail = string.Empty;
            LoginForm dlg = new LoginForm();
            dlg.ShowDialog();
            //MessageBox.Show("Ваша пошта", dlg.OutEmail);
            lbEmail.Text = dlg.OutEmail;
            //MessageBox.Show("Begin login");
        }
    }
}
