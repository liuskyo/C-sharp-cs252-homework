using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int sex = random.Next(1, 2);
            string show;
            if (sex == 1)
            {
                show=String.Format("{0}是男生，恭喜你猜對了!",name.Text);
                MessageBox.Show(show);
            }
            else
            {
                show = String.Format("{0}是女生，你猜錯了!", name.Text);
                MessageBox.Show(show);
            }

        }

        private void female_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int sex = random.Next(1, 2);
            string show;
            if (sex == 2)
            {
                show = String.Format("{0}是女生，恭喜你猜對了!", name.Text);
                MessageBox.Show(show);
            }
            else
            {
                show = String.Format("{0}是男生，你猜錯了!", name.Text);
                MessageBox.Show(show);
            }
        }
    }
}
