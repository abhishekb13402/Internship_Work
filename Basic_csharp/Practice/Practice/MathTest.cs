using System;

namespace Practice
{
    internal class MathTest
    {
        public MathTest()
        {
        }

        internal void mathTest()
        {
            MathTest mathTest = new MathTest();
            int ch;

            while (true)
            {

                Console.WriteLine("Enter choice for math operations: \n" +
                    "1 for reverse a number.\n" +
                    "2 for sorting a number in assending order.\n" +
                    "3 for sorting a number in decenging order\n" +
                    "4 for closest palindrom number\n" +
                    "5 Area of a Circle\n" +
                    "6  to find greater among three numbers\n" +
                    "9 for exit");
                ch = Convert.ToInt32(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        mathTest.Reverseano();
                        break;
                    case 2:
                        mathTest.Sortassending();
                        break;
                    case 3:
                        mathTest.Sortdecending();
                        break;
                    case 4:
                        mathTest.Closestpalindrom();
                        break;
                    case 5:
                        mathTest.Areaofacircle();
                        break;
                    case 6:
                        mathTest.Greateramongthreeno();
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

        private void Greateramongthreeno()
        {
            //Program to find greater among three numbers ----------------------------
            int n1, n2, n3, max;
            Console.WriteLine("Enter Numbers: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            n3 = Convert.ToInt32(Console.ReadLine());
            max = (n1 > n2 && n1 > n2) ? n1 : (n2 > n3) ? n2 : n3;
            Console.WriteLine("Largest number among " + n1 + ", " + n2 + " and " + n3 + " is " + max);

        }

        private void Areaofacircle()
        {
            //Program to calculate area of circle -------------------------
            const double Pi = 3.14;
            Console.WriteLine("Enter Radius: ");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Area of circle is = {(Pi * r * r)}");

        }

        private void Closestpalindrom()
        {
            int number;
            Console.WriteLine("Enter number");
            number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Original number: {number}");
            int closestPalindrome = FindClosestPalindrome(number);
            Console.WriteLine($"Closest Palindrome number is: {closestPalindrome}");

            //flag=Checkpalindrom(num);

            //if (flag == 1)
            //{
            //    for (int i = 0; i <= 20; i++)
            //    {
            //        newno=++num;
            //        Checkpalindrom(newno);
            //        if (newno == num)
            //        {
            //            Console.WriteLine($"closest palindrom number find is {newno}");
            //            return;
            //        }
            //        break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("number is not palindrom");
            //}

        }

        static bool IsPalindrome(int number)
        {
            string numberString = number.ToString();
            int start = 0;
            int end = numberString.Length - 1;

            while (start < end)
            {
                if (numberString[start] != numberString[end])
                {
                    return false;
                }
                start++;
                end--;
            }

            return true;
        }

        private int FindClosestPalindrome(int number)
        {
            int closestPalindrome = number;
            bool isPalindromeFound = false;

            // Check if the original number is a palindrome
            if (IsPalindrome(number))
            {
                isPalindromeFound = true;
            }
            else
            {
                // Find the closest palindrome by checking the numbers before and after the original number
                int lowerPalindrome = number - 1;
                while (lowerPalindrome > 0 && !isPalindromeFound)
                {
                    if (IsPalindrome(lowerPalindrome))
                    {
                        closestPalindrome = lowerPalindrome;
                        isPalindromeFound = true;
                    }
                    lowerPalindrome--;
                }

                int higherPalindrome = number + 1;
                while (!isPalindromeFound)
                {
                    if (IsPalindrome(higherPalindrome))
                    {
                        closestPalindrome = higherPalindrome;
                        isPalindromeFound = true;
                    }
                    higherPalindrome++;
                }
            }

            // If no palindrome is found, return the original number
            if (!isPalindromeFound)
            {
                return number;
            }

            return closestPalindrome;
        }

        private int Checkpalindrom(int num)
        {
            int temp, rem, revno = 0;
            temp = num;
            while (temp != 0)
            {
                rem = temp % 10;
                revno = revno * 10 + rem;
                temp /= 10;
            }
            if (num == revno)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        private void Sortdecending()
        {

            int[] num = new int[5];
            int temp = 0;
            Console.WriteLine("Enter 5 numbers in array to sort in decending order");
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i <= num.Length - 1; i++)
            {
                for (int j = i + 1; j < num.Length; j++)
                {
                    if (num[i] < num[j])
                    {
                        temp = num[i];
                        num[i] = num[j];
                        num[j] = temp;
                    }
                }
            }
            Console.WriteLine("Sorting--");
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i]);
            }
        }

        private void Sortassending()
        {
            int[] num = new int[5];
            int temp = 0;
            Console.WriteLine("Enter 5 numbers in array to sort in assending order");
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i <= num.Length - 1; i++)
            {
                for (int j = i + 1; j < num.Length; j++)
                {
                    if (num[i] > num[j])
                    {
                        temp = num[i];
                        num[i] = num[j];
                        num[j] = temp;
                    }
                }
            }
            Console.WriteLine("Sorting--");
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i]);
            }
        }

        private void Reverseano()
        {
            int revno = 0, number, rem;
            Console.WriteLine("Enter number");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Original Integer value: {number}");
            while (number != 0)
            {
                rem = number % 10;
                revno = revno * 10 + rem;
                number /= 10;
            }
            Console.WriteLine($"Reverse the digits of the said signed integer value: {revno}");

        }

    }
}