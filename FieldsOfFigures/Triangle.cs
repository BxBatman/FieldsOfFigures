using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldsOfFigures
{
    class Triangle : Polygon
    {
        private double length;
        public Triangle(int num,double length) : base(num,length)
        {
            this.length = length;
            
        }

        override
        public double calculateArea()
        {   
            double calculation = Math.Pow(length, 2) * Math.Sqrt(3)/4;
            calculation = Math.Round(calculation, 2);
            return calculation;
        }
    }
}
