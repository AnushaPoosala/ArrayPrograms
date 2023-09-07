using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42CheckIfCycleIsPresentInCircularArray
{
    internal class Program
    {
        public static bool CheckIfCircularArrayHasCycle(int[] arr)
        {
            if (arr.Length <= 1)
            {
                return false;
            }

            for (int i=0;i<arr.Length;i++)
            {
                int slowJump = i;
                int fastJump = i;
                bool isForward= arr[i]>=0 ? true: false;

                while(true)
                {
                    slowJump = NextPositionCalculation(arr, slowJump, isForward);
                    
                    if(slowJump == -1)
                        break;

                    fastJump=NextPositionCalculation(arr, fastJump, isForward);
                    if (fastJump == -1)
                        break;

                    fastJump = NextPositionCalculation(arr, fastJump, isForward);
                    if (fastJump == -1)
                        break;


                    if (slowJump == fastJump)
                        return true;
                }
            
            }
            return false; 
        }

        public static int NextPositionCalculation(int[] arr, int index, bool isForward)
        {
            bool direction= arr[index] >= 0 ? true : false;

            if (direction != isForward)
                return -1;

            int nextPosition = (arr[index] + index) % arr.Length;

            if (nextPosition < 0)
                nextPosition = nextPosition + arr.Length;

            if (nextPosition == index)
                return -1;

            return nextPosition;
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 1, 2, 1, 2 };
            
            Console.WriteLine(Program.CheckIfCircularArrayHasCycle(arr));

        }
    }
}
