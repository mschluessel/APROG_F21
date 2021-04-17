using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW07_Shape {
    class Square: Shape {

        private int width;

        public Square() {

        }

        public Square(int w) : base(1, 1) {
            width = w;
        }

        public void ChangeWidth(int w) {
            width = w;
        }

        public override void Draw() {
            Console.WriteLine($"Draw Square at pos ({xPos}|{yPos}) with a dimension of {width}x{width}");
        }
    }
}
