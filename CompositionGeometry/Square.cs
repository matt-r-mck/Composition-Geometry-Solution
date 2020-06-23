using System;
using System.Collections.Generic;
using System.Text;

namespace CompositionGeometry {
    public class Square {

        private Rectangle rect;

        public void GetPerimeter() {
            rect.GetPerimeter();
        }

        public void GetArea() => rect.GetArea(); 

        public Square(int l1) {
            rect = new Rectangle(l1, l1);
        }

    }
}
