using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
    //Q1-task 2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConvertValues objConvertValues = new ConvertValues();
            Console.WriteLine("Enter values in kilometers: ");
            double kilometers = double.Parse(Console.ReadLine());
            objConvertValues.KilometerToMeter(kilometers);
            Console.ReadKey();

        }
    }
}
