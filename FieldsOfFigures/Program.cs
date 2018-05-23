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
            int num = 0;
            double length = 0;
            bool isWriteToFile = false;
            if (args.Length == 3)
            {
                try
                {
                    num = Convert.ToInt16(args[0]);
                }catch(FormatException e)
                {
                    Console.WriteLine("[1st argument] Number of edges must be type of integer" + "\n\n");
                }


                try
                {
                    length = Convert.ToDouble(args[1]);
                }catch(FormatException e)
                {
                    Console.WriteLine("[2nd argument] Length must be type of double" + "\n\n");
                }


                try
                {
                    isWriteToFile = Convert.ToBoolean(args[2]);
                    
                }catch(FormatException e)
                {
                    Console.WriteLine("[3rd argument] 3rd argument is invalid \nIf you want to write to file type true if not false \nDefault is false");
                }



           

            PolygonFactory polygonFactory = new PolygonFactory();
            Polygon polygon = null;

                try
                {
                    polygon = polygonFactory.createPolygon(num, length);

                    if (isWriteToFile)
                    {
                        polygon.writeToFile(polygon.calculateArea());
                    }
                    else if (!isWriteToFile)
                    {
                        Console.WriteLine(polygon.calculateArea());
                    }



                }
                catch(InvalidNumberOfEdges)
                {
                    Console.WriteLine("Number of edges must be greater than 2");
                }

            }
            else
            {
                Console.WriteLine("Not enough parameters\n(Must be three: num-integer, length-double, isWriteToFile-bool)");
            }

            Console.ReadLine();
            
        }
    }
}
