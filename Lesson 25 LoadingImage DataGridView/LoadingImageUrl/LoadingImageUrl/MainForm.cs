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
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            LoadImage();
            stopWatch.Stop();
            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;

            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
            MessageBox.Show("RunTime " + elapsedTime);
        }
        public async Task LoadImage()
        {
            byte[] imageBytes = await client.GetByteArrayAsync(imgUrl);
            using var ms = new MemoryStream(imageBytes);

            pbImage.Image = Image.FromStream(ms);
                //photo = Image.FromStream(ms);
        }
    }
}
