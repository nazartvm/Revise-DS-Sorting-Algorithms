using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure
{
    public static class BubbleSort
    {
        /// <summary>
        /// Bubble sort function
        /// </summary>
        /// <param name="arr"></param>
        public static int[] Sort(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = i + 1; j < arr.Length; j++)
                {
                    //swap the greater numbers to next position
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                    //end of the swapping
                }
            }
            return arr;
        }
        public static int[] DescendingOrderSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    //swap the samll numbers to next position
                    if (arr[i] < arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                    //end of the swapping
                }
            }
            return arr;
        }
        /// <summary>
        /// Bubble sort using recursion
        /// </summary>
        /// <param name="arr"></param>
        public static int[] RecursionSort(int[] arr)
        {
                for (int j = 0; j < arr.Length-1; j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = temp;
                        RecursionSort(arr);
                    }
                }
            return arr;
        }
    }
}
