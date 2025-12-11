using System;
using System.Text.RegularExpressions;

namespace oop_assignment_2_2025_71757.Models
{
    public class ExamQuestion_1
    {
        public void Run()
        {
            Console.WriteLine("Testing Mobile: 0831234567 -> " + IsValidIrishMobile("0831234567"));
            Console.WriteLine("Testing Discount: Level 1 -> " + CalculateDiscount(1));
        }

        public bool IsValidIrishMobile(string number)
        {
            if (string.IsNullOrEmpty(number)) return false;
            string pattern = @"^08[359]\d{7}$";
            return Regex.IsMatch(number, pattern);
        }

        public double CalculateDiscount(int membershipLevel)
        {
            if (membershipLevel == 1) return 0.05;
            if (membershipLevel == 2) return 0.10;
            if (membershipLevel == 3) return 0.15;
            if (membershipLevel == 4) return 0.20;
            return 0.0;
        }
    }
}