using Bogus;
using Newtonsoft.Json;
using System.IO;
using System.Text;
using System.Windows;

namespace MyUsersApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnInitList_Click(object sender, RoutedEventArgs e)
        {
            UserItemModel user = new UserItemModel();

            Faker<UserItemModel> faker = new Faker<UserItemModel>("uk")
                .RuleFor(u => u.Id, f => f.Random.Guid().ToString())
                .RuleFor(u => u.FirstName, f => f.Name.FirstName())
                .RuleFor(u => u.LastName, f => f.Name.LastName())
                .RuleFor(u => u.Email, f => f.Internet.Email())
                .RuleFor(u => u.Phone, f => f.Phone.PhoneNumber())
                .RuleFor(u => u.Image, f => f.Internet.Avatar());

            var userList = faker.Generate(10);

            List<UserItemModel> usersOld = new List<UserItemModel>();
            if (File.Exists("users.json"))
            {
                var oldDataJson = File.ReadAllText("users.json");
                usersOld = JsonConvert.DeserializeObject<List<UserItemModel>>(oldDataJson);
            }
            //Читаємо стані дані із файлу
            usersOld.AddRange(userList); //додаю до старих користувачів нових користувачів
            var jsonData = JsonConvert.SerializeObject(usersOld);

            File.WriteAllText("users.json", jsonData, Encoding.UTF8);
        }

        private void btnViewList_Click(object sender, RoutedEventArgs e)
        {
            var users = new List<UserItemModel>();
            if (File.Exists("users.json"))
            {
                string json = File.ReadAllText("users.json");
                users = JsonConvert.DeserializeObject<List<UserItemModel>>(json);
            }
            var countList = users.Count;
            MessageBox.Show("Кількість користувачів " + countList);
            //foreach(var user in users)
            //    MessageBox.Show(user.ToString());

        }

        private void btnClearList_Click(object sender, RoutedEventArgs e)
        {
            if(File.Exists("users.json"))
            {
                File.Delete("users.json");
            }
        }
    }
}