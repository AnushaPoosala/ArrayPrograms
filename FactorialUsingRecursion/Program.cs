using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialUsingRecursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = 5;
            Program obj = new Program();
            Console.WriteLine(obj.Factorial(5));
        }
        public int Factorial(int n)
        {
            int result;
            if (n >= 1)
            {
                return result = n * Factorial(n - 1);
            }
            
            else { return 1; }

        }
    }
}
