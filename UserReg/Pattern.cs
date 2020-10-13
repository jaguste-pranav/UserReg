using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserReg
{
    public class Pattern
    {
        string firstNameReGex = "^[A-Z][a-z]{2,}$";
        string lastNameReGex = "^[A-Z][a-z]{2,}$";
        string emailReGex = "^[a-z0-9A-Z]+([._+-][a-z0-9A-Z]+)*[@][a-z0-9A-Z]+[.][a-zA-Z]{2,3}(.[a-zA-Z]{2})?$";
        string phoneRegex = "^[1-9][0-9]{1}[ ][1-9]{1}[0-9]{9}$";
        string passwordRegex = "((?=.*[A - Z])(?=.*[0 - 9])(?= ^[a - zA - Z0 - 9] *[@$#^!-+][a-zA-Z0-9]*$)).{8,}";

        public bool checkFirstName(string firstName)
        {
            if (Regex.IsMatch(firstName, firstNameReGex) == true)
            {
                Console.WriteLine("First Name " + firstName + " is valid");
                return true;
            }
            else
            {
                Console.WriteLine("First Name " + firstName + " is not valid");
                return false;
            }
        }

        public bool checkLastName(string lastName)
        {
            if (Regex.IsMatch(lastName, lastNameReGex) == true)
            {
                Console.WriteLine("Last Name " + lastName + " is valid");
                return true;
            }
            else
            {
                Console.WriteLine("Last Name " + lastName + " is not valid");
                return false;
            }
        }

        public bool checkEmail(string emailId)
        {
            if (Regex.IsMatch(emailId, emailReGex) == true)
            {
                Console.WriteLine("Mail Id " + emailId + " is valid");
                return true;
            }
            else
            {
                Console.WriteLine("Mail Id " + emailId + " is not valid");
                return false;
            }
        }

        public bool checkPhone(string phoneNo)
        {
            if (Regex.IsMatch(phoneNo, phoneRegex) == true)
            {
                Console.WriteLine("Phone No " + phoneNo + " is valid");
                return true;
            }
            else
            {
                Console.WriteLine("Phone No " + phoneNo + " is not valid");
                return false;
            }
        }

        public bool checkPassword(string password)
        {
            if (Regex.IsMatch(password, passwordRegex))
            {
                Console.WriteLine("Password " + password + " is valid");
                return true;
            }
            else
            {
                Console.WriteLine("Password " + password + " is not valid");
                return false;
            }
        }
    }
}