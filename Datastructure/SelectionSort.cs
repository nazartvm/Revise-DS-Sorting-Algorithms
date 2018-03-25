using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure
{
    public class SelectionSort
    {
        /// <summary>
        /// Selection sort
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int[] Sort(int[] arr)
        {
            for(int i = 0; i < arr.Length - 1; i++)
            {
                int minIndex = i;
                //based on the i index value find the first minimum value index
                for(int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                //end of the loop
                if (i != minIndex)
                {
                    //swap the finded last minimum value
                    int temp = arr[i];
                    arr[i] = arr[minIndex];
                    arr[minIndex] = temp;
                    //end of the swaping
                }
            }
            return arr;
        }
    }
}
