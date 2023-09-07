using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unionof2SortedArrays
{
    internal class Program
    {
        public void Union(int[] arr, int[] arr2,List<int> list)
        {
            int i, j;
            i = j  = 0;
            while(i<arr.Length && j<arr2.Length)
            {
                while ((i < arr.Length - 1) && (arr[i] == arr[i + 1]))
                    i++;
                while ((j < arr2.Length - 1) && (arr2[j] == arr2[j + 1]))
                    j++;
                if (arr[i] <arr2[j])
                    list.Add(arr[i++]);
                else if (arr2[j] < arr[i])
                    list.Add(arr2[j++]);
                else 
                {
                    list.Add(arr[i]);
                    i++;
                    j++;
                }
            }
            while (i<arr.Length)
            {
                if ((i < arr.Length - 1) && (arr[i] == arr[i + 1]))
                    i++;
                else
                    list.Add(arr[i++]);
            }
                
            while (j<arr2.Length)
            {
                if ((j < arr2.Length - 1) && (arr2[j] == arr2[j + 1]))
                    j++;
                else
                    list.Add(arr2[j++]);
            }
          

        }
        static void Main(string[] args)
        {
            int[] arr = new int[] { 2, 2, 3, 4, 4, 4, 7, 8 };
            int[] arr2 = new int[] { 1, 2, 2, 2, 4, 6, 6, 6, 7, 8, 10 };
            List<int> list = new List<int>();
            Program obj = new Program();
            obj.Union(arr,arr2,list);
            foreach (var item in list)
                Console.WriteLine(item);
        }
    }
}
