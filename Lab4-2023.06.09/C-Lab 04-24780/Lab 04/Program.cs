using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculateValues Calculate=new CalculateValues();

            Console.WriteLine("enter 2 numbers ");
            int num1=int.Parse(Console.ReadLine());
            int num2=int.Parse(Console.ReadLine());


            Console.WriteLine("chose the operation");
            Console.WriteLine("enter 1 for addition");
            Console.WriteLine("enter 2 for substraction");
            Console.WriteLine("enter 3 for multiplication");
            Console.WriteLine("enter 4 for division");

            int choice=int.Parse(Console.ReadLine());

            double decimalvalue;
            int results;

            switch(choice)
            {
                case 1:
                    results = Calculate.add(num1, num2);
                    Console.WriteLine("sum:" + results);
                    break;


                case 2:
                    results = Calculate.sub(num1, num2);
                    Console.WriteLine("difference:" + results);
                    break;

                case 3:
                    results = Calculate.multiply(num1, num2);
                    Console.WriteLine("multiplication:" + results);
                    break;

                case 4:
                    decimalvalue = Calculate.division(num1, num2);
                    Console.WriteLine("division:" + decimalvalue);
                    break;


                default: 
                    Console.WriteLine("invalid choce!");
                    break;
            }
               Console.ReadKey();
     
        }
    }
}
