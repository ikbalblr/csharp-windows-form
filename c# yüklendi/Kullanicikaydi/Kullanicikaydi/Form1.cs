namespace Kullanicikaydi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label10.Text = textBox1.Text+textBox5.Text;
            label8.Text = textBox2.Text;
            label6.Text = comboBox1.Text;
            label12.Text = textBox4.Text;

        }
    }
}
