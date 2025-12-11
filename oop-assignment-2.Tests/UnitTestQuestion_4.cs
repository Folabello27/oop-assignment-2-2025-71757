using Xunit;
using oop_assignment_2_2025_71757.Models;

namespace oop_assignment_2.Tests
{
    public class UnitTestQuestion_4
    {
        [Fact]
        public void PadNumber_Integer_ReturnsPaddedString()
        {
            var q4 = new ExamQuestion_4();
            Xunit.Assert.Equal("00042", q4.PadNumber(42));
            Xunit.Assert.Equal("12345", q4.PadNumber(12345));
        }

        [Fact]
        public void FormatCurrency_Double_ReturnsFormattedCurrency()
        {
            var q4 = new ExamQuestion_4();
            string result = q4.FormatCurrency(1234.5);
            Xunit.Assert.Contains("€", result);
            Xunit.Assert.Contains("1,234.50", result);
        }
    }
}