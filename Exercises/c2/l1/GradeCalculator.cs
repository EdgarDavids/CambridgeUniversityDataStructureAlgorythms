﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.c2.l1
{
    public static class GradeCalculator
    {
        public static void Calculate() {
            Grade grade = new Grade(18, 39, 31, 10, 15, 20, 17);
            Console.WriteLine("Grade calculations for 18 39 31 10 15 20 17");
            Console.WriteLine("Average: {0}", grade.Average());
            Console.WriteLine("Highest: {0}", grade.Highest());
            Console.WriteLine("Lowest: {0}", grade.Lowest());
            Console.WriteLine();

        }
    }
}
