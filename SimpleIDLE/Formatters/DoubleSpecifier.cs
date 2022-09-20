using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleIDLE.Formatters
{
    internal class DoubleSpecifier
    {
        public static string GetSpecifier(double d)
        {
            double tmp = d;
            string result = string.Empty;

            if (d < 1.00e3)
            {
                result = "##0.00";
            }
            else if (d < 1.00e6)
            {
                tmp /= Math.Pow(10,3);
                result = "##0.00 K";
            }
            else if (d < 1.00e9)
            {
                tmp /= Math.Pow(10,6);
                result = "##0.00 M";
            }
            else if (d < 1.00e12)
            {
                tmp /= Math.Pow(10, 9);
                result = "##0.00 B";
            }
            else if (d < 1.00e15)
            {
                tmp /= Math.Pow(10, 12);
                result = "##0.00 T";
            }
            else if (d < 1.00e18)
            {
                tmp /= Math.Pow(10, 15);
                result = "##0.00 Qa";
            }
            else if (d < 1.00e21)
            {
                tmp /= Math.Pow(10, 18);
                result = "##0.00 Qi";
            }
            else if (d < 1.00e24)
            {
                tmp /= Math.Pow(10, 21);
                result = "##0.00 Sx";
            }
            else if (d < 1.00e27)
            {
                tmp /= Math.Pow(10, 24);
                result = "##0.00 Sp";
            }
            else if (d < 1.00e30)
            {
                tmp /= Math.Pow(10, 27);
                result = "##0.00 Oc";
            }
            else if (d < 1.00e33)
            {
                tmp /= Math.Pow(10, 30);
                result = "##0.00 No";
            }
            else
            {
                tmp /= Math.Pow(10, 33);
                result = "0.00e0";
            }

            return tmp.ToString(result);
        }
    }
}
