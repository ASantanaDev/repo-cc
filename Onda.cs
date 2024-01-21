using System;
using System.Drawing;

namespace Pixel
{
    public class Onda : Vector
    {
        public double t;
        public int color;
        public Color c;
        public double v, w, w1, w2, x, y, z, z1, z2, z3, m = 0.5;
        public Color[] Paleta0 = new Color[16];
        public Color[] PaletaOnda = new Color[16];
        
        public Onda()
        {
            Paleta0[0] = Color.Black;
            Paleta0[1] = Color.Navy;
            Paleta0[2] = Color.Green;
            Paleta0[3] = Color.Aqua;
            Paleta0[4] = Color.Red;
            Paleta0[5] = Color.Purple;
            Paleta0[6] = Color.Maroon;
            Paleta0[7] = Color.LightGray;
            Paleta0[8] = Color.DarkGray;
            Paleta0[9] = Color.Blue;
            Paleta0[10] = Color.Lime;
            Paleta0[11] = Color.Silver;
            Paleta0[12] = Color.Teal;
            Paleta0[13] = Color.Fuchsia;
            Paleta0[14] = Color.Yellow;
            Paleta0[15] = Color.White;
            
           for (int k = 0; k < 16; k++)
            {
                int r = Convert.ToInt32((-11.13 * k) + 200);
                int g = Convert.ToInt32((-11.13 * k) + 200);
                int b = Convert.ToInt32((-11.13 * k) + 200);
                PaletaOnda[k] = Color.FromArgb(r, g, b);
            }
            
        }
        public void GrafOnda(Bitmap pantalla)
        {
            double aux;
            
            for (int i = 0; i < 600; i++)
            {
                for (int j = 0; j < 500; j++)
                {
                    transforma(i, j, out x, out y); //Transforma valores enteros de la ventana pantalla a reales de la pantalla real
                    aux = w * (Math.Sqrt((x - (-4)) * (x - (-4)) + (y - 0) * (y - 0)) - v * t);
                    z = (1 /* m */ * Math.Sin(aux)) + 1; // + 1 para que tomo valores positivos
                    color = (int)(z * 7.5); // cant de colores de la paleta / 2
                    c = PaletaOnda[color];
                    pantalla.SetPixel(i, j, c);
                }
            }
        }
        public void InterferenciaGraf(Bitmap pantalla)
        {
            for (int i = 0; i < 600; i++)
            {
                for (int j = 0; j < 500; j++)
                {
                    transforma(i, j, out x, out y);
                    z1 = w * (Math.Sqrt((x - (-4)) * (x - (-4)) + (y - (-2)) * (y - (-2))) - v * t);
                    z2 = w * (Math.Sqrt((x - (-4)) * (x - (-4)) + (y - (2)) * (y - (2))) - v * t);
                    z3 = w * (Math.Sqrt((x - (4)) * (x - (4)) + (y - (0)) * (y - (0))) - v * t);//tercera onda...

                    z1 = (1 * Math.Sin(z1)) + 1;
                    z2 = (1 * Math.Sin(z2)) + 1;
                    z3 = (1 * Math.Sin(z3)) + 1;

                    z = z1 + z2 + z3; //Produce la interferencia
                    
                    color = (int)(z * 2.5); // 15/(2 * #Zi)
                    c =Paleta0[color];
                    //c = PaletaOnda[color];
                    pantalla.SetPixel(i, j, c);

                }
            }
        }
        
        public void GrafOnda3D(Bitmap pantalla) 
        {
            Vector3D v3d = new Vector3D();
            x = -8;
            do
            {
                y = -6;
                do
                {
                    v3d.x0 = x;
                    v3d.y0 = y;
                    z = w * (Math.Sqrt((x - (0)) * (x - (0)) + (y - (1)) * (y - (1))) - v * t);
                    z = 0.6 * Math.Sin(z);
                    v3d.z0 = z;
                    v3d.color0 = Color.DarkBlue;
                    v3d.Encender(pantalla);
                    y += 0.15;
                } while (y <= 6);
                x += 0.15;
            } while (x <= 8);

        }
        
        public void Interferencia3D(Bitmap bitmap)
        {
            Vector3D v3d = new Vector3D();
            double  p, p2, z, z0, zt;
            
            x = -9;
            do
            {
                y = -7;
                do
                {
                    v3d.x0 = x;
                    v3d.y0 = y;

                    p = w * (Math.Sqrt((x - (0)) * (x - (0)) + (y - (3)) * (y - (3))) - v * t);
                    z = 0.4 * Math.Sin(p);
                    
                    p2 = w * (Math.Sqrt((x - (0)) * (x - (0)) + (y - (-3)) * (y - (-3))) - v * t);
                    z0 = 0.4 * Math.Sin(p2);
                    
                    zt = z + z0;
                    v3d.z0 = zt;
                    v3d.color0 = Color.DarkBlue;
                    v3d.Encender(bitmap);

                    y = y + 0.1;
                } while (y <= 7);
                x = x + 0.1;
            } while (x <= 9);

        }
        
    }
}