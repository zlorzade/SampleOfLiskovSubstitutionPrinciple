// See https://aka.ms/new-console-template for more information
using SampleOfLiskovSubstitutionPrinciple;

Console.WriteLine("....");
Console.WriteLine("Area of rectangle is : ");
Quadrilaterals rec = new Rectangle(4, 6);
AreaOfQuadrilaterals.GetArea(rec);

Console.WriteLine("Area of Square is : ");
Quadrilaterals squ = new Square(4);
AreaOfQuadrilaterals.GetArea(squ);



