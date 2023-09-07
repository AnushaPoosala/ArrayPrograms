using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37FindAllQuadrupleforGivenSum
{
    internal class Program
    {
        public List<List<int>> QuadrupleForGivenSum(int[] arr,int targetSum)
        {
           List< List<int>> listQuadruple=new List<List<int>>();
           Array.Sort(arr);

            for(int i=0;i<arr.Length-3;i++)
            {
                for(int j=i+1;j<arr.Length-2;j++)
                {
                    int start = j + 1;
                    int end = arr.Length - 1;
                    int sum = targetSum - (arr[i]+arr[j]);

                    while (start<end)
                    {
                        if (sum == arr[start] + arr[end])
                        {
                            listQuadruple.Add(new List<int> { arr[i], arr[j], arr[start], arr[end] });
                            start++;end--;
                        }
                        else if (sum < arr[start] + arr[end])
                            end--;
                        else
                            start++;
                    }
                }
            }
            return listQuadruple;
        }
        static void Main(string[] args)
        {

            int[] arr = { 1, 2, -3, 4, -2, -1,3 };
            Program program= new Program();

            List<List<int>> result = program.QuadrupleForGivenSum(arr, 3);

            foreach(List<int> quadraple in result)
            {
                Console.WriteLine(string.Join(" , ",quadraple));
            }
        }
    }
}
