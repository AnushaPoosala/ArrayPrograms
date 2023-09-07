using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43CyclicSortSortTheElementsfrom1ton
{
    internal class Program
    {
        public void CyclicSort(int[] arr)
        {
            int i = 0;
            while (i < arr.Length)
            {
                if (arr[i] != i + 1)
                {
                    int otherIndex = arr[i] - 1;

                    int temp = arr[i];
                    arr[i] = arr[otherIndex];
                    arr[otherIndex] = temp;
                }
                else
                { i++; }
            }

        }

        public void CyclicSortWhenEleAreNotFrom1toNButXtoN(int[] arr)
        {
            int min = int.MaxValue;
            int max = int.MinValue;

            for(int j=0;j<arr.Length; j++)
            {
                min=Math.Min(min, arr[j]);
                max=Math.Max(max, arr[j]);
            }

            int i = 0;
            int value = min;
            while (i < arr.Length)
            {
                if (arr[i] != value)
                {
                    int otherIndex = arr[i] - value+i;

                    int temp = arr[i];
                    arr[i] = arr[otherIndex];
                    arr[otherIndex] = temp;
                }
                else
                { 
                    i++;
                    value= value+1;
                }
            }

        }
        static void Main(string[] args)
        {
            int[] arr = { 3, 4, 6, 2, 1, 5 };
            int[] arr2 = { 13, 14, 16, 12, 15 };
            Program program = new Program();
           // program.CyclicSort(arr);
            //foreach(int i in arr) { Console.WriteLine(i); }

            program.CyclicSortWhenEleAreNotFrom1toNButXtoN(arr2);
            foreach (int i in arr2) { Console.WriteLine(i); }
        }
    }
}
