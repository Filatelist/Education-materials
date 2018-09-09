using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quick_Sort
{
    class Program
    {
        static void quickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {int pi = partition(arr, low, high);
                
                quickSort(arr, low, pi);
                quickSort(arr, pi + 1, high);
            }
        }
        static int partition(int[] arr, int low, int high)
        {
            int pivot = arr[(low + high) / 2];
            int i = low - 1, j = high + 1;

            while (true)
            {
                do
                {
                    i++;
                } while (arr[i] < pivot);

                do
                {
                    j--;
                } while (arr[j] > pivot);
                if (i >= j)
                    return j;

                swap(ref arr[i],  ref arr[j]);
                Console.WriteLine(pivot);
                printArray(arr);
            }
        }
        static void swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        static  void printArray(int[] arr)
          {
              for (int i = 0; i < arr.Length; i++)
                  Console.Write( arr[i] + " ");
            Console.WriteLine();
          }
            static void Main(string[] args)
        {
            int[] arr = { 8, 19, -2, 5, 16, 0, 1, 7, 2, 13, 25, -8, 11, 20, 4 };
            int n = arr.Length;
            quickSort(arr, 0, n - 1);
            Console.WriteLine("Sorted array");
            printArray(arr);
        }
    }
}