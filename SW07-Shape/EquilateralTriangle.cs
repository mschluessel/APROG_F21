using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW07_Shape {
    class EquilateralTriangle : Shape {

        private int sideLength;

        public EquilateralTriangle() {

        }

        public EquilateralTriangle(int s) {
            sideLength = s;
        }

        public EquilateralTriangle(int s, int x, int y) : base(x, y) {
            sideLength = s;
        }

        public void ChangeSideLength(int s) {
            sideLength = s;
        }

        public override void Draw() {
            Console.WriteLine($"Draw Equilateral Triangle at pos ({xPos}|{yPos}) with a side length of {sideLength}");
        }
    }
}
