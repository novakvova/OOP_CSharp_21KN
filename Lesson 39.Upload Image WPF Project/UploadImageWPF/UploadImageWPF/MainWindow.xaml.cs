using System.IO;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UploadImageWPF
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

        private void btnUploadImage_Click(object sender, RoutedEventArgs e)
        {
            string url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSbvCFFFCsQYbI82fOx2Tv9GHGxS2DQa34geg&s";
            HttpClient client = new HttpClient();
            string dir = "images";
            Directory.CreateDirectory(dir);
            byte[] bytes = client.GetByteArrayAsync(url).Result;
            //Для унікальної назви фото
            string fileName = Guid.NewGuid().ToString() + ".jpg";
            string path = System.IO.Path.Combine(dir, fileName);
            System.IO.File.WriteAllBytes(path, bytes);
        }
    }
}