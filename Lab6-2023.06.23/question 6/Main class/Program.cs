using anotherclass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of the array: ");
            int size = Convert.ToInt32(Console.ReadLine());

            Class1 obj = new Class1();
            int[] array = obj.CreateArray(size);
            obj.TakeUserInputs(array);

            Console.WriteLine("Values inside the array:");
            foreach (int value in array)
            {
                Console.Write(value + " ");
            }

            Console.ReadLine();
        }
    }
    }

