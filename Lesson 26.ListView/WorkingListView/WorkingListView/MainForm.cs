namespace WorkingListView
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            myListView.Items.Add(new ListViewItem
            {
                Text="Привіт козаки"
            });
        }
    }
}
