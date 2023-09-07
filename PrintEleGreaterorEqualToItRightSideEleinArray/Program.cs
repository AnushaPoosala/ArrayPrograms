using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquilibriumPointinArray
{
    internal class Program
    {
        public void Leaders(int[] arr)
        {
            int max=arr[arr.Length-1];
            Console.WriteLine(arr[arr.Length-1]);
            for (int i = arr.Length-2; i >=0; i--)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                    Console.WriteLine(max);
                }
                   
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("array ele are {0}",arr[i]);
            }
        }
        static void Main(string[] args)
        {
            int[] arr = new int[6] { 14,15,8,9,5,2 };
            Program obj = new Program();
            obj.Leaders(arr);
        }
    }
}
