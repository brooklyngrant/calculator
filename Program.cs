using System;
using System.IO;

namespace Calculator
{

    class Calculator
    {
        public static double Calculate(double num1, double num2, string op)
        {
            double result = double.NaN;

            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    break;
            }

            return result;

        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            double num1 = 0; double num2 = 0;

            bool keepGoing = true;

            Console.WriteLine("C# Calculator");

            while (keepGoing)
            {
                Console.WriteLine("------------------------");

                string numInput1 = "";
                string numInput2 = "";
                double result = 0;
                double checkedNum1 = 0;
                double checkedNum2 = 0;

                Console.Write("Enter a number: "); // first number in calculator
                numInput1 = Console.ReadLine();

                while (!double.TryParse(numInput1, out checkedNum1))
                {
                    Console.Write("This is not valid input. Please enter a number: ");
                    numInput1 = Console.ReadLine();
                }

                Console.WriteLine("Choose an option by typing the symbol: "); // operation choosing
                Console.WriteLine("\t+ - Add");
                Console.WriteLine("\t- - Subtract");
                Console.WriteLine("\t* - Multiply");
                Console.WriteLine("\t/ - Divide");

                string op = Console.ReadLine();

                Console.Write("Enter another number: "); // second number in calculator
                numInput2 = Console.ReadLine();


                while (!double.TryParse(numInput2, out checkedNum2))
                {
                    Console.Write("This is not valid input. Please enter a number: ");
                    numInput2 = Console.ReadLine();
                }

                try
                {
                    result = Calculator.Calculate(checkedNum1, checkedNum2, op);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("This operation will result in a mathematical error. Start Over. \n");
                    }
                    else
                    {
                        Console.WriteLine("Your result: " + result);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("There was an error - " + e.Message);
                }

                Console.Write("\nEnter 'end' to close, or enter anything else to continue: ");
                if (Console.ReadLine() == "end")
                {
                    keepGoing = false;
                }


            }


            






        }
    }
}
