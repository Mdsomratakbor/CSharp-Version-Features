using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp8
{
    /// <summary>
    /// This class demonstrates the usage of static and non-static local functions in C# 8.
    /// It includes:
    /// - **MultiplyWithInstanceFunction**: A method that uses a non-static local function.
    ///   The non-static function can access instance members like _factor.
    /// - **MultiplyWithStaticFunction**: A method that uses a static local function.
    ///   The static function cannot access instance members and requires external data to be passed explicitly.
    /// </summary>
    public static class StaticLocalFunctionDemo
    {


        /// <summary>
        /// The Run method demonstrates how both non-static and static local functions work.
        /// </summary>
        public static void Run()
        {
            Calculator calculator = new Calculator();
            int result1 = calculator.MultiplyWithInstanceFunction(10);
            Console.WriteLine($"Result with instance function: {result1}");

            int result2 = calculator.MultiplyWithStaticFunction(10);
            Console.WriteLine($"Result with static function: {result2}");
        }
    }

    public class Calculator
    {
        private int _factor = 5;

        /// <summary>
        /// This method uses a non-static local function.
        /// The non-static function can access instance members like _factor.
        /// </summary>
        public int MultiplyWithInstanceFunction(int number)
        {
            int MultiplyByFactor(int number) => number * _factor;

            return MultiplyByFactor(number);
        }

        /// <summary>
        /// This method uses a static local function.
        /// The static function cannot access instance members like _factor.
        /// </summary>
        public int MultiplyWithStaticFunction(int number)
        {
            static int MultiplyByFactor(int number, int factor) => number * factor;

            return MultiplyByFactor(number, _factor);
        }
    }
}
