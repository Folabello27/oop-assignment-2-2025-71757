using System;

namespace oop_assignment_2_2025_71757.Models
{
    public class ExamQuestion_2
    {
        public void Run()
        {
            Console.WriteLine(SafeDivide(10, 0));
            Console.WriteLine(ParseInt("abc"));
            Console.WriteLine(RegisterUser(15));
        }

        public string SafeDivide(int a, int b)
        {
            try
            {
                int result = a / b;
                return result.ToString();
            }
            catch (DivideByZeroException)
            {
                return "Cannot divide by zero.";
            }
        }

        public string ParseInt(string input)
        {
            try
            {
                int result = int.Parse(input);
                return result.ToString();
            }
            catch (FormatException)
            {
                return "Invalid number entered.";
            }
        }

        public string RegisterUser(int age)
        {
            try
            {
                if (age < 18)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return "Registration successful.";
            }
            catch (ArgumentOutOfRangeException)
            {
                return "User must be at least 18 to register.";
            }
        }
    }
}