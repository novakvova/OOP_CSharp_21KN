namespace MyComboBox
{
    public partial class MainForm : Form
    {
        MyRole[] listRoles = 
        {
            new MyRole(1, "Aдмін"),
            new MyRole(8, "Менеджер"),
            new MyRole(3, "Продавець"),
            new MyRole(4, "Складовик")
        };
        public MainForm()
        {
            InitializeComponent();
            cbRoles.Items.AddRange(listRoles);
        }
    }
}
