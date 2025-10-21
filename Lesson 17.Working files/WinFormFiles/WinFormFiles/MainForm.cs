namespace WinFormFiles
{
    public partial class MainForm : Form
    {
        //Шлях до зображення, якщо зображення відсутнє
        //Це відносний шлях
        private string noImage = @"images\noimage.jpg";
        public MainForm()
        {
            InitializeComponent();

            if(File.Exists(noImage))
            {
                pbImage.Image = Image.FromFile(noImage);
                //MessageBox.Show("Файл зображення для відсутніх зображень знайдено.");
            }
            else
            {
                MessageBox.Show("Файл зображення для відсутніх зображень не знайдено.");
            }
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            
            //MessageBox.Show("Обирайємо файл!");
            //Це клас для відкриття діалогу вибору файлу
            OpenFileDialog dlgOpenFile = new OpenFileDialog();
            //Показуємо діалогове вікно
            //var dialogResult =  dlgOpenFile.ShowDialog();
            DialogResult dialogResult =  dlgOpenFile.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                string filePath = dlgOpenFile.FileName;
                txtSelectFile.Text = filePath;
                //MessageBox.Show("Ви обрали файл: " + filePath);
            }
            
        }
    }
}
