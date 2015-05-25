namespace WindowsFormsApplication1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.baseSalarybox = new System.Windows.Forms.TextBox();
            this.benefitbox = new System.Windows.Forms.TextBox();
            this.OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "底薪";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "獎金";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // baseSalarybox
            // 
            this.baseSalarybox.Location = new System.Drawing.Point(111, 44);
            this.baseSalarybox.Name = "baseSalarybox";
            this.baseSalarybox.Size = new System.Drawing.Size(100, 22);
            this.baseSalarybox.TabIndex = 2;
            this.baseSalarybox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // benefitbox
            // 
            this.benefitbox.Location = new System.Drawing.Point(111, 72);
            this.benefitbox.Name = "benefitbox";
            this.benefitbox.Size = new System.Drawing.Size(100, 22);
            this.benefitbox.TabIndex = 3;
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(111, 119);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 4;
            this.OK.Text = "確定";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.benefitbox);
            this.Controls.Add(this.baseSalarybox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox baseSalarybox;
        private System.Windows.Forms.TextBox benefitbox;
        private System.Windows.Forms.Button OK;
    }
}

