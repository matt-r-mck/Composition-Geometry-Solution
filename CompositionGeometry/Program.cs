using System;

namespace CompositionGeometry {
    class Program {
        static void Main(string[] args) {


            var quad1 = new Quadrillateral {
                Leg1 = 2, Leg2 = 4, Leg3 = 6, Leg4 = 8
            };
            quad1.GetPerimeter();

            var rect1 = new Rectangle(5, 7) {};
            rect1.GetPerimeter();
            rect1.GetArea();

            var sq1 = new Square(7) {};
            sq1.GetPerimeter();
            sq1.GetArea();

        }
    }
}
