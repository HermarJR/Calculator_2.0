using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("*************");
        Console.WriteLine("CALCULATOR");
        Console.WriteLine("*************");
        
            double num1, num2, result;
        string op;
        bool tryAgain = true;
        string again;

        while (tryAgain)
        {
            Console.Write("Enter first Num: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Second Num: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter your Operator: ADD (+) SUB (-) MULTI (*) DIV (/) MOD (%)");
            op = Console.ReadLine();



            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    Console.WriteLine($"{num1} + {num2} = {result} ");
                    break;
                case "-":
                    result = num1 - num2;
                    Console.WriteLine($"{num1} - {num2} = {result} ");
                    break;
                case "*":
                    result = num1 * num2;
                    Console.WriteLine($"{num1} * {num2} = {result} ");
                    break;
                case "/":
                    result = num1 / num2;
                    Console.WriteLine($"{num1} / {num2} = {result} ");
                    break;
                case "%":
                    result = num1 % num2;
                    Console.WriteLine($"{num1} % {num2} = {result} ");
                    break;
                default:
                    Console.WriteLine("Invalid Operator!!!!!!");
                    break;
            }

            Console.Write("Would you like to try again? (Y/N): ");
            again = Console.ReadLine();
            again = again.ToUpper();

            if (again == "Y")
            {
                tryAgain = true;
            }
            else
            {
                tryAgain = false;
            }
        }

        Console.ReadKey();
    }
}


