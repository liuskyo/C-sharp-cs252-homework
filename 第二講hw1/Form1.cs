using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int oneAddtow;
            int threeAddfour;
            oneAddtow = int.Parse(textBox1.Text) + int.Parse(textBox2.Text);
            threeAddfour = int.Parse(textBox3.Text) + int.Parse(textBox4.Text);
            string ans = "前兩項和:";
            ans = ans + oneAddtow;
            ans = ans + "後兩項和:";
            ans = ans + threeAddfour;
            MessageBox.Show(ans);
            
        }
    }
}
