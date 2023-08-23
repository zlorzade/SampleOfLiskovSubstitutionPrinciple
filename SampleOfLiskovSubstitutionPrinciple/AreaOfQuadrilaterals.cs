using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleOfLiskovSubstitutionPrinciple
{
    public class AreaOfQuadrilaterals
    {
        //polymorphism
        public static void GetArea(Quadrilaterals quadrilaterals)
        {
            var area = quadrilaterals.CalculateArea();
            Console.WriteLine(area);
        }
    }
}
