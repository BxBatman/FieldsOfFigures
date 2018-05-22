using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldsOfFigures
{
    class Program
    {
        
       static void Main(string[] args)
        {
            PolygonFactory polygonFactory = new PolygonFactory();
            Polygon polygon = null;
            try
            {
               polygon = polygonFactory.createFigure(0, 0);
               Console.WriteLine(polygon.calculateArea());
            }
            catch (Exception e)
            {
               Console.WriteLine("Number of edges must be greater than 2"+"\n\n"+e.ToString());
            }

            Console.ReadLine();
            
        }
    }
}
