namespace MyComboBox
{
    public partial class MainForm : Form
    {
        MyRole[] listRoles = 
        {
            new MyRole(1, "A���"),
            new MyRole(8, "��������"),
            new MyRole(3, "���������"),
            new MyRole(4, "���������")
        };
        public MainForm()
        {
            InitializeComponent();
            cbRoles.Items.AddRange(listRoles);
        }
    }
}
