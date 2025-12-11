using Xunit;
using System.Collections.Generic;
using oop_assignment_2_2025_71757.Models;

namespace oop_assignment_2.Tests
{
    public class UnitTestQuestion_3
    {
        [Fact]
        public void GetAverageRating_ValidList_ReturnsAverage()
        {
            var q3 = new ExamQuestion_3();
            var ratings = new List<int> { 5, 5, 5, 4 };
            double result = q3.GetAverageRating(ratings);
            Xunit.Assert.Equal(4.8, result);
        }

        [Fact]
        public void GetAverageRating_EmptyList_ReturnsZero()
        {
            var q3 = new ExamQuestion_3();
            var ratings = new List<int>();
            double result = q3.GetAverageRating(ratings);
            Xunit.Assert.Equal(0, result);
        }
    }
}