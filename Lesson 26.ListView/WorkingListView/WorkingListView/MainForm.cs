namespace WorkingListView
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            var drivers = Environment.GetLogicalDrives();

            foreach (var driver in drivers)
            {
                cbDrivers.Items.Add(driver);
            }
            cbDrivers.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            myListView.Items.Add(new ListViewItem
            {
                Text="Привіт козаки"
            });
        }

        private void cbDrivers_SelectedIndexChanged(object sender, EventArgs e)
        {
            var driver = cbDrivers.SelectedItem.ToString();

            myListView.Items.Clear();
            foreach (var dir in Directory.GetDirectories(driver))
            {
                string name = Path.GetFileName(dir);
                myListView.Items.Add(new ListViewItem{
                    Text=name
                });
            }

            foreach (var file in Directory.GetFiles(driver))
            {
                string name = Path.GetFileName(file);
                myListView.Items.Add(new ListViewItem
                {
                    Text=name
                });
            }
        }
    }
}
