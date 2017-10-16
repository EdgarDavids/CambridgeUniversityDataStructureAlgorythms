using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.c2.l2
{
    public static class GradeCalculator
    {
        public static void Calculate() {
            Grade[] grades = new Grade[] {
                new Grade(18, 39, 31, 10, 15, 20, 17),
                new Grade(18, 53, 21, 10, 15, 20, 17)
            };

            Console.WriteLine("Grade calculations for 18 39 31 10 15 20 17");
            Console.WriteLine("Grade calculations for 18 53 21 10 15 20 17");

            foreach (Grade grade in grades)
            {
                Console.WriteLine("Average: {0}", grade.Average());
                Console.WriteLine("Highest: {0}", grade.Highest());
                Console.WriteLine("Lowest: {0}", grade.Lowest());
            }

        }
    }
}
