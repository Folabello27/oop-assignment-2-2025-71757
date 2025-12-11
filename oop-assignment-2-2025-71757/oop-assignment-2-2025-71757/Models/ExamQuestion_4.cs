using System;
using System.Globalization;

namespace oop_assignment_2_2025_71757.Models
{
    public class ExamQuestion_4
    {
        public void Run()
        {
            Console.WriteLine(PadNumber(42));
            Console.WriteLine(FormatCurrency(1234.5));
        }

        public string PadNumber(int number)
        {
            return number.ToString("D5");
        }

        public string FormatCurrency(double amount)
        {
            return amount.ToString("C2", CultureInfo.CreateSpecificCulture("en-IE"));
        }
    }
}