using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestContiguousSumSubarray
{
    internal class Program
    {
        public void LargestContigiousSumSubarray(int[] arr)
        {
            var CurrentMax = arr[0];
            var MaxsoFar = arr[0];
            int i,count=0;
            for(i=1;i<arr.Length;i++) 
            {
                CurrentMax = Math.Max(CurrentMax,CurrentMax + arr[i]);
                MaxsoFar= Math.Max(MaxsoFar,CurrentMax);
                if(CurrentMax == MaxsoFar) { count++; }
            }
            Console.WriteLine("Maximum sum of sub array is:{0}",MaxsoFar);
        }
        static void Main(string[] args)
        {
            Program obj= new Program();
            obj.LargestContigiousSumSubarray(new int[8] { -3, -4, 4, -1, -2, 1, 5, -3 });
        }
    }
}
