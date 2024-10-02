using PracticalTaskMindbox.Shapes.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalTaskMindbox.Shapes
{
    public class Circle : IShape
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public double CalculateArea()
        {
            if (Radius < 0)
            {
                return 0;
            }
            return Math.PI * Radius * Radius;
        }
    }
}
