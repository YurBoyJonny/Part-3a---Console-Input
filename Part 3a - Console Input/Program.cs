//Part 3a - Console Input



using System;

namespace Part_3a___Console_Input
{
    class Program
    {
        static void Main(string[] args)
        {


            // Greetings With System Date
            DateTime aDate = DateTime.Now;

            string response;
            Console.WriteLine("Greetings, today's date is: ");
            Console.WriteLine(aDate.ToString("MM/dd/yyyy"));
            Console.WriteLine("Is this correct?");
            response = Console.ReadLine();
            Console.WriteLine("You said: " + response);

            string name;
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("Hello, " + name);

            string age;
            Console.WriteLine("What is your age?");
            age = Console.ReadLine();
            Console.WriteLine("You are " + age + " years old!");

            //string yearborn;

            //Console.WriteLine("You were born in " + yearborn);

            // Adder 


            // Distance


            // Hypotenuse


            Console.ReadKey();
        }
    }
}




