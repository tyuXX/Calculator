using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        BigInteger answer = BigInteger.Zero;
        public Calculator()
        {
            InitializeComponent();
        }
        
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox2.Clear();
            richTextBox2.Text = richTextBox1.Text;
            richTextBox2.Text = richTextBox2.Text.Replace(" ", "");
            richTextBox2.Text = richTextBox2.Text.Replace("+", "\n+\n");
            richTextBox2.Text = richTextBox2.Text.Replace("-", "\n-\n");
            richTextBox2.Text = richTextBox2.Text.Replace("/", "\n/\n");
            richTextBox2.Text = richTextBox2.Text.Replace("*", "\n*\n");
            richTextBox2.Text = richTextBox2.Text + "\n ";
            try
            {
                for (int i = 0; i < richTextBox2.Lines.Length; i++)
                {
                    if (richTextBox2.Lines[i] == "+")
                    {
                        
                        i = 0;
                    }
                }
                for (int i = 0; i < richTextBox2.Lines.Length; i++)
                {
                    try
                    {
                        answer = BigInteger.Parse(richTextBox2.Lines[i]);
                    }
                    catch (Exception ex)
                    {

                    }
                }
                label1.Text = answer.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }
    }
}
