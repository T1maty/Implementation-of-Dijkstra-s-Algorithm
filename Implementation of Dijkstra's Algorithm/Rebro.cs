using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation_of_Dijkstra_s_Algorithm
{
    public class Rebro
    {
        public  Point FirstPoint { get; private set; }
        public Point SecondPoint { get; private set; }  
        public float Weight { get; private set; }

        public Rebro(Point firstPoint, Point secondPoint, float weight)
        {
            FirstPoint = firstPoint;
            SecondPoint = secondPoint;
            Weight = weight;
        }
    }
}
