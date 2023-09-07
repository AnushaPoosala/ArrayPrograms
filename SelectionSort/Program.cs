
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[5] { 5, 3, 8, 4, 6 };
            Program obj = new Program();
            obj.Print(arr1);

            obj.SelectionSort(arr1);
            obj.Print(arr1);
        }
        public void SelectionSort(int[] arr1)
        {
            if (arr1.Length == 0 || arr1.Length == 1) { return; }

            for (var i = 0; i < arr1.Length; i++)
            {
                var minIndex = i;
                for (var j = i + 1; j < arr1.Length; j++)
                {
                    if (arr1[minIndex] > arr1[j])
                        minIndex = j;
                }
                if (minIndex != i)
                {
                    int temp = arr1[minIndex];
                    arr1[minIndex] = arr1[i];
                    arr1[i] = temp ;
                }
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
