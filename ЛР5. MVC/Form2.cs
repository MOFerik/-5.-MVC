using System;
using System.Windows.Forms;

namespace ЛР5.MVC
{
    public partial class Form2 : Form
    {
        Model model;
        public Form2()
        {
            InitializeComponent();

            model = new Model();
            model.observers += new System.EventHandler(this.UpdateFromModel);
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text == "-")
                model.setValue1(0);
            else
                model.setValue1(Convert.ToInt32(textBox1.Text));
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox2.Text == "-")
                model.setValue2(0);
            else
                model.setValue2(Convert.ToInt32(textBox2.Text));
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
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
            model.setValue1(Convert.ToInt32(numericUpDown1.Value));
        }

        private void NumericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            model.setValue2(Convert.ToInt32(numericUpDown2.Value));
        }

        private void ButtonPl1_Click(object sender, EventArgs e)
        {
            model.setValue1(model.getValue1() + 1);
        }

        private void ButtonMi1_Click(object sender, EventArgs e)
        {
            model.setValue1(model.getValue1() - 1);
        }

        private void ButtonPl2_Click(object sender, EventArgs e)
        {
            model.setValue2(model.getValue2() + 1);
        }

        private void ButtonMi2_Click(object sender, EventArgs e)
        {
            model.setValue2(model.getValue2() - 1);
        }

        private void UpdateFromModel(object sender, EventArgs e)
        {
            if (model.getValue1() >= model.getValue2() && model.getSide() == 1)
            {
                textBox1.Text = Convert.ToString(model.getValue1());
                numericUpDown1.Value = model.getValue1();
                label1.Text = Convert.ToString(model.getValue1());

                model.setValue2(model.getValue1() + 1);
                textBox2.Text = Convert.ToString(model.getValue2());
                numericUpDown2.Value = model.getValue2();
                label2.Text = Convert.ToString(model.getValue2());
            }
            else if (model.getValue1() >= model.getValue2() && model.getSide() == 2)
            {
                textBox2.Text = Convert.ToString(model.getValue2());
                numericUpDown2.Value = model.getValue2();
                label2.Text = Convert.ToString(model.getValue2());

                model.setValue1(model.getValue2() - 1);
                textBox1.Text = Convert.ToString(model.getValue1());
                numericUpDown1.Value = model.getValue1();
                label1.Text = Convert.ToString(model.getValue1());
            }
            else
            {
                textBox1.Text = Convert.ToString(model.getValue1());
                numericUpDown1.Value = model.getValue1();
                label1.Text = Convert.ToString(model.getValue1());
                textBox2.Text = Convert.ToString(model.getValue2());
                numericUpDown2.Value = model.getValue2();
                label2.Text = Convert.ToString(model.getValue2());
            }
        }
    }

    public class Model
    {
        private int value1;
        private int value2;
        private int lastSide;
        public System.EventHandler observers;

        public int getSide()
        {
            return lastSide;
        }

        public void setValue1(int value)
        {
            this.value1 = value;
            this.lastSide = 1;
            observers.Invoke(this, null);
        }

        public void setValue2(int value)
        {
            this.value2 = value;
            this.lastSide = 2;
            observers.Invoke(this, null);
        }

        public int getValue1()
        {
            return value1;
        }

        public int getValue2()
        {
            return value2;
        }
    }
}
