﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserReg
{
    class Pattern
    {
        string firstNameReGex = "^[A-Z][a-z]{2,}$";
        string lastNameReGex = "^[A-Z][a-z]{2,}$";

        public void checkFirstName()
        {
            Console.WriteLine("Enter your First Name: ");
            string firstName = Console.ReadLine();

            if (Regex.IsMatch(firstName, firstNameReGex) == true)
            {
                Console.WriteLine("First Name " + firstName + " is valid");
            }
            else
            {
                Console.WriteLine("First Name " + firstName + " is not valid");
            }
        }

        public void checkLastName()
        {
            Console.WriteLine("Enter your Last Name: ");
            string lastName = Console.ReadLine();

            if (Regex.IsMatch(lastName, lastNameReGex) == true)
            {
                Console.WriteLine("Last Name " + lastName + " is valid");
            }
            else
            {
                Console.WriteLine("Last Name " + lastName + " is not valid");
            }
        }
    }
}