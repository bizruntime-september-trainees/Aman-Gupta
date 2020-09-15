using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorFunction
{
    public static class CalculatorFunctionProgram
    {
        public static int add(int a, int b)
        {
            int result = a + b;
            return result;
            //Console.WriteLine("sum: "+result);
        }
        public static int multiplication(int a, int b)
        {
            int result = a * b;
            return result;
            //Console.WriteLine("multiplication is: " + result);
        }
        public static void Main(String[] args)
        {
            Console.WriteLine("calculator");
        }
    }
}
