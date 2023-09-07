using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstOccuranceOfaValueIfAdjacentEleDiffereByValue1
{
    internal class Program
    {
        public int FindValueUsingBruteForce(int[] arr, int ele)
        {
            for(int i=0;i<arr.Length;i++)
            {
                if (arr[i]== ele)
                {
                    Console.WriteLine("ele{0} fount at index{1}", ele, i);
                    return i;
                }
            }  

            return -1;
        }

        public void BestApproach(int[] arr, int ele)
        {
            int start = 0;
            while(start<=arr.Length)
            {
                if (arr[start]==ele)
                {
                    Console.WriteLine("ele{0} fount at index{1}\n\n", ele, start);
                    break;
                }
                int diff = Math.Abs(ele - arr[start]);
                start = start+diff;
            }
        }
        static void Main(string[] args)
        {
            int[] arr = new int[7] { 7,6,7,6,5,4,3};
            int[] arr2 = new int[9] { 1, 2, 1, 0, 1, 2, 3, 4, 3 };
            Program obj = new Program();
            //obj.FindValueUsingBruteForce(arr,5);
            obj.BestApproach(arr,5);
            obj.BestApproach(arr2, 3);
        }
    }
}
