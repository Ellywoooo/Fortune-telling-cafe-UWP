using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace CafeOZ.Models
{
    public class LottoGenerater
    {
        private int[] numArray;
        private Random randomNumber;

        public LottoGenerater()
        {
            numArray = new int[6];
            randomNumber = new Random(DateTime.Now.Millisecond);
        }

        //Add the random 6 numbers into array
        public void GenerateNumbers()
        {
            for(int i = 0; i < numArray.Length; i++)
            {
                //Set the random numberin array 
                numArray[i] = randomNumber.Next(1, 50);

                for (int j = 0; j < i; j++)
                {
                    //When a new random number overlaps with previous numbers
                    if (numArray[i] == numArray[j])
                    {
                        //Reinitializing random numbers until not overlap
                        while (numArray[i] != numArray[j])
                        { 
                            numArray[i] = randomNumber.Next(1, 50); 
                        }
                    }
                    
                }

            }
        }
        //Print the random 6 numbers
        public void PrintNumbers(TextBlock OutputTextBlock)
        {
            for(int num = 0; num < numArray.Length; num++)
            {
                if (numArray[num] < 10)
                {
                    OutputTextBlock.Text = OutputTextBlock.Text + " " + numArray[num] + "  ";

                }
                else
                {
                    OutputTextBlock.Text = OutputTextBlock.Text + numArray[num] + "  ";
                }
                
            }
                
        }
        //Set 6 numbers to zero
        public void SetNumbersToZero()
        {
            for(int num = 0; num < numArray.Length; num++)
            {
                numArray[num] = 0;                
            }
        }

    }
}
