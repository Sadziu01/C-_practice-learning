using ConsoleApp1___Learn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1_First
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type in your name:");
            string userName = Console.ReadLine();
            Console.WriteLine("Hello " + userName);

            string someText = "Some text";

            char jChar = 'j';
            char jCharUnicode = '\u006A';

            bool isUserReady = false;

            DateTime now = DateTime.Now;
            DateTime dateOfBirth = new DateTime(2001, 03, 09);

            byte byteNumber = 255;
            float floatNumber = 1.5f;
            decimal decimalNumber = 1.5m;
            double doubleNumber = 1.5;


            string text = "He said \"Hi\"";
            string fontsFolder = @"c:\windows\fonts";

            string concatenated = string.Concat(text, " to", " me");
            string concatenated2 = text + " to" + " me";

            string interpolated = $"{text} to me";

            StringBuilder sb = new StringBuilder("This");
            sb.Append(" is");
            sb.Append(" a");
            sb.Append(" long");
            sb.Append(" text.");

            string result = sb.ToString();

            string userInput = Console.ReadLine();
            int yearOfBirth;
            
            if(int.TryParse(userInput, out yearOfBirth))
            {
                int age = DateTime.Now.Year - yearOfBirth;

                Console.WriteLine("Your age is " + age);
            }
            else
            {
                Console.WriteLine("Incorrect value");
            }


            string[] cars = { "Audi", "BMW", "Honda" };
            Console.WriteLine(cars[0]);
            int arrayLength = cars.Length;

            for(int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }


            foreach(string car in cars)
            {
                Console.WriteLine(car);
            }


            Console.WriteLine("Whats is your gender? 1 - Male, 2 - Female");
            string userInput2 = Console.ReadLine();

            Gender userGender = (Gender) Enum.Parse(typeof(Gender), userInput2);

            int? favouriteNumber = null;
            Console.WriteLine("Favourite number: " + (favouriteNumber.HasValue ? favouriteNumber.Value.ToString() : ""));


            Regex regex = new Regex(@"^([a-z0-9]+)\.?([a-z0-9]+)@([a-z]+)\.[a-z]{2,3}$");
            string email = "test.test2@gmail.com";

            bool isMatch = regex.IsMatch(email);
            Console.WriteLine(isMatch);
        }

    }
}
