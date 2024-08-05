namespace Student_Management
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
            btn_register = new Button();
            btn_login = new Button();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(126, 45);
            label1.Name = "label1";
            label1.Size = new Size(543, 106);
            label1.TabIndex = 0;
            label1.Text = "WELCOME.....";
            // 
            // btn_register
            // 
            btn_register.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_register.ForeColor = SystemColors.Highlight;
            btn_register.Location = new Point(499, 199);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(94, 29);
            btn_register.TabIndex = 1;
            btn_register.Text = "Register";
            btn_register.UseVisualStyleBackColor = true;
            btn_register.Click += btn_register_Click;
            // 
            // btn_login
            // 
            btn_login.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_login.ForeColor = SystemColors.Highlight;
            btn_login.Location = new Point(499, 280);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(94, 29);
            btn_login.TabIndex = 2;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(183, 199);
            label2.Name = "label2";
            label2.Size = new Size(270, 31);
            label2.TabIndex = 3;
            label2.Text = "New User?Register Here";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(183, 275);
            label3.Name = "label3";
            label3.Size = new Size(300, 31);
            label3.TabIndex = 4;
            label3.Text = "Already A User?Login Here";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btn_login);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btn_register);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(347, 126);
            panel1.Name = "panel1";
            panel1.Size = new Size(769, 475);
            panel1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1337, 751);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btn_register;
        private Button btn_login;
        private Label label2;
        private Label label3;
        private Panel panel1;
    }
}
