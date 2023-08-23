using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleOfLiskovSubstitutionPrinciple
{
    public class Square : Quadrilaterals
    {
        private readonly int _size;

        public Square(int size)
        {
            _size = size;
        }


        public override int CalculateArea()
        {
            return _size * _size;
        }
    }
}
