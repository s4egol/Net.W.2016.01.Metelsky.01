using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1;

namespace Task1UI
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 8, 3, 17, 10, 9, 1 };
            QuickSort.Sorting(arr, 0, arr.Length - 1);

            foreach (var element in arr)
            {
                Console.Write(element);
                Console.Write(" ");
            }

            Console.ReadKey();
        }
    }
}
