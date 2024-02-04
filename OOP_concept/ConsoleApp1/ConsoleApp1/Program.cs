using ConsoleApp1.myclasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Factory design method

            CarFactory carFactory = new CarFactory();
            Console.WriteLine("Welcome to Car rent search platform");
            Console.Write("Enter car seater number 4,6 choose: ");
            int input = Convert.ToInt32(Console.ReadLine());
            getCarInfo(carFactory, input);
            input = getPaymentInfo();

            Console.WriteLine("Thank you visit again..");


            Console.ReadLine();
        }

        private static int getPaymentInfo()
        {
            int input;
            Console.Write("Payment Mode are (gpay=1, phonepay=2, cardpay=3) ");
            input = Convert.ToInt32(Console.ReadLine());
            if (input == 1 || input == 2)
            {
                Console.WriteLine("Enter Amount for gpay payment= ");
                double amount = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter upiid = ");
                string upiid = Console.ReadLine();

                Gpay gpay = new Gpay();
                gpay.paymentmode(amount, upiid);
            }
            else if (input == 3)
            {
                Console.WriteLine("Enter Amount = ");
                double amount = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter upi id = ");
                string accno = Console.ReadLine();
                Console.WriteLine("Enter CVV number = ");
                int cvv = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter exp number = ");
                int exp = Convert.ToInt32(Console.ReadLine());

                Cardpay cardpay = new Cardpay();
                cardpay.paymentmode(amount, accno, cvv, exp);
            }
            else
            {
                Console.WriteLine("Please Enter valid choice for payment");
            }

            return input;
        }

        private static void getCarInfo(CarFactory carFactory, int input)
        {
            if (input == 4 || input == 6)
            {
                Icar mycar = carFactory.getcar(input);
                mycar.details();
                mycar.car();
            }
            else
            {
                Console.WriteLine("Enter valid input");
            }
        }


    }
}
