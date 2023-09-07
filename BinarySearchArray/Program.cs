using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[5] { 12, 34, 45, 57, 76 };
            Program obj = new Program();
            var result = obj.SearchIndex(arr1, 17, 0, arr1.Length);
            if(result==-1)
                Console.WriteLine("Ele is not in array");
            else
            Console.WriteLine(result);
        }
        public int SearchIndex(int[] arr1, int val, int start, int end)
        {
            if (arr1.Length == 0 || start > end)
                return -1;
            int mid = (start + end) / 2;
            if (val == arr1[mid])
                return mid;
            if (val < arr1[mid])
                return SearchIndex(arr1, val, start, mid - 1);
            else 
                return SearchIndex(arr1, val, mid+1, end);
        }
    }
}
