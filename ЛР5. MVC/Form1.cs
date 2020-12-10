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
            int txt1;
            if (textBox1.Text == "" || textBox1.Text == "-")
                txt1 = 0;
            else
                txt1 = Convert.ToInt32(textBox1.Text);
            int txt2;
            if (textBox2.Text == "" || textBox2.Text == "-")
                txt2 = 0;
            else
                txt2 = Convert.ToInt32(textBox2.Text);
            if (txt1 >= txt2)
            {
                txt2 = txt1 + 1;
                textBox2.Text = Convert.ToString(txt2);
                numericUpDown2.Text = Convert.ToString(txt2);
                label2.Text = Convert.ToString(txt2);
            }

            numericUpDown1.Text = Convert.ToString(txt1);
            label1.Text = Convert.ToString(txt1);
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            int txt1;
            if (textBox1.Text == "" || textBox1.Text == "-")
                txt1 = 0;
            else
                txt1 = Convert.ToInt32(textBox1.Text);
            int txt2;
            if (textBox2.Text == "" || textBox2.Text == "-")
                txt2 = 0;
            else
                txt2 = Convert.ToInt32(textBox2.Text);
            if (txt1 >= txt2)
            {
                txt1 = txt2 - 1;
                textBox1.Text = Convert.ToString(txt1);
                numericUpDown1.Text = Convert.ToString(txt1);
                label1.Text = Convert.ToString(txt1);
            }

            numericUpDown2.Text = Convert.ToString(txt2);
            label2.Text = Convert.ToString(txt2);
        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(numericUpDown1.Value);
            label1.Text = Convert.ToString(numericUpDown1.Value);

            int txt1;
            if (textBox1.Text == "" || textBox1.Text == "-")
                txt1 = 0;
            else
                txt1 = Convert.ToInt32(textBox1.Text);
            int txt2;
            if (textBox2.Text == "" || textBox2.Text == "-")
                txt2 = 0;
            else
                txt2 = Convert.ToInt32(textBox2.Text);
            if (txt1 >= txt2)
            {
                txt2 = txt1 + 1;
                textBox2.Text = Convert.ToString(txt2);
                numericUpDown2.Text = Convert.ToString(txt2);
                label2.Text = Convert.ToString(txt2);
            }
        }

        private void NumericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            textBox2.Text = Convert.ToString(numericUpDown2.Value);
            label2.Text = Convert.ToString(numericUpDown2.Value);

            int txt1;
            if (textBox1.Text == "" || textBox1.Text == "-")
                txt1 = 0;
            else
                txt1 = Convert.ToInt32(textBox1.Text);
            int txt2;
            if (textBox2.Text == "" || textBox2.Text == "-")
                txt2 = 0;
            else
                txt2 = Convert.ToInt32(textBox2.Text);
            if (txt1 >= txt2)
            {
                txt1 = txt2 - 1;
                textBox1.Text = Convert.ToString(txt1);
                numericUpDown1.Text = Convert.ToString(txt1);
                label1.Text = Convert.ToString(txt1);
            }
        }

        private void Label1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = label1.Text;
            numericUpDown1.Text = label1.Text;

            int txt1;
            if (textBox1.Text == "" || textBox1.Text == "-")
                txt1 = 0;
            else
                txt1 = Convert.ToInt32(textBox1.Text);
            int txt2;
            if (textBox2.Text == "" || textBox2.Text == "-")
                txt2 = 0;
            else
                txt2 = Convert.ToInt32(textBox2.Text);
            if (txt1 >= txt2)
            {
                txt2 = txt1 + 1;
                textBox2.Text = Convert.ToString(txt2);
                numericUpDown2.Text = Convert.ToString(txt2);
                label2.Text = Convert.ToString(txt2);
            }
        }

        private void Label2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = label2.Text;
            numericUpDown2.Text = label2.Text;

            int txt1;
            if (textBox1.Text == "" || textBox1.Text == "-")
                txt1 = 0;
            else
                txt1 = Convert.ToInt32(textBox1.Text);
            int txt2;
            if (textBox2.Text == "" || textBox2.Text == "-")
                txt2 = 0;
            else
                txt2 = Convert.ToInt32(textBox2.Text);
            if (txt1 >= txt2)
            {
                txt1 = txt2 - 1;
                textBox1.Text = Convert.ToString(txt1);
                numericUpDown1.Text = Convert.ToString(txt1);
                label1.Text = Convert.ToString(txt1);
            }
        }

        private void ButtonMi1_Click(object sender, EventArgs e)
        {
            int text = Convert.ToInt32(label1.Text);
            text--;
            label1.Text = Convert.ToString(text);
        }

        private void ButtonMi2_Click(object sender, EventArgs e)
        {
            int text = Convert.ToInt32(label2.Text);
            text--;
            label2.Text = Convert.ToString(text);
        }

        private void ButtonPl1_Click(object sender, EventArgs e)
        {
            int text = Convert.ToInt32(label1.Text);
            text++;
            label1.Text = Convert.ToString(text);
        }

        private void ButtonPl2_Click(object sender, EventArgs e)
        {
            int text = Convert.ToInt32(label2.Text);
            text++;
            label2.Text = Convert.ToString(text);
        }

         private void Button1_Click(object sender, EventArgs e)
         {
            Form2 newForm = new Form2();
            newForm.Show();
        }
    }
}
