namespace Practice0302
{
    public partial class Form1 : Form
    {
        string path = "C:\\Users\\nasty\\OneDrive\\���������\\����� � ��� ������\\���������� � ����\\Practice0302\\Practice0302\\output";
            
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new(new FileStream(path + ".txt", FileMode.OpenOrCreate, FileAccess.ReadWrite));
            writer.WriteLine("�������: " + textBoxSurname.Text);
            writer.WriteLine("���: " + textBoxName.Text);
            writer.WriteLine("��������: " + textBoxPatronymic.Text);
            writer.WriteLine("�������: " + textBoxAge.Text);
            writer.Close();

            MessageBox.Show("������ ���������");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new(new FileStream(path + ".csv", FileMode.OpenOrCreate, FileAccess.ReadWrite));
            writer.WriteLine("�������: " + textBoxSurname.Text);
            writer.WriteLine("���: " + textBoxName.Text);
            writer.WriteLine("��������: " + textBoxPatronymic.Text);
            writer.WriteLine("�������: " + textBoxAge.Text);
            writer.Close();

            MessageBox.Show("������ ���������");
        }
    }
}