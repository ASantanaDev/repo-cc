
using System;
using System.Drawing;

namespace Pixel
{
    public class CurvaV : Circunferencia
    {
        public int tipo;

        public CurvaV()
        {
        }
        
        public double Radio;
        public override void Encender(Bitmap lienzo)
        {
            if (tipo == 0)
            {
                Vector objVector = new Vector();
                double t, dt;
                t = 0; //carga el extremo inferior del dominio
                dt = 0.001;
                do
                {
                    objVector.x0 = x0 + (Radio * (Math.Sin(2*t)));
                    objVector.y0 = y0 + (Radio * (Math.Cos(3*t)));
                    objVector.color0 = color0;
                    objVector.Encender(lienzo);
                    t = t + dt;
                } while (t <= 2*(Math.PI));
            }

            if (tipo == 1)
            {
                Vector objVector = new Vector();
                double t, dt;
                t = 0; //carga el extremo inferior del dominio
                dt = 0.001;
                do
                {
                    objVector.x0 = x0 + (Radio * (Math.Cos(4*t))*(Math.Cos(t)));
                    objVector.y0 = y0 + (Radio * (Math.Cos(4*t))*(Math.Sin(t)));
                    objVector.color0 = color0;
                    objVector.Encender(lienzo);
                    t = t + dt;
                } while (t <= 2*(Math.PI));
            }
            
            if (tipo == 2)
            {
                Vector objVector = new Vector();
                double t, dt;
                t = 0; //carga el extremo inferior del dominio
                dt = 0.001;
                do
                {
                    objVector.x0 = x0 + (Radio * (Math.Pow((Math.Sin(t)), 3)));
                    objVector.y0 = y0 + (Radio * (Math.Pow((Math.Cos(t)), 3)));
                    objVector.color0 = color0;
                    objVector.Encender(lienzo);
                    t = t + dt;
                } while (t <= 2*(Math.PI));
            }
            
            if (tipo == 3)
            {
                Vector objVector = new Vector();
                double t, dt;
                t = 0; //carga el extremo inferior del dominio
                dt = 0.001;
                do
                {
                    objVector.x0 = x0 + (Radio * (Math.Sin(8*t/5))*(Math.Cos(t)));
                    objVector.y0 = y0 + (Radio * (Math.Sin(8*t/5))*(Math.Sin(t)));
                    objVector.color0 = color0;
                    objVector.Encender(lienzo);
                    t = t + dt;
                } while (t <= 10 * (Math.PI));
            }
            
            if (tipo == 4)
            {
                Vector objVector = new Vector();
                double t, dt;
                t = -8; //carga el extremo inferior del dominio
                dt = 0.001;
                do
                {
                    objVector.x0 = x0 + t;
                    objVector.y0 = y0 + (Math.Pow(2, t));
                    objVector.color0 = color0;
                    objVector.Encender(lienzo);
                    
                    objVector.y0 = y0 + ((Math.Pow(t, 2) / 5) - 3); //parábola
                    objVector.color0 = Color.Brown;
                    objVector.Encender(lienzo);
                    
                    objVector.y0 = y0 + (Math.Log(t)); //logaritmo
                    objVector.color0 = Color.DarkGreen;
                    objVector.Encender(lienzo);
                    
                    objVector.y0 = y0 + (Math.Sin(t)); //seno
                    objVector.color0 = Color.SandyBrown;
                    objVector.Encender(lienzo);
                    
                    objVector.y0 = y0 + (Math.Pow(t, 3) + 2); //cubica
                    objVector.color0 = Color.MediumVioletRed;
                    objVector.Encender(lienzo);

                    t += dt;
                } while (t <= 8);
            }
            
            if (tipo == 5)
            {
                Vector objVector = new Vector();
                double t, dt;
                t = -8; //carga el extremo inferior del dominio
                dt = 0.001;
                do
                {
                    objVector.x0 = x0 + t;
                    objVector.y0 = y0 + (Math.Pow(3, t));
                    objVector.color0 = color0;
                    objVector.Encender(lienzo);
                    
                    objVector.y0 = y0 + 1 + (1.098) * (t - 0) + (1.206 * Math.Pow(t, 2) / 2) + (1.325 * Math.Pow(t, 3) / 6) + (1.456 * Math.Pow(t, 4) / 24); //Taylor
                    objVector.color0 = Color.Red;
                    objVector.Encender(lienzo);
                    
                    t = t + dt;
                } while (t <= 8);
            }

            if (tipo == 6)
            {
                Vector objVector = new Vector();
                double t, dt;
                t = -10; //carga el extremo inferior del dominio
                dt = 0.001;
                do
                {
                    objVector.x0 = x0 + t;
                    objVector.y0 = y0 + ((-0.03 * Math.Pow(t, 2)) + 3);
                    objVector.color0 = Color.LightSeaGreen;
                    objVector.Encender(lienzo);

                    t += dt;

                } while (t <= 10);
            }
            
        }
    }
}