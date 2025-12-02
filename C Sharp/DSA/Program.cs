using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== DSA Training ===");
        Solve();
    }

    static void Solve()
    {
        string input = "hello_world";
        string result = ToCamelCase(input);
        Console.WriteLine(result);
    }

    static string ToCamelCase(string str)
    {
        string removed = str.Replace("-", "")
                  .Replace("_", "");
        return removed;
    }

    static int Solution(int value)
    {
        int num1 = 3;
        int num2 = 5;
        int counter = 1;
        List<int> numArr = new List<int>();

        while (num1 * counter <= value || num2 * counter <= value)
        {
            int prod1 = num1 * counter;
            int prod2 = num2 * counter;
            if (prod1 < value && !numArr.Contains(prod1))
            {
                numArr.Add(prod1);
            }
            if (prod2 < value && !numArr.Contains(prod2))
            {
                numArr.Add(prod2);
            }
            counter++;
        }

        int result = numArr.Sum();
        return result;
    }
}
