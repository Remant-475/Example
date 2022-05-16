using System;

namespace PallindromeString
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int option;
            do
            {
                Console.WriteLine("Enter your option");
                Console.WriteLine("1:Even&Odd");
                Console.WriteLine("2:Odd Within Range");
                Console.WriteLine("3:Positive Number");
                Console.WriteLine("4:Greatest in two Number");
                Console.WriteLine("5:Swap Two Number");
                Console.WriteLine("6:Reverse Number");
                Console.WriteLine("7:Leap Year");
                Console.WriteLine("8:Perfect Number");
                Console.WriteLine("9:Reverse String");
                Console.WriteLine("10:Harmonic Number");
                Console.WriteLine("11:Reverse Array");
                Console.WriteLine("12: Fibonacci Series");
                Console.WriteLine("13: Prime factor of number");
                Console.WriteLine("14: Factorial");
                Console.WriteLine("15: Armstrong Number");
                Console.WriteLine("16: Square Root");
                Console.WriteLine("17:Cube Root");
                Console.WriteLine("18: Convert Celsius to Fahrenheit");
                Console.WriteLine("19: Simple Interest");
                Console.WriteLine("20: Compound Interest");
                Console.WriteLine("21: Reverse String Array");
                Console.WriteLine("22: Vowel or Consonent");
                Console.WriteLine("23: Find Largest among Three Numbers");
                Console.WriteLine("24: Find LCM");
                Console.WriteLine("25: Find HCF");

                option = int.Parse(Console.ReadLine());
                switch (option)

                {
                    case 1:
                        BasicProgram even = new BasicProgram();
                        even.EvenOdd();
                        break;
                    case 2:

                        BasicProgram odd = new BasicProgram();
                        odd.OddRange();
                        break;
                    case 3:

                        BasicProgram positive = new BasicProgram();
                        positive.PositiveNumber();
                        break;
                    case 4:

                        BasicProgram greatest = new BasicProgram();
                        greatest.GreatestTwoNumbers();
                        break;
                    case 5:

                        BasicProgram swap = new BasicProgram();
                        swap.SwapNumber();
                        break;
                    case 6:
                        BasicProgram reverse = new BasicProgram();
                        int rev = reverse.Reverse();
                        Console.WriteLine("Reverse Number: " + rev);
                        break;
                    case 7:
                        BasicProgram leap = new BasicProgram();
                        leap.Leapyear();
                        break;
                    case 8:
                        BasicProgram perfect = new BasicProgram();
                        perfect.PerfectNumber();
                        break;
                    case 9:
                        BasicProgram revstr = new BasicProgram();
                        revstr.ReverseString();
                        break;
                    case 10:
                        BasicProgram harmonic = new BasicProgram();
                        harmonic.HarmonicNumber();
                        break;
                    case 11:
                        BasicProgram reversearr = new BasicProgram();
                        reversearr.ReverseArray();
                        break;
                    case 12:
                        BasicProgram fibonacci = new BasicProgram();
                        fibonacci.FibbonacciSeries();
                        break;
                    case 13:
                        BasicProgram factor = new BasicProgram();
                        factor.Factor();
                        break;
                    case 14:
                        BasicProgram factorial = new BasicProgram();
                        factorial.Factorial();
                        break;
                    case 15:
                        BasicProgram armstrong = new BasicProgram();
                        armstrong.ArmstrongNumber();
                        break;
                    case 16:
                        BasicProgram square = new BasicProgram();
                        square.SquareRoot();
                        break;
                    case 17:
                        BasicProgram cube=new BasicProgram();
                        cube.CubeRoot();
                        break;
                    case 18:
                        BasicProgram celsius = new BasicProgram();
                        celsius.CelsiusToFahrenheit();
                        break;
                    case 19:
                        BasicProgram simple=new BasicProgram();
                        simple.SimpleInterest();
                        break;
                    case 20:
                        BasicProgram compound=new BasicProgram();
                        compound.CompoundInterest();
                        break;
                    case 21:
                        BasicProgram rever=new BasicProgram();
                        rever.ReverseStringArray();
                        break;
                    case 22:
                        BasicProgram vowel=new BasicProgram();
                        vowel.VowelandConsonant();
                        break;
                    case 23:
                        BasicProgram largest =new BasicProgram();
                        largest.LargestThreeNumber();
                        break;
                    case 24:
                        BasicProgram lcm = new BasicProgram();
                        lcm.LCM();
                        break;
                    case 25:
                        BasicProgram hcf = new BasicProgram();
                        hcf.HCF();
                        break;
                   
                }

            } while (option != 0);

        }
    }
}
