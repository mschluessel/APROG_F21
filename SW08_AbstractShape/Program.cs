using System;

namespace SW08_AbstractShape {
    class Program {
        static void Main(string[] args) {

            Shape s1 = new Circle(4); // initialize diameter (d)
            Shape s2 = new Rectangle(4, 3); // intialize dimension (w x h)
            Shape s3 = new Square(3, 3, 3);

            //Shape s3 = new Shape();

            ShapeContainer sc = new ShapeContainer();

            sc.Add(s1);
            sc.Add(s2);
            sc.Add(s3);

            sc.DrawAll();

            Console.WriteLine($"The area of s1 is {s1.Area}");
            Console.WriteLine($"The area of s2 is {s2.Area}");
            Console.WriteLine($"The area of s3 is {s3.Area}");

            if (s1.IsSmallerThan(s2)) {
                Console.WriteLine("s1 is smaller than s2");
            }
            else {
                Console.WriteLine("s1 is bigger than s2");
            }

            if (s3.IsSmallerThan(s2)) {
                Console.WriteLine("s3 is smaller than s2");
            }
            else {
                Console.WriteLine("s3 is bigger than s2");
            }

            Console.WriteLine($"The sum of all areas is {sc.SumAll()}");
        }
    }
}