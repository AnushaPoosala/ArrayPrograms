using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstRepeatingValueinArray
{
    internal class Program
    {
        public int FirstReapeat(int[] arr)
        {
            HashSet<int> set=new HashSet<int>();
            for(int i=0; i<arr.Length;i++)
            {
                if (set.Contains(arr[i]))
                {
                    Console.WriteLine("First repeating val is {0}", arr[i]);
                    return 1;
                }
                set.Add(arr[i]);   
            }
            return -1;
        }

        static void Main(string[] args)
        {
            int[] arr = new int[7] { 70, 60, 70, 60, 50, 40, 30 };
            int[] arr2 = new int[9] { 10, 30, 90, 20, 40, 20, 40, 60, 80 };
            Program obj = new Program();
            obj.FirstReapeat(arr);
            obj.FirstReapeat(arr2);
        }
    }
}
