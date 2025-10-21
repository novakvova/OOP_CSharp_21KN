namespace WinFormFiles
{
    public partial class MainForm : Form
    {
        //���� �� ����������, ���� ���������� ������
        //�� �������� ����
        private string noImage = @"images\noimage.jpg";
        public MainForm()
        {
            InitializeComponent();

            if(File.Exists(noImage))
            {
                pbImage.Image = Image.FromFile(noImage);
                //MessageBox.Show("���� ���������� ��� ������� ��������� ��������.");
            }
            else
            {
                MessageBox.Show("���� ���������� ��� ������� ��������� �� ��������.");
            }
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            
            //MessageBox.Show("�������� ����!");
            //�� ���� ��� �������� ������ ������ �����
            OpenFileDialog dlgOpenFile = new OpenFileDialog();
            //�������� �������� ����
            //var dialogResult =  dlgOpenFile.ShowDialog();
            DialogResult dialogResult =  dlgOpenFile.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                string filePath = dlgOpenFile.FileName;
                txtSelectFile.Text = filePath;
                //MessageBox.Show("�� ������ ����: " + filePath);
            }
            
        }
    }
}
