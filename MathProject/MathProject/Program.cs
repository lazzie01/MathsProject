using MathProject.Algorithms;
using System;

namespace MathProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            var result = Maths.FindPrimes(1, int.MaxValue);

            Console.WriteLine($"prime number count: {result}");
        }
    }
}
