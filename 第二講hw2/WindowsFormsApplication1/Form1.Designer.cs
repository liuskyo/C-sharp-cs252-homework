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
            this.name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.male = new System.Windows.Forms.Button();
            this.female = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(91, 42);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(157, 22);
            this.name.TabIndex = 0;
            this.name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "請輸入一名字";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "請猜測性別";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // male
            // 
            this.male.Location = new System.Drawing.Point(75, 148);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(75, 23);
            this.male.TabIndex = 3;
            this.male.Text = "男";
            this.male.UseVisualStyleBackColor = true;
            this.male.Click += new System.EventHandler(this.button1_Click);
            // 
            // female
            // 
            this.female.Location = new System.Drawing.Point(156, 148);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(75, 23);
            this.female.TabIndex = 4;
            this.female.Text = "女";
            this.female.UseVisualStyleBackColor = true;
            this.female.Click += new System.EventHandler(this.female_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.female);
            this.Controls.Add(this.male);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button male;
        private System.Windows.Forms.Button female;
    }
}

