namespace Student_Management
{
    partial class Homepage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxStudents = new System.Windows.Forms.ComboBox();
            this.buttonViewResult = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBoxStudents);
            this.panel1.Controls.Add(this.buttonViewResult);
            this.panel1.Controls.Add(this.labelResult);
            this.panel1.Location = new System.Drawing.Point(103, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1267, 535);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(533, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "ViewResults";
            // 
            // comboBoxStudents
            // 
            this.comboBoxStudents.FormattingEnabled = true;
            this.comboBoxStudents.Location = new System.Drawing.Point(540, 70);
            this.comboBoxStudents.Name = "comboBoxStudents";
            this.comboBoxStudents.Size = new System.Drawing.Size(200, 28);
            this.comboBoxStudents.TabIndex = 1;
            // 
            // buttonViewResult
            // 
            this.buttonViewResult.Location = new System.Drawing.Point(540, 120);
            this.buttonViewResult.Name = "buttonViewResult";
            this.buttonViewResult.Size = new System.Drawing.Size(200, 30);
            this.buttonViewResult.TabIndex = 2;
            this.buttonViewResult.Text = "View Result";
            this.buttonViewResult.UseVisualStyleBackColor = true;
            this.buttonViewResult.Click += new System.EventHandler(this.ButtonViewResult_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.ForeColor = System.Drawing.SystemColors.Info;
            this.labelResult.Location = new System.Drawing.Point(540, 170);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 32);
            this.labelResult.TabIndex = 3;
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1447, 649);
            this.Controls.Add(this.panel1);
            this.Name = "Homepage";
            this.Text = "Homepage";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxStudents;
        private System.Windows.Forms.Button buttonViewResult;
        private System.Windows.Forms.Label labelResult;
    }
}
