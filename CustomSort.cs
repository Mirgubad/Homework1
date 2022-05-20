using System;
namespace ConsoleApp29
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 4, 8, 11, 21, 1 };
            ArraySort(arr);
        }
        public static void ArraySort(int[] arr)
        {
            int length = arr.Length;
            for (int i = 0; i < length - 1; i++)
            {
                if (arr[i] < arr[i + 1])
                {

                    int temp = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = temp;

                    i = -1;
                }
            }
            foreach (int item in arr)
            {
                Console.WriteLine(item);


            }
        }



    }
}


