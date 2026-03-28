using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.Write("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());

            string operation = "";
            bool validOperation = false;

            while (!validOperation)
            {
                Console.Write("Choose operation (+, -, *, /, %, =): ");
                operation = Console.ReadLine();

                if (operation == "=")
                {
                    Console.WriteLine("Program terminated.");
                    return; 
                }

                if (operation == "+" || operation == "-" || operation == "*" || 
                    operation == "/" || operation == "%")
                {
                    validOperation = true;
                }
                else
                {
                    Console.WriteLine("Incorrect Operation Used, please try again");
                }
            }

            object result = CalculatorLogic.Calculate(num1, num2, operation);


            if (result != null)
            {
                Console.WriteLine($"Result: {result}");
            }

            Console.WriteLine(); 
        }
    }
}