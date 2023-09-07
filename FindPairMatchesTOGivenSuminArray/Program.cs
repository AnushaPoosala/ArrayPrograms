using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindPairMatchesTOGivenSuminArray
{
    internal class Program
    {
        public void FindPairUsingBruteForce(int[] arr,int sum)
        {
            for(var i=0;i<=arr.Length-1;i++)
                for(int j=i+1;j<=arr.Length-1;j++)
                {
                    if (sum == arr[j] + arr[i])
                    {

                        Console.WriteLine("Pair of eles are {0},{1}", arr[j], arr[i]);
                        break;
                    }
                }
        }
        public void FindPairUsingSort(int[] arr, int sum)
        {
            Array.Sort(arr);
            int start = 0; int end=arr.Length-1;
            while(start<=end)
            {
               if(arr[start]+arr[end]==sum)
                {
                    Console.WriteLine("Pair of eles are {0},{1}", arr[start], arr[end]);
                    break;
                }
                else if (arr[start] + arr[end] > sum)
                    end--;
                else if (arr[start] + arr[end] < sum)
                    start++;
            }

        }
        public void FindPairUsingHashSet(int[] arr, int sum)
        {
              HashSet<int> set1 = new HashSet<int>();
            for(int i=0;i<=arr.Length-1;i++)
            {
                if (set1.Contains(sum-arr[i]))
                {
                    Console.WriteLine("pair of ele exists\n\n");
                    break;
                }
                else
                    set1.Add(arr[i]);
            }
            foreach(int ele in set1)
                Console.WriteLine(ele);
        }
        static void Main(string[] args)
        {
            int[] arr = new int[6] { 14, 15, 8, 9, 5, 2 };
            Program obj = new Program();
            //obj.FindPairUsingBruteForce(arr,10);
           // obj.FindPairUsingSort(arr, 10);
            obj.FindPairUsingHashSet(arr, 10);
        }
    }
}
