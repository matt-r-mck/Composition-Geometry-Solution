using System;
using System.Collections.Generic;
using System.Text;

namespace CompositionGeometry {
    public class Rectangle { //does not inherit quad

        private Quadrillateral quad = new Quadrillateral(); // creates a var quad type Quadrillateral

        public void GetPerimeter() {
            quad.GetPerimeter();
        }

        public void GetArea() {
            Console.WriteLine($"The Area is {quad.Leg1 * quad.Leg2}"); 
        }

        public Rectangle(int l1, int l2) { //takes user entered parameters, sets them to legs
            quad.Leg1 = l1;
            quad.Leg3 = l1;
            quad.Leg2 = l2;
            quad.Leg4 = l2;
        }

    }
}
