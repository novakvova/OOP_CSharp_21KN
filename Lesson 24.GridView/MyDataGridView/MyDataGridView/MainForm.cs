namespace MyDataGridView;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        object[] items =
        {
            "1",
            "Непол Василь Петрович",
            "+38(096) 23 45 32",
            "nepol@gmail.com"
        };
        dgvUsers.Rows.Add(items);
    }
}
