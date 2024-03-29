using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pixel
{
    public class Vector
    {
        public static int sx1 = 0;
        public static int sx2 = 600;
        public static int sy1 = 0;
        public static int sy2 = 500;
        public static double x1 = -10;
        public static double x2 = 10;
        public static double y1 = -8.33;
        public static double y2 = 8.33;
        /*public static double x1 = -2.5;
        public static double x2 = 2.5;
        public static double y1 = -2.08;
        public static double y2 = 2.08;*/
        public double x0 { get; set; }
        public double y0 { get; set; }
        public Color color0 { get; set; }
        public Vector() { }

        public Vector(double x0, double y0, Color color0)
        {
            this.x0 = x0;
            this.y0 = y0;
            this.color0 = color0;
        }

        public virtual void Encender(Bitmap lienzo)
        {
            int sx, sy;

            Procesos.pantalla(this.x0, this.y0, out sx, out sy);
            if (sx > 0 && sx < 600 && sy > 0 && sy < 500)
            {
                lienzo.SetPixel(sx, sy, color0);
            }

        }
        public virtual void apagar(Bitmap lienzo)
        {

            this.color0 = Color.White;
            Encender(lienzo);

        }
        public void transforma(int sx, int sy, out double x, out double y)
        {
            x = (((sx - sx2) * (x2 - x1)) / (sx2 - sx1)) + x2;
            y = (((sy - sy1) * (y1 - y2)) / (sy2 - sy1)) + y2;
        }
    }
}
