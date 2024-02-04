using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.myclasses
{
    public interface Icar
    {
        void details();
        void car();
    }
    
    public class SixSeatercar : Icar
    {
        public void details()
        {
            Console.WriteLine("\n Car Seater type is = 6" +
                "\n Available cars are Maruti x1, Maruti x2, Maruti x3" +
                "\n Color maybe differ (Red,Black,White,Gray)");

        }
        public void car()
        {
            Console.WriteLine("Enter choice Maruti x1=1, Maruti x2=2, Maruti x3=3");
            int color = Convert.ToInt32(Console.ReadLine());
            string car;
            switch (color)
            {
                case 1:
                    car = "Maruti x1";
                    Console.WriteLine($"Car color set to ={car}");
                    break;
                case 2:
                    car = "Maruti x2";
                    Console.WriteLine($"Car color set to ={car}");
                    break;
                case 3:
                    car = "Maruti x3";
                    Console.WriteLine($"Car color set to ={car}");
                    break;
                default:
                    Console.WriteLine("Enter valid choice");
                    car = null;
                    Console.WriteLine($"Car color set to null ={car}");
                    break;

            }

        }
    }
    public class FourSeatercar : Icar
    {
        public void details()
        {
            Console.WriteLine("\n Car Seater type is = 4" +
                "\n Available cars are Maruti Jimny, Maruti Alto K10, Maruti Alto" +
                "\n Color maybe differ (Red,Black,White,Gray)");
        }
        public void car()
        {
            Console.WriteLine("Enter choice Maruti Jimny = 1, Maruti Alto K10 = 2, Maruti Alto =3");

            int color = Convert.ToInt32(Console.ReadLine());
            string car;
            switch (color)
            {
                case 1:
                    car = "Maruti Jimny";
                    Console.WriteLine($"Car set to ={car}");
                    break;
                case 2:
                    car = "Maruti Alto K10";
                    Console.WriteLine($"Car set to ={car}");
                    break;
                case 3:
                    car = "Maruti Alto";
                    Console.WriteLine($"Car set to = {car}");
                    break;
                default:
                    Console.WriteLine("Enter valid choice");
                    car = null;
                    Console.WriteLine($"Car set to null ={car}");
                    break;

            }
        }
    }
    public class CarFactory
    {
        public Icar getcar(int cartype)
        {
            switch (cartype)
            {
                case 4:
                    return new FourSeatercar();
                case 6:
                    return new SixSeatercar();


            }
            return null;
        }
    }
    internal class Factorymethod
    {
    }
}
