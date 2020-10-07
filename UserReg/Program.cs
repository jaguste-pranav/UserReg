using System;

namespace UserReg
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration");
            Pattern pattern = new Pattern();
            pattern.checkFirstName();
            pattern.checkLastName();
        }
    }
}
