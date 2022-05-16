using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PallindromeString
{
    public class BasicProgram
    {
        public void EvenOdd()
        {
            {
                int num;
                Console.Write("Enter a Number : ");
                num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    Console.Write(" Number is an Even Number");
                }
                else
                {
                    Console.Write(" Number is an Odd Number");
                }
            }
        }

        public void OddRange()
        {
            {
                IEnumerable<int> oddNums = Enumerable.Range(20, 20).Where(x => x % 2 != 0);

                foreach (int n in oddNums)
                {
                    Console.WriteLine(n);
                }

            }
        }
        public void PositiveNumber()
        {
            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number > 0)
            {
                Console.WriteLine("Number is positive");
            }
            else if (number == 0)
            {
                Console.WriteLine("Number is 0");
            }
            else
            {
                Console.WriteLine("Number is negative");
            }
        }
        public void GreatestTwoNumbers()
        {
            int num_a, num_b;
            Console.WriteLine("Enter the first Numbers : ");
            num_a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            num_b = Convert.ToInt32(Console.ReadLine());
            if (num_a > num_b)
            {
                Console.WriteLine("{0} is the Greatest Number", num_a);
            }
            else
            {
                Console.WriteLine("{0} is the Greatest Number ", num_b);
            }

        }
        public void SwapNumber()
        {
            {
                int num_1, num_2, temp;
                Console.Write("\nEnter the First Number : ");
                num_1 = int.Parse(Console.ReadLine());
                Console.Write("\nEnter the Second Number : ");
                num_2 = int.Parse(Console.ReadLine());
                temp = num_1;
                num_1 = num_2;
                num_2 = temp;
                Console.Write("\nAfter Swapping : ");
                Console.Write("\nFirst Number : " + num_1);
                Console.Write("\nSecond Number : " + num_2);
            }
        }
        public int Reverse()
        {
            int num, reverse = 0, remainder;

            Console.WriteLine("Enter Number");
            num = int.Parse(Console.ReadLine());
            while (num != 0)
            {
                remainder = num % 10;
                reverse = reverse * 10 + remainder;
                num = num / 10;

            }

            return reverse;
        }
        public void Leapyear()
        {
            Console.WriteLine("Enter year");
            int year = int.Parse(Console.ReadLine());
            if (year >= 1000 && year <= 9999)
            {
                if ((year % 4 == 0) && (year != 100) || (year % 400 == 0))
                {
                    Console.WriteLine("It is a Leap Year");

                }
                else
                {
                    Console.WriteLine("It is not a leap year");
                }
            }
            else
            {
                Console.WriteLine("Invalid year");
            }
        }
        public void PerfectNumber()
        {
            int sum = 0;
            Console.WriteLine("Enter the Number");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                }
            }
            if (sum == num)
            {
                Console.WriteLine(num + "is a Perfect Number");
            }
            else
            {
                Console.WriteLine(num + "is not a perfect number");
            }
        }
        public void ReverseString()
        {
            string str, revstring = "";
            Console.WriteLine("Enter String");
            str = Console.ReadLine();
            str = str.ToLower();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                revstring = revstring + str[i];
            }
            Console.WriteLine("reverse string:" + revstring);
        }
        public void HarmonicNumber()
        {
            Console.WriteLine("Enter Number");
            int num = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 1; i <= num; i++)
            {
                Console.Write("1/{0}+", i);
                sum = sum + 1 / (float)i;

            }
            Console.Write("\n");
            Console.WriteLine("Harmonic value: " + sum);
        }
        public void ReverseArray()
        {
            {
                int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                Console.WriteLine("Original Number :");
                foreach (int num in array)
                {
                    Console.WriteLine(num);
                }
                Array.Reverse(array);
                Console.WriteLine("Reversed Array : ");
                foreach (int value in array)
                {
                    Console.WriteLine(value);
                }
            }

        }
        public void FibbonacciSeries()
        {
            Console.WriteLine("Enter the Number");
            int Number = int.Parse(Console.ReadLine());

            int Num_a = 0;
            int Num_b = 1;
            int Sum;
            Console.Write(Num_a + " " + Num_b + " ");
            for (int i = 2; i < Number; i++)
            {
                Sum = Num_a + Num_b;
                Console.Write(Sum + " ");
                Num_a = Num_b;
                Num_b = Sum;
            }
        }
        public void Factor()
        {
            Console.WriteLine("Enter the number");
            int Num = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} Prime Factors is =", Num);
            for (int i = 1; i <= Num; i++)
            {
                if (Num % i == 0)
                {
                    Console.WriteLine(i + " is a factor of " + Num);

                }
            }
        }
        public void Factorial()
        {
            {
                int i, number, fact;
                Console.WriteLine("Enter the Number");
                number = int.Parse(Console.ReadLine());
                fact = number;
                for (i = number - 1; i >= 1; i--)
                {
                    fact = fact * i;
                }
                Console.WriteLine("\nFactorial of Given Number is: " + fact);

            }
        }
        public void ArmstrongNumber()
        {
            {
                int number, remainder, sum = 0;
                Console.Write("Enter the Number : ");
                number = int.Parse(Console.ReadLine());
                for (int i = number; i > 0; i = i / 10)
                {
                    remainder = i % 10;
                    sum = sum + remainder * remainder * remainder;

                }
                if (sum == number)
                {
                    Console.WriteLine("Entered Number is an Armstrong Number");
                }
                else
                    Console.WriteLine("Entered Number is not an Armstrong Number");
            }
        }
        public void SquareRoot()
        {
            Console.WriteLine("Enter a Number : ");
            int number = Convert.ToInt16(Console.ReadLine());
            double sqrtnum = Math.Sqrt(number);
            Console.WriteLine("Square root of {0} is: {1}", number, sqrtnum);
            Console.ReadLine();
        }
        public void CubeRoot()
        {

            Console.Write("Enter the Number : ");
            int number = Convert.ToInt16(Console.ReadLine());
            double cuberoot = MathF.Cbrt(number);
            Console.WriteLine("Square root of {0} is: {1}", number, cuberoot);
        }
        public void CelsiusToFahrenheit()
        {
            int celsius, faren;
            Console.WriteLine("Enter the Temperature in Celsius(°C) : ");
            celsius = int.Parse(Console.ReadLine());
            faren = (celsius * 9) / 5 + 32;
            Console.WriteLine("0Temperature in Fahrenheit is(°F) : " + faren);
        }
        public void SimpleInterest()
        {
            int year;
            double princamt, rate, interest, total_amt;
            Console.Write("Enter The Loan Amount : ");
            princamt = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter The Number of Years : ");
            year = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter the Rate Of Interest : ");
            rate = Convert.ToDouble(Console.ReadLine());
            interest = princamt * year * rate / 100;
            total_amt = princamt + interest;
            Console.WriteLine("Interest : " + interest);
            Console.WriteLine("Total Amount : {0}", total_amt);

        }
        public void CompoundInterest()
        {
            double Total = 0, interestRate, years, annualCompound, Amount;
            Console.Write("Enter the Initial Amount : ");
            Amount = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the Rate of Interest : ");
            interestRate = Convert.ToDouble(Console.ReadLine()) / 100;
            Console.Write("Enter the Number of Years : ");
            years = Convert.ToDouble(Console.ReadLine());
            Console.Write("Number of Times the Interest will be Compounded : ");
            annualCompound = Convert.ToDouble(Console.ReadLine());
            for (int t = 1; t < years + 1; t++)
            {
                Total = Amount * Math.Pow((1 + interestRate / annualCompound),
                                         (annualCompound * t));
                Console.Write("Your Total for Year {0} "
                            + "is {1:F0}. \n", t, Total);

            }
        }
        public void ReverseStringArray()
        {

            string[] array = { "Remant", "Ravi", "Yogesh" };
            Console.WriteLine("Original Number :");
            foreach (string num in array)
            {
                Console.WriteLine(num);
            }
            Array.Reverse(array);
            Console.WriteLine("Reversed Array : ");
            foreach (string value in array)
            {
                Console.WriteLine(value);
            }

        }
        public void VowelandConsonant()
        {
            Console.WriteLine("Enter the character :");
            char ch = char.Parse(Console.ReadLine());

            switch (ch)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("Albhabet is Vowel");
                    break;
                default:
                    Console.WriteLine("Albhabet is Consonant");
                    break;

            }
        }
        public void LargestThreeNumber()
        {
            Console.WriteLine("Enter Number a");
            int num_a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number b");
            int num_b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number c");
            int num_c = int.Parse(Console.ReadLine());

            if (num_a > num_b && num_a > num_c)
            {
                Console.WriteLine("Number a is largest Number");
            }
            else if (num_b > num_a && num_b > num_c)
            {
                Console.WriteLine("Number b is largest Number");

            }
            else
            {
                Console.WriteLine("Number  is largest Number");

            }
        }
        public void LCM()
        {
            int num_1, num_2, lcm = 0;
            Console.Write("Enter the First Number : ");
            num_1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the Second Number : ");
            num_2 = int.Parse(Console.ReadLine());
           
            while (num_1 != num_2)
            {
                if (num_1 > num_2)
                {
                    num_1 = num_1 - num_2;
                }
                else
                {
                    num_2 = num_2 - num_1;
                }
            }
            lcm = (num_1 * num_2) / num_1;
            Console.Write("Least Common Multiple is : " + lcm);
            Console.Read();
        }
        public void HCF()
        {
            
                int num_1, num_2, i;
                int hcf = 0;
                Console.Write("\nEnter the First Number : ");
                num_1 = int.Parse(Console.ReadLine());
                Console.Write("\nEnter the Second Number : ");
                num_2 = int.Parse(Console.ReadLine());
                for (i = 1; i <= num_1 || i <= num_2; ++i)
                {
                    if (num_1 % i == 0 && num_2 % i == 0)
                    {
                        hcf = i;
                    }
                }
                Console.Write("\nCommon Factor is : ");
                Console.WriteLine(hcf);
                
            
        }
        public void PerimeterRectangleCicle()
        {
            double length, breadth, radius, per_rect, per_cir;
            double PI = 3.14;
            Console.WriteLine("Enter the Length and Breadth : ");
            length = Convert.ToDouble(Console.ReadLine());
            breadth = Convert.ToDouble(Console.ReadLine());
            per_rect = 2 * (length + breadth);
            Console.WriteLine("Enter the radius of the circle : ");
            radius= Convert.ToDouble(Console.ReadLine());
            per_cir = 2 * PI * radius;
            Console.WriteLine("Perimeter of Rectangle : {0}", per_rect);
            Console.WriteLine("Perimeter of Circle : {0}", per_cir);
          
        }
        public void SumDigit()
        {
            int num, sum = 0, rem;
            Console.WriteLine("Enter a Number : ");
            num = int.Parse(Console.ReadLine());
            while (num != 0)
            {
                rem = num % 10;
                num = num / 10;
                sum = sum + rem;
            }
            Console.WriteLine("Sum of Digits of the Number : " + sum);
        }

    }
}
