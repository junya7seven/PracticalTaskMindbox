using PracticalTaskMindbox.Shapes.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalTaskMindbox.Shapes
{
    public class Triangle : IShape
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }
        public double CalculateArea()
        {
            if (IsValidTriangle() || IsValidkSides()) return 0;

            double tringlePerimeter = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(tringlePerimeter * (tringlePerimeter - SideA) * (tringlePerimeter - SideB) * (tringlePerimeter - SideC));
        }
        public bool IsRightTriangle()
        {
            double[] sides = { SideA, SideB, SideC };
            Array.Sort(sides);
            double x = sides[0];
            double y = sides[1];
            double z = sides[2];
            return Math.Abs(x * x + y * y - z * z) < 1e-9;
        }
        private bool IsValidkSides()
        {
            return SideA <= 0 || SideB <= 0 || SideC <= 0;
        }
        private bool IsValidTriangle()
        {
            return SideA + SideB <= SideC || SideA + SideC <= SideB || SideB + SideC <= SideA;
        }
    }
}
