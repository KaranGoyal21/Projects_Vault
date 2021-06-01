using System;

namespace Calculator
{
    class CalculatorLogic
    {

        double value1;
        double value2;

        public void AcceptValues()
        {
            //value1 = 5;
            //value2 = 10;
            Console.Write("Value1 Input: ");
            value1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Value2 Input: ");
            value2 = Convert.ToDouble(Console.ReadLine());
        }

        public double GetAddition()
        {
            return value1 + value2;
        }

        public double GetAddition(double val1, double val2)
        {
            return val1 + val2;
        }

        public double GetSubtraction()
        {
            return value1 - value2;
        }

        public double GetMultiplication()
        {
            return value1 * value2;
        }

        public double GetDivision()
        {
            return value1 / value2;
        }

        



    }


}
