using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW08_AbstractShape {
    public class Circle : Shape {

        private int diameter;

        public Circle() { // implicitly calls base()
            // Console.WriteLine( "in Circle()" );
        }
        
        public Circle( int d ) : this( 0, 0, d ) { // constructor overloading
            // Console.WriteLine( "in Circle(int)" );
            diameter = d;
        }
        public Circle( int x, int y, int d ) : base( x, y ) { // calls base constructor
            // Console.WriteLine( "in Circle(int, int)" );
            diameter = d;
        }

        public void ChangeDimension( int newDiameter ) {
            diameter = newDiameter;
        }

        public override void Draw() {
            Console.WriteLine($"Draw Circle at pos ({xPos}|{yPos}) with a diameter of {diameter}");
        }

        public override double Area {
            get { return (diameter/2) * (diameter/2) * Math.PI; }
        }
    } // end class Circle
}