using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfWorkingWindow.Models;

namespace WpfWorkingWindow.City
{
    /// <summary>
    /// Interaction logic for CityAddWindow.xaml
    /// </summary>
    public partial class CityAddWindow : Window
    {
        public CityAddWindow()
        {
            InitializeComponent();
        }
        public CityModel CityItem { get; set; }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnAddCity_Click(object sender, RoutedEventArgs e)
        {
            CityModel cityModel = new CityModel()
            {
                Name = txtCityName.Text,
                Image = txtCityImage.Text,
                Population = int.Parse(txtCityPopulation.Text),
                Area = double.Parse(txtCityArea.Text)
            };
            CityItem = cityModel;

            this.Close();
        }
    }
}
