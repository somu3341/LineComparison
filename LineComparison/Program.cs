﻿using System;
namespace LineComparison
{
    class Programm
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program");
            CalculateLength calculateLength1 = new CalculateLength(3,2,3,10);
            double line1= calculateLength1.Calculate();
            CalculateLength calculateLength2 = new CalculateLength(3,2,3,4);
            double line2= calculateLength2.Calculate();
            calculateLength2.CheckEquality(line1 , line2);
        }
    }
}