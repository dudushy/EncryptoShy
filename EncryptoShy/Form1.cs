namespace EncryptoShy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //label1.Text = "aaaa";
            label1.Text = (int.Parse(label1.Text) + 1).ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}