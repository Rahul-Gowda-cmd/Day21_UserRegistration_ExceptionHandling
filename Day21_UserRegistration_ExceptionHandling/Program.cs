using System;

namespace Day21_UserRegistration_ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Program with EXception Handling ");
            Patterns patternsMatch = new Patterns();
            Console.WriteLine("Enter FirstName:");
            string firstName = Console.ReadLine();
            Console.WriteLine("FirstName:" + patternsMatch.ValidateFirstName(firstName));
            Console.WriteLine("Enter LastName:");
            string lastName = Console.ReadLine();
            Console.WriteLine("LastName:" + patternsMatch.ValidateLastName(lastName));
            Console.WriteLine("Enter EmailID:");
            string emailId = Console.ReadLine();
            Console.WriteLine("EmailID:" + patternsMatch.ValidateEmailId(emailId));
            Console.WriteLine("Enter Mobile Number:");
            string mobileNumber = Console.ReadLine();
            Console.WriteLine("Mobile Number:" + patternsMatch.ValidateMobileNumber(mobileNumber));
            Console.WriteLine("Enter Password:");
            string password = Console.ReadLine();
            Console.WriteLine("Password:" + patternsMatch.ValidatePassword(password));
        }
    }
}
