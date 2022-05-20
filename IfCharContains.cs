using System;

namespace ConsoleApp27
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = { "Badam", "Natiq", "Eli" };
            char user = 'i';
            StringPrint(arr, user);
        }


        static void StringPrint(string[] arr, char letter)
        {
            foreach (var item in arr)
            {
                for (int j = 0; j < item.Length; j++)
                {
                    if (item[j] == letter)
                    {
                        Console.WriteLine(item);
                    }
                }
            }

        }
    }
}

