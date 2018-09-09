using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory5
{
    class Program
    {
        static void printArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }

        static int print(int[] arr,int i)
        {
            int n = arr.Length;

            return arr[i];
        }
        static void sort(int[] arr)
        {
            int n = arr.Length;

            // Start with a big gap, 
            // then reduce the gap
            int[] gaps = { 1, 3, 5, 9, 17, 33, 65 };
            int k= gaps.Length;
            while ( k > 0)
            {
                Console.WriteLine(gaps[k-1]);
                int gap = gaps[k-1];
                for (int i = gap; i < n; i += 1)
                {   int temp = arr[i];
                    int j;
                    for (j = i; j >= gap && arr[j - gap] > temp; j -= gap)
                    {
                        Console.WriteLine($"swapping {arr[j-gap]} at {j-gap} and {arr[j]} at {j}");
                        arr[j] = arr[j - gap];
                        Console.WriteLine("After:");
                        printArray(arr);
                    }

                    arr[j] = temp;
                }
                k--;
            }
        }

        static void InsertionSort(int[] inputArray)
        {
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (inputArray[j - 1] > inputArray[j])
                    {
                        int temp = inputArray[j - 1];

                        Console.WriteLine($"swapping {inputArray[j-1]} at {j} and {inputArray[j]}");
                        
                        inputArray[j - 1] = inputArray[j];
                        inputArray[j] = temp;
                        printArray(inputArray);
                    }
                }
            }
        }
        public static void Main()
        {
            int[] arr = {8,19,-2,5,16,0,1,7,2,13,25,-8,11,20,4 };
            Console.Write("Array before sorting :\n");

            printArray(arr);

            sort(arr);
            int[] array = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                array[i] = print(arr, i);
            }
            Console.WriteLine($"Видалення {array[arr.Length - 1]}");
            array[array.Length-1] = 0;
            Console.WriteLine($"{array[arr.Length-2]} - найбільший");
            Console.Write("Array after sorting :\n");
            for (int i = 0; i < array.Length-1; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.ReadKey();
        }
    }
    
}


