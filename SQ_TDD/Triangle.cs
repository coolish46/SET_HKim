﻿using System;
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
            area = sideA * sideB;
            return area;
        }
    }
}
