using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _44FindMissingNumberIn1ton_1NumbersRange
{
    internal class Program
    {
        //Arrays 44: https://www.youtube.com/watch?v=Ye87Z472M3k&list=PLt4nG7RVVk1huDVqwMojFsxlz9AXYmKKo&index=44
        //Arrays 11: https://www.youtube.com/watch?v=9al_CQEksVA&list=PLt4nG7RVVk1huDVqwMojFsxlz9AXYmKKo&index=12

        public int FindMissingNumberIn1ton_1NumbersRange(int[] arr)
        {
            int missingNum=0;

            int i = 0;

            while(i<arr.Length)
            {
                if (arr[i]!=i+1 && arr[i]<=arr.Length)
                {
                    int positionIndex = arr[i] - 1;

                    int temp = arr[i];
                    arr[i] = arr[positionIndex];
                    arr[positionIndex] = temp;
                }
                else
                    i++;
            }
            foreach(var ele in arr) 
                Console.WriteLine(ele);

            for(int j=0;j<arr.Length;j++)
            {
                if (arr[j] != j + 1)
                    return j + 1;
            }
           
            return missingNum;
        }
        static void Main(string[] args)
        {
            int[] arr = new int[] { 4,3,5,2,6,7 };
            Program program = new Program();
            Console.WriteLine("Missing number is: {0}",program.FindMissingNumberIn1ton_1NumbersRange(arr));
        }
    }
}
