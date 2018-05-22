using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldsOfFigures
{
    class Square : Figure
    {
        
        public double calculateField(double length)
        {
            double calculation = Math.Pow(length, 2);
            return calculation;
        }
    }
}
