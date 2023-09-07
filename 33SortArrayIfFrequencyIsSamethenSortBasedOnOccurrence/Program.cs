using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33SortArrayIfFrequencyIsSamethenSortBasedOnOccurrence
{
    internal class Program
    {
        public List<int> SortBasedOnFrequencyIfSameThenBasedOnOccurence(List<int> listArray)
        { 
            Dictionary<int,int> dictionary=new Dictionary<int,int>();

            foreach(var ele in listArray)
            {
                if (dictionary.ContainsKey(ele))
                    dictionary[ele]++;
                else
                    dictionary[ele] = 1;
            }
            foreach(var ele in dictionary) Console.WriteLine(ele);

            listArray.Sort((n1, n2) => 
            {
                var frequency1 = dictionary[n1];
                var frequency2 = dictionary[n2];
                if (frequency1 != frequency2)
                    return frequency2 - frequency1;
                else
                    return listArray.IndexOf(n1) - listArray.IndexOf(n2);
            });
            return listArray; 
        }

        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 10,10,10,11,11,11,9,9,9,9,7,5,6 };
            int[] arr2 = new int[] { -4, -2, -5, -3, -1, -8 };
            int[] arr3 = new int[] { -3, 2, -7, 6, -2, 4, -8, 5 };
            Program obj = new Program();
            List<int> listArray=arr1.ToList();
            obj.SortBasedOnFrequencyIfSameThenBasedOnOccurence(listArray);

            foreach(var ele in listArray) Console.WriteLine(ele);
        }
    }
}
