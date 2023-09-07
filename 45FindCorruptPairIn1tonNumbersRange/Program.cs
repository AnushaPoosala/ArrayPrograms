using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _45FindCorruptPairIn1tonNumbersRange
{
    internal class Program
    {//we need to find out what is the missing num, wt is the duplicate no.

        public int FindCorruptPairIn1tonNumbersRange(int[] arr)
        {
            int duplicateNum = 0; int i = 0;

            while(i<arr.Length)
            {
                if (arr[i] != arr[arr[i] - 1])
                {
                    int otherIndex = arr[i] - 1;

                    int temp = arr[i];
                    arr[i] = arr[otherIndex];
                    arr[otherIndex] = temp;
                }
                else
                {
                    i++;
                }
            }

            for(i=0;i<arr.Length;i++)
            {
                if (arr[i]!=i+1)
                {
                    Console.WriteLine("Missing no. is: {0}\nDuplicate ele is:{1}", i + 1, arr[i]);
                }
            }
          
            return duplicateNum;
        }
        static void Main(string[] args)
        {
            int[] arr = { 2, 3, 4, 5, 5 };
            Program program=new Program();
            program.FindCorruptPairIn1tonNumbersRange(arr);
        }
    }
}
