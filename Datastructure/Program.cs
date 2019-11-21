using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Datastructure
{
    public class Program
    {
        public static void Main()
        {
            PrintSortedValues(SelectionSort.Sort(new int[] {0, 64, 25, 92, 22, 11 }));
            PrintSortedValues(BubbleSort.RecursionSort(new int[] { 110, 0, 64, 25, 92, 22, 11, 99 }));
            PrintSortedValues(BubbleSort.DescendingOrderSort(new int[] { 5,1,2,4,8 }));
            Console.WriteLine("checking");
            Console.ReadKey();
        }
        /// <summary>
        /// Helper function to print sorted values
        /// </summary>
        /// <param name="arr"></param>
        public static void PrintSortedValues(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
