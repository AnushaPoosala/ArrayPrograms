using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35SquareArrayOfNumbersArrayIsSortedBeforeAndafterSquaring
{
    internal class Program
    {
        public int[] SqaureofaSortedArrayStoringOutputAnotherArr(int[] arr,int[] outputArr)
        {
            int start=0; int end=arr.Length-1;int position = end;
            

            while(start<=end)
            {
                if ((arr[start] * arr[start])> (arr[end] * arr[end]))
                {
                    outputArr[position--] = arr[start]*arr[start];
                    start++;
                }
                else if(((arr[start] * arr[start]) <= (arr[end] * arr[end])))
                {
                    outputArr[position--] = arr[end] * arr[end];
                    end--;
                }
            }
            return outputArr;
        }
        //public int[] SqaureofaSortedArrayUsingSameArrayforOutput(int[] arr)
        //{
        //    int start = 0; int end = arr.Length - 1; 

        //    while (start <= end)
        //    {
        //        if ((arr[start] * arr[start]) >= (arr[end] * arr[end]))
        //        {
        //            var temp = arr[start];
        //            arr[start] = arr[end];
        //            arr[end] = temp;
        //        }
        //        arr[end] = arr[end] * arr[end];
        //        end--;
        //    }
        //    return arr;
        //}

        static void Main(string[] args)
        {
            int[] arr = new int[] { 7, -4, 2, 3, 11 };
            int[] outputArr = new int[arr.Length];

            Program program = new Program();
            program.SqaureofaSortedArrayStoringOutputAnotherArr(arr, outputArr);

            foreach (var ele in outputArr)
                Console.WriteLine(ele);

            //program.SqaureofaSortedArrayUsingSameArrayforOutput(arr);

            //foreach (var ele in arr)
            //    Console.WriteLine(ele);


        }
    }
}
