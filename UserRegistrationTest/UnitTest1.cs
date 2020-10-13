using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserReg;

namespace UserRegistrationTest
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void Validate_FirstName_Given_Valid_First_Name()
        {
            //Arrange
            Pattern pattern = new Pattern();
            string firstName = "Abc";
            //Act
            bool output = pattern.checkFirstName(firstName);
            //Assert
            Assert.AreEqual(true, output);
        }
        [TestMethod]
        public void Validate_FirstName_Given_Invalid_First_Name()
        {
            //Arrange
            Pattern pattern = new Pattern();
            string firstName = "abc";
            //Act
            bool output = pattern.checkFirstName(firstName);
            //Assert
            Assert.AreEqual(false, output);
        }

        [TestMethod]
        public void Validate_LastName_Given_Valid_Last_Name()
        {
            //Arrange
            Pattern pattern = new Pattern();
            string lastName = "Xyz";
            //Act
            bool output = pattern.checkLastName(lastName);
            //Assert
            Assert.AreEqual(true, output);
        }
        [TestMethod]
        public void Validate_LastName_Given_Invalid_Last_Name()
        {
            //Arrange
            Pattern pattern = new Pattern();
            string lastName = "xyz";
            //Act
            bool output = pattern.checkLastName(lastName);
            //Assert
            Assert.AreEqual(false, output);
        }

        [TestMethod]
        public void Validate_Email_Given_Valid_Email()
        {
            //Arrange
            Pattern pattern = new Pattern();
            string email = "abc@gmail.com";
            //Act
            bool output = pattern.checkEmail(email);
            //Assert
            Assert.AreEqual(true, output);
        }
        [TestMethod]
        public void Validate_Email_Given_Invalid_Email()
        {
            Pattern pattern = new Pattern();
            string email = "abc@xyz@gmail.com";
            //Act
            bool output = pattern.checkEmail(email);
            //Assert
            Assert.AreEqual(false, output);
        }

        [TestMethod]
        public void Validate_Phone_Given_Valid_Phone()
        {
            //Arrange
            Pattern pattern = new Pattern();
            string phone = "91 9930386170";
            //Act
            bool output = pattern.checkPhone(phone);
            //Assert
            Assert.AreEqual(true, output);
        }
        [TestMethod]
        public void Validate_Phone_Given_Invalid_Phone()
        {
            Pattern pattern = new Pattern();
            string phone = "12345678912";
            //Act
            bool output = pattern.checkPhone(phone);
            //Assert
            Assert.AreEqual(false, output);
        }

        [TestMethod]
        public void Validate_Password_Given_Valid_Password()
        {
            //Arrange
            Pattern pattern = new Pattern();
            string password = "Hello@World1";
            //Act
            bool output = pattern.checkPassword(password);
            //Assert
            Assert.AreEqual(true, output);
        }
        [TestMethod]
        public void Validate_Password_Given_Invalid_Password()
        {
            Pattern pattern = new Pattern();
            string password = "Hello@World";
            //Act
            bool output = pattern.checkPassword(password);
            //Assert
            Assert.AreEqual(false, output);
        }
    }
}
