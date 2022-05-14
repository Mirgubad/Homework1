using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3, 4, 8 };


            Console.WriteLine(ArrSum(arr1));


        }

        static string ArrSum(int[] arr)
        {
            int sum = 0;

            foreach (int i in arr)
            {
                sum += i;



            }
            if (sum % 2 == 0)
            {

                return "Ededlerin cemi 2 e bolunur:";
            }


            else
            {
            }
            return "Ededlerin cemi 2 e bolunmur:";
        }





    }
}
