using System;
using System.Linq;

namespace Practice
{
    internal class LoopSample
    {
        public LoopSample()
        {
        }

        internal void LoopTest()
        {
            LoopSample loopTest = new LoopSample();


            while (true)
            {

                Console.WriteLine("Enter choice for math operations: \n" +
                    "1 for sum avg min max a number.\n" +
                    "2 for Other Operations.\n" +
                    "9 for exit");
                int ch = Convert.ToInt32(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        loopTest.sumavgminmax();
                        break;
                    case 2:
                        loopTest.otheroperation();
                        break;
                    case 9:
                        return;
                    default:
                        Console.WriteLine("Enter valid choise");
                        break;
                }

                Console.ReadLine();
            }
        }

        private void otheroperation()
        {
            int num, sum = 0, count = 0, temp, temp1, temp3, revno = 0, r;
            Console.WriteLine("Other Operations are \n " +
                "N natural number," +
                "\n natural number in reverse order," +
                "\n even and odd number," +
                "\n Display Table," +
                "\n sum of first N natural numbers," +
                "\n Count Digits in a number and sum of a number," +
                "\n Reverse a number,");
            Console.WriteLine("Enter number For Other operations :");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Print N Natural Numbers are");
            for (int i = 1; i <= num; i++)
            {
                Console.Write(" " + i);
            }

            Console.WriteLine("\n Print N Natural Numbers in reverse order are");
            for (int i = num; i >= 1; i--)
            {
                Console.Write(" " + i);
            }

            Console.WriteLine("\n Even Numbers are");
            for (int i = 2; i <= num; i += 2)
            {
                Console.Write(" " + i);
            }

            Console.WriteLine("\n Odd Numbers are");
            for (int i = 1; i <= num; i += 2)
            {
                Console.Write(" " + i);
            }

            Console.WriteLine($"\n Table of number {num}");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num} X {i} = {num * i}");
            }

            Console.WriteLine("\n Sum of Numbers are");
            for (int i = 1; i <= num; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);

            Console.WriteLine($"\n Number is={num}");
            temp = num;
            while (temp > 0)
            {
                temp /= 10;
                count++;
            }
            Console.WriteLine($"\n Count is : {count}");

            temp1 = num;
            while (temp1 > 0)
            {
                r = temp % 10;
                temp /= 10;
                sum += r;
            }
            Console.WriteLine($"\n sum of Digits : {sum}");

            temp3 = num;
            while (temp != 0)
            {
                r = temp % 10;
                revno = (revno * 10 + r);
                temp /= 10;
            }
            Console.WriteLine($"{revno}");
            //Console.ReadLine();
        }


        private void sumavgminmax()
        {
            //w.a.p to calculate sum and average of the array
            //w.a.p to find minimum and maximum from the array.

            int[] val = { 1, 2, 3 };
            int sum = 0, avg = 0, min, max;
            min = max = val[0];
            for (int i = 0; i < val.Length; i++)
            {
                sum += val[i];
                if (val[i] > max)
                {
                    max = val[i];
                }
                if (val[i] < min)
                {
                    min = val[i];
                }
            }
            avg = sum / val.Length;
            Console.WriteLine($"sum={sum}, avg={avg} ,min={min}, max={max}");
            Console.WriteLine(val.Min());
            Console.WriteLine(val.Max());


        }

    }
}