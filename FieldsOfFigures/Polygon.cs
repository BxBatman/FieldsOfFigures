using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldsOfFigures
{
    class Polygon 
    {
        private int num;
        private double length;

        public Polygon(int num,double length)
        {
            this.num = num;
            this.length = length;
        }

        public virtual double calculateArea()
        {
            double calculation =( num* Math.Pow(length, 2))/(4*Math.Tan( Math.PI / num));
            calculation = Math.Round(calculation,2);
            return calculation;
        }
    }
}
