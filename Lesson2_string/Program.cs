using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_string
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World");
            string firstName;
            string lastName;
            string favorateColor;
           
            Console.WriteLine("Enter your first name: ");
            firstName = Console.ReadLine();
            //Console.WriteLine("Hello, "+ firstName);
            Console.WriteLine("Enter your last name: ");
            lastName = Console.ReadLine();
            //Console.WriteLine("Nice to meet you, " + firstName+ " "+ lastName+"!");
            //Comment line

            Console.WriteLine("Nice to meet you {0} {1}", firstName, lastName);

            
            Console.WriteLine("What is your favorate color?");
            favorateColor = Console.ReadLine();
            Console.WriteLine("Your favorate color is {0}, very nice {1}!", favorateColor, firstName);

            int age;
            Console.WriteLine("Enter your age: ");
            age = int.Parse(Console.ReadLine());
            

            Console.ReadLine();
        }
    }
}
