using System;
using System.Text.RegularExpressions;

namespace Lab_7_RegEx_Ate_My_Neighbors
{
    class Program
    {
        static void Main(string[] args)
        {
            ValidateUserName();
            ValidateUserEmail();
            ValidatePhoneNumber();
            ValidateDate();
        }

        static void ValidateUserName()
        {
            Regex namePattern = new Regex(@"^([A-Z][a-z]+([ ]?[a-z]?['-]?[A-Z][a-z]+)*)$");
            Console.WriteLine("Please enter your name.");
            var userName = Console.ReadLine();

            if (namePattern.IsMatch(userName))
            {
                Console.WriteLine($"Thank you for entering your name, {userName}.\n");
            }
            else
            {
                Console.WriteLine("Sorry, name is not valid!\n");
            }
        }

        static void ValidateUserEmail()
        {
            Regex emailPattern = new Regex(@"(\w+)@(\w+)(\.(\w{2,3}))");
            Console.WriteLine("Please enter your email address.");
            var emailAddress = Console.ReadLine();

            if (emailPattern.IsMatch(emailAddress))
            {
                Console.WriteLine($"Your email address is {emailAddress}.\n");
            }
            else
            {
                Console.WriteLine("Sorry, email address is not valid!\n");
            }

        }
        static void ValidatePhoneNumber()
        {
            Regex numberPattern = new Regex(@"(\d{3}-)(\d{3}-)(\d{4})");
            Console.WriteLine("Please enter your phone number.");
            var phoneNumber = Console.ReadLine();

            if (numberPattern.IsMatch(phoneNumber))
            {
                Console.WriteLine($"Your phone number is {phoneNumber}.\n");
            }
            else
            {
                Console.WriteLine("Sorry, that phone number is not valid!\n");
            }

        }
        static void ValidateDate()
        {
            Regex datePattern = new Regex(@"(\d{2}\/)(\d{2}\/)(\d{4})");
            Console.WriteLine("Please enter today's date in this format: dd/mm/yyyy.");
            var currentDate = Console.ReadLine();

            if (datePattern.IsMatch(currentDate))
            {
                Console.WriteLine($"Today's date is {currentDate}.\n");
            }
            else
            {
                Console.WriteLine("Sorry, date is not valid!\n");
            }
        }
    }
}
