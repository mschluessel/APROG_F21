using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW08_AbstractShape {
    public class Rectangle : Shape {

        private int width;
        private int height;

        public Rectangle() { // implicitly calls base()
            // Console.WriteLine( "in Rectangle()" );
        }

        public Rectangle( int w, int h ) : this( 0, 0, w, h ) { // constructor overloading
            // Console.WriteLine( "in Rectangle( int, int )" );
        }
        public Rectangle( int x, int y, int w, int h ) : base( x, y ) { // calls base constructor
            // Console.WriteLine( "in Rectangle( int, in, int, int )" );
            this.width = w;
            this.height = h;
        }

        public void ChangeDimension( int newWidth, int newHeight ) {
            width = newWidth;
            height = newHeight;
        }

        public override void Draw() {
            Console.WriteLine( $"Draw Rectangle at pos ({xPos}|{yPos}) with a dimension of {width}x{height}" );
        }

        public override double Area {
            get { return (width * height); }
        }
    }
}
