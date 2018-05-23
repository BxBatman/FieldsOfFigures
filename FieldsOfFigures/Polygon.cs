using System;
using System.Collections.Generic;
using System.IO;
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

        public virtual void writeToFile(double calc)
        {
            string path = "../../calc.txt";
            if(!File.Exists(path))
            {
                var myFile = File.Create(path);
                myFile.Close();
                Console.WriteLine("New file created ! (calc.txt)");
                TextWriter tw = new StreamWriter(path);
                tw.WriteLine(calc);
                Console.WriteLine("Calculation successfully saved!");
                tw.Close();
                
                

            }else if(File.Exists(path))
            {
                using (var tw = new StreamWriter(path, true))
                {
                    tw.WriteLine(calc);
                    Console.WriteLine("Calculation successfully saved!");
                    tw.Close();
                }
            }
        }
    }
}
