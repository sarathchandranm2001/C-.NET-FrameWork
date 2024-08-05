namespace Student_Management
{
    partial class register
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
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            panel1 = new Panel();
            dob = new DateTimePicker();
            clear = new Button();
            submit = new Button();
            text_password = new TextBox();
            text_username = new TextBox();
            text_number = new TextBox();
            text_address = new RichTextBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            text_name = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(178, 16);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(178, 54);
            label2.Name = "label2";
            label2.Size = new Size(133, 20);
            label2.TabIndex = 1;
            label2.Text = "Department Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(182, 92);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 3;
            label4.Text = "Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(182, 139);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 4;
            label5.Text = "Address";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(182, 199);
            label6.Name = "label6";
            label6.Size = new Size(40, 20);
            label6.TabIndex = 5;
            label6.Text = "DOB";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(185, 246);
            label7.Name = "label7";
            label7.Size = new Size(80, 20);
            label7.TabIndex = 6;
            label7.Text = "Mobile No";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(185, 291);
            label8.Name = "label8";
            label8.Size = new Size(46, 20);
            label8.TabIndex = 7;
            label8.Text = "Email";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(184, 327);
            label9.Name = "label9";
            label9.Size = new Size(70, 20);
            label9.TabIndex = 8;
            label9.Text = "Password";
            // 
            // panel1
            // 
            panel1.Controls.Add(dob);
            panel1.Controls.Add(clear);
            panel1.Controls.Add(submit);
            panel1.Controls.Add(text_password);
            panel1.Controls.Add(text_username);
            panel1.Controls.Add(text_number);
            panel1.Controls.Add(text_address);
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(radioButton1);
            panel1.Controls.Add(checkBox2);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(text_name);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(284, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(814, 628);
            panel1.TabIndex = 9;
            // 
            // dob
            // 
            dob.Format = DateTimePickerFormat.Short;
            dob.Location = new Point(305, 192);
            dob.Name = "dob";
            dob.Size = new Size(250, 27);
            dob.TabIndex = 22;
            // 
            // clear
            // 
            clear.Location = new Point(322, 388);
            clear.Name = "clear";
            clear.Size = new Size(94, 29);
            clear.TabIndex = 21;
            clear.Text = "Clear";
            clear.UseVisualStyleBackColor = true;
            clear.Click += clear_Click;
            // 
            // submit
            // 
            submit.Location = new Point(200, 388);
            submit.Name = "submit";
            submit.Size = new Size(94, 29);
            submit.TabIndex = 20;
            submit.Text = "submit";
            submit.UseVisualStyleBackColor = true;
            // 
            // text_password
            // 
            text_password.Location = new Point(306, 320);
            text_password.Name = "text_password";
            text_password.Size = new Size(125, 27);
            text_password.TabIndex = 19;
            // 
            // text_username
            // 
            text_username.Location = new Point(305, 287);
            text_username.Name = "text_username";
            text_username.Size = new Size(125, 27);
            text_username.TabIndex = 18;
            // 
            // text_number
            // 
            text_number.Location = new Point(306, 246);
            text_number.Name = "text_number";
            text_number.Size = new Size(125, 27);
            text_number.TabIndex = 17;
            // 
            // text_address
            // 
            text_address.Location = new Point(306, 124);
            text_address.Name = "text_address";
            text_address.Size = new Size(239, 51);
            text_address.TabIndex = 15;
            text_address.Text = "";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(394, 95);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(78, 24);
            radioButton2.TabIndex = 14;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(322, 95);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(63, 24);
            radioButton1.TabIndex = 13;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(390, 56);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(103, 24);
            checkBox2.TabIndex = 11;
            checkBox2.Text = "Commerce";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(324, 56);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(48, 24);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "CS";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // text_name
            // 
            text_name.Location = new Point(321, 12);
            text_name.Name = "text_name";
            text_name.Size = new Size(125, 27);
            text_name.TabIndex = 9;
            // 
            // register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1310, 639);
            Controls.Add(panel1);
            Name = "register";
            Text = "register";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Panel panel1;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private TextBox text_name;
        private RichTextBox text_address;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button clear;
        private Button submit;
        private TextBox text_password;
        private TextBox text_username;
        private TextBox text_number;
        private DateTimePicker dob;
    }
}