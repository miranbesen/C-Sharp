using System;

namespace WinProg_Week7_DelegateExamples
{
    class MathOperations
    {
        public static double MultiplyByTwo(double value)
        {
            return value * 2;
        }
        public static double Square(double value)
        {
            return value * value;
        }

    }

    delegate double DoubleOp(double x);
    class Program
    {
        static void Main(string[] args)
        {
            DoubleOp[] operations =
            {
                //MathOperations.MultiplyByTwo,
                //MathOperations.Square
                new DoubleOp(MathOperations.MultiplyByTwo),
                new DoubleOp(MathOperations.Square)
            };
            //Console.WriteLine(operations[0](4.0));
            //Console.WriteLine(operations[1](4.0));
            //processAndDisplayNumber(operations[0], 5.0);
            //processAndDisplayNumber(operations[1], 5.0);
            for (int i = 0; i < operations.Length; i++)
            {
                Console.WriteLine("using operations[{0}]:", i);
                processAndDisplayNumber(operations[i], 2.0);
                processAndDisplayNumber(operations[i], 3.0);

            }

        }


        static void processAndDisplayNumber(DoubleOp action,double value)
        {
            double result = action(value);
            Console.WriteLine("Value is {0},result of operations is {1}", value, result);
        }


    }
}
