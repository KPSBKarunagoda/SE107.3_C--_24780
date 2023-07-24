using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
   // Q1 task 1
{ 
    internal class ConvertValues
    {
        public void kilometerTOmeter()
        {
            double km, m;

            Console.WriteLine("Enter values in kilometers:  ");
            km = double.Parse(Console.ReadLine());

            m = km * 1000;

            Console.WriteLine("The meter value : " + m);
        }
    }
}
