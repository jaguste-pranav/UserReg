using System;
using System.Collections.Generic;
using System.Text;

namespace UserReg
{
    class Person
    {
        private string fName, lName, email, phoneNumber, password;
        private bool fNameResult, lNameResult, emailResult, phoneNumberResult, passwordResult;


        public string getFirstName()
        {
            return this.fName;
        }
        public string getLastName()
        {
            return this.lName;
        }
        public string getEmail()
        {
            return this.email;
        }
        public string getPhone()
        {
            return this.phoneNumber;
        }
        public string getPassword()
        {
            return this.password;
        }

        public bool getFirstNameResult()
        {
            return this.fNameResult;
        }
        public bool getLastNameResult()
        {
            return this.lNameResult;
        }
        public bool getEmailResult()
        {
            return this.emailResult;
        }
        public bool getPhoneResult()
        {
            return this.phoneNumberResult;
        }
        public bool getPasswordResult()
        {
            return this.passwordResult;
        }

        public Person(string firstName, string lastName, string email, string phoneNumber, string password, bool firstNameResult, bool lastNameResult, bool emailResult, bool phoneNumberResult, bool passwordResult)
        {
            this.fName = firstName;
            this.lName = lastName;
            this.email = email;
            this.password = password;

            this.fNameResult = firstNameResult;
            this.lNameResult = lastNameResult;
            this.emailResult = emailResult;
            this.passwordResult = passwordResult;
        }
    }
}
