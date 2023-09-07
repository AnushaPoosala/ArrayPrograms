using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubArrayWhoseSumEqltoGivenSum
{
    internal class Program
    {
        //https://thecodingsimplified.com/find-sub-array-whose-sum-is-equal-to-given-sum/
        public void PositiveNegativeEleSubArray(int[] arr2, int sum)
        {
            int end = 0;int totalSumTillNow = 0;
            Dictionary<int, int> dic = new Dictionary<int, int>();
            if (arr2.Length == 0)
                Console.WriteLine("No ele in array, so no sub array exists");
            while (end < arr2.Length)
            {
                totalSumTillNow = totalSumTillNow + arr2[end];
                if(totalSumTillNow==sum)
                {
                    Console.WriteLine("subarray exists at start{0} end{1}", 0, end);
                    break;
                }
                int windowSum = totalSumTillNow - sum;
                if(dic.ContainsKey(windowSum))
                {
                    int start = dic[windowSum];
                    Console.WriteLine("subarray exists at start{0} end{1}", start+1, end);
                    break;
                }
                dic[totalSumTillNow] = end++;
            }


        }
        public void PositiveEleSubArray(int[] arr1,int sum)
        {
            int start = 0;int end = 0; int windowSum = 0; 
            if(arr1.Length==0)
                Console.WriteLine("No ele in array, so no sub array exists");
            while (end<arr1.Length)
            {
                windowSum = windowSum + arr1[end];
                if(windowSum==sum)
                {
                    Console.WriteLine("subarray exists at start{0} end{1}", start, end);
                    break;
                }
                while(windowSum>sum && start<=end)
                {
                    windowSum = windowSum - arr1[start++];
                    if (windowSum == sum)
                    {
                        Console.WriteLine("subarray exists at start{0} end{1}", start, end);
                        break;
                    }
                }
                end++;
            }
        }
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 4, 1, 3, 12, 7, 8 };
            int[] arr2 = new int[] { 4, 2, -5, 3, 1, 8 };
            Program obj = new Program();
            //obj.PositiveEleSubArray(arr1,15);
            obj.PositiveNegativeEleSubArray(arr2,-1);
        }
    }
}
