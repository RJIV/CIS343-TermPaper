using System;

namespace SampleCalculator
{
    public class Calculator
    {
        public Calculator()
        {
            List<float> tally = new List<float>();
            float x, y;
            string mathOperator;
        }

        public static void main(string[] args)
        {
            Console.WriteLine("Please enter values that you wish to compute.");
            string userInput = Console.ReadLine();
            string[] seperatedInput = userInput.Split(null);
            x = float.Parse(seperatedInput[0]);
            y = float.Parse(seperatedInput[2]);
            mathOperator = seperatedInput[1];

            compute(x, mathOperator, y);
        }



        public void compute(float x, string mathOperator, float y)
        {
            switch (mathOperator)
            {
                case "+":
                    float sum = add(x, y);
                    Console.WriteLine(x + " + " + y + " = " + sum);
                    tally.Add(sum);
                    break;
                case "-":
                    float sum = subtract(x, y);
                    Console.WriteLine(x + " - " + y + " = " + sum);
                    tally.Add(sum);
                    break;
                case "*":
                    float sum = add(x, y);
                    Console.WriteLine(x + " * " + y + " = " + sum);
                    tally.Add(sum);
                    break;
                case "/":
                    float sum = add(x, y);
                    Console.WriteLine(x + " / " + y + " = " + sum);
                    tally.Add(sum);
                    break;
                default:
                    Console.WriteLine("Default");
                    break;
            }
        }

        public float add(float x, float y)
        {
            float sum = x + y;
            return sum;
        }

        public float subtract(float x, float y)
        {
            float sum = x - y;
            return sum;
        }

        public float multiply(float x, float y)
        {
            float sum = x * y;
            return sum;
        }

        public float divide(float x, float y)
        {
            if (y == 0)
            {
                Console.WriteLine("Cannot divide by zero.");
                return null;
            }
            else
            {
                float sum = x / y;
                return sum;
            }
        }

        public void quit()
        {
            Console.WriteLine("Are you sure you want to quit? (y/n)");
            char decision = Console.ReadLine();
            decision.ToLower();
            if (decision == "y")
            {
                exit();
            }
        }
    }
}