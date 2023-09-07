using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[5] { 5, 3, 8, 4, 6 };
            Program obj = new Program();
            obj.Print(arr1);

            obj.InsertionSort(arr1);
            obj.Print(arr1);
        }
        public void InsertionSort(int[] arr1)
        {
            if (arr1.Length == 0 || arr1.Length == 1) { return; }

            for (var i = 1; i < arr1.Length; i++)
            {
                var key = arr1[i];
                int j;
                for(j=i-1;j >= 0 && arr1[j]>key; j--) 
                {
                    arr1[j + 1] = arr1[j];
                }
                arr1[j+1]=key;
            }
        }
        public void Print(int[] arr)
        {
            for (var i = 0; i < arr.Length; i++)
                Console.WriteLine(arr[i]);
            Console.WriteLine();
        }

    }
}
