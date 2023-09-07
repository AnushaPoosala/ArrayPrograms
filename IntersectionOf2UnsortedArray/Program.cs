using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntersectionOf2UnsortedArray
{
    internal class Program
    {
        public void IntersectionOfUnsorted(int[] arr1, int[] arr2, HashSet<int> set, HashSet<int> finalSet)
        {
            int i = 0;int j = 0;
            while(i<arr1.Length)
                set.Add(arr1[i++]);
            while(j<arr2.Length)
            {
                if (set.Contains(arr2[j]))
                {
                    finalSet.Add(arr2[j]);
                }
                j++;
            }
        }
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 2, 2, 3, 4, 4, 4, 7, 8 };
            int[] arr2 = new int[] { 1, 2, 2, 2, 4, 6, 6, 6, 7, 8, 10 };
            HashSet<int> set = new HashSet<int>();
            HashSet<int> finalSet = new HashSet<int>();
            Program obj = new Program();
            obj.IntersectionOfUnsorted(arr1, arr2, set,finalSet);
            foreach (var item in finalSet)
                Console.WriteLine(item);
        }
    }
}
