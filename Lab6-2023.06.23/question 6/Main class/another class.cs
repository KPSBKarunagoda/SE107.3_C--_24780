using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anotherclass

{
    internal class Class1
    {
        
    public int[] CreateArray(int size)
        {
            int[] array = new int[size];
            return array;
        }

        public void TakeUserInputs(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Enter a value: ");
                int value = Convert.ToInt32(Console.ReadLine());
                array[i] = value;
                Console.WriteLine("User input: {0}, 0", value);
            }
        }
    }
}

