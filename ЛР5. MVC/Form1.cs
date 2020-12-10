using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЛР5.MVC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            numericUpDown1.Text = textBox1.Text;
            label1.Text = textBox1.Text;
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            numericUpDown2.Text = textBox2.Text;
            label2.Text = textBox2.Text;
        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = numericUpDown1.Text;
            label1.Text = numericUpDown1.Text;
        }

        private void NumericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            textBox2.Text = numericUpDown2.Text;
            label2.Text = numericUpDown2.Text;
        }

        private void Label1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = label1.Text;
            numericUpDown1.Text = label1.Text;
        }

        private void Label2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = label2.Text;
            numericUpDown2.Text = label2.Text;
        }

        private void ButtonMi1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == "")
            {
            }
            else
            {
                int text = Convert.ToInt32(textBox1.Text);
                text--;
                label1.Text = Convert.ToString(text);
            }
        }

        private void ButtonMi2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0" || textBox2.Text == "")
            {
            }
            else
            {
                int text = Convert.ToInt32(textBox2.Text);
                text--;
                label2.Text = Convert.ToString(text);
            }
        }

        private void ButtonPl1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == "")
            {
                textBox1.Text = "1";
            }
            else
            {
                int text = Convert.ToInt32(textBox1.Text);
                text++;
                label1.Text = Convert.ToString(text);
            }
        }

        private void ButtonPl2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0" || textBox2.Text == "")
            {
                textBox2.Text = "1";
            }
            else
            {
                int text = Convert.ToInt32(textBox2.Text);
                text++;
                label2.Text = Convert.ToString(text);
            }
        }
    }
}
