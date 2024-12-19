namespace RenklerinDili
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "yönetici" && textBox3.Text == "12345")
            {
                Form2 renkformu= new Form2();
                renkformu.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("yanlýþ giriþ");
            }
        }
    }
}
