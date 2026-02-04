using System;

class Program
{
    static string Evaluate(string expression)
    {
        if (string.IsNullOrWhiteSpace(expression))
            return "Error:InvalidExpression";

        var parts = expression.Split(' ');
        if (parts.Length != 3)
            return "Error:InvalidExpression";

        if (!int.TryParse(parts[0], out int a) || !int.TryParse(parts[2], out int b))
            return "Error:InvalidNumber";

        string op = parts[1];

        switch (op)
        {
            case "+":
                return (a + b).ToString();

            case "-":
                return (a - b).ToString();

            case "*":
                return (a * b).ToString();

            case "/":
                if (b == 0)
                    return "Error:DivideByZero";
                return (a / b).ToString();

            default:
                return "Error:UnknownOperator";
        }
    }

    static void Main()
    {
        Console.WriteLine(Evaluate("10 + 5"));   // 15
        Console.WriteLine(Evaluate("10 / 0"));   // Error:DivideByZero
        Console.WriteLine(Evaluate("x + 5"));    // Error:InvalidNumber
        Console.WriteLine(Evaluate("10 % 5"));   // Error:UnknownOperator
        Console.WriteLine(Evaluate("10+5"));     // Error:InvalidExpression
    }
}
