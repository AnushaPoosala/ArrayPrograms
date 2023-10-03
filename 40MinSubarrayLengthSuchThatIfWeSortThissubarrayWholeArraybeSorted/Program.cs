using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40MinSubarrayLengthSuchThatIfWeSortThissubarrayWholeArraybeSorted
{
    internal class Program
    {
        static int GetMinSubarrayLengthForSorting(int[] arr)
        {

            if(arr.Length==0 || arr.Length==1)
                return -1;
            int start = 0; int end = arr.Length - 1;
            int min = int.MaxValue;
            int max=int.MinValue;

            while (arr[start] < arr.Length && arr[start] < arr[start + 1])
            {
                start++;
            }
            if (start == arr.Length - 1)
                return 0;
            while (arr[end] >= 0 && arr[end] > arr[end - 1])
            {
                end--;
            }

            for (int i = start ; i <=end; i++)
            {
                min = Math.Min(min, arr[i]);
                max = Math.Max(max, arr[i]);
            }

            while (start >= 0 && arr[start] > min)
                start--;
            while (end <= arr.Length - 1 && arr[end] < max)
                end++;

            return end - start - 1;
            
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 5, 3, 0, 22, 13, 8, 15, 18 };

            Console.WriteLine(Program.GetMinSubarrayLengthForSorting(arr));
        }
    }
}
