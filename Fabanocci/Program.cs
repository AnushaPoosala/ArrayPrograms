using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabanocci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program obj=new Program();
            Console.WriteLine(obj.Fab(5));  
        }
        public int Fab(int n)
        {
            if (n <= 0)
                return -1;
            else if (n == 1)
                return 0;
            else if (n == 2) return 1;
            else
                return Fab(n - 1) + Fab(n - 2);
        }

    }
}
