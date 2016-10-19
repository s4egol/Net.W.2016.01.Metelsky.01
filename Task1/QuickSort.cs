using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public static class QuickSort
    {
        public static void Sorting(int[] arr, int first, int last)
        {
            int i = first;
            int j = last;
            int middle = arr[(first + last) / 2];

            while (i <= j)
            {
                while (arr[i] < middle)
                    i++;
                while (arr[j] > middle)
                    j--;
                if (i <= j)
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    i++;
                    j--;
                }
            }

            if (j > first)
                Sorting(arr, first, j);
            if (i < last)
                Sorting(arr, i, last);
        }
    }
}
