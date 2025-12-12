using Microsoft.Win32;
using System.IO;
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

namespace WpfGallery
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // список розширень які будуть відображатись
        private readonly string[] SUPPORTED_EXTENSIONS = { ".jpg", ".jpeg", ".png", ".gif", ".bmp" };
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnLoadGallery_Click(object sender, RoutedEventArgs e)
        {
            // шлях до папки
            string folderPath = txtFolderPath.Text.Trim();

            // чи вказано шлях
            if (string.IsNullOrWhiteSpace(folderPath))
            {
                MessageBox.Show("Будь ласка, вкажіть шлях до папки.", "Помилка", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            // чи папка існує
            if (!Directory.Exists(folderPath))
            {
                MessageBox.Show($"Папка не знайдена: {folderPath}", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            try
            {
                // очистка галереї
                ImageGalleryPanel.Children.Clear();

                var files = Directory.GetFiles(folderPath);
                int imageCount = 0;

                foreach (string filePath in files)
                {
                    string extension = System.IO.Path.GetExtension(filePath);
                    if (extension != null && Array.IndexOf(SUPPORTED_EXTENSIONS, extension.ToLower()) >= 0)
                    {
                        BitmapImage bitmap = new BitmapImage();

                        try
                        {
                            bitmap.BeginInit();
                            bitmap.UriSource = new Uri(filePath);
                            bitmap.CacheOption = BitmapCacheOption.OnLoad;
                            bitmap.EndInit();
                            bitmap.Freeze();
                            Image imageControl = new Image
                            {
                                Source = bitmap,
                                Width = 150,
                                Height = 150,
                                Margin = new Thickness(5),
                                Stretch = System.Windows.Media.Stretch.UniformToFill,
                                Tag = filePath
                            };
                            imageControl.MouseDown += ImageControl_MouseDown;
                            ImageGalleryPanel.Children.Add(imageControl);
                            imageCount++;
                        }
                        catch (Exception innerEx)
                        {
                            Console.WriteLine($"Не вдалося завантажити зображення {filePath}: {innerEx.Message}");
                        }
                    }
                }
                if (imageCount > 0)
                {
                    MessageBox.Show($"Галерея успішно завантажена! Знайдено {imageCount} зображень.", "Успіх", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("У вказаній папці не знайдено підтримуваних зображень.", "Попередження", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Виникла системна помилка під час завантаження галереї: {ex.Message}", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ImageControl_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var image = sender as Image;

            MessageBox.Show("Click Image Gallery " + image?.Tag);
        }

        private void btnSelectFolder_Click(object sender, RoutedEventArgs e)
        {
            OpenFolderDialog dlg = new OpenFolderDialog();
            if (dlg.ShowDialog() == true)
            {
                var folderName = dlg.FolderName;
                txtFolderPath.Text = folderName;
            }
        }
    }
}