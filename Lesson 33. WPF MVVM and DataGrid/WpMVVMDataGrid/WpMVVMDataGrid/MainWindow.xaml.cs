using System.Collections.ObjectModel;
using System.Windows;

using WpMVVMDataGrid.Models;

namespace WpMVVMDataGrid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Спеціальна колекція, яка підтримує
        // сповіщення View про зміни у колекції(додавання, видалення елементів)
        private ObservableCollection<UserVM> users = new ();
        public MainWindow()
        {
            InitializeComponent();
            //Заповнюємо колекцію users
            dgUsers.ItemsSource = users;
        }

        private void btnAddUser_Click(object sender, RoutedEventArgs e)
        {
            UserVM newUser = new UserVM();
            newUser.Id = users.Count + 1;
            newUser.Name = "New User " + newUser.Id;
            newUser.Image = "https://i.pinimg.com/originals/43/06/3c/43063c8162fbbae1cf37df742d2afa1c.jpg";

            users.Add(newUser);
            //MessageBox.Show("Додати нового користувача");
        }

        private void btnEditUser_Click(object sender, RoutedEventArgs e)
        {
            users[0]
                .Image = "https://assets.dots.live/misteram-public/01978356-8ff2-7017-bbaa-b3367d576463-826x0.png";
        }
    }
}