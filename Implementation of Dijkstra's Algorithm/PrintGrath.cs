using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation_of_Dijkstra_s_Algorithm
{
    // <summary>
    /// для печати графа
    /// </summary>
    static class PrintGrath
    {
        public static List<string> PrintAllPoints(DekstraAlgorim da)
        {
            List<string> retListOfPoints = new List<string>();
            foreach (Point p in da.points)
            {
                retListOfPoints.Add(string.Format("point name={0}, point value={1}, predok={2}", p.Name, p.ValueMetka, p.predPoint.Name ?? "нет предка"));
            }
            return retListOfPoints;
        }
        public static List<string> PrintAllMinPaths(DekstraAlgorim da)
        {
            List<string> retListOfPointsAndPaths = new List<string>();
            foreach (Point p in da.points)
            {

                if (p != da.BeginPoint)
                {
                    string s = string.Empty;
                    foreach (Point p1 in da.MinPath1(p))
                    {
                        s += string.Format("{0} ", p1.Name);
                    }
                    retListOfPointsAndPaths.Add(string.Format("Point ={0},MinPath from {1} = {2}", p.Name, da.BeginPoint.Name, s));
                }

            }
            return retListOfPointsAndPaths;

        }
    }
}
