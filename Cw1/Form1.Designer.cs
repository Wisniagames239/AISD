namespace Cw1
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
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            napisout = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(725, 62);
            label1.TabIndex = 0;
            label1.Text = "Program posortuje ci liczby metodą bąbelkową.\r\nPodaj niżej swoje liczby, oddzielając je przecinkiem,, , \" bez spacji";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            textBox1.Location = new Point(240, 223);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(357, 40);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button1.Location = new Point(329, 300);
            button1.Name = "button1";
            button1.Size = new Size(175, 57);
            button1.TabIndex = 2;
            button1.Text = "Sortuj :)";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // napisout
            // 
            napisout.AutoSize = true;
            napisout.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            napisout.Location = new Point(220, 171);
            napisout.Name = "napisout";
            napisout.Size = new Size(0, 28);
            napisout.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(800, 450);
            Controls.Add(napisout);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Label napisout;
    }
}
