namespace WinMenu
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void msMain_FileExit_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Виходимо із програми");
            Application.Exit();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult action = MessageBox.Show("Чи дійсно ви хочете вийти?",
                "Підтвердження виходу",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (action == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void smMain_OperationsCreateUser_Click(object sender, EventArgs e)
        {
            CreateUserForm dlg = new CreateUserForm();
            dlg.ShowDialog();
        }
    }
}
