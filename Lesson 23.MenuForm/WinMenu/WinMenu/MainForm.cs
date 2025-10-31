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
    }
}
