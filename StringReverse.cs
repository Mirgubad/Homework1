namespace ConsoleApp19
{
    class Program
    {
        static void Main()
        {
            System.Console.WriteLine(StringReverse("Nurlan Faiq Emil Tural Yusif"));

        }

        static string StringReverse(string name)
        {
            string revname = "";

            for (int i = name.Length - 1; i >= 0; i--)
            {
                revname += name[i];
            }
            return revname;

        }




    }
}
