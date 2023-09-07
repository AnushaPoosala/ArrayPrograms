using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36FindAllTripletsForGivenSum
{
    internal class Program
    {
        public List<List<int>> TripletsForGivenSum(int[] arr, int targetSum)
        {
            List <List<int>> tripletsList=new List<List<int>>();
            Array.Sort(arr);
            
            for(int i=0;i<arr.Length-2;i++)
            {
                int start = i + 1; int end=arr.Length-1;
                int sum = targetSum - arr[i];
                while(start<end)
                {
                    if (sum == arr[start] + arr[end])
                    {
                        tripletsList.Add(new List<int> { arr[start],arr[end],arr[i]});
                        start++; end--;
                    }
                    else if (sum < (arr[start] + arr[end]))
                        end--;
                    else if(sum > (arr[start] + arr[end]))
                        start++;
                }
            }

            return tripletsList;
        }
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, -3, 4, -2, -1 };
            Program prog = new Program();

            List<List<int>> result=prog.TripletsForGivenSum(arr, 1);

            foreach(List<int> triplet in result) 
            {
                Console.WriteLine(string.Join(", ", triplet));
            }
            
        }
    }
}
