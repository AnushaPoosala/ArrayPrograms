using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29FindsubarraywithmaximumsumKadaneAlgo10
{
    internal class Program
    {
        public int KadaneAlgo(int[] arr)
        {
            int maxSum = int.MinValue;
            int sum = 0;
            bool isAnyPositiveNoExists = false;
            int maxElement=int.MinValue;

            for(int i=0;i<arr.Length; i++)
            {
                if (arr[i] >= 0)
                    isAnyPositiveNoExists = true;
                maxElement = Math.Max(maxElement, arr[i]);
                sum = sum + arr[i];
                if (sum < 0)
                {
                    sum = 0;
                    continue;
                }
                maxSum = Math.Max(sum, maxSum);
            }
            return isAnyPositiveNoExists ? maxSum : maxElement;


        }
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 3, 2, 5, -5, 3, 2, 10 };
            int[] arr2 = new int[] { -4, -2, -5, -3, -1, -8 };
            int[] arr3 = new int[] { -3,2,-7,6,-2,4,-8,5};
            Program obj = new Program();
            Console.WriteLine(obj.KadaneAlgo(arr1));
            Console.WriteLine(obj.KadaneAlgo(arr2));
            Console.WriteLine(obj.KadaneAlgo(arr3));
        }
    }
}
