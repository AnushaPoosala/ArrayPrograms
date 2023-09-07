using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveAllDuplicatesFromSortedArray
{
    internal class Program
    {
        public int[] SortArray(int[] arr)
        {
            int start=1;

            for(var i=1;i<arr.Length;i++)
            {
                if (arr[i] != arr[i - 1])
                {
                    arr[start++] = arr[i];
                }
            }
            Console.WriteLine("Number of Unique values in araay is:{0}", start);
            return arr;
        }
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 1, 4, 4, 4, 5, 6, 7, 8, 8, 9 };

            foreach (var ele in arr1) Console.WriteLine(ele);
            Program obj = new Program();
            obj.SortArray(arr1);

            Console.WriteLine("\nafter Sorting:");
            foreach (var ele in arr1) Console.WriteLine(ele);

        }
    }
}
