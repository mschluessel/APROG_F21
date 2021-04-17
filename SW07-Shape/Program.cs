using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW07_Shape
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle();
            c.Move(1, 2);
            c.ChangeDimension(4);

            Circle c2 = new Circle(8, 3, 4);

            Rectangle r = new Rectangle();
            r.Move(3, 4);
            r.ChangeDimension(5, 7);

            Shape s = new Shape();
            s.Move(-3, 6);

            Square sq = new Square(4);
            sq.Move(5, 8);

            EquilateralTriangle t = new EquilateralTriangle();
            t.Move(2, 5);
            t.ChangeSideLength(15);

            EquilateralTriangle t2 = new EquilateralTriangle(14);
            t2.Move(3, 6);

            EquilateralTriangle t3 = new EquilateralTriangle(13, 4, 7);

            ShapeContainer sc = new ShapeContainer();
            sc.Add(c);
            sc.Add(c2);
            sc.Add(r);
            sc.Add(s);
            sc.Add(sq);
            sc.Add(t);
            sc.Add(t2);
            sc.Add(t3);

            sc.DrawAll();

            Console.ReadKey();
        }
    }
}
