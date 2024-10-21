namespace sortowania
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            panel2 = new Panel();
            numericUpDown1 = new NumericUpDown();
            label2 = new Label();
            button2 = new Button();
            label3 = new Label();
            button3 = new Button();
            label4 = new Label();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            label5 = new Label();
            button8 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(37, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(341, 209);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(15, 15);
            label1.Name = "label1";
            label1.Size = new Size(313, 20);
            label1.TabIndex = 2;
            label1.Text = "Tu podajesz swoje liczby, oddzielone spacją";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            textBox1.Location = new Point(42, 67);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(244, 40);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button1.Location = new Point(69, 143);
            button1.Name = "button1";
            button1.Size = new Size(197, 47);
            button1.TabIndex = 0;
            button1.Text = "Konwertuj ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(numericUpDown1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(button2);
            panel2.Location = new Point(372, 35);
            panel2.Name = "panel2";
            panel2.Size = new Size(352, 209);
            panel2.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(33, 76);
            numericUpDown1.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.Location = new Point(21, 15);
            label2.Name = "label2";
            label2.Size = new Size(311, 40);
            label2.TabIndex = 3;
            label2.Text = "Tu generujesz losowy ciąg liczb o wybranej \r\nliczbie elementów (max 10M)";
            // 
            // button2
            // 
            button2.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button2.Location = new Point(80, 143);
            button2.Name = "button2";
            button2.Size = new Size(197, 47);
            button2.TabIndex = 1;
            button2.Text = "Generuj";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.Location = new Point(37, 265);
            label3.Name = "label3";
            label3.Size = new Size(46, 18);
            label3.TabIndex = 2;
            label3.Text = "label3";
            label3.Visible = false;
            // 
            // button3
            // 
            button3.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button3.Location = new Point(24, 374);
            button3.Name = "button3";
            button3.Size = new Size(111, 47);
            button3.TabIndex = 3;
            button3.Text = "Bubblesort";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label4.Location = new Point(37, 296);
            label4.Name = "label4";
            label4.Size = new Size(46, 18);
            label4.TabIndex = 4;
            label4.Text = "label4";
            label4.Visible = false;
            // 
            // button4
            // 
            button4.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button4.Location = new Point(141, 376);
            button4.Name = "button4";
            button4.Size = new Size(129, 47);
            button4.TabIndex = 5;
            button4.Text = "Insertionsort";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button5.Location = new Point(276, 374);
            button5.Name = "button5";
            button5.Size = new Size(129, 47);
            button5.TabIndex = 6;
            button5.Text = "Selectionsort";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button6.Location = new Point(411, 374);
            button6.Name = "button6";
            button6.Size = new Size(112, 47);
            button6.TabIndex = 7;
            button6.Text = "Quicksort";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button7.Location = new Point(529, 374);
            button7.Name = "button7";
            button7.Size = new Size(107, 47);
            button7.TabIndex = 8;
            button7.Text = "Mergesort";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label5.Location = new Point(37, 327);
            label5.Name = "label5";
            label5.Size = new Size(46, 18);
            label5.TabIndex = 9;
            label5.Text = "label5";
            label5.Visible = false;
            // 
            // button8
            // 
            button8.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button8.Location = new Point(642, 374);
            button8.Name = "button8";
            button8.Size = new Size(123, 47);
            button8.TabIndex = 10;
            button8.Text = "Countingsort";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(800, 450);
            Controls.Add(button8);
            Controls.Add(label5);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Sortowania";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox textBox1;
        private Button button1;
        private Panel panel2;
        private Button button2;
        private Label label1;
        private NumericUpDown numericUpDown1;
        private Label label2;
        private Label label3;
        private Button button3;
        private Label label4;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Label label5;
        private Button button8;
    }
}
