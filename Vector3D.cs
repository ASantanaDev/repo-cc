
using System.Drawing;

namespace Pixel
{
    public class Vector3D : Vector
    {
        public double z0;
        public override void Encender(Bitmap bitmap)
        {
            double ax, ay;
            int Sx, Sy;
            Procesos.axonometria(x0, y0, z0, out ax, out ay);
            Procesos.pantalla(ax, ay, out Sx, out Sy);

            if (Sx >= 0 && Sx < 600 && Sy >= 0 && Sy < 500)
            {
                bitmap.SetPixel(Sx, Sy, color0);
            }
        }
    }
}