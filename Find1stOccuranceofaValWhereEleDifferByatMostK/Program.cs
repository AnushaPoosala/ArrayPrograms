using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find1stOccuranceofaValWhereEleDifferByatMostK
{
    internal class Program
    {
        public void BestApproach(int[] arr, int Maxdiff,int val)
        {
            int start = 0;
            while (start <= arr.Length)
            {
                if (arr[start] == val)
                {
                    Console.WriteLine("ele{0} fount at index{1}\n\n", val, start);
                    break;
                }
                int diff = Math.Max(1,Math.Abs(val - arr[start])/Maxdiff);
                start =start + diff;
            }
        }
        static void Main(string[] args)
        {
            int[] arr = new int[7] { 70, 60, 70, 60, 50, 40, 30 };
            int[] arr2 = new int[9] { 10, 30, 10, 20, 40, 20, 40, 60, 80 };
            Program obj = new Program();
            //obj.FindValueUsingBruteForce(arr,5);
            obj.BestApproach(arr, 10,40);
            obj.BestApproach(arr2, 20,20);
        }
    }
}
