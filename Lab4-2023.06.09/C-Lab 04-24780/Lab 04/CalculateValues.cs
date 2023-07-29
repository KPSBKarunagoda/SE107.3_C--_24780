using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_04
{
    internal class CalculateValues
    {
       
        public int add(int a,int b) 
        {
            return a + b;
        }

        public int sub(int a, int b)
        {
            return a - b;
        }

        public int multiply(int a, int b)
        {
            return a * b;
        }

        public double division(int a, int b)
        {
            if(a == 0)
            {
                Console.WriteLine("error: divisible bye 0");
                return 0;
            }
            return (double) a / b;
        }


    }
}
