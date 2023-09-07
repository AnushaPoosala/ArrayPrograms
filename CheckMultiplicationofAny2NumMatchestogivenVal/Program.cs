using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckMultiplicationofAny2NumMatchestogivenVal
{
    internal class Program
    {
        public bool Multiplication(int[] arr1, int val)
        {
            HashSet<int> set = new HashSet<int>();
            for(var i=0;i<arr1.Length; i++)
            {
                if (val % arr1[i] == 0 && set.Contains(val / arr1[i]))
                    return true;
                set.Add(arr1[i]);
            }
            return false;
        }
        static void Main(string[] args)
        {
            int[] arr1 = new int[] {4,1,3,12,7,8};
            Program obj = new Program();
            Console.WriteLine(obj.Multiplication(arr1, 15)); 
        }
    }
}
