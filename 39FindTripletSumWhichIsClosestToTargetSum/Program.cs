using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39FindTripletSumWhichIsClosestToTargetSum
{
  
    internal class Program
    {
        public int TripletSumCloseToTargetSum(int[] arr, int targetSum)
        {
            int minDifference = int.MaxValue;
            int closestSum = int.MaxValue;

            Array.Sort(arr);

            for (int i = 0; i < arr.Length - 2; i++)
            {
                int start = i + 1; int end = arr.Length - 1;

                while (start < end)
                {
                    int tripletSum = arr[start] + arr[end] + arr[i];

                    //tripletSum<closestSum means for ex there are 2 triplets with same difference,then considering the smaller difference
                    //targetsum=1---- tripletsum=-1, difference=2 [-3,-2,4]-------tripletsum=3, difference=2 [-3,2,4]
                    //we compare -1 and 3, we will take -1


                    if (Math.Abs(targetSum - tripletSum) <= minDifference && tripletSum < closestSum)
                    {
                        minDifference = targetSum - tripletSum;
                        closestSum = tripletSum;
                    }

                    if (tripletSum == targetSum)
                    {
                        return tripletSum;
                    }
                    else if (tripletSum < targetSum)
                        start++;
                    else
                        end--;

                }
            }
            return closestSum;
        }
        static void Main(string[] args)
        {
            int[] arr = { 2, -3, 4, -2 };
            Program program= new Program();
            Console.WriteLine(program.TripletSumCloseToTargetSum(arr, 1));
        }
    }
}
