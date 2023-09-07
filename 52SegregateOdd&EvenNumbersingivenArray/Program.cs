using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _52SegregateOdd_EvenNumbersingivenArray
{
    internal class Program
    {
        public void SegregateOdd_EvenNumbers(int[] arr)
        {
            int start = 0;int end= arr.Length-1;
            while(start<end)
            {
                while (arr[start]%2==0 && start<end)
                  start++;
                while (arr[start] % 2 != 0 && end < start)
                    end--;
                if(start<end)
                {
                    int temp = arr[start]; 
                    arr[start] = arr[end]; 
                    arr[end] = temp; 
                    start++; end--;
                }
            }
        }
        static void Main(string[] args)
        {
            int[] arr = {2,4,1,7,2,4,5,8,10 };
            int[] arr2 = { -2, -11, -1, -3, -2, -10, -4 };
            int[] arr3 = { 12, 11, 13, 23, 22, 10, 4 };
            int[] arr4 = { 1, 2, 3, 4, 5 };
            Program program = new Program();
            program.SegregateOdd_EvenNumbers(arr);
            
            foreach(var ele in arr)
                Console.WriteLine(ele);
        }
    }
}
