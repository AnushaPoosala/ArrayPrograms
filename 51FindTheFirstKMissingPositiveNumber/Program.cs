﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _51FindTheFirstKMissingPositiveNumbers
{
    internal class Program
    {
        public void FirstKMissingPositiveNumbers(int[] arr,int k)
        { 
            int i = 0;
            while(i<arr.Length)
            {
                if (arr[i] > 0 && arr[i] <= arr.Length && arr[i] != arr[arr[i] - 1] )
                {
                    int otherIndex = arr[i] - 1;

                    int temp = arr[otherIndex];
                    arr[otherIndex] = arr[i];
                    arr[i] = temp;
                }
                else
                    i++;
            }
            
            List<int> missingList = new List<int>();
            HashSet<int> otherValue = new HashSet<int>();

            for(i=0; i < arr.Length && missingList.Count<k;i++)
            {
                if (arr[i]!=i+1)
                {
                    missingList.Add(i+1);
                    otherValue.Add(arr[i]);
                }
            }
            for(int j=i;missingList.Count<k;j++)
            {
                if (!otherValue.Contains(j+1))
                    missingList.Add(j+1);
            }
            Console.WriteLine("Missing Ele are:");
            foreach (var ele in missingList) Console.WriteLine(ele);
        }
        static void Main(string[] args)
        {
            int[] arr = { 1,2,3,4};
            int[] arr2 = { -2, -11, -1, -3, -2, -10, -4 };
            int[] arr3 = { 12, 11, 13, 23, 22, 10, 4 };
            int[] arr4 = { 1, 2, 3, 4, 5 };
            Program program = new Program();
            program.FirstKMissingPositiveNumbers(arr,7);
           // program.FirstKMissingPositiveNumbers(arr2,3);
            //program.FirstKMissingPositiveNumbers(arr3,1);
            
        }
    }
}
