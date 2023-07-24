using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2_task_1
//Question 2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FindValues newobj2 = new FindValues();
            Console.WriteLine("enter value");
            double radius=double.Parse(Console.ReadLine());
            double area=newobj2.Findarea (radius);
            double circum=newobj2.FindCircumference (radius);
            Console.WriteLine("the area is:" + area);
            Console.WriteLine("the circumference is:" + circum);
            Console.ReadKey();

        }
    }
}
