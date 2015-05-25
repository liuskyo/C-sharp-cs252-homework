using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    class guessNumberGame
    {
       public string guess(string anwserNumber,string guessNumber){
           int A, B;
           A=0;
           B=0;

           for (int i = 0; i < anwserNumber.Count(); i++) {
               for (int j = 0; j < guessNumber.Count(); j++) {
                   if (anwserNumber[i] == guessNumber[j]) {
                       B++;
                   }
               }
           }
               for (int i = 0; i < anwserNumber.Count(); i++)
               {
                   if (guessNumber[i] == anwserNumber[i])
                   {
                       B--;
                       A++;
                   }
               }
               if (A == 4)
               {
                   return "猜對了!!";
               }
               else {
                   return String.Format("{0}A{1}B", A, B);
               
               }

       }

       public void computerGuess(string anwserNumber)
       {
          List<string> unuseString=new List<string>();
          int i, j, k, l;
          for (i = 0; i <= 9; i++) {
              for (j = 0; j <= 9; j++)
              {
                  for (k = 0; k <= 9; k++)
                  {
                      for (l = 0; l <= 9; l++)
                      {
                          if ((i != j) && (i != k))
                          {
                              if ((i != l) && (j != k))
                              {
                                  if ((j != l) && (k != l))
                                  {
                                      string str = String.Format("{0}{1}{2}{3}", i, j, k, l);
                                      unuseString.Add(str);
                                  }
                              }
                          }
                      }
                  }
              }
          }

          string computerGuessString;
          string computerGuessResponse="";
          while (computerGuessResponse != "猜對了!!")
          {
              Random random = new Random();
              int randomint = random.Next(0, unuseString.Count);
              computerGuessString = unuseString[randomint];
              computerGuessResponse = guess(anwserNumber, computerGuessString);
              MessageBox.Show(String.Format("電腦猜:{0},結果:{1}",computerGuessString,computerGuessResponse));
            //  Console.WriteLine("電腦猜:{0}", computerGuessString);
            //  Console.WriteLine("結果:{0}", computerGuessResponse);
              if (computerGuessResponse != "猜對了!!")
              {
                  int AplusB = int.Parse(String.Format("{0}",computerGuessResponse[0]));
                  AplusB = AplusB + int.Parse(String.Format("{0}", computerGuessResponse[2]));
                  unuseString.Remove(computerGuessString);
                  for (int t = 0; t < unuseString.Count; t++)
                  {
                      string temStr = guess(computerGuessString, unuseString[t]);
                      int temAplusB = int.Parse(String.Format("{0}", temStr[0]));
                      temAplusB = temAplusB + int.Parse(String.Format("{0}", temStr[2]));
                      if (temAplusB > AplusB)
                      {
                          unuseString.RemoveAt(t);
                      }
                  }


              }
          }










       }







    }
}
