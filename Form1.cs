using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptoShy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void ConvertMessage(string mode, string input)
        {
            Console.WriteLine($"[ConvertMessage] mode: {mode} | input: {input}");

            string output = input;
            Console.WriteLine($"[ConvertMessage] output: {output}");

            richTextBoxOutput.Text = output;
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            Console.WriteLine($"[buttonConvert_Click] comboBoxMode {comboBoxMode.SelectedItem}");

            if (comboBoxMode.SelectedItem != null)
            {
                if (richTextBoxInput.Text != "")
                {
                    Console.WriteLine($"[buttonConvert_Click] richTextBoxInput {richTextBoxInput.Text}");

                    ConvertMessage(comboBoxMode.SelectedItem.ToString(), richTextBoxInput.Text);
                }
            }
        }
    }
}
