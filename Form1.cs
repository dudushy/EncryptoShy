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

        private string ZENIT(string input)
        {
            string encode = "ZENITzenit";
            string decode = "POLARpolar";
            string output = "";

            foreach (char c in input)
            {
                if (encode.IndexOf(c) != -1)
                {
                    output += decode[encode.IndexOf(c)];
                }
                else if (decode.IndexOf(c) != -1)
                {
                    output += encode[decode.IndexOf(c)];
                }
                else
                {
                    output += c;
                }
                Console.WriteLine($"[ZENIT] c: {c} | output: {output}");
            }

            return output;
        }

        private string NATZU(string input)
        {
            string encode = "NATZUnatzu";
            string decode = "JOLIPjolip";
            string output = "";

            foreach (char c in input)
            {
                if (encode.IndexOf(c) != -1)
                {
                    output += decode[encode.IndexOf(c)];
                }
                else if (decode.IndexOf(c) != -1)
                {
                    output += encode[decode.IndexOf(c)];
                }
                else
                {
                    output += c;
                }
                Console.WriteLine($"[NATZU] c: {c} | output: {output}");
            }

            return output;
        }

        private void ConvertMessage(string mode, string input)
        {
            Console.WriteLine($"[ConvertMessage] mode: {mode} | input: {input}");

            string output = "";

            switch (mode)
            {
                case "ZENIT_POLAR":
                    output = ZENIT(input);
                    break;
                case "NATZU_JOLIP":
                    output = NATZU(input);
                    break;
                default:
                    Console.WriteLine("[ConvertMessage] Invalid Mode!");
                    break;
            }

            Console.WriteLine($"[ConvertMessage] output: {output}");
            richTextBoxOutput.Text = output;
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            Console.WriteLine($"[buttonConvert_Click] comboBoxMode: {comboBoxMode.SelectedItem}");

            if (comboBoxMode.SelectedItem != null)
            {
                if (richTextBoxInput.Text != "")
                {
                    Console.WriteLine($"[buttonConvert_Click] richTextBoxInput: {richTextBoxInput.Text}");

                    ConvertMessage(comboBoxMode.SelectedItem.ToString(), richTextBoxInput.Text);
                }
            }
        }
    }
}
