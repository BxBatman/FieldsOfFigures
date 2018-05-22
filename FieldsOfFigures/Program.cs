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
            FigureFactory figureFactory = new FigureFactory();
            Figure figure = figureFactory.createFigure(4);
            Console.WriteLine(figure.calculateField(3));
            Console.ReadLine();
            
        }
    }
}
