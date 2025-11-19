using System.Configuration;
using System.Data;
using System.Windows;
using WpfAppXML.Windows;

namespace WpfAppXML
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        //Метод, який спрацьовує при старті додатку
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            LoginWindow window = new LoginWindow();
            window.Show();
        }
    }

}
