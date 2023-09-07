using System;
using System.Collections.Generic;

class ArrayImpl
{
    /*
     * It'll return intersection of two sorted array
     */
    public void IntersectionOfTwoSortedArray(int[] arr1, int[] arr2, List<int> finalList)
    {
        int i = 0;
        int j = 0;

        while(i < arr1.Length && j < arr2.Length) 
        {
            while (i < arr1.Length - 1 && arr1[i] == arr1[i + 1])
                i++;
            while (j < arr2.Length - 1 && arr2[j] == arr2[j + 1])
                j++;
            
           if(arr1[i] <arr2[j])
            {
                i++;
            }

            else if (arr1[i] > arr2[j])
            {
                j++;
            }
            else if (arr1[i] == arr2[j])
            {
                finalList.Add(arr1[i]);
                i++; j++;
            }
        }
        while (i < arr1.Length )
        {
            if (finalList.Contains(arr1[i])) { i++; }
            else break;
        }
        while (j < arr2.Length)
        {
            if (finalList.Contains(arr2[j])) { j++; }
            else { break; }
        }

    }
}

public class ArrayApp
{
    public static void Main(string[] args)
    {
        ArrayImpl a = new ArrayImpl();
        int[] arr1 = { 2, 2, 3, 4, 4, 4, 7, 8 };
        int[] arr2 = { 1, 2, 2, 2, 4, 6, 6, 6, 7, 8, 10 };
        List<int> finalUnion = new List<int>();

        a.IntersectionOfTwoSortedArray(arr1, arr2, finalUnion);
        foreach(var ele in finalUnion)
            Console.WriteLine(ele);
    }
}
