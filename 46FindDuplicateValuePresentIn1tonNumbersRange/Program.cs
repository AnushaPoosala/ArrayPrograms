using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46FindDuplicateValuePresentIn1tonNumbersRange
{
    internal class Program
    {
        public int FindDuplicateValuePresentIn1tonNumbersRange(int[] arr)
        {
            int i = 0;
            while(i<arr.Length)
            {
                if (arr[i] != arr[arr[i] - 1])
                {
                    int otherIndex =arr[i] - 1;

                    int temp = arr[i];
                    arr[i] = arr[otherIndex];
                    arr[otherIndex] = temp;
                }
                else
                    i++;
            }

            foreach(var ele in arr) 
                Console.WriteLine(ele);
            return arr[arr.Length-1];
        }
        static void Main(string[] args)
        {
            int[] arr = {3,2,1,2,4,5};
            Program program = new Program();
            Console.WriteLine("Duplicate value in array is{0}:",program.FindDuplicateValuePresentIn1tonNumbersRange(arr));
        }
    }
}
