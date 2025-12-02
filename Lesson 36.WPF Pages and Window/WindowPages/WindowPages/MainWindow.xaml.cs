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

namespace WindowPages
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Navigate to LoginPage on startup
            MainFrame.Navigate(new MyPages.LoginPage());
        }

        private void btnToLogin_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new MyPages.LoginPage());
        }

        private void btnToRegister_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new MyPages.RegisterPage());
        }
    }
}