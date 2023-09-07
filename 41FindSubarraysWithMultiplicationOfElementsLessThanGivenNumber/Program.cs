using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41FindSubarraysWithMultiplicationOfElementsLessThanGivenNumber
{
    internal class Program
    {
        public List<List<int>> SubarraysWithMultiplicationOfElementsLessThanGivenNumber(int[] arr, int number)
        { 
            List<List<int>> solution=new List<List<int>>();
            int multiplicationValue = 1;
            int start = 0;

            for (int i=0;i<arr.Length;i++)
            {
                multiplicationValue = multiplicationValue * arr[i];

                while(multiplicationValue>=number)
                {
                    multiplicationValue = multiplicationValue / arr[start];
                    start++;
                }

                List<int> list = new List<int>();
                for (int j=i;j>=start;j--)
                {
                    list.Insert(0, arr[j]);
                    solution.Add(new List<int>(list));
                }
                
                
            }
            return solution;
        }
        static void Main(string[] args)
        {
            int[] arr = new int[] { 4, 2, 5, 3, 6 };
            List<List<int>> result= new List<List<int>>();

            Program program = new Program();
            result = program.SubarraysWithMultiplicationOfElementsLessThanGivenNumber(arr, 45);

            foreach(List<int> list in result)
            {
                Console.WriteLine(string.Join(",", list));
            }
        }
    }
}
