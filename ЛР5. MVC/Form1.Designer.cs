namespace ЛР5.MVC
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonMi1 = new System.Windows.Forms.Button();
            this.buttonPl1 = new System.Windows.Forms.Button();
            this.buttonMi2 = new System.Windows.Forms.Button();
            this.buttonPl2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(59, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(226, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "0";
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(510, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(226, 22);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "1";
            this.textBox2.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(59, 114);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            -469762049,
            -590869294,
            5421010,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            268435455,
            1042612833,
            542101086,
            -2147483648});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(225, 22);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.NumericUpDown1_ValueChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(510, 114);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            -469762049,
            -590869294,
            5421010,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            268435455,
            1042612833,
            542101086,
            -2147483648});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(225, 22);
            this.numericUpDown2.TabIndex = 3;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.NumericUpDown2_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "0";
            this.label1.TextChanged += new System.EventHandler(this.Label1_TextChanged);
            // 
            // buttonMi1
            // 
            this.buttonMi1.Location = new System.Drawing.Point(59, 191);
            this.buttonMi1.Name = "buttonMi1";
            this.buttonMi1.Size = new System.Drawing.Size(57, 47);
            this.buttonMi1.TabIndex = 5;
            this.buttonMi1.Text = "-";
            this.buttonMi1.UseVisualStyleBackColor = true;
            this.buttonMi1.Click += new System.EventHandler(this.ButtonMi1_Click);
            // 
            // buttonPl1
            // 
            this.buttonPl1.Location = new System.Drawing.Point(227, 191);
            this.buttonPl1.Name = "buttonPl1";
            this.buttonPl1.Size = new System.Drawing.Size(57, 47);
            this.buttonPl1.TabIndex = 6;
            this.buttonPl1.Text = "+";
            this.buttonPl1.UseVisualStyleBackColor = true;
            this.buttonPl1.Click += new System.EventHandler(this.ButtonPl1_Click);
            // 
            // buttonMi2
            // 
            this.buttonMi2.Location = new System.Drawing.Point(510, 191);
            this.buttonMi2.Name = "buttonMi2";
            this.buttonMi2.Size = new System.Drawing.Size(57, 47);
            this.buttonMi2.TabIndex = 7;
            this.buttonMi2.Text = "-";
            this.buttonMi2.UseVisualStyleBackColor = true;
            this.buttonMi2.Click += new System.EventHandler(this.ButtonMi2_Click);
            // 
            // buttonPl2
            // 
            this.buttonPl2.Location = new System.Drawing.Point(678, 191);
            this.buttonPl2.Name = "buttonPl2";
            this.buttonPl2.Size = new System.Drawing.Size(57, 47);
            this.buttonPl2.TabIndex = 8;
            this.buttonPl2.Text = "+";
            this.buttonPl2.UseVisualStyleBackColor = true;
            this.buttonPl2.Click += new System.EventHandler(this.ButtonPl2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(573, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "1";
            this.label2.TextChanged += new System.EventHandler(this.Label2_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(334, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 62);
            this.button1.TabIndex = 10;
            this.button1.Text = "Открыть версию с MVC";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonPl2);
            this.Controls.Add(this.buttonMi2);
            this.Controls.Add(this.buttonPl1);
            this.Controls.Add(this.buttonMi1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonMi1;
        private System.Windows.Forms.Button buttonPl1;
        private System.Windows.Forms.Button buttonMi2;
        private System.Windows.Forms.Button buttonPl2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
    }
}

