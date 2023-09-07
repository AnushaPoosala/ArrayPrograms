using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace ArrayAppNamespace
{
    public class ArrayApp
    {
        public void Mergesort(int[] arr,int start, int end)
        {
            if (start < end)
            {
                int mid = (start + end) / 2;
                Mergesort(arr, start, mid);
                Mergesort(arr, mid + 1, end);
                Merge(arr, start, mid, end);
            }
        }
        public void Merge(int[] arr, int start,int mid, int end)
        {
            int i=start;
            int j = mid + 1;
            int k = 0;
            int[] temp=new int[end-start+1];

            while ((i<=mid) && (j<=end))
            {
                if (arr[i] < arr[j])
                { temp[k++] = arr[i++]; }
                else
                    temp[k++] = arr[j++];
            }
            while (i <= mid)
                temp[k++] = arr[i++];
            while(j<=end)
                temp[k++] = arr[j++];
            for (i = start; i <=end; i++)
                arr[i] = temp[i-start];
        }
        public static void Main(string[] args)
        {
            int[] arr = new int[5] { 5, 14, 2, 3, 1 };
            foreach(var ele in arr)
                Console.WriteLine(ele);
            ArrayApp obj=new ArrayApp();
            obj.Mergesort(arr, 0, arr.Length - 1);
            Console.WriteLine("\nSorted array is");
            foreach (var ele in arr)
                Console.WriteLine(ele);

        }
    }
}
