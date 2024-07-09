namespace DBConnectForm
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
            login = new Button();
            register = new Button();
            SuspendLayout();
            // 
            // login
            // 
            login.Location = new Point(225, 110);
            login.Name = "login";
            login.Size = new Size(335, 112);
            login.TabIndex = 0;
            login.Text = "LOGIN";
            login.UseVisualStyleBackColor = true;
            login.Click += login_Click;
            // 
            // register
            // 
            register.Location = new Point(225, 245);
            register.Name = "register";
            register.Size = new Size(335, 112);
            register.TabIndex = 1;
            register.Text = "REGISTER";
            register.UseVisualStyleBackColor = true;
            register.Click += register_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(register);
            Controls.Add(login);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button login;
        private Button register;
    }
}
