namespace HelloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = $"Ola {textBox1.Text} visitante ,tem um bom dia";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
