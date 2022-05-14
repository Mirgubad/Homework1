using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main()
        {
            IsPrime(13);

            Console.ReadLine();
        }



        static void IsPrime(int n)
        {

            int i = 0;
            int m = 0;
            int counter = 0;



            m = n / 2;
            for (i = 2; i <= m; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine("False");
                    counter++;
                    break;
                }
            }
            if (counter == 0)
                Console.WriteLine("True");

        }
    }



}




