﻿using System.Drawing;

namespace SyntaxTest.Exercises
{
    public class Exercise09
    {
        /*
          Parašykite viešą metodą pavadinimu GetPoint, kuris grąžina Point tipo rezultatą. 
          Point tipas yra System.Drawing katalogo klasė, kuri aprašo vieną tašką, kuris turi x ir y koordinates.
          Šis metodas turi turėti du parametrus: int tipo parametrą xCoordinate ir int tipo parametrą yCoordinate.
        */
        public Point GetPoint(int xCoordinate, int yCoordinate)
        {
            Point p1 = new Point(6,6);
          

            return p1;
        }
    }
}
