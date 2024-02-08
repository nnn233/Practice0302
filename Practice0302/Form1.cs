namespace Practice0302
{
    public partial class Form1 : Form
    {
        string path = "C:\\Users\\nasty\\OneDrive\\Документы\\Практ и лаб работы\\Подготовка к демо\\Practice0302\\Practice0302\\output";
            
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new(new FileStream(path + ".txt", FileMode.OpenOrCreate, FileAccess.ReadWrite));
            writer.WriteLine("Фамилия: " + textBoxSurname.Text);
            writer.WriteLine("Имя: " + textBoxName.Text);
            writer.WriteLine("Отчество: " + textBoxPatronymic.Text);
            writer.WriteLine("Возраст: " + textBoxAge.Text);
            writer.Close();

            MessageBox.Show("Данные сохранены");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new(new FileStream(path + ".csv", FileMode.OpenOrCreate, FileAccess.ReadWrite));
            writer.WriteLine("Фамилия: " + textBoxSurname.Text);
            writer.WriteLine("Имя: " + textBoxName.Text);
            writer.WriteLine("Отчество: " + textBoxPatronymic.Text);
            writer.WriteLine("Возраст: " + textBoxAge.Text);
            writer.Close();

            MessageBox.Show("Данные сохранены");
        }
    }
}