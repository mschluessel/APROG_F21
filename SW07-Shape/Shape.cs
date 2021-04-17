using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW07_Shape {
    public class Shape {

        protected int xPos;
        protected int yPos;

        public Shape() {

        }

        public Shape(int x, int y) {
            xPos = x;
            yPos = y;
        }

        public ConsoleColor Color { get; set; }

        public void Move(int newXPos, int newYPos) {
            xPos = newXPos;
            yPos = newYPos;
        }

        public virtual void Draw() {
            Console.WriteLine($"Draw Shape at pos ({xPos}|{yPos})");
        }

    }
}
