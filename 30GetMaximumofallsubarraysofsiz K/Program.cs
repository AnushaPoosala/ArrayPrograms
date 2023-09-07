using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30GetMaximumofallsubarraysofsiz_K
{
    internal class Program
    {
        public void MaximumOfEverySubArray(int[] arr, int subArraySize)
        {
            int i;
            LinkedList<int> doubleEndedQueue = new LinkedList<int>();     //which has first,last. we will insert from last, compares&removes from last.Uses first only to print max.

            if(subArraySize<0 || subArraySize > arr.Length || arr.Length<=0)
                Console.WriteLine("Invalid entries");

            for (i=0;i<subArraySize;i++)
            {
                while(doubleEndedQueue.Count>0 && arr[i] >= arr[doubleEndedQueue.Last.Value])
                {
                    doubleEndedQueue.RemoveLast();
                }
                doubleEndedQueue.AddLast(i);
            }

            for(;i<arr.Length;i++)
            {
                Console.WriteLine("\n{0}",arr[doubleEndedQueue.First.Value]);

                //windowsize calculation
                while(doubleEndedQueue.Count>0 && doubleEndedQueue.First.Value<=(i-subArraySize))
                {
                    doubleEndedQueue.RemoveFirst();             //in window cal we compare with peek(first) and removes the first ele
                }

                //comparing the one "i" value with remaining all ele in doubleEndedQueue
                while(doubleEndedQueue.Count>0 && arr[i] >= arr[doubleEndedQueue.Last.Value])
                {
                    doubleEndedQueue.RemoveLast();
                }
                doubleEndedQueue.AddLast(i);
            }
            Console.WriteLine("\n{0}",arr[doubleEndedQueue.First.Value]);
        }
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 3, 2, 5, -5, 3, 2, 10 };
            int[] arr2 = new int[] { -4, -2, -5, -3, -1, -8 };
            int[] arr3 = new int[] { -3, 2, -7, 6, -2, 4, -8, 5 };
            Program obj = new Program();
            foreach(var ele in arr1)
                Console.Write("{0}  ",ele);
            obj.MaximumOfEverySubArray(arr1, 4);
            Console.WriteLine();
            foreach (var ele in arr2)
                Console.Write("{0}  ", ele);
            obj.MaximumOfEverySubArray(arr2, 4);
            Console.WriteLine();
            foreach (var ele in arr3)
                Console.Write("{0}  ", ele);
            obj.MaximumOfEverySubArray(arr3, 4);


        }
    }
}
