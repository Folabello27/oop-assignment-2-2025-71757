using System;
using System.Collections.Generic;
using System.Linq;

namespace oop_assignment_2_2025_71757.Models
{
    public class ExamQuestion_3
    {
        public void Run()
        {
            var products = new List<(string Name, List<int> Ratings)>
            {
                ("Laptop", new List<int> { 5, 4, 4, 5, 3 }),
                ("Headphones", new List<int> { 4, 3, 5 }),
                ("Keyboard", new List<int> { 5, 5, 5, 4 }),
                ("Mouse", new List<int> { 3, 3, 4 })
            };

            ProcessProducts(products);
        }

        public void ProcessProducts(List<(string Name, List<int> Ratings)> products)
        {
            string topProduct = "";
            double highestAvg = -1;

            foreach (var product in products)
            {
                if (product.Ratings == null || product.Ratings.Count == 0)
                {
                    Console.WriteLine($"{product.Name}: No ratings available");
                    continue;
                }

                double average = product.Ratings.Average();
                Console.WriteLine($"{product.Name}: Average Rating = {average:F1}");

                if (average > highestAvg)
                {
                    highestAvg = average;
                    topProduct = product.Name;
                }
            }

            if (!string.IsNullOrEmpty(topProduct))
            {
                Console.WriteLine($"The top-rated product is {topProduct} with an average rating of {highestAvg:F1}");
            }
        }
        
        public double GetAverageRating(List<int> ratings)
        {
            if (ratings == null || ratings.Count == 0) return 0;
            return Math.Round(ratings.Average(), 1);
        }
    }
}