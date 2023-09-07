using System;

namespace QuickSort
{
    internal class Program
    {
        public int Partition(int[] arr, int start, int end)
        {
            int pivot = start;
            int i = pivot + 1;
            int j = end;
            while (i <= j) // Corrected loop condition
            {
                while (i <= j && arr[i] <= arr[pivot]) // Use <= instead of <
                    i++;
                while (i <= j && arr[j] >= arr[pivot]) // Use >= instead of >
                    j--;
                if (i < j)
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
            if (start < end)
            {
                int j = Partition(arr, start, end);
                QuickSort(arr, start, j - 1);
                QuickSort(arr, j + 1, end);
            }
        }

        static void Main(string[] args)
        {
            int[] arr = new int[5] { 5, 6, 1, 2, 14 };
            foreach (var ele in arr) { Console.WriteLine(ele); }
            Console.WriteLine();
            Program obj = new Program();
            obj.QuickSort(arr, 0, arr.Length - 1);
            foreach (var ele in arr) { Console.WriteLine(ele); }
        }
    }
}