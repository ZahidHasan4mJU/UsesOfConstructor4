using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleApp
{
    class Circle
    {
        private double radius;


        public double Radius
        {
            set
            {
                radius = value;
            }
            get
            {
                return radius;
            }
        }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public double getDiameter()
        {
            return (2*radius);
        }

        public double getPerimeter()
        {
            return (2*Math.PI*radius);
        }

        public double getArea()
        {
            return (Math.PI*radius*radius);
        }
    }
}
