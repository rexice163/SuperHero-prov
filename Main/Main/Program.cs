using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class Program
    {
        //skriv sin hjälte namn
        static void Main(string[] args)
        {
            Console.WriteLine("What is your hero name?");

            string name = Console.ReadLine();

            Base_stats player = ChooseClass("Which class of hero do you want to become?");
        }
        //man väljer vilken klass man vill vara och kommer returna den klassen
        static Base_stats ChooseClass(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine("1. Offensive 2. Defensive 3. Balanced \n Use numbers");

            while (true)
            {
                string answer = Console.ReadLine();

                if (answer == "1")
                {
                    Console.WriteLine("You chose Offensive class");
                    Console.ReadKey();
                    return new offensive();
                }
                else if (answer == "2")
                {
                    Console.WriteLine("You chose Defensive class");
                    Console.ReadKey();
                    return new defensive();
                }
                else if (answer == "3")
                {
                    Console.WriteLine("You chose Balanced class");
                    Console.ReadKey();
                    return new balanced();
                }
                else
                {
                    Console.WriteLine("It is not to hard to use numbers");
                }

            }
        }
    }
}