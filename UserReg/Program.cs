using System;
using System.Collections.Generic;

namespace UserReg
{
    class Program
    {
        static void Main(string[] args)
        {
            Pattern pattern = new Pattern();
            Console.WriteLine("Welcome to User Registration");
            List<Person> validEntry = new List<Person>();
            while (true)
            {
                Console.WriteLine("Press 1. For New Entry, 2. for Exit");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {


                    Console.WriteLine("Enter the first name");
                    string firstName = Console.ReadLine();

                    Console.WriteLine("Enter the last name");
                    string lastName = Console.ReadLine();

                    Console.WriteLine("Enter the email ID");
                    string emailId = Console.ReadLine();

                    Console.WriteLine("Enter the phone number");
                    string phoneNumber = Console.ReadLine();

                    Console.WriteLine("Enter the password");
                    string password = Console.ReadLine();

                    Person p = new Person(firstName, lastName, emailId, phoneNumber, password, pattern.checkFirstName(firstName), pattern.checkLastName(lastName), pattern.checkEmail(emailId), pattern.checkPhone(phoneNumber), pattern.checkPassword(password));
                    validEntry.Add(p);
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("__________________________________________________________");
            foreach (var p in validEntry.FindAll(e => e.getFirstNameResult() == true && e.getLastNameResult() == true))
            {
                Console.WriteLine("First Name: " + p.getFirstName());
                Console.WriteLine("Last Name: " + p.getLastName());
                Console.WriteLine("Email: " + p.getEmail());
                Console.WriteLine("Phone No : " + p.getPhone());
                Console.WriteLine("Password: " + p.getPassword());
                Console.WriteLine();
            }
            
        }
    }
}
