namespace WinFormsApp1
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
            label2 = new Label();
            uname = new TextBox();
            pass = new TextBox();
            Login = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 60);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 0;
            label1.Text = "USER NAME:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 125);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 1;
            label2.Text = "PASSWORD:";
            // 
            // uname
            // 
            uname.Location = new Point(207, 60);
            uname.Name = "uname";
            uname.Size = new Size(358, 27);
            uname.TabIndex = 2;
            uname.TextChanged += uname_TextChanged;
            // 
            // pass
            // 
            pass.Location = new Point(207, 129);
            pass.Name = "pass";
            pass.Size = new Size(358, 27);
            pass.TabIndex = 3;
            pass.TextChanged += pass_TextChanged;
            // 
            // Login
            // 
            Login.Location = new Point(207, 213);
            Login.Name = "Login";
            Login.Size = new Size(247, 61);
            Login.TabIndex = 5;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = true;
            Login.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(327, 358);
            label3.Name = "label3";
            label3.Size = new Size(25, 20);
            label3.TabIndex = 6;
            label3.Text = "12";
            label3.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(Login);
            Controls.Add(pass);
            Controls.Add(uname);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox uname;
        private TextBox pass;
        private Button Login;
        private Label label3;
    }
}
