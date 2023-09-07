using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Program
    {
        int count = 0;
        static void Main()
        {
            var obj = new Program();
            var print = new Print();
            var insertFront = new InsertAtFront();
            var insertAtPosition = new InsertAtIndex();
            var arr1 = new int[5];

            //insert values into array
            for (var i=0;i<arr1.Length;i++)
            {
                Console.WriteLine("Enter ele into array");
                var ele = Convert.ToInt32(Console.ReadLine());
                obj.Insertion(arr1,ele);
            }
            print.PrintEle(arr1);

            insertFront.InsertEleAtFront(arr1, 7); //insert at front 
            print.PrintEle(arr1);

            insertAtPosition.InsertEleAtIndex(arr1, 3, 90); //insert at middle,last
            print.PrintEle(arr1);
        }
        public void Insertion(int[] arr1, int val)
        {
           
            arr1[count++]=val;
        }
    }
}
