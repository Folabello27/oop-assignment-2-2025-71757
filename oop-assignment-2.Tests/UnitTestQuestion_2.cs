using Xunit;
using oop_assignment_2_2025_71757.Models;

namespace oop_assignment_2.Tests
{
    public class UnitTestQuestion_2
    {
        [Fact]
        public void SafeDivide_DivideByZero_ReturnsErrorString()
        {
            var q2 = new ExamQuestion_2();
            string result = q2.SafeDivide(10, 0);
            Xunit.Assert.Equal("Cannot divide by zero.", result);
        }

        [Fact]
        public void ParseInt_InvalidString_ReturnsErrorString()
        {
            var q2 = new ExamQuestion_2();
            string result = q2.ParseInt("abc");
            Xunit.Assert.Equal("Invalid number entered.", result);
        }

        [Fact]
        public void RegisterUser_UnderAge_ReturnsErrorString()
        {
            var q2 = new ExamQuestion_2();
            string result = q2.RegisterUser(15);
            Xunit.Assert.Equal("User must be at least 18 to register.", result);
        }

        [Fact]
        public void RegisterUser_ValidAge_ReturnsSuccess()
        {
            var q2 = new ExamQuestion_2();
            string result = q2.RegisterUser(25);
            Xunit.Assert.Equal("Registration successful.", result);
        }
    }
}