namespace WorkingDynamics
{
    public partial class MainForm : Form
    {
        private TextBox[,] textBoxes;
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            int n = textBoxes.GetLength(0);
            int m = textBoxes.GetLength(1);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    this.Controls.Remove(textBoxes[i,j]);
                }
            }
        }

        private void btnBuilder_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtN.Text);
            int m = int.Parse(txtM.Text);
            //MessageBox.Show($"Побудовано об'єктів: {count}");

            // Створення масиву текстових полів
            textBoxes = new TextBox[n,m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    textBoxes[i,j] = new TextBox
                    {
                        Location = new Point(36+j*60, 150+i*60),
                        Size = new Size(50, 39),
                        Name = $"txtDynamic{j + i + 1}"
                    };
                    this.Controls.Add(textBoxes[i,j]);
                }
            }

        }

        private void btnCalculation_Click(object sender, EventArgs e)
        {
            string str = ""; //зберігає рядок значень із полів
            foreach (var txtBox in textBoxes)
            {
                str += txtBox.Text + " ";
            }
            MessageBox.Show(str);
        }
    }
}
