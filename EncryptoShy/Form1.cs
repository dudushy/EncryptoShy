namespace EncryptoShy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //ConsoleLog("[Form1] init.");
            InitializeComponent();
        }

        //public void ConsoleLog(string input)
        //{
        //    Console.WriteLine(input);

        //    if (textBox1.Text == "init")
        //    {
        //        textBox1.Text = input;
        //    }
        //    else
        //    {
        //        textBox1.Text = $"{textBox1.Text}\n{input}";
        //    }
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            //ConsoleLog("[button1_Click] click.");

            int input = 0;
            int output = 0;

            int.TryParse(label1.Text, out input);
            //ConsoleLog($"[button1_Click] input = '{input}'.");

            if (input < 999999)
            {
                if (input == 0) label1.BackColor = Color.Lime;
                output = input + 1;

                label1.Text = output.ToString();
                //ConsoleLog($"[button1_Click] output = '{output}'.");
            }
            else
            {
                label1.BackColor = Color.DarkRed;
                label1.Text = "Error!";
                //ConsoleLog("[button1_Click] output = 'Error!'.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //ConsoleLog("[label1_Click] click.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ConsoleLog("[Form1_Load] load.");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //ConsoleLog("[textBox1_TextChanged] text changed.");
        }
    }
}