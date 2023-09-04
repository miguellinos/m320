using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_03
{
    class Calculator
    {
        private int lastResult = 0;

        public int Addiere(int a, int b)
        {
            lastResult = a + b;
            return lastResult;
        }

        public int Subtrahiere(int a, int b)
        {
            lastResult = a - b;
            return lastResult;
        }

        public int Multipliziere(int a, int b)
        {
            lastResult = a * b;
            return lastResult;
        }

        public int Dividiere(int a, int b)
        {
            if (b != 0)
            {
                lastResult = a / b;
                return lastResult;
            }
            else
            {
                Console.WriteLine("Division mit 0 ist unmöglich.");
                return lastResult;
            }
        }

        public int GetLastResult()
        {
            return lastResult;
        }
        public int PerformOperation(int operand)
        {
            // Verwenden Sie das vorherige Ergebnis (lastResult) als ersten Operanden
            int result = operand + lastResult;
            lastResult = result;
            return result;
        }

       
    }
    
}

