using MyFilesWpf.Models;
using Newtonsoft.Json;
using System.IO;
using System.Text;
using System.Windows;

namespace MyFilesWpf
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

        private void btnWriteFile_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Write File button clicked!");
            string filePath = "cities.txt";
            CityModel kiyiv = new CityModel
            {
                Name = "Київ",
                Image = 
                "https://faktypro.com.ua/uploads/img/23-cikavih-faktu-pro-kiyiv.jpg",
                Population = 2967000,
                Area = 839.0
            };
            CityModel rivne = new CityModel
            {
                Name = "Рівне",
                Image =
                "https://www.ukraine-is.com/wp-content/uploads/2018/05/%D0%A0%D1%96%D0%B2%D0%BD%D0%B5.jpg",
                Population = 243873,
                Area = 63.0
            };
            CityModel zaporizhzhia = new CityModel
            {
                Name = "Запоріжжя",
                Image = "https://zp.gov.ua/upload/editor/prospekt-sobornyj.jpg",
                Population = 710000,
                Area = 334.0
            };
            var list = new List<CityModel> { kiyiv, rivne, zaporizhzhia };
            string json = JsonConvert.SerializeObject(list);
            File.WriteAllText(filePath, json, Encoding.UTF8);

        }
    }
}