using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquilibriumPointinArray
{
    internal class Program
    {
        public void Unsorted(int[] arr,int ele)
        {
            for (int i = 0; i <= (arr.Length/2); i++)
            {
                if (arr[i] != ele)
                    i++;
                else if (arr[i] == ele)
                {
                    Console.WriteLine("Ele{0} found at index{1}", ele,i);
                    break;
                }
                if (arr[arr.Length-1-i] != ele)
                    i--;
                else if (arr[arr.Length - 1 - i] == ele)
                {
                    Console.WriteLine("Ele{0} found at index{1}", ele, arr.Length - 1 - i);
                    break;
                }
            }
        }
        public void Sorted(int[] arr,int ele, int low, int high)
        {
            while(low<=high)
            {
                int mid = low + high / 2;
                if (ele < arr[mid])
                    Sorted(arr, ele, low, mid);
                else if (ele == arr[mid])
                {
                    Console.WriteLine("Ele{0} found at index{1}", ele, mid);
                    break;
                }
                else if (ele > arr[mid])
                    Sorted(arr, ele, mid + 1, high);
            }
        }
        public void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine(arr[i]);
            
        }
        static void Main(string[] args)
        {
            int[] arr = new int[9] { -1,0,1,2,3,4,5,6,7 };
            Program obj = new Program();
            obj.Sorted(arr,3,0,8);
            obj.Print(arr);
        }
    }
}
