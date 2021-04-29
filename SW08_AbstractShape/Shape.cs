using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW08_AbstractShape {
    public abstract class Shape {
        protected int xPos;
        protected int yPos;

        public abstract double Area { get; }

        public Shape() {
            // Console.WriteLine( "in Shape()" );
        }

        public Shape( int x, int y ) {
            // Console.WriteLine( "in Shape(int, int)" );
            xPos = x;
            yPos = y;
        }

        public ConsoleColor Color { get; set; }

        public void Move( int xPos, int yPos ) {
            this.xPos = xPos;
            this.yPos = yPos;
        }

        public abstract void Draw();

        public bool IsSmallerThan(Shape s) {
            return (this.Area < s.Area);
        }

    } // end class Shape
} // end namspace
