using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW07_Shape {
    public class ShapeContainer {

        private List<Shape> shapes = new List<Shape>();

        //private List<Rectangle> rectangles = new List<Rectangle>();
        //private List<Circle> circles = new List<Circle>();

        public void Add(Shape s) {
            shapes.Add(s);
        }

        public void DrawAll() {
            foreach (Shape s in shapes) {

                s.Draw();

                //if (s is Circle) {              //cast zu circle und zeichnen in einem command
                //    ((Circle)s).Draw();
                //}
                //else if (s is Rectangle) {      //cast zu rectangle und dann Zeichnen
                //    Rectangle r = (Rectangle)s;
                //    r.Draw();
                //}
                //else {
                //    //error
                //}

                //s.Draw();                     //kann nicht mehr verwendet werden da zuerst gecastet werden muss
            }
        }
    }
}