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
        List<string> input = new List<string> {};        
        string result = Likes(input.ToArray());
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

    static string Roman(int n)
	{
        Dictionary<int, string> romanMap = new Dictionary<int, string>()
        {
            { 1000, "M" },
            { 2000, "MM" },
            { 3000, "MMM" },
            { 900, "CM" },
            { 800, "DCCC" },
            { 700, "DCC" },
            { 600, "DC" },
            { 500, "D" },
            { 400, "CD" },
            { 300, "CCC" },
            { 200, "CC" },
            { 100, "C" },
            { 90, "XC" },
            { 80, "LXXX" },
            { 70, "LXX" },
            { 60, "LX" },
            { 50, "L" },
            { 40, "XL" },
            { 30, "XXX" },
            { 20, "XX" },
            { 10, "X" },
            { 9, "IX" },
            { 8, "VIII" },
            { 7, "VII" },
            { 6, "VI" },
            { 5, "V" },
            { 4, "IV" },
            { 3, "III" },
            { 2, "II" },
            { 1, "I" }
        };
		List<int> result = new List<int>();
        int divisor = 1;

        while (divisor <= n)
        {
            divisor *= 10;
        }
        divisor /= 10;

        while (divisor > 0)
        {
            int digit = n / divisor;
            if (digit > 0)
            {
                result.Add(digit * divisor);
            }
            n %= divisor;
            divisor /= 10;
        }

        string romanResult = string.Empty;
        foreach (int value in result)
        {
            romanResult += romanMap[value];
        }

        return romanResult;
	}

    static string Likes(string[] name)
    {
        if (name == null || name.Length == 0)
        {
            return "no one likes this";
        }
        else if (name.Length == 1)
        {
            return $"{name[0]} likes this";
        } 
        else if (name.Length == 2)
        {
            return $"{name[0]} and {name[1]} like this";
        }
        else if (name.Length == 3)
        {
            return $"{name[0]}, {name[1]} and {name[2]} like this";
        }
        else if (name.Length > 3)
        {
            return $"{name[0]}, {name[1]} and {name.Length - 2} others like this";
        }

        return string.Empty;
    }
}
