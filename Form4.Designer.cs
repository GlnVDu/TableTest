namespace TableTest1
{
    partial class Form4
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
            label4 = new Label();
            label2 = new Label();
            textBox5 = new TextBox();
            textBox1 = new TextBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 61);
            label4.Name = "label4";
            label4.Size = new Size(75, 25);
            label4.TabIndex = 22;
            label4.Text = "Country";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 26);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 20;
            label2.Text = "Name";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(273, 55);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(150, 31);
            textBox5.TabIndex = 19;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(273, 18);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 16;
            // 
            // button3
            // 
            button3.Location = new Point(290, 151);
            button3.Name = "button3";
            button3.Size = new Size(133, 57);
            button3.TabIndex = 15;
            button3.Text = "reference";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(151, 151);
            button2.Name = "button2";
            button2.Size = new Size(133, 57);
            button2.TabIndex = 14;
            button2.Text = "close";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 151);
            button1.Name = "button1";
            button1.Size = new Size(133, 57);
            button1.TabIndex = 13;
            button1.Text = "add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 220);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(textBox5);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label2;
        private TextBox textBox5;
        private TextBox textBox1;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}