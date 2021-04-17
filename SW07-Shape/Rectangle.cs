using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW07_Shape {
    public class Rectangle : Shape {
        private int width;
        private int height;

        public Rectangle() {

        }

        public Rectangle(int w, int h) {
            width = w;
            height = h;
        }

        public void ChangeDimension(int newWidth, int newHeight) {
            width = newWidth;
            height = newHeight;
        }

        public override void Draw() {
            Console.WriteLine($"Draw Rectangle at pos ({xPos}|{yPos}) with a dimension of {width}x{height}");
        }

    }
}
