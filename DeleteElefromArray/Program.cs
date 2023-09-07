using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteElefromArray
{
    internal class Program
    {
        int count = 5;
        static void Main(string[] args)
        {
            var arr1 = new int[5] { 12, 34, 44, 6, 13 };
            var obj = new Program();
            obj.Print(arr1);
            
            obj.DeleteEnd(arr1);
            obj.Print(arr1);

            obj.DeleteAtPosition(arr1, 2);
            obj.Print(arr1);

            obj.DeleteValue(arr1, 34);
            obj.Print(arr1);
        }
        public void DeleteValue(int[] arr1, int value)
        {
            int i;
            for(i=0; i < arr1.Length;i++)
                if (arr1[i] == value)
                 break; 
            if(i== arr1.Length)
                Console.WriteLine("value not exists in the array");
            for (int j=i; j < arr1.Length-1;j++)
                arr1[j] = arr1[j+1];
            count--;
        }
        public void DeleteAtPosition(int[] arr1, int index)
        {
            if(index>arr1.Length ||  index<0)
                Console.WriteLine("Please enter valid index\n");
            for (int i=index;i<arr1.Length-1;i++)
                arr1[i] = arr1[i+1];
            count--;
        }
        public void DeleteEnd(int[] arr1)
        {
            count--;
        }
        public void Print(int[] arr1)
        {
            for (int i = 0; i < count; i++)
                Console.WriteLine(arr1[i]);
            Console.WriteLine();
        }

    }
    
}
