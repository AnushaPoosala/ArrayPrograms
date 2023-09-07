
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
            int[] arr1 = new int[5] { 5,3,8,4,6 };
            Program obj=new Program();
            obj.Print(arr1);

            obj.BubbleSort(arr1);
            obj.Print(arr1);
        }
        public void BubbleSort(int[] arr1)
        {
            if(arr1.Length==0|| arr1.Length == 1) { return; }
            for(var i=0;i<arr1.Length;i++)
                for(var j=0;j<arr1.Length-1-i;j++)
                    if (arr1[j] > arr1[j+1])
                    {
                        var ele = arr1[j];
                        arr1[j] = arr1[j+1]; 
                        arr1[j+1] = ele;
                    }
        }
        public void Print(int[] arr) 
        {
            for(var i=0;i<arr.Length; i++)
                Console.WriteLine(arr[i]);
            Console.WriteLine();
        }
        
    }
}
