using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38FindTripletswithSumSmallerthanTargetSum
{
    internal class Program
    {
        public int TripletswithSumSmallerthanTargetSum(int[] arr,int targetSum)
        {
            List<List<int>> listTriplet = new List<List<int>>();
            Array.Sort(arr);
            int tripletCount=0;

            for(int i=0;i<arr.Length-2;i++)
            {
                int start = i+1;
                int end = arr.Length-1;
                int sum = targetSum - arr[i];

                while(start<end)
                {
                    int t = arr[start] + arr[end];

                    if (t< sum)
                    {
                        tripletCount= tripletCount+(end-start);
                        start++;
                    }
                    else
                    {
                        end--;
                    }

                }
            }

            return tripletCount;
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, -3, 4, -2 };
            Program program=new Program();

            Console.WriteLine(program.TripletswithSumSmallerthanTargetSum(arr, 1)); 
           
        }
    }
}
