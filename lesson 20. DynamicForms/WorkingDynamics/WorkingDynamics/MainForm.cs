namespace WorkingDynamics
{
    public partial class MainForm : Form
    {
        private TextBox[] textBoxes;
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnBuilder_Click(object sender, EventArgs e)
        {
            int count = int.Parse(txtCount.Text);
            //MessageBox.Show($"Побудовано об'єктів: {count}");

            // Створення масиву текстових полів
            textBoxes = new TextBox[count];
            for (int i = 0; i < count; i++)
            {
                textBoxes[i] = new TextBox
                {
                    Location = new Point(36+i*60, 120),
                    Size = new Size(50, 39),
                    Name = $"txtDynamic{i + 1}"
                };
                this.Controls.Add(textBoxes[i]);
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
