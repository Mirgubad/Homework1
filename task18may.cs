using System;

namespace ConsoleApp21
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] arr1 = { 2, 3, 4, 7 };
            int[] arr2 = { 2, 4, 7, 8 };

            Console.WriteLine(İsArrayContains(arr1, arr2));

        }

        static bool İsArrayContains(int[] arr1, int[] arr2)
        {

            int a = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)


                {
                    if (arr1[i] == arr2[j])
                    {
                        a++;
                    }
                    if (a == arr2.Length && IsSorted(arr2))
                    {
                        return true;
                    }
                }
            }
            return false;

        }

        static bool IsSorted(int[] a)
        {
            for (int i = 0; i < a.Length - 1; ++i)
            {
                if (a[i].CompareTo(a[i + 1]) > 0)
                    return false;
            }
            return true;
        }

    }

}

