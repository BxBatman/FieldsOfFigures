using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldsOfFigures
{
    class Square : Polygon
    {
        private double length;
        public Square(int num,double length) : base(num,length)
        {
            this.length = length;
        }

        override
            public double calculateArea()
        {
            double calculation = Math.Pow(length,2);
            calculation = Math.Round(calculation, 2);
            return calculation;
        }
    }
}
