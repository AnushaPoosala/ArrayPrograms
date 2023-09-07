using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main()
        {
            var array1 = new int[] { 1, 3 };
            var array2 = new int[] { 2 };

            var temp = array1.Concat(array2).ToArray();

            Array.Sort(temp);

            //var median = temp[0] + temp[temp.Length - 1] / 2;
            var number = temp.Length;

            if (number % 2 != 0)
            {
                var middle = temp.Length-1 / 2;
                Console.WriteLine( temp[middle]);
                
            }
            else
            {
                var middle = temp.Length - 1 / 2;
                Console.WriteLine((temp[middle] + temp[middle+1])/2);
            }
                

            

        }




    }
}
