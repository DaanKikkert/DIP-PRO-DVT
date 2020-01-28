using System;

namespace Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            float answer = 0;
            string firstNum = Console.ReadLine();
            string calcType = Console.ReadLine();
            string secondNum = Console.ReadLine();
            float first = float.Parse(firstNum);
            float second = float.Parse(secondNum);

            if (calcType == "+")
            {
                answer = calcAdd(first, second);
            }
            else if (calcType == "-")
            {
                answer = calcSub(first , second);
            }
            else if (calcType == "/")
            {
                answer = divide(first, second);
            }
            else if (calcType == "*")
            {
                answer = multiply(first, second);
            }
            else if (calcType == "modullo")
            {
                answer = modullo(first, second);
            }

            float calcAdd(float a, float b)
            {
                return a + b;
            }

            float calcSub(float a, float b)
            {
                return a - b;
            }

            float divide(float a, float b)
            {
                return a / b;
            }

            float multiply(float a, float b)
            {
                return a * b;
            }

            float modullo(float a, float b)
            {
                return a % b;
            }

            Console.WriteLine( answer );
        }
    }
}
