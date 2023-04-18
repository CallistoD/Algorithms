using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Quicksort.Tools;

namespace Quicksort
{
    // Pivot - берем первый элемент
    internal class FirstPivot
    {
        public static int[] SortArray(int[] arr, int leftIndex, int lastIndex)
        {
            var i = leftIndex;
            var j = lastIndex;
            var pivot = arr[leftIndex];

            while (i <= j){
                while (arr[i] < pivot){
                    i++;
                }
                while (arr[j] > pivot){
                    j--;
                }

                if (i <= j){
                    var temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    i++;
                    j--;
                }

                if (leftIndex < j){
                    SortArray(arr, leftIndex, j);
                }
                
                if (i < lastIndex){
                    SortArray(arr, i, lastIndex);
                }
            }
            return arr;
        }


    }
}
