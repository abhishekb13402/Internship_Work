using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.myclasses
{
    //Factory design method
    public interface Ipayment
    {
        void paymentmode(double amount, string upiid);
    }
    public interface Icardpayment
    {
        void paymentmode(double amount, string accno, int cvv, int exp);
    }

    public class Gpay : Ipayment
    {
        public void paymentmode(double amount, string upiid)
        {
            Console.WriteLine($"Amout is = {amount} and upiid is = {upiid}");
        }
    }
    public class Phonepay : Ipayment
    {
        public void paymentmode(double amount, string upiid)
        {
            Console.WriteLine($"Amout is = {amount} and upiid is = {upiid}");
        }
    }
    public class Cardpay : Icardpayment
    {
        public void paymentmode(double amount, string accno, int cvv, int exp)
        {
            Console.WriteLine($"\nAmout is = {amount} " +
                $"\n Account number is = {accno} " +
                $"\n CVV number {cvv}" +
                $"\n and exp number {exp}");
        }
    }
    internal class Class1
    {
    }
}
