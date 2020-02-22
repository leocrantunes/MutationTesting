using System;
using System.Collections.Generic;

namespace MutationTesting
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter your first name: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Please, enter your last name: ");
            string lastName = Console.ReadLine();

            Console.WriteLine("Please, enter your gender: ");
            string gender = ReadGender();

            Console.WriteLine("Please, enter your age: ");
            int age = ReadValidInteger();

            string result = PersonCategorization.Categorize(gender, age);

            Console.WriteLine($"Data: firstName: {firstName}, lastName: {lastName}, gender: {gender}, age: {age}"); 
            Console.WriteLine($"Result: {result}");

            Console.ReadKey();
        }

        /// <summary>
        /// Auxiliary method to read a valid integer and handle exceptions
        /// </summary>
        /// <returns></returns>
        private static int ReadValidInteger()
        {
            bool correct = false;
            do
            {
                Console.Write("Value: ");
                bool validInteger = int.TryParse(Console.ReadLine(), out int value);
                if (validInteger)
                {
                    if (value <= 0)
                    {
                        Console.WriteLine("Please inform an integer greater than 0");
                    }
                    else
                    {
                        return value;
                    }
                }
                else
                {
                    Console.WriteLine("Please inform a valid integer number");
                }
            }
            while (!correct);

            return 0;
        }

        /// <summary>
        /// Auxiliary method to read option code and handle exceptions
        /// </summary>
        /// <returns></returns>
        private static string ReadGender()
        {
            List<string> _options = new List<string> { Constants.MALE_INITIALS, Constants.FEMALE_INITIALS };

            bool correct = false;
            string value;
            do
            {
                value = Console.ReadLine();
                if (_options.Contains(value))
                {
                    return value;
                }
                else
                {
                    Console.WriteLine("Please inform a code in the list above");
                    Console.WriteLine($"{string.Join(", ", _options)}");
                }
            }
            while (!correct);

            return value;
        }
    }
}