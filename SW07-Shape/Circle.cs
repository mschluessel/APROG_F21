using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW07_Shape {
    public class Circle : Shape {

        private int diameter;

        public Circle() {

        }

        public Circle(int d, int x, int y) : base(x, y) {
            diameter = d;
        }

        public void ChangeDimension(int newDiameter) {
            diameter = newDiameter;
        }

        public override void Draw() {
            Console.WriteLine($"Draw Circle at pos ({xPos}|{yPos}) with a diameter of {diameter}");
        }
    }
}
