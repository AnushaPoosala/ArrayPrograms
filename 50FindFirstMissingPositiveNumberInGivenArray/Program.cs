using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _50FindFirstMissingPositiveNumberInGivenArray
{
    internal class Program
    {
        public int FirstMissingPositiveNumberInGivenArray(int[] arr)
        {
            int i = 0;
            while(i<arr.Length)
            {
                if (arr[i] > 0 && arr[i]<=arr.Length && arr[i] != arr[arr[i]-1])
                {
                    int otherIndex = arr[i] - 1;

                    int temp = arr[otherIndex];
                    arr[otherIndex] = arr[i];
                    arr[i] = temp;
                }
                else { i++; }
            }
            //foreach(var ele in arr)
            //    Console.WriteLine(ele);
            for (i=0;i<arr.Length;i++)
            {
                if (arr[i]!=i+1)
                {
                    Console.WriteLine("Missing first Positive value is: {0}", i + 1);
                    break;
                }
            }
            return arr.Length + 1;

        }
            static void Main(string[] args)
            {
                int[] arr = { -2,11,1,-3,2,10,4 };
                int[] arr2 = { -2, -11, -1, -3, -2, -10, -4 };
                int[] arr3 = { 12, 11, 13, 23, 22, 10, 4 };
                int[] arr4 = { 1, 2, 3, 4, 5 };
                Program program = new Program();
                program.FirstMissingPositiveNumberInGivenArray(arr);
                program.FirstMissingPositiveNumberInGivenArray(arr2);
                program.FirstMissingPositiveNumberInGivenArray(arr3);
                Console.WriteLine(program.FirstMissingPositiveNumberInGivenArray(arr4)); 
            }
    }
}
