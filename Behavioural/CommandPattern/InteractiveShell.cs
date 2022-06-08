using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class InteractiveShell
    {
        public void Run()
        {
            var mathLib = new MathLib();
            var calculator = new Calculator();

            Console.WriteLine("Input math operation");
            Console.WriteLine("\t~: undo");
            Console.WriteLine("\tq:quit");
            Console.WriteLine();

            string input = Console.ReadLine();

            while (input != "q")
            {
                if (input.Length >= 2)
                {
                    string op = input.Substring(0, 1);
                    int arg = int.Parse(input.Substring(1));

                    if (op == "~")
                    {
                        for (int i = 0; i < arg; i++)
                        {
                            calculator.Undo();
                        }
                    } else {
                        AbstractOperation operation = new Operation(mathLib, op, arg);
                        calculator.Invoke(operation);
                    }
                }

                Console.WriteLine($"Result: {mathLib.Value}");
                input = Console.ReadLine();

            }

        }
    }
}
