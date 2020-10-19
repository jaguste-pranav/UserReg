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
            try
            {
                if(firstName.Equals(""))
                {
                    throw new UserRegCustomExceptions(UserRegCustomExceptions.ExceptionType.EMPTY_INPUT, "First Name cannot be empty");
                }
                if (Regex.IsMatch(firstName, firstNameReGex) == true)
                {
                    //Console.WriteLine("First Name " + firstName + " is valid");
                    return true;
                }
                else
                {
                    //Console.WriteLine("First Name " + firstName + " is not valid");
                    return false;
                }
            }
            catch (NullReferenceException)
            {
                throw new UserRegCustomExceptions(UserRegCustomExceptions.ExceptionType.NULL_INPUT, "First Name cannot be null");
            }
        }

        public bool checkLastName(string lastName)
        {
            try
            {
                if (lastName.Equals(""))
                {
                    throw new UserRegCustomExceptions(UserRegCustomExceptions.ExceptionType.EMPTY_INPUT, "Last Name cannot be empty");
                }

                if (Regex.IsMatch(lastName, lastNameReGex) == true)
                {
                    //Console.WriteLine("Last Name " + lastName + " is valid");
                    return true;
                }
                else
                {
                    //Console.WriteLine("Last Name " + lastName + " is not valid");
                    return false;
                }
            }
            catch (NullReferenceException)
            {
                throw new UserRegCustomExceptions(UserRegCustomExceptions.ExceptionType.NULL_INPUT, "Last Name cannot be null");
            }
        }

        public bool checkEmail(string emailId)
        {
            try
            {
                if (emailId.Equals(""))
                {
                    throw new UserRegCustomExceptions(UserRegCustomExceptions.ExceptionType.EMPTY_INPUT, "Email cannot be empty");
                }
                if (Regex.IsMatch(emailId, emailReGex) == true)
                {
                    //Console.WriteLine("Mail Id " + emailId + " is valid");
                    return true;
                }
                else
                {
                    //Console.WriteLine("Mail Id " + emailId + " is not valid");
                    return false;
                }
            }
            catch (NullReferenceException)
            {
                throw new UserRegCustomExceptions(UserRegCustomExceptions.ExceptionType.NULL_INPUT, "Email cannot be null");
            }
        }

        public bool checkPhone(string phoneNo)
        {
            try
            {
                if (phoneNo.Equals(""))
                {
                    throw new UserRegCustomExceptions(UserRegCustomExceptions.ExceptionType.EMPTY_INPUT, "Phone cannot be empty");
                }
                if (Regex.IsMatch(phoneNo, phoneRegex) == true)
                {
                    //Console.WriteLine("Phone No " + phoneNo + " is valid");
                    return true;
                }
                else
                {
                    //Console.WriteLine("Phone No " + phoneNo + " is not valid");
                    return false;
                }
            }
            catch (NullReferenceException)
            {
                throw new UserRegCustomExceptions(UserRegCustomExceptions.ExceptionType.NULL_INPUT, "Phone cannot be null");
            }
        }

        public bool checkPassword(string password)
        {
            try
            {
                if (password.Equals(""))
                {
                    throw new UserRegCustomExceptions(UserRegCustomExceptions.ExceptionType.EMPTY_INPUT, "Password cannot be empty");
                }
                if (Regex.IsMatch(password, passwordRegex))
                {
                    //Console.WriteLine("Password " + password + " is valid");
                    return true;
                }
                else
                {
                    //Console.WriteLine("Password " + password + " is not valid");
                    return false;
                }
            }
            catch (NullReferenceException)
            {
                throw new UserRegCustomExceptions(UserRegCustomExceptions.ExceptionType.NULL_INPUT, "Password cannot be null");
            }
        }
    }
}