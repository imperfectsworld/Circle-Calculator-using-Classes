using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Lab
{
    internal class Circle
    {
        //properties

        private double Radius { get; set; }

        //constructor

        public Circle(double _radius)
        {
            Radius = _radius;
        
        }
        //methods

        public double CalculateDiameter()
        {
            return 2 * Radius;
        }

        public double Grow()
        {
            return Radius *= 2;
        }

        public double GetRadius()
        {
            return Radius;
        }

        public double CalculateCircumfrence()
        {
            return 2 * Math.PI * Radius;
        }

        public double CalculateArea()
        {
            return Math.PI * (Radius * Radius);
        }





    }
}
