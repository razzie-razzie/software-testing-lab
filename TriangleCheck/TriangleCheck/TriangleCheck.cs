using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleCheck
{
    public class TriangleCheck
    {
        public bool Triangle_Check(double a, double b, double c)
        {
            if (a > 0 && b > 0 && c > 0)
            {
                if ((a < b + c) && (b < a + c) && (c < a + b))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
