using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMissingNoInUnsortedArray1ton
{
    internal class Program
    {
        public void FindMissingSerialNum(int[] arr, int sum)
        {
           for(int i=0; i<arr.Length;i++)
                sum = sum - arr[i];
            Console.WriteLine(sum);
        }
        static void Main(string[] args)
        {
            int[] arr = new int[5] { 1, 2, 4, 5, 6 };
            int n=arr.Length+1;
            int sum = (n)*(n + 1) / 2;
            Program obj = new Program();
            obj.FindMissingSerialNum(arr,sum);
        }
    }
}
