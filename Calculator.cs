using System;

public class Calculator 
{

    public static object Calculate(int n1, int n2, string op)
    {
        switch (op)
        {
            case "+":
                return n1 + n2;
            case "-":
                return n1 - n2;
            case "*":
                return n1 * n2;
            case "/":
                if (n2 == 0) {
                    Console.WriteLine("Cannot divide by zero");
                    return null;
                }
                return (double)n1 / n2;
            case "%":
                if (n2 == 0) {
                    Console.WriteLine("Cannot modulo by zero");
                    return null;
                }
                return n1 % n2;
            default:
                return null;
        }
    }
}