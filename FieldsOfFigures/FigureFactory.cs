using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldsOfFigures
{
    class FigureFactory
    {
        public Figure createFigure(int num)
        {
            Figure figure = null;
            switch (num)
            {
                case 3:
                    figure = new Triangle();
                    break;
                case 4:
                    figure = new Square();
                    break;
            }

            return figure;
        }
    }
}
