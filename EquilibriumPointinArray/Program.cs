using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquilibriumPointinArray
{
    internal class Program
    {
        public void Equilibrium(int[] arr)
        {
            int totalSum = 0;
            int sumSofar = 0;
            for (int i = 0; i < arr.Length;i++)
            {
                Console.WriteLine(arr[i]);
                totalSum = totalSum + arr[i];
            }
            int decSum = totalSum;
            for (int i = 0; i < arr.Length;i++)
            {
                
               decSum = decSum - arr[i];
                if (decSum == sumSofar)
                {
                    Console.WriteLine("Equilibrium point is{0}", arr[i]);
                    break;
                }
                sumSofar = sumSofar + arr[i];
               
            }

        }
        static void Main(string[] args)
        {
            int[] arr = new int[9] { -2,3, 8, 2,9,0, -1, 12,9};
            Program obj=new Program();
            obj.Equilibrium(arr);
        }
    }
}
