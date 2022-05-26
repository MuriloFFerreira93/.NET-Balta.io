namespace WinFormsApp1234
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //label1.Text = "teste TESTE";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            label1.Text = label1.Text + textBox1.Text + ".";

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
        }
    }
}