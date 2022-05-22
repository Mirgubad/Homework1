namespace ConsoleApp34
{
    class Program
    {
        static void Main(string[] args)
        {
            User mysecurity = new User
            {
                name = "Mirqubad",
                Surname = "Akberov",
                NickName = "Miri",
                Password = "Mirqubad123",

            };
            string pass = "saklsMirqubadsaskla";
            System.Console.WriteLine(mysecurity.IsPasswordValid(pass));
        }
    }
    class User
    {
        public string name;
        public string Surname;
        public string NickName;
        public string Password;


        public bool IsPasswordValid(string password)
        {
            bool result = true;
            int[] digit = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            int i = 0;
            int j = 0;


            for (int q= 0;q < digit.Length;q++)
            {
                while (i < password.Length && j < name.Length)
                {
                    if (password[i] == name[j])
                    {
                        i++;
                        j++;

                        if ( j == name.Length)
                        { 
                           return false; 
                        }
                    }
                    else
                    {
                        i = i - j + 1;
                        j = 0;
                    }
                }
            }
            return result;

        }
    }
}
