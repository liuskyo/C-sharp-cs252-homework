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
            this.peoplenumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.computerPlay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // peoplenumber
            // 
            this.peoplenumber.Location = new System.Drawing.Point(131, 40);
            this.peoplenumber.Name = "peoplenumber";
            this.peoplenumber.Size = new System.Drawing.Size(100, 22);
            this.peoplenumber.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "請輸入猜拳人數";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // one
            // 
            this.one.Location = new System.Drawing.Point(38, 100);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(75, 23);
            this.one.TabIndex = 2;
            this.one.Text = "剪刀";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(120, 100);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(75, 23);
            this.two.TabIndex = 3;
            this.two.Text = "石頭";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // three
            // 
            this.three.Location = new System.Drawing.Point(202, 100);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(75, 23);
            this.three.TabIndex = 4;
            this.three.Text = "布";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // computerPlay
            // 
            this.computerPlay.Location = new System.Drawing.Point(65, 181);
            this.computerPlay.Name = "computerPlay";
            this.computerPlay.Size = new System.Drawing.Size(165, 50);
            this.computerPlay.TabIndex = 5;
            this.computerPlay.Text = "電腦自己玩";
            this.computerPlay.UseVisualStyleBackColor = true;
            this.computerPlay.Click += new System.EventHandler(this.computerPlay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 291);
            this.Controls.Add(this.computerPlay);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.peoplenumber);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox peoplenumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button computerPlay;
    }
}

