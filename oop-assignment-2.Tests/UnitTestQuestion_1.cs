using Xunit;
using oop_assignment_2_2025_71757.Models;
using Assert = NUnit.Framework.Assert;

namespace oop_assignment_2.Tests
{
    public class UnitTestQuestion_1
    {
        [Fact]
        public void IsValidIrishMobile_ValidInput_ReturnsTrue()
        {
            var q1 = new ExamQuestion_1();
            Assert.True(q1.IsValidIrishMobile("0831234567"));
            Assert.True(q1.IsValidIrishMobile("0859876543"));
            Assert.True(q1.IsValidIrishMobile("0891122334"));
        }

        [Fact]
        public void IsValidIrishMobile_InvalidInput_ReturnsFalse()
        {
            var q1 = new ExamQuestion_1();
            Assert.False(q1.IsValidIrishMobile("0812345678")); 
            Assert.False(q1.IsValidIrishMobile("083 1234567")); 
            Assert.False(q1.IsValidIrishMobile("08312345678"));
        }

        [Fact]
        public void CalculateDiscount_ReturnsCorrectPercentage()
        {
            var q1 = new ExamQuestion_1();
            Xunit.Assert.Equal(0.05, q1.CalculateDiscount(1));
            Xunit.Assert.Equal(0.10, q1.CalculateDiscount(2));
            Xunit.Assert.Equal(0.0, q1.CalculateDiscount(0));
        }
    }
}