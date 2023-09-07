using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArrayOf0s1s2sDutchNationalFlagProblem
{
    internal class Program
    {
        public void DutchNationalFlag(int[] arr)
        {
            int low, mid, high;
            low = mid = 0; high = arr.Length - 1;
            while(mid<=high)
            {
                switch(arr[mid])
                {
                    case 0:
                        var temp = arr[mid];
                        arr[mid] = arr[low];
                        arr[low] = temp;
                        mid++;
                        low++;
                        break;
                    case 1:
                        mid++;
                        break;
                    case 2:
                        var temp2 = arr[mid];
                        arr[mid] = arr[high];
                        arr[high] = temp2;
                        high--;
                        break;

                }

            }
            foreach(var ele in arr)
                Console.WriteLine(ele);
        }

        static void Main(string[] args)
        {
            int[] arr = new int[9] { 2, 1, 1, 0, 2, 2, 1, 0, 2 };
            Program obj=new Program();
            obj.DutchNationalFlag(arr);
        }
    }
}
