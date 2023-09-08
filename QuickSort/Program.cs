using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace QuickSort
{
    internal class Program
    {
        public int Partion(int[] arr,int start, int end)
        {
            int pivot = start;
            int i = start;
            int j = end;
            while(i<j)
            {
                while(arr[i] <= arr[pivot] && i<end)
                    i++;
                while(arr[j] > arr[pivot] && j>=0)
                    j--;
                if(i<j)
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
            int temp2 = arr[pivot];
            arr[pivot] = arr[j];
            arr[j] = temp2;
            return j;
        }
        public void QuickSort(int[] arr, int start, int end)
        {
            if(start<end)
            {
                int j = Partion(arr, start, end);
                QuickSort(arr, start, j-1);
                QuickSort(arr, j + 1, end);
            }
        }
        static void Main(string[] args)
        {
            int[] arr = new int[5] { 5, 6, 1, 2, 14 };
            foreach(var ele in arr) { Console.WriteLine(ele); }
            Console.WriteLine();
            Program obj = new Program();
            obj.QuickSort(arr, 0, arr.Length - 1);
            foreach (var ele in arr) { Console.WriteLine(ele); }
        }
    }
}
