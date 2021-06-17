﻿namespace Exercise2
{
    internal class Program
    {
        public abstract class AbstractTeacher
        {
            public string IndentityNumber { get; set; }
            public string Name { get; set; }
            public double BaseSalary { get; set; }
            public int Level { get; set; }
            public bool IsSenior { get; set; }
            public double Bonus { get; set; }

            public abstract double CalculateSalary();
        }
    }
}