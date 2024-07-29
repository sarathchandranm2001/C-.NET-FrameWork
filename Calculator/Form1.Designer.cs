namespace Calculator
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
            add = new Button();
            sub = new Button();
            prod = new Button();
            divide = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // add
            // 
            add.Location = new Point(71, 222);
            add.Name = "add";
            add.Size = new Size(94, 29);
            add.TabIndex = 0;
            add.Text = "+";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // sub
            // 
            sub.Location = new Point(258, 222);
            sub.Name = "sub";
            sub.Size = new Size(94, 29);
            sub.TabIndex = 1;
            sub.Text = "-";
            sub.UseVisualStyleBackColor = true;
            sub.Click += sub_Click;
            // 
            // prod
            // 
            prod.Location = new Point(451, 222);
            prod.Name = "prod";
            prod.Size = new Size(94, 29);
            prod.TabIndex = 2;
            prod.Text = "x";
            prod.UseVisualStyleBackColor = true;
            // 
            // divide
            // 
            divide.Location = new Point(671, 222);
            divide.Name = "divide";
            divide.Size = new Size(94, 29);
            divide.TabIndex = 3;
            divide.Text = "/";
            divide.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(358, 51);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(267, 27);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(358, 122);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(267, 27);
            textBox2.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(242, 58);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 6;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(242, 129);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 7;
            label2.Text = "label2";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(223, 360);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(334, 27);
            textBox3.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(divide);
            Controls.Add(prod);
            Controls.Add(sub);
            Controls.Add(add);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button add;
        private Button sub;
        private Button prod;
        private Button divide;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private TextBox textBox3;
    }
}
