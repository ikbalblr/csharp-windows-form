namespace rastgelesayiüret
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            int a = rastgele.Next(0,50);
            label1.Text = a.ToString();
                







        }
    }
}
