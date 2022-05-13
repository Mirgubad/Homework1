using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main()
        {

            CalcAvg(58);
            Console.ReadLine();
        }





        static void CalcAvg(int score)
        {

            int[] examscore = { 60, 70, 80, 90, 100 };
            foreach (int i in examscore)
            {
                if (score > i)
                {

                    Console.WriteLine("Mezun oldunuz");
                    break;
                }
                else
                {
                    Console.WriteLine("Mezun ola bilmediniz");
                    break;
                }
            }

        }





    }
}
