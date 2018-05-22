using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldsOfFigures
{
    class PolygonFactory
    {
        public Polygon createFigure(int num,double length)
        {
            Polygon polygon = null;

            if(num < 3)
            {
                throw new InvalidNumberOfEdges();
            }

            switch (num)
            {
                case 3:
                    polygon = new Triangle(num,length);
                    break;
                case 4:
                    polygon = new Square(num,length);
                    break;
                default:
                    polygon = new Polygon(num, length);
                    break;
            }

            return polygon;
        }
    }
}
