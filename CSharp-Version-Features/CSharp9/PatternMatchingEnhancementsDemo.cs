using System;

namespace CSharp9
{
    /// <summary>
    /// Demonstrates pattern matching enhancements in C# 9.
    /// </summary>
    public static class PatternMatchingEnhancementsDemo
    {
        /// <summary>
        /// Entry point to execute pattern matching examples.
        /// </summary>
        public static void Run()
        {
            int[] numbers = { -5, 3, 25, 150 };
            foreach (var number in numbers)
            {
                Console.WriteLine($"Number: {number}, Description: {DescribeNumber(number)}");
            }

            DayOfWeek[] days = { DayOfWeek.Monday, DayOfWeek.Saturday, DayOfWeek.Sunday };
            foreach (var day in days)
            {
                Console.WriteLine($"Day: {day}, Is Weekend: {IsWeekend(day)}");
            }
        }

        /// <summary>
        /// Categorizes a number based on its range.
        /// </summary>
        /// <param name="number">The number to categorize.</param>
        /// <returns>A string description of the number.</returns>
        static string DescribeNumber(int number) => number switch
        {
            < 0 => "Negative",
            >= 0 and <= 10 => "Small",
            > 10 and < 100 => "Medium",
            >= 100 => "Large"
        };

        /// <summary>
        /// Determines whether the given day is a weekend.
        /// </summary>
        /// <param name="day">The day of the week.</param>
        /// <returns>True if the day is a weekend, otherwise false.</returns>
        static bool IsWeekend(DayOfWeek day) => day is DayOfWeek.Saturday or DayOfWeek.Sunday;
    }
}
