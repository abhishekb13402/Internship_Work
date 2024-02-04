using System;

namespace Practice
{
    internal class IfElseSample
    {
        public IfElseSample()
        {
        }

        internal void IfElseTest()
        {
            int input;
            Console.WriteLine("Enter 1 for leap year program");
            Console.WriteLine("Enter 2 for check number is prime or not program");
            input = Convert.ToInt32(Console.ReadLine());

            if (input == 1)
            {
                Leapyear();
            }
            else if (input == 2)
            {
                Checkprime();
            }
        }

        private void Checkprime()
        {
            //Program to check whether a number is Prime or not in C
            int num;
            Console.WriteLine("Enter number: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num == 0 || num == 1)
            {
                Console.WriteLine($"{num} is not prime");
                Console.ReadLine();
            }
            else
            {
                for (int i = 2; i < num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        Console.WriteLine($"{num} is not prime");
                        Console.ReadLine();
                    }
                }
                Console.WriteLine($"{num} is prime");
                //Console.ReadLine();
            }
        }

        void Leapyear()
        {
            //Program to check leap year in C#
            Console.WriteLine("Enter year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                Console.WriteLine($"Year = {year} is leap year");
            }
            else
            {
                Console.WriteLine($"Year = {year} is not a leap year");
            }

        }
    }
}