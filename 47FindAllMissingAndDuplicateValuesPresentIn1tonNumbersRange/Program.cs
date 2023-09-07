using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _47FindAllMissingAndDuplicateValuesPresentIn1tonNumbersRange
{
    internal class Program
    {
        public List<List<int>> FindAllMissingAndDuplicateValuesPresentIn1tonNumbersRange(int[] arr)
        {
            int i = 0;
            while(i<arr.Length)
            {
                if (arr[i] != arr[arr[i]-1])
                {
                    int otherIndex = arr[i] - 1;

                    int temp = arr[i];
                    arr[i] = arr[otherIndex];
                    arr[otherIndex]  = temp;
                }
                else { i++; }
            }
            foreach(var ele in arr) Console.WriteLine(ele);

            List<int> missingVal= new List<int>();
            HashSet<int> missingValues = new HashSet<int>();

            List<int> duplicateVal= new List<int>();
            for(i=0;i<arr.Length;i++)
            {
                if (arr[i] != i+1)
                {
                    missingVal.Add(i + 1);
                    duplicateVal.Add(arr[i]);
                }
            }
            List<List<int>> resultList= new List<List<int>>();
            resultList.Add(missingVal);
            resultList.Add(duplicateVal);
            return resultList;
        }
        static void Main(string[] args)
        {
            int[] arr = { 2, 3, 2, 5, 5,3 };
            Program program = new Program();
            List<List<int>> result=program.FindAllMissingAndDuplicateValuesPresentIn1tonNumbersRange(arr);

            foreach(List<int> list in result )
                Console.WriteLine(string.Join(",",list));
        }
    }
}
