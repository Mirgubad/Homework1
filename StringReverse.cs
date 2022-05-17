namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(StringReverse("Nurlan Faiq Emil Tural Yusif"));

        }

        static string StringReverse(string name)
        {
            string revname = "";

            string[] words = name.Split();
            foreach (var j in words)
            {
                for (int i = j.Length - 1; i >= 0; i--)

                {

                    revname += j[i];

                }
                revname += " ";

            }
            return revname;




    }
}
