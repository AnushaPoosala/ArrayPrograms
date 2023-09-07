using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShufflethearraynumberShuffletheCards
{
    internal class Program
    {
        static void ShuffleArrayElements(int[] arr)
        {
            Random obj=new Random();
            
            for(var i=0;i<arr.Length;i++) 
            {
                int randomNumber = obj.Next(arr.Length);
                var temp = arr[randomNumber];
                arr[randomNumber] = arr[i];
                arr[i]= temp;
            }
            foreach(var i in arr)
                Console.WriteLine(i);
        }
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 1,2,3,4,5,6,7 };
            int[] arr2 = new int[] { -4, -2, -5, -3, -1, -8 };
            int[] arr3 = new int[] { -3, 2, -7, 6, -2, 4, -8, 5 };
            ShuffleArrayElements(arr1);
        }
    }
}
