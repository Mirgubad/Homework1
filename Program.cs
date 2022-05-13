using System;
namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = { 100, 200, 300, 200 };


            if (CalcAvg(arr) > 60)
            {
                Console.WriteLine("Siz mezun oldunuz");
            }
            else
            {
                Console.WriteLine("siz mezun olmadiniz");
            }
        }

        static int CalcAvg(int[] arr)
        {
            int avg = 0;
            int sum = 0;
            int counter = 0;

            foreach (int i in arr)

            {
                sum += i;
                counter++;
            }
            avg = sum / counter;

            return avg;














        }
    }
}
