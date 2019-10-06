using System;

namespace StringCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var isCtrlC = false;
            Console.CancelKeyPress += (object sender, ConsoleCancelEventArgs e) =>
            {

                isCtrlC = e.SpecialKey == ConsoleSpecialKey.ControlC;
                if (isCtrlC)
                {
                    e.Cancel = true;
                }
            };

            Console.WriteLine("Please press Ctrl+C to close the Calculator console");
            do
            {
                while (!Console.KeyAvailable)
                {
                    Console.WriteLine("Enter maximum of 2 numbers using a comma delimiter to add numbers. For Example: 1,1 = 1+1=2:");
                    string number = "";
                    number = Convert.ToString(Console.ReadLine());
                    if (number.Length > 2)
                    {
                        Console.WriteLine("Error: Max number of string length must be is 2");
                        break;
                    }
                    int result = Calculator.AddNumber(number);
                    Console.WriteLine($"Result: {result}");
                }
            } while (true);

        }
    }
}
