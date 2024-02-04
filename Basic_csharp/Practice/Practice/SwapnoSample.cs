using System;

namespace Practice
{
    internal class SwapnoSample
    {
        public SwapnoSample()
        {
        }

        internal void SwapTest()
        {
            int input;
            Console.WriteLine("Enter 1 for swap two number");
            Console.WriteLine("Enter 2 for swap two number without using third variable");
            input = Convert.ToInt32(Console.ReadLine());

            if (input == 0)
            {
                swpno();
            }
            else
            {
                swpnowithouttemp();
            }
        }

        private void swpno()
        {
            //Program of Swapping of two Integers-------------------

            int a = 2; int b = 3, temp = 0;
            Console.WriteLine($"Before Swap a={a} ,b={b} ");
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"After Swap a={a} ,b={b} ");
        }

        private void swpnowithouttemp()
        {
            //Program of Swapping of two Integers without using third variable----------------

            int aa = 2; int bb = 3;
            Console.WriteLine($"Before Swap a={aa} ,b={bb} ");
            aa = aa + bb;//5
            bb = aa - bb;//5-3=2
            aa = aa - bb;//5-2=3
            Console.WriteLine($"After Swap a={aa} ,b={bb} ");
        }
    }
}