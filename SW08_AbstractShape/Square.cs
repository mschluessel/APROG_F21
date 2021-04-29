using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW08_AbstractShape {
    class Square:Rectangle {

        public Square(int w) : base(w, w) {}

        public Square(int x, int y, int w) : base(x, y, w, w) {}


        //following is useless since all is availabe in Rectangle

        //private int width;

        //public override double Area {
        //    get { return (width * width); }
        //}

        //public Square() {

        //}

        //public Square(int w) : base(0, 0) {
        //    width = w;
        //}

        //public Square( int x, int y, int w) : base(x, y) {
        //    width = w;
        //}

        //public void ChangeWidth(int w) {
        //    width = w;
        //}

        //public override void Draw() {
        //    Console.WriteLine($"Draw Square at pos ({xPos}|{yPos}) with a dimension of {width}x{width}");
        //}
    }
}