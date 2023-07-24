using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2_task_1
{
    internal class FindValues
    {
        public double Findarea(double r) 
        { 
            double Area = Math.PI * r *r;
            return Area;
        }
        public double FindCircumference(double r) 
        { 
            double circ= Math.PI * r *2;
            return circ;
        }
    }
}
