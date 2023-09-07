using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _49ReverseArrayElements
{
    internal class Program
    {

        public void ReverseArrayUsingRecursion(int[] arr,int start,int end)
        {
            if(start<=end)
            {
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                ReverseArrayUsingRecursion(arr, start+1, end-1);
            }

           
        }
        public void ReverseArray(int[] arr)
        {
         
            for(int i=0;i<arr.Length/2; i++)
            {
                int otherIndex = arr.Length - 1 - i;

                int temp = arr[otherIndex];
                arr[otherIndex]=arr[i];
                arr[i]= temp;
            }
            foreach(var ele in arr)
                Console.WriteLine(ele);
        }
        static void Main(string[] args)
        {
            int[] arr = { 1,2, 3, 4, 5, 5 };
            int[] arr2 = { 2, 3, 4, 5, 5 ,};
            Program program = new Program();
            //program.ReverseArray(arr);
            program.ReverseArrayUsingRecursion(arr,0,arr.Length-1);

            foreach (var ele in arr)
                Console.WriteLine(ele);
           Array.Reverse(arr2);
            Console.WriteLine("After again reversing");
            foreach (var ele in arr2)
                Console.WriteLine(ele);
        }
    }
}
