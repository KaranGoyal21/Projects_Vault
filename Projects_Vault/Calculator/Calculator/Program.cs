using System;

namespace Calculator
{

    class CalculatorApp
    {

        static void Main(string[] args)
        {
            string continueCalculator = "";
            CalculatorLogic c = new CalculatorLogic();

            do
            {
                Console.Clear();
                DisplayOperations();
                double x = Convert.ToDouble(Console.ReadLine());

                c.AcceptValues();

                if (x == 1)
                {
                    double y = c.GetAddition();
                    //double y = c.GetAddition(5, 6);
                    Console.WriteLine("Addition of values are: {0}", y);
                }
                else if (x == 2)
                {
                    double y = c.GetSubtraction();
                    Console.WriteLine("Subtraction of values are: {0} ", y);
                }
                else if (x == 3)
                {
                    double y = c.GetMultiplication();
                    Console.WriteLine("Multiplication of values are: {0} ", y);
                }
                else if (x == 4)
                {
                    double y = c.GetDivision();
                    Console.WriteLine("Division of values are: {0} ", y);
                }

                ContinueOperation();
                continueCalculator = Console.ReadLine().ToLower();
                

            } while (continueCalculator == "y");

        }

        static void DisplayOperations()
        {
            Console.WriteLine("Select desired operation");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.Write("Operation Input: ");
        }

        static void ContinueOperation()
        {
            Console.WriteLine("\n\nDo you want to continue");
            Console.WriteLine("\nPress Y for yes :");
            Console.WriteLine("Press N for no :");
        }
    }
}
