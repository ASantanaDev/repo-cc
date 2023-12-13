using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pixel
{
    public class Procesos
    {
        public static int sx1 = 0;
        public static int sx2  = 600 ;
        public static int sy1 = 0;
        public static int sy2  = 500;
        public static double x1 = -2.5;
        public static double x2 = 2.5;
        public static double y1 = -2.08;
        public static double y2 = 2.08;
        
        public Procesos() { }
 
        public static void pantalla(double x, double y, out int sx, out int sy)
        {
            sx = (int)((((sx1 - sx2) / (x1 - x2)) * (x - x2)) + sx2);
            sy = (int)((((sy1 - sy2) / (y2 - y1)) * (y - y1)) + sy2);
        }
        
        public static void axonometria(double x0, double y0, double z0, out double ax, out double ay)
        {
            ax = x0 + (0.5) * y0 * Math.Cos(0.8);
            ay = z0 + (0.5) * y0 * Math.Sin(0.8);
        }
    }
}