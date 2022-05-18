using System;

namespace ConsoleApp21
{
    class Program
    {static void Main(string[] args)
        {
            int[] arr = { 3, 4, 5, 6 };
            int[] arr1 = { 6, 5, 4 };
            Console.WriteLine(IsArrayContains(arr, arr1));
        }

        static bool IsArrayContains(int[] arr, int[] arr1)
        {

            string arrstr = string.Join("", arr);
            string arrstr1 = string.Join("", arr1);



            return arrstr.Contains(arrstr1);
        }

        
        

    }

}

