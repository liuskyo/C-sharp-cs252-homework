using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        string anser = makeAnwserNumber();
        
        public Form1()
        {
            InitializeComponent();
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            guessNumberGame game = new guessNumberGame();
            string str = game.guess(anser, textBox1.Text);
            MessageBox.Show(str);
        }

       public static string makeAnwserNumber()
        {
            Random random=new Random();
            List<int> unuseNumber =new List<int>();
            List<int> useNumber = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                unuseNumber.Add(i);
            }
            for (int i = 0; i < 4; i++)
            {
                int temp;
                temp = random.Next(0, unuseNumber.Count);
                useNumber.Add(unuseNumber[temp]);
                unuseNumber.RemoveAt(temp);

            }
            string answerString;
            answerString = String.Format("{0}{1}{2}{3}", useNumber[0], useNumber[1], useNumber[2], useNumber[3]);



            return answerString;
            

        }

       private void button2_Click(object sender, EventArgs e)
       {
           guessNumberGame computerGame = new guessNumberGame();
           computerGame.computerGuess(anser);
       }


    }
}
