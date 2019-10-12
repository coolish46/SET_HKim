using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQ_TDD
{
    public class Triangle
    {
        public Triangle()
        {

        }

        public double CalcArea(int sideA, int sideB)
        {
            double area = 0.0;
            area = (sideA * sideB) / 2;
            return area;
        }

        public int CalcAngle(int angleA, int angleB)
        {
            int angleC = 0;

            if((angleB > 0) && (angleA > 0))
            {
                angleC = 180 - angleA - angleB;
            }
           

            return angleC;
        }
    }
}
