namespace ListViewImageView
{
    public partial class MainForm : Form
    {
        //Фото для ImageList - зберігає фото
        //Дані фото потрібні для роботи ImageView
        private ImageList largeImageList;
        public MainForm()
        {
            InitializeComponent();
            //Після ініціалізації ми закинемо фото.
            largeImageList = new ImageList();
            largeImageList.ImageSize = new Size(128, 128); // розмір іконки
            largeImageList.ColorDepth = ColorDepth.Depth32Bit;
            //Клас, який може з мережі викачати фото
            using HttpClient client = new HttpClient();
            //Качає з мережі фото по адресі - оримуємо байти фото
            byte[] data = client.GetByteArrayAsync("https://p.novaskin.me/6720725015855104.png").Result;
            //Збегіємо байти у memory stream
            using var ms = new System.IO.MemoryStream(data);
            //Створюємо фото на основі об'єкта ms
            Image img = Image.FromStream(ms);
            //Додаємо дане фото у масив фото і називаємо його folder
            largeImageList.Images.Add("folder", img);
            //створуюємо новий елемент у ListView 
            //Називаємо його Папка і даємо ідентифікатор фото folder
            myLv.Items.Add(new ListViewItem("Папка", "folder"));
            myLv.Items.Add(new ListViewItem("Марко", "folder"));
            myLv.Items.Add(new ListViewItem("Кабан", "folder"));
            myLv.LargeImageList = largeImageList;

        }
    }
}
