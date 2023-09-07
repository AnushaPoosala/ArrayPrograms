using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestSubArrayLengthWithGivenSum
{
    internal class Program
    {
        public int PositiveNegativeEleSubArray(int[] arr1, int sum)
        {
            int start = 0; int end = 0; int smallestSubArrayLength = int.MaxValue; int totalSumTillHere = 0; int windowSum;
            Dictionary<int,int> totalSumTillHereEnd = new Dictionary<int,int>();

            if (arr1.Length == 0)
                return -1;

           while (end < arr1.Length)
            {
                totalSumTillHere = totalSumTillHere + arr1[end];
                
                if(sum== totalSumTillHere)
                {
                    Console.WriteLine("Start index is{0} end index is :{1}", start, end);
                    smallestSubArrayLength = Math.Min(smallestSubArrayLength, end - start + 1);
                }
                windowSum = totalSumTillHere - sum;
                if(totalSumTillHereEnd.ContainsKey(windowSum))
                {
                    start = totalSumTillHereEnd[windowSum] + 1;
                    Console.WriteLine("Start index is{0} end index is :{1}", start, end);
                    smallestSubArrayLength = Math.Min(smallestSubArrayLength, end - start + 1);
                }
                totalSumTillHereEnd[totalSumTillHere] = end++;
            }
            return smallestSubArrayLength !=int.MaxValue? smallestSubArrayLength:-1;
        }
        public int PositiveEleSubArray(int[] arr2, int sum)
        {
            int start = 0;int end = 0; int smallestSubArrayLength=int.MaxValue;int windowSum = 0;

            if (arr2.Length == 0)
                return -1;

            while(end < arr2.Length)
            {
                windowSum = windowSum + arr2[end];

                if (windowSum == sum)
                {
                    Console.WriteLine("Start index is{0} end index is :{1}", start, end);
                    smallestSubArrayLength= Math.Min(smallestSubArrayLength, end - start + 1);
                }

                while (windowSum>sum && start<=end)
                {
                    windowSum = windowSum - arr2[start++];
                    if (windowSum == sum)
                    {
                        Console.WriteLine("Start index is{0} end index is :{1}",start,end);
                        smallestSubArrayLength= Math.Min(smallestSubArrayLength, end - start + 1);
                    }
                }
                end++;
            }
           return (smallestSubArrayLength!=int.MaxValue) ? smallestSubArrayLength : -1;

           // return smallestSubArrayLength != int.MaxValue ? smallestSubArrayLength : -1;
        }
       
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 3,2,5,5,3,2,10};
            int[] arr2 = new int[] { 4, 2, -5, 3, 1, 8 };
            Program obj = new Program();
            //Console.WriteLine(obj.PositiveEleSubArray(arr1, 10)); 
            Console.WriteLine(obj.PositiveNegativeEleSubArray(arr1, 10)); 
        }
    }
}
