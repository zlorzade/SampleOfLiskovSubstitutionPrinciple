using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleOfLiskovSubstitutionPrinciple
{
    public class Rectangle : Quadrilaterals
    {
        private readonly int _width;
        private readonly int _length;

        public Rectangle(int width, int length)
        {
            _width = width;
            _length = length;
        }

        public override int CalculateArea()
        {
           return _width * _length;
        }
    }
}
