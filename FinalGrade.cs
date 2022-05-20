using System;

namespace ConsoleApp28
{
    class Program
    {
        static void Main(string[] args)
        {
            Student myscore = new Student
            {
                HomeWorkGrades = 90,
                finalgrade = 90,
                ishtiraketdiyi = 1,
                umumiders = 8,
                ProjectGrades = 83,
                Davamiyyet = true,
            };
            myscore.FinalGrades(100);
        }


    }
    class Student
    {
        public int HomeWorkGrades;
        public int ProjectGrades;
        public int finalgrade;
        public bool Davamiyyet;
        public int umumiders;
        public int ishtiraketdiyi;

        public void FinalGrades(int umumibal)
        {
            double score = (ProjectGrades * 0.25) + (HomeWorkGrades * 0.25) + (finalgrade * 0.4) + (ishtiraketdiyi * 0.1);

            if (score >= 90)
            {
                Console.WriteLine("HighHonour");
            }
            else if (score > 80)
            {
                Console.WriteLine("Honour");
            }
            else
            {
                Console.WriteLine("Normal");
            }
        }
    }




}