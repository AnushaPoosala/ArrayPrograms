using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32SortArrayBasedonFrequency
{
    internal class Program
    {
        public List<int> SortArrayBasedonFrequency(List<int> listofArray)
        {
            Dictionary<int,int> eleFrequencyKeyValue = new Dictionary<int,int>();

            foreach(var ele in listofArray)
            {
                if (eleFrequencyKeyValue.ContainsKey(ele) )
                    eleFrequencyKeyValue[ele]++;
                else
                    eleFrequencyKeyValue[ele] = 1;
            }

            foreach(var ele in eleFrequencyKeyValue)
                Console.WriteLine(ele);

            listofArray.Sort((n1, n2) =>
            {
                int freq1 = eleFrequencyKeyValue[n1];
                int freq2 = eleFrequencyKeyValue[n2];
                if (freq1 != freq2)
                    return freq2 - freq1;
                return n2 - n1;
            });
            return listofArray;
            
        }
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 10,7,2,10,1,10,2,3,3,3,3};
            int[] arr2 = new int[] { -4, -2, -5, -3, -1, -8 };
            int[] arr3 = new int[] { -3, 2, -7, 6, -2, 4, -8, 5 };

            List<int> listofArray=new List<int>();
            listofArray=arr1.ToList();

            Program obj = new Program();
            obj.SortArrayBasedonFrequency(listofArray);

            foreach(var ele in listofArray) { Console.WriteLine(ele); }
        }
    }
}
