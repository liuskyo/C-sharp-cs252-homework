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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int peopleNumber = int.Parse(peoplenumber.Text);
            int choiceOne=0;
            int choiceTwo=0;
            int choiceThree=0;
            Random random = new Random();
            choiceOne++;
            List<int> choice=new List<int>();
            choice.Add(1);
            for(int i=1;i<peopleNumber;i++){
                
                int ch=random.Next(1,4);
                choice.Add(ch);
                switch (ch)
                {
                    case 1:
                        choiceOne++;
                        break;
                    case 2:
                        choiceTwo++;
                        break;
                    case 3:
                        choiceThree++;
                        break;
                    default:
                        break;

                }
     
            }

            string showtext="";
            for(int i=1;i<peopleNumber;i++){
                switch(choice[i]){
                    case 1:
                        showtext=String.Format("{0}{1}號玩家出的是:剪刀 ",showtext,i);
                    break;
                    case 2:
                        showtext=String.Format("{0}{1}號玩家出的是:石頭 ",showtext,i);
                    break;
                    case 3:
                        showtext=String.Format("{0}{1}號玩家出的是:布 ",showtext,i);
                    break;
                    default:
                    break;

                }
            }


            if (choiceTwo != 0 && choiceThree != 0)
            {
                MessageBox.Show(String.Format("平手!! 你出的是:剪刀 {0}", showtext));
            }
            else if (choiceTwo == 0 && choiceThree == 0)
            {
                MessageBox.Show(String.Format("平手!! 你出的是:剪刀 {0}", showtext));
            }
            else if (choiceTwo == 0 && choiceThree != 0)
            {
                MessageBox.Show(String.Format("你贏了!! 你出的是:剪刀 {0}", showtext));
            }
            else
            {
                MessageBox.Show(String.Format("你輸了!! 你出的是:剪刀 {0}", showtext));
            }
            



        }

        private void two_Click(object sender, EventArgs e)
        {
            int peopleNumber = int.Parse(peoplenumber.Text);
            int choiceOne = 0;
            int choiceTwo = 0;
            int choiceThree = 0;
            Random random = new Random();
            choiceTwo++;
            List<int> choice = new List<int>();
            choice.Add(2);
            for (int i = 1; i < peopleNumber; i++)
            {

                int ch = random.Next(1, 4);
                choice.Add(ch);
                switch (ch)
                {
                    case 1:
                        choiceOne++;
                        break;
                    case 2:
                        choiceTwo++;
                        break;
                    case 3:
                        choiceThree++;
                        break;
                    default:
                        break;

                }

            }

            string showtext = "";
            for (int i = 1; i < peopleNumber; i++)
            {
                switch (choice[i])
                {
                    case 1:
                        showtext = String.Format("{0}{1}號玩家出的是:剪刀 ", showtext, i);
                        break;
                    case 2:
                        showtext = String.Format("{0}{1}號玩家出的是:石頭 ", showtext, i);
                        break;
                    case 3:
                        showtext = String.Format("{0}{1}號玩家出的是:布 ", showtext, i);
                        break;
                    default:
                        break;

                }
            }


            if (choiceOne != 0 && choiceThree != 0)
            {
                MessageBox.Show(String.Format("平手!! 你出的是:石頭 {0}", showtext));
            }
            else if (choiceOne == 0 && choiceThree == 0)
            {
                MessageBox.Show(String.Format("平手!! 你出的是:石頭 {0}", showtext));
            }
            else if (choiceOne == 0 && choiceThree != 0)
            {
                MessageBox.Show(String.Format("你輸了!! 你出的是:石頭 {0}", showtext));
            }
            else
            {
                MessageBox.Show(String.Format("你贏了!! 你出的是:石頭 {0}", showtext));
            }
        }

        private void three_Click(object sender, EventArgs e)
        {
            int peopleNumber = int.Parse(peoplenumber.Text);
            int choiceOne = 0;
            int choiceTwo = 0;
            int choiceThree = 0;
            Random random = new Random();
            choiceThree++;
            List<int> choice = new List<int>();
            choice.Add(3);
            for (int i = 1; i < peopleNumber; i++)
            {

                int ch = random.Next(1, 4);
                choice.Add(ch);
                switch (ch)
                {
                    case 1:
                        choiceOne++;
                        break;
                    case 2:
                        choiceTwo++;
                        break;
                    case 3:
                        choiceThree++;
                        break;
                    default:
                        break;

                }

            }

            string showtext = "";
            for (int i = 1; i < peopleNumber; i++)
            {
                switch (choice[i])
                {
                    case 1:
                        showtext = String.Format("{0}{1}號玩家出的是:剪刀 ", showtext, i);
                        break;
                    case 2:
                        showtext = String.Format("{0}{1}號玩家出的是:石頭 ", showtext, i);
                        break;
                    case 3:
                        showtext = String.Format("{0}{1}號玩家出的是:布 ", showtext, i);
                        break;
                    default:
                        break;

                }
            }


            if (choiceTwo != 0 && choiceOne != 0)
            {
                MessageBox.Show(String.Format("平手!! 你出的是:布 {0}", showtext));
            }
            else if (choiceTwo == 0 && choiceOne == 0)
            {
                MessageBox.Show(String.Format("平手!! 你出的是:布 {0}", showtext));
            }
            else if (choiceTwo == 0 && choiceOne != 0)
            {
                MessageBox.Show(String.Format("你輸了!! 你出的是:布 {0}", showtext));
            }
            else
            {
                MessageBox.Show(String.Format("你贏了!! 你出的是:布 {0}", showtext));
            }
        }

        private void computerPlay_Click(object sender, EventArgs e)
        {
            int peopleNumber = int.Parse(peoplenumber.Text);
            int choiceOne = 0;
            int choiceTwo = 0;
            int choiceThree = 0;
            Random random = new Random();
            List<int> choice = new List<int>();
    
            for (int i = 0; i < peopleNumber; i++)
            {

                int ch = random.Next(1, 4);
                choice.Add(ch);
                switch (ch)
                {
                    case 1:
                        choiceOne++;
                        break;
                    case 2:
                        choiceTwo++;
                        break;
                    case 3:
                        choiceThree++;
                        break;
                    default:
                        break;

                }

            }

            string showtext = "";
            List<int> oneList = new List<int>();
            List<int> twoList = new List<int>();
            List<int> threeList = new List<int>();
            for (int i = 0; i < peopleNumber; i++)
            {
                switch (choice[i])
                {
                    case 1:
                        showtext = String.Format("{0}{1}號玩家出的是:剪刀 ", showtext, i);
                        oneList.Add(i);
                        break;
                    case 2:
                        showtext = String.Format("{0}{1}號玩家出的是:石頭 ", showtext, i);
                        twoList.Add(i);
                        break;
                    case 3:
                        showtext = String.Format("{0}{1}號玩家出的是:布 ", showtext, i);
                        threeList.Add(i);
                        break;
                    default:
                        break;

                }
            }
            if ((choiceOne != 0 && choiceTwo != 0) && choiceThree != 0)
            {
                MessageBox.Show(String.Format("平手!! {0}", showtext));
            }else if(choiceOne==0&&choiceTwo*choiceThree!=0){
                string str="";
                for(int i=0;i<threeList.Count;i++){
                    str=String.Format("{0} {1} ",str,threeList[i]);
                }
                MessageBox.Show(String.Format("{0}號玩家贏!!，{1}",str,showtext));
            }
            else if (choiceTwo == 0 && choiceOne * choiceThree != 0)
            {
                string str = "";
                for (int i = 0; i < oneList.Count; i++)
                {
                    str = String.Format("{0} {1} ", str, oneList[i]);
                }
                MessageBox.Show(String.Format("{0}號玩家贏!!，{1}", str, showtext));
            }
            else if (choiceThree == 0 && choiceOne * choiceTwo != 0)
            {
                string str = "";
                for (int i = 0; i < twoList.Count; i++)
                {
                    str = String.Format("{0} {1} ", str, twoList[i]);
                }
                MessageBox.Show(String.Format("{0}號玩家贏!!，{1}", str, showtext));
            }
            else
            {
                MessageBox.Show(String.Format("平手!! {0}",showtext));
            }





           
        }
    }
}
