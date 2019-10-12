/*
* FILE : Triangle.cs
* PROJECT : SQ Lab TDD
* PROGRAMMER : Hyungbum Kim
* FIRST  VERSION : 2019-10-12
* DESCRIPTION :
* The purpose of this class is to 
* model the physical attributes of Triangle.
*/


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

        /* =================================================================================*/
        /* Name		: CalcArea	                											*/
        /* PURPOSE  : this method is used to calculate area of Triangle         			*/
        /* INPUTS   : side A and side B of Triangle											*/
        /* Returns	: area of Triangle                  					        	    */
        /* =================================================================================*/

        public double CalcArea(int sideA, int sideB)
        {
            double area = 0.0;
            area = (sideA * sideB) / 2;
            return area;
        }

        /* =================================================================================*/
        /* Name		: CalcAngle	                											*/
        /* PURPOSE  : this method is used to get remain angle of Triangle       			*/
        /* INPUTS   : Other angles of Triangle											    */
        /* Returns	: Remain angle of Triangle                  						    */
        /* =================================================================================*/

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
