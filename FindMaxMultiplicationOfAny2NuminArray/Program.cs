using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxMultiplicationOfAny2NuminArray
{
    internal class Program
    {
        public int MaxMultiplication(int[] arr1)
        {
            int max = arr1[0] > arr1[1] ? arr1[0] : arr1[1];
            int secondMax = arr1[0] < arr1[1] ? arr1[0] : arr1[1];
            int min = arr1[0] > arr1[1] ? arr1[1] : arr1[0];
            int secondMin = arr1[0] < arr1[1] ? arr1[1] : arr1[0];

            for(int i=2;i<arr1.Length;i++)
            {
                if (arr1[i] <min)
                {
                    secondMin = min;
                    min=arr1[i];
                }
                else if (arr1[i]<secondMin)
                {
                    secondMin = arr1[i];
                }
                if (arr1[i]>max)
                {
                    secondMax = max;
                    max = arr1[i];
                }
                else if (arr1[i] > secondMax)
                {
                    secondMax = arr1[i];
                }
            }
            
            int firsttwoeleMultiplication = min * secondMin;
            int lasttwoMultiplication = max * secondMax;
            return (firsttwoeleMultiplication > lasttwoMultiplication) ? firsttwoeleMultiplication : lasttwoMultiplication;

        }
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 4,-20 ,-18,1, 3, 12, 7, 8 };
            Program obj = new Program();
            Console.WriteLine(obj.MaxMultiplication(arr1)); 
        }
    }
}
