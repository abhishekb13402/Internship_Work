using System.Numerics;

namespace WebApplication1.Calc
{
    public class Calculator
    {

        public int Add(int number1,int number2)
        {
            if (number1 < 0 || number2 < 0)
            {
                throw new Exception("Nagaative number not allowed");
            }
            return number1 + number2;
        }
        public int Sub(int number1, int number2)
        {
            if(number1 < number2)
            {
                throw new Exception("Num1 must be greater");
            }
            return number1 - number2;
        }
        public int Mul(int number1, int number2)
        {
            return number1 * number2;
        }
        public int Div(int number1, int number2)
        {
            if (number2 == 0)
            {
                throw new Exception("Divide by zero not allowed");
            }
            return number1 / number2;
        }

    }
}
