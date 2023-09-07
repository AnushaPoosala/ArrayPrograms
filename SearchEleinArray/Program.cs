using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertEleintoArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var obj = new Program();
            var arr1 = new int[5] { 36, 24, 32, 78, 1 };
            var result = obj.Search(arr1, 878);
            if (result == -1)
                Console.WriteLine("ele is not in array");
            Console.WriteLine(result);
        }
        public int Search(int[] arr1, int value)
        {
            if (arr1.Length == 0) return -1;
            for (var i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] == value)
                {
                    return i;
                }

            }
            return -1;
        }
    }
}
