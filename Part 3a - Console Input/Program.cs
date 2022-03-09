//Part 3a - Console Input
using System;
using System.Linq;

namespace Part3aConsoleInput
{
    internal class Program
    {
        static void Main(string[] args)             
        {

            ///////////////////////////////////////////////////////////////////////// Greetings With System Date
            Console.WriteLine("----Greetings With System Date----");
            DateTime myDateTime = DateTime.Now;
            string findYear = myDateTime.Year.ToString();

            int currentYear = Convert.ToInt32(findYear);

            string name;
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();

            int userAge;
            Console.WriteLine("What is your age?");
            userAge = Convert.ToInt32(Console.ReadLine());

            int yearBorn;
            yearBorn = currentYear - userAge;
            Console.WriteLine("Hello " + name + " you were born in " + yearBorn);
            ///////////////////////////////////////////////////////////////////////// Adder 
            Console.WriteLine("----Adder----");
            int result;
            int num1, num2, num3;
            Console.WriteLine("Enter the first integer");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second integer");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third integer");
            num3 = Convert.ToInt32(Console.ReadLine());
            result = num1 + num2 + num3;
            Console.WriteLine("{0} + {1} + {2} = {3}", num1, num2, num3, result);
            ///////////////////////////////////////////////////////////////////////// Distance
            Console.WriteLine("----Distance----");
            double firstDist, secondDist, thirdDist;

            Console.WriteLine("Enter the first distance");
            firstDist = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second distance");
            secondDist = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the third distance");
            thirdDist = Convert.ToDouble(Console.ReadLine());

            double addition;
            addition = firstDist + secondDist + thirdDist;

            double division;
            division = addition / 3;

            double average;
            average = Math.Round(division, 2);

            Console.WriteLine("The average distance is " + average + " km");
            ///////////////////////////////////////////////////////////////////////// Hypotenuse
            Console.WriteLine("----Hypotenuse----");

            Console.WriteLine("Enter the length of the first leg");
            Double leg1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the length of the second leg");
            Double leg2 = Convert.ToDouble(Console.ReadLine());

            Double addedLeg1 = leg1 * leg1;
            Double addedLeg2 = leg2 * leg2;

            Double legsTogether = addedLeg1 + addedLeg2;
            Double hypotenuse = Math.Sqrt(legsTogether);
            
            Double roundedHypotenuse = Math.Round(hypotenuse, 2);
            Console.WriteLine("The hypotenuse is " + roundedHypotenuse);
            Console.ReadKey();
            
        }
    }
}

 
