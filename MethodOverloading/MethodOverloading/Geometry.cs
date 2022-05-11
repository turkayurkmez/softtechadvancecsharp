using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    public class Geometry
    {

       public double getArea(double unitLength1, string geometry)
        {
            switch (geometry)
            {
                case "square":
                    return unitLength1 * unitLength1;
                case "circle":
                    return Math.PI * unitLength1 * unitLength1;
                default:
                    return 0;

            }


        }


       public double getArea(double unitLength1, double unitLength2, string geometry)
        {
            switch (geometry)
            {
                case "rectangle":
                    return unitLength1 * unitLength2;
                case "triangle":
                    return unitLength1 * unitLength2 / 2;
                default:
                    return 0;

            }
        }

        public double optionalGetArea(double unitLength1, double unitLength2 = 1, string geometry = "square")
        {
            switch (geometry)
            {
                case "square":
                    return unitLength1 * unitLength1;
                case "circle":
                    return Math.PI * unitLength1 * unitLength1;
                case "rectangle":
                    return unitLength1 * unitLength2;
                case "triangle":
                    return unitLength1 * unitLength2 / 2;
                default:
                    return 0;
            }
        }
    }
}
