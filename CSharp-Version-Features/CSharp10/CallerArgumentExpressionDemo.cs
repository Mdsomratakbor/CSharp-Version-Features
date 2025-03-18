using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharp10
{
    public static class CallerArgumentExpressionDemo
    {
        public static void Run()
        {
            int number = 10;
            CheckCondition(number > 20, "The number should be greater than 20");
        }
        static void CheckCondition(bool condition, string message,
        [CallerArgumentExpression("condition")] string? conditionText = null)
        {
            if (!condition)
            {
                Console.WriteLine($"Assertion failed: {conditionText}");
                Console.WriteLine($"Message: {message}");
            }
        }
    }
}
