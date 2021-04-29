using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW08_AbstractShape {
    public class ShapeContainer {

        // ein Circle ist ein Shape (andersherum stimmt das nicht)
        private List<Shape> shapes = new List<Shape>();

        public void Add( Shape s ) {
            shapes.Add( s );
        }

        public void DrawAll() {
            foreach( Shape s in shapes ) {

                s.Draw();

                //if( s is Circle ) {
                //    Circle c = (Circle)s;
                //    c.Draw();
                //} else if( s is Rectangle ) {
                //    Rectangle r = (Rectangle)s;
                //    r.Draw();
                //} else {
                //    s.Draw();
                //}
            }


        } // end DrawAll()

        public double SumAll() {
            double sum = 0;
            foreach(Shape s in shapes) {
                sum += s.Area;
            }
            return sum;
        }

    } // end Main()
}
