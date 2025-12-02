using System.Windows;
using WpfWorkingWindow.City;

namespace WpfWorkingWindow
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

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            CityAddWindow cityAddWindow = new CityAddWindow();
            cityAddWindow.ShowDialog();
            var newCity = cityAddWindow.CityItem;
            MessageBox.Show("Add button clicked ->" + newCity.Name);
        }
    }
}