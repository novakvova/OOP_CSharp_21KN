using System.Diagnostics;

namespace LoadingImageUrl
{
    public partial class MainForm : Form
    {
        string imgUrl = "https://thispersondoesnotexist.com/";
        private readonly HttpClient client = new();
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnLoadUrl_Click(object sender, EventArgs e)
        {
            LoadImage();
        }
        public async Task LoadImage()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            int n = 5;
            for(int i=0; i < n; i++)
            {
                byte[] imageBytes = await client.GetByteArrayAsync(imgUrl);
                using var ms = new MemoryStream(imageBytes);

                pbImage.Image = Image.FromStream(ms);

                var dir = Path.Combine(Directory.GetCurrentDirectory(), "images");
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }
                string fileSave = Path.Combine(dir, "image"+i+".jpg");
                FileStream fs = new FileStream(fileSave, FileMode.Create);
                fs.Write(ms.ToArray());
                fs.Close();
            }
            //photo = Image.FromStream(ms);
            stopWatch.Stop();
            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;

            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
            MessageBox.Show("RunTime " + elapsedTime);
        }
    }
}
