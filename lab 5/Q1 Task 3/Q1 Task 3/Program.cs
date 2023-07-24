using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1_Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConvertValues objConvertValues = new ConvertValues();

            Console.WriteLine("Enter values in kilometers: ");
            double kilometers = double.Parse(Console.ReadLine());

            double meters = objConvertValues.KilometerToMeter(kilometers);

            Console.WriteLine("The meter value: " + meters);

            Console.ReadKey();
        }
    }
}
