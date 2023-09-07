using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48LongestSubArrayWithAll1sIfAtMax_k_0sCanBeReplacedWith1s
{
    internal class Program
    {
        public int LongestSubArrayWithAll1sIfAtMax_k_0sCanBeReplacedWith1s(int[] arr, int maxZerosAllowed)
        {
            int windowLength = 0;
            
            int start = 0;int end = 0; int zerosCount = 0;

            while (end<arr.Length)
            {
                if (arr[end] == 0)
                    zerosCount++;
                
                if(zerosCount> maxZerosAllowed)
                {
                    if (arr[start] == 0)
                        zerosCount--;
                    
                    start = start + 1;
                }
                windowLength = Math.Max(end - start+1, windowLength);
                end++;
            }
            return windowLength;
        }
        static void Main(string[] args)
        {
            int[] arr = {0,1,0,1,0,1,1,1,0};
            Program program = new Program();
            Console.WriteLine(program.LongestSubArrayWithAll1sIfAtMax_k_0sCanBeReplacedWith1s(arr, 2));
        }
    }
}
