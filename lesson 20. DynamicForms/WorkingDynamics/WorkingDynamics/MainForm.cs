namespace WorkingDynamics
{
    public partial class MainForm : Form
    {
        private TextBox[,] textBoxes = new TextBox[0, 0];
        public MainForm()
        {
            InitializeComponent();

            cbRows.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRows.Items.Add("2");
            cbRows.Items.Add("3");
            cbRows.Items.Add("4");
            cbRows.Items.Add("5");
            //cbRows.SelectedItem = "2";
            cbRows.SelectedIndex = 0;

        }

        private void clearItemsView()
        {
            int n = textBoxes.GetLength(0);
            int m = textBoxes.GetLength(1);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    this.gbA.Controls.Remove(textBoxes[i, j]);
                }
            }
        }

        private void btnBuilder_Click(object sender, EventArgs e)
        {
            clearItemsView();

            int n = int.Parse(txtN.Text);
            int m = int.Parse(txtM.Text);
            //MessageBox.Show($"Побудовано об'єктів: {count}");

            // Створення масиву текстових полів
            textBoxes = new TextBox[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    textBoxes[i, j] = new TextBox
                    {
                        Location = new Point(20+j*60, 40+i*60),
                        Size = new Size(50, 39),
                        Name = $"txtDynamic{j + i + 1}"
                    };
                    this.gbA.Controls.Add(textBoxes[i, j]);
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
        private void builderMatrixA(int n, int m)
        {
            clearItemsView();
            // Створення масиву текстових полів
            textBoxes = new TextBox[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    textBoxes[i, j] = new TextBox
                    {
                        Location = new Point(20+j*60, 40+i*60),
                        Size = new Size(50, 39),
                        Name = $"txtDynamic{j + i + 1}"
                    };
                    this.gbA.Controls.Add(textBoxes[i, j]);
                }
            }
        }

        private void cbRows_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectItem = cbRows.SelectedItem;
            int n = int.Parse(selectItem.ToString());
            int m = n; //для квадратної матриці
            builderMatrixA(n, m);
            //MessageBox.Show(selectItem.ToString());
        }
    }
}
