using Microsoft.Data.Sqlite;
using System.Windows;

namespace WpfForSQLite
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        UserManager userManager;
        public MainWindow()
        {
            userManager = new UserManager();
            InitializeComponent();
        }

        private void btnCreateTable_Click(object sender, RoutedEventArgs e)
        {
            var user = new MyUser
            {
                Email = "qq@qq.qq",
                FirstName = "Вова",
                LastName = "Новак",
                Phone = "098 89 77 889",
                Password = "123456"
            };
            userManager.CreateUser(user);
            MessageBox.Show("Cтворили таблицю для користувачів");
        }
    }
}