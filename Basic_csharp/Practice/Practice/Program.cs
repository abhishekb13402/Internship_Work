using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("Enter choice\n 0 for swap number test" +
                    "\n 1 for loop test" +
                    "\n 2 for if else test" +
                    "\n 3 for array test" +
                    "\n 4 for Math test" +
                    "\n 9 for exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        SwapnoSample swapnoSample = new SwapnoSample();
                        swapnoSample.SwapTest();
                        break;
                    case 1:
                        LoopSample loopSample = new LoopSample();
                        loopSample.LoopTest();
                        break;
                    case 2:
                        IfElseSample ifElseSample = new IfElseSample();
                        ifElseSample.IfElseTest();
                        break;
                    case 3:
                        ArraySample arraySample = new ArraySample();
                        arraySample.arrayTest();
                        break;
                    case 4:
                        MathTest mathSample = new MathTest();
                        mathSample.mathTest();
                        break;
                    //case 8:
                    //    MathTest mathSample = new MathTest();
                    //    mathSample.mathTest();
                    //    break;
                    case 9:
                        Console.WriteLine("exit");
                        return;
                    default:
                        Console.WriteLine("Enter valid choice");
                        break;

                }



                Console.ReadLine();
            }
        }
    }
}
