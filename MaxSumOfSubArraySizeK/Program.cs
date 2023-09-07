using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSumOfSubArraySizeK
{
    internal class Program
    {
        public int MaxSumSubArraySizeK(int[] arr, int k)
        {
            int maxSum;int sum = 0;

            if (arr.Length == 0 || arr.Length < k || k == 0)
                return -1;
            for (int i = 0; i < k; i++)
                sum = sum + arr[i];
            maxSum = sum;
            int start = 0;
            for(int j=k;j<arr.Length;j++)
            {
                sum = sum + arr[j] - arr[start++];
                maxSum = (sum > maxSum) ? sum : maxSum;
            }
            return maxSum;
        }
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 44, 100, 103, 112, 7, 8 };
            
            Program obj = new Program();
            Console.WriteLine(obj.MaxSumSubArraySizeK(arr1, 3));
        }
    }
}
