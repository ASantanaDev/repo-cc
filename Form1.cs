using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pixel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static readonly int width = 600;
        static readonly int height = 500;

        Bitmap lienzo = new Bitmap(width, height);
        
        Color[] paletaMadera = new Color[16];
        
        Color[] paleta0 = new[]
        {
            Color.Black,        //0
            Color.Navy,         //1
            Color.Green,        //2
            Color.Aqua,         //3
            Color.Red,          //4
            Color.Purple,       //5
            Color.Maroon,       //6
            Color.LightGray,    //7
            Color.DarkGray,     //8
            Color.Blue,         //9
            Color.Lime,         //10
            Color.Silver,       //11
            Color.Teal,         //12
            Color.Fuchsia,      //13
            Color.Yellow,       //14
            Color.White         //15
        };
        
        Color[] paleta1 = new[]
        {
            Color.LightGreen,        //0
            Color.CadetBlue,         //1
            Color.Red,               //2
            Color.GreenYellow,       //3
            Color.DarkViolet,        //4
            Color.Pink,              //5
            Color.DeepSkyBlue,       //6
            Color.Gray,              //7
            Color.Black,             //8
            Color.LightCoral,        //9
            Color.Aqua,              //10
            Color.Goldenrod,         //11
            Color.Teal,              //12
            Color.Blue,              //13
            Color.WhiteSmoke,        //14
            Color.BurlyWood          //15
        };

        private void PintarFondoEjes()
        {
            Color fondo = Color.White;
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    lienzo.SetPixel(i, j, fondo);
                }
            }
            
            Segmento s5 = new Segmento();
            s5.x0 = 0;
            s5.y0 = 8.33;
            s5.xf = 0;
            s5.yf = -8.33;
            s5.color0 = Color.Black;
            s5.Encender(lienzo);
            
            Segmento s6 = new Segmento();
            s6.x0 = -10;
            s6.y0 = 0;
            s6.xf = 10;
            s6.yf = 0;
            s6.color0 = Color.Black;
            s6.Encender(lienzo);
            
        }

        private void ApagarPixel()
        {
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    lienzo.SetPixel(i, j, Color.White);
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            ApagarPixel();
            pictureBox1.Image = lienzo;
        }

        private void btnSegmento_Click(object sender, EventArgs e)
        {
            PintarFondoEjes();
            
            Segmento segmento = new Segmento();
            segmento.x0 = -10; segmento.y0 = -2;//punto 1
            segmento.xf = 6; segmento.yf = 4;//punto 2
            segmento.color0 = Color.Red;
            segmento.Encender(lienzo);
            
            Segmento segmento1 = new Segmento();
            segmento1.x0 = 6; segmento1.y0 = 4;//punto 1
            segmento1.xf = 6; segmento1.yf = 0;//punto 2
            segmento1.color0 = Color.Blue;
            segmento1.Encender(lienzo);
            
            Segmento segmento2 = new Segmento();
            segmento2.x0 = 6; segmento2.y0 = 0;//punto 1
            segmento2.xf = 10; segmento2.yf = 5;//punto 2
            segmento2.color0 = Color.Black;
            segmento2.Encender(lienzo);
            
            Circunferencia c = new Circunferencia();
            c.Radio = 3.0;
            c.x0 = -2;
            c.y0 = -1;
            c.color0 = Color.Blue;
            c.Encender(lienzo);
            
            Circunferencia c1 = new Circunferencia();
            c1.Radio = 1.0;
            c1.x0 = 6;
            c1.y0 = 4;
            c1.color0 = Color.Blue;
            c1.Encender(lienzo);
            
            Circunferencia c2 = new Circunferencia();
            c2.Radio = 0.2;
            c2.x0 = -2;
            c2.y0 = 1.5;
            c2.color0 = Color.Blue;
            c2.Encender(lienzo);
            
            pictureBox1.Image = lienzo;
        }

        private void btnCurvas_Click(object sender, EventArgs e)
        {
            PintarFondoEjes();
            
            /*CurvaV c0 = new CurvaV();
            c0.tipo = 0;
            c0.Radio = 2;
            c0.x0 = 5;
            c0.y0 = 3;
            c0.color0 = Color.Blue;
            c0.Encender(lienzo);
            
            CurvaV c1 = new CurvaV();
            c1.tipo = 1;
            c1.Radio = 2;
            c1.x0 = 0;
            c1.y0 = 0;
            c1.color0 = Color.Firebrick;
            c1.Encender(lienzo);
            
            CurvaV c2 = new CurvaV();
            c2.tipo = 2;
            c2.Radio = 2;
            c2.x0 = -5;
            c2.y0 = -3;
            c2.color0 = Color.ForestGreen;
            c2.Encender(lienzo);*/
            
            CurvaV c3A = new CurvaV();
            c3A.tipo = 3;
            c3A.Radio = 3.5;
            c3A.x0 = 0;
            c3A.y0 = 0;
            c3A.color0 = Color.Firebrick;
            c3A.Encender(lienzo);
            
            CurvaV c3B = new CurvaV();
            c3B.tipo = 3;
            c3B.Radio = 1;
            c3B.x0 = 5;
            c3B.y0 = 5;
            c3B.color0 = Color.CadetBlue;
            c3B.Encender(lienzo);
            
            CurvaV c3C = new CurvaV();
            c3C.tipo = 3;
            c3C.Radio = 1.5;
            c3C.x0 = -5;
            c3C.y0 = 5;
            c3C.color0 = Color.BlueViolet;
            c3C.Encender(lienzo);
            
            pictureBox1.Image = lienzo;
        }
        
        private void encenderPixelToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Color pixelColor = Color.Black;
            
            //Linea de abajo
            for (int i = width/2 - 75; i <= width/2 + 75; i++)
            {
                lienzo.SetPixel(i, (int)(height/1.5), pixelColor);
            }
            
            //Linea de arriba
            for (int i = width/2 - 75; i <= width/2 + 75; i++)
            {
                lienzo.SetPixel(i, (int)(height/2.5), pixelColor);
            }
            
            //Linea del medio
            for (int i = width/2 - 75; i <= width/2 + 75; i++)
            {
                lienzo.SetPixel(i, (int)(height/1.9), pixelColor);
            }
            // Línea vertical que conecta las dos líneas
            for (int i = (int)(width / 2 - 75); i <= (int)(width / 2 - 75); i++)
            {
                for (int j = (int)(height / 2.5); j <= (int)(height / 1.9); j++)
                {
                    lienzo.SetPixel(i, j, pixelColor);
                }
            }
            
            // Línea vertical que conecta el extremo derecho de la línea del medio con el extremo derecho de la línea inferior
            for (int i = (int)(width / 2 + 75); i <= (int)(width / 2 + 75); i++)
            {
                for (int j = (int)(height / 1.9); j <= (int)(height / 1.5); j++)
                {
                    lienzo.SetPixel(i, j, pixelColor);
                }
            }
            pictureBox1.Image = lienzo;
        }

        private void pruebaColoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color pixelColor = Color.Blue;
            
            for(int i = 0; i < 299; i++)
            {
                for(int j = 0; j < height; j++)
                {
                    lienzo.SetPixel(i, j, pixelColor);
                }
            }
            
            pixelColor = Color.Green;
            
            for(int i = 299; i < width; i++)
            {
                for(int j = 0; j < height; j++)
                {
                    lienzo.SetPixel(i, j, pixelColor);
                }
            }
            
            pictureBox1.Image = lienzo;
        }

        private void degradadoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < width; i++)
            {
                for(int j = 0; j < height; j++)
                {
                    //lienzo.SetPixel(i, j, Color.FromArgb(0, (int)(0.425 * i), (int)((-0.425 * i) + 255)));
                    lienzo.SetPixel(i, j,
                        Color.FromArgb((int)(-0.06333 * i + 174), (int)(-0.2267 * i + 214),
                            (int)(-0.135 * i + 241)));
                }
            }
            
            pictureBox1.Image = lienzo;
        }

        private void segmentoCircunferenciaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PintarFondoEjes();
            
            Segmento segmento = new Segmento();
            segmento.x0 = -10; segmento.y0 = -2;//punto 1
            segmento.xf = 6; segmento.yf = 4;//punto 2
            segmento.color0 = Color.Red;
            segmento.Encender(lienzo);
            
            Segmento segmento1 = new Segmento();
            segmento1.x0 = 6; segmento1.y0 = 4;//punto 1
            segmento1.xf = 6; segmento1.yf = 0;//punto 2
            segmento1.color0 = Color.Blue;
            segmento1.Encender(lienzo);
            
            Segmento segmento2 = new Segmento();
            segmento2.x0 = 6; segmento2.y0 = 0;//punto 1
            segmento2.xf = 10; segmento2.yf = 5;//punto 2
            segmento2.color0 = Color.Black;
            segmento2.Encender(lienzo);
            
            Circunferencia c = new Circunferencia();
            c.Radio = 3.0;
            c.x0 = -2;
            c.y0 = -1;
            c.color0 = Color.Blue;
            c.Encender(lienzo);
            
            Circunferencia c1 = new Circunferencia();
            c1.Radio = 1.0;
            c1.x0 = 6;
            c1.y0 = 4;
            c1.color0 = Color.Blue;
            c1.Encender(lienzo);
            
            Circunferencia c2 = new Circunferencia();
            c2.Radio = 0.2;
            c2.x0 = -2;
            c2.y0 = 1.5;
            c2.color0 = Color.Blue;
            c2.Encender(lienzo);
            
            pictureBox1.Image = lienzo;
        }

        private void curvasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PintarFondoEjes();
            
            /*CurvaV c0 = new CurvaV();
            c0.tipo = 0;
            c0.Radio = 2;
            c0.x0 = 5;
            c0.y0 = 3;
            c0.color0 = Color.Blue;
            c0.Encender(lienzo);

            CurvaV c1 = new CurvaV();
            c1.tipo = 1;
            c1.Radio = 2;
            c1.x0 = 0;
            c1.y0 = 0;
            c1.color0 = Color.Firebrick;
            c1.Encender(lienzo);

            CurvaV c2 = new CurvaV();
            c2.tipo = 2;
            c2.Radio = 2;
            c2.x0 = -5;
            c2.y0 = -3;
            c2.color0 = Color.ForestGreen;
            c2.Encender(lienzo);*/
            
            CurvaV c3A = new CurvaV();
            c3A.tipo = 3;
            c3A.Radio = 3.5;
            c3A.x0 = 0;
            c3A.y0 = 0;
            c3A.color0 = Color.Firebrick;
            c3A.Encender(lienzo);
            
            CurvaV c3B = new CurvaV();
            c3B.tipo = 3;
            c3B.Radio = 1;
            c3B.x0 = 5;
            c3B.y0 = 5;
            c3B.color0 = Color.CadetBlue;
            c3B.Encender(lienzo);
            
            CurvaV c3C = new CurvaV();
            c3C.tipo = 3;
            c3C.Radio = 1.5;
            c3C.x0 = -5;
            c3C.y0 = 5;
            c3C.color0 = Color.BlueViolet;
            c3C.Encender(lienzo);
            
            pictureBox1.Image = lienzo;
        }

        private void ejercicioCurvasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PintarFondoEjes();
            
            CurvaV eje = new CurvaV();
            eje.tipo = 4;
            eje.Radio = 1;
            eje.x0 = 0;
            eje.y0 = 0;
            eje.color0 = Color.BlueViolet;
            eje.Encender(lienzo);
            
            pictureBox1.Image = lienzo;
        }

        private void ejercicioTaylorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PintarFondoEjes();
            
            CurvaV eje = new CurvaV();
            eje.tipo = 5;
            eje.Radio = 1;
            eje.x0 = 0;
            eje.y0 = 0;
            eje.color0 = Color.Blue;
            eje.Encender(lienzo);
            
            pictureBox1.Image = lienzo;
        }

        private void prácticaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PintarFondoEjes();
            double xa;
            
            CurvaV c1 = new CurvaV();
            c1.tipo = 6;
            c1.Radio = 1;
            c1.x0 = 0;
            c1.y0 = 0;
            c1.Encender(lienzo);
            
            Segmento seg = new Segmento();
            xa = 3;
            seg.x0 = -10;
            seg.y0 = (-0.06 * xa) * (seg.x0 - xa) + (-0.03 * Math.Pow(xa, 2) + 3);
            seg.xf = 10;
            seg.yf = (-0.06 * xa) * (seg.xf - xa) + (-0.03 * Math.Pow(xa, 2) + 3);
            seg.color0 = Color.Red;
            seg.Encender(lienzo);
            
            Segmento seg2 = new Segmento();
            xa = -5;
            seg2.x0 = -10;
            seg2.y0 = (-0.06 * xa) * (seg.x0 - xa) + (-0.03 * Math.Pow(xa, 2) + 3);
            seg2.xf = 10;
            seg2.yf = (-0.06 * xa) * (seg.xf - xa) + (-0.03 * Math.Pow(xa, 2) + 3);
            seg2.color0 = Color.Red;
            seg2.Encender(lienzo);
            
            Segmento seg3 = new Segmento();
            xa = 6;
            seg3.x0 = -10;
            seg3.y0 = (-0.06 * xa) * (seg.x0 - xa) + (-0.03 * Math.Pow(xa, 2) + 3);
            seg3.xf = 10;
            seg3.yf = (-0.06 * xa) * (seg.xf - xa) + (-0.03 * Math.Pow(xa, 2) + 3);
            seg3.color0 = Color.Red;
            seg3.Encender(lienzo);
            
            pictureBox1.Image = lienzo;
        }

        private void paletaColoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int colorT;
            Color c;
            
            for (int k = 0; k < 15; k++)
            {
                paleta0[k] = Color.FromArgb((int)(4.667 * k + 130), (int)(2 * k + 70), (int)(1.333 * k + 30));
            }
            
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    //colorT = (i * i + j * j) % 15;
                    colorT = (int)((Math.Sqrt((i + 50.5)) + Math.Cos(i) + 10 * j) / 2.3) % 15;
                    c = paleta0[colorT];
                    lienzo.SetPixel(i, j, c);
                }
            }
            
            pictureBox1.Image = lienzo;
        }

        private void tapete1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int colorT;
            Color c;
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    colorT = (int)(6 * Math.Abs(Math.Sin(i * i + j) + 1) % 15);
                    c = paleta0[colorT];
                    lienzo.SetPixel(i, j, c);
                }
            }
            
            pictureBox1.Image = lienzo;
        }

        private void tapete2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int colorT;
            Color c;
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    colorT = (int)(3 * Math.Abs(Math.Sin(i)) + Math.Sqrt(21 * j)) % 15;
                    c = paleta0[colorT];
                    lienzo.SetPixel(i, j, c);
                }
            }
            
            pictureBox1.Image = lienzo;
        }

        private void tapete3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int colorT;
            Color c;
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    colorT = (int)(8 * Math.Abs(Math.Sin((i * i + j * j) / 10.0)) % 15);
                    c = paleta0[colorT];
                    lienzo.SetPixel(i, j, c);
                }
            }
            
            pictureBox1.Image = lienzo;
        }

        private void tapete4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int colorT;
            Color c;
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    colorT = (int)((6 * Math.Abs(Math.Sin(i * j))) % 15);
                    c = paleta0[colorT];
                    lienzo.SetPixel(i, j, c);
                }
            }
            
            pictureBox1.Image = lienzo;
        }

        private void tapete5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int colorT;
            Color c;
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    colorT = (int)(7 * Math.Abs(Math.Sin(i * i + j * j)) % 15);
                    c = paleta0[colorT];
                    lienzo.SetPixel(i, j, c);
                }
            }
            
            pictureBox1.Image = lienzo;
        }

        private void tapete6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int colorT;
            Color c;
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    colorT = (int)(19 * Math.Abs(Math.Tan(i * i + j * j)) % 15);
                    c = paleta0[colorT];
                    lienzo.SetPixel(i, j, c);
                }
            }
            
            pictureBox1.Image = lienzo;
        }

        private void tapete7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int colorT;
            Color c;
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    colorT = (int)(7 * Math.Abs(Math.Pow(Math.Sin(i & j), 3)) % 15); 
                    c = paleta0[colorT];
                    lienzo.SetPixel(i, j, c);
                }
            }
            
            pictureBox1.Image = lienzo;
        }

        private void tapete8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int colorT;
            Color c;
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    colorT = (int)(7 * Math.Abs(Math.Cos(i / 3.0) * Math.Sin(j / 5.0) + Math.Sin(i / 7.0) * Math.Cos(j / 4.0)) % 15);
                    c = paleta0[colorT];
                    lienzo.SetPixel(i, j, c);
                }
            }
            
            pictureBox1.Image = lienzo;
        }

        private void cespedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int colorT;
            Color c;
            
            for (int k = 0; k < 15; k++)
            {
                paleta1[k] = Color.FromArgb((int)(126 - (4.87 * k)), (int)(217 - (7.53 * k)), (int)(87 - (2.8 * k)));
            }
            
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    colorT = (int)((Math.Pow(i / 4, 3) + Math.Pow(j / 2.5, 2)) % 15 + 1) * (int)((Math.Sqrt(Math.Pow(i * 3.7, 2) + Math.Pow(j * 3.7, 2))) + (i * i * 4 + j +j * 2.7)) % 15;
                    c = paleta1[colorT];
                    lienzo.SetPixel(i, j, c);
                }
            }
            
            pictureBox1.Image = lienzo;
        }
        
        private void jeanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int colorT;
            Color c;
            
            for (int a = 0; a <= 15; a++)
            {
                paleta1[a] = Color.FromArgb((int)(30 - (1.5 * a)), (int)(50 - (2.0 * a)), (int)(70 - (2.0 * a)));
            }
            
            for (int i = 0; i < 600; i++)
            {
                for (int j = 0; j < 500; j++)
                {
                    colorT = (int)(((Math.Sin(i + Math.PI) % 16 - Math.Cos(j % 16)) + Math.Pow(i, 5)) % 16);
                    c = paleta1[colorT];
                    lienzo.SetPixel(i, j, c);
                }
            }
            
            pictureBox1.Image = lienzo;
        }

        private void maderaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int k = 0; k < 16; k++)
            {
                int r = (int)(4.66 * k + 130);
                int g = (int)(2 * k + 70);
                int b = (int)(1.33 * k + 30);

                paletaMadera[k] = Color.FromArgb(r, g, b);

            }
            
            int colorT, cs = 0;
            Color c;
            for (int j = 0; j < 600; j++)
            {
                for (int i = 0; i < 500; i++)
                {
                    cs += 3;
                    colorT = (int)(((j + cs)) / Math.Log(cs) % 15);
                    c = paletaMadera[colorT];
                    lienzo.SetPixel(j, i, c);

                }
            }
            
            pictureBox1.Image = lienzo;
        }

        private void fuegoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            int colorT;
            Color c;
            
            Color[] paletaFuego = new Color[16];
            
            paletaFuego[0] = Color.FromArgb(236, 13, 13);
            paletaFuego[1] = Color.FromArgb(236, 107, 0);
            paletaFuego[2] = Color.FromArgb(240, 127, 32);
            paletaFuego[3] = Color.FromArgb(214, 161, 61);
            paletaFuego[4] = Color.FromArgb(244, 192, 28);
            paletaFuego[5] = Color.FromArgb(212, 193, 193);
            
            for (int i = 0; i < 600; i++)
            {
                for (int j = 0; j < 500; j++)
                {
                    double flameIntensity = Math.Sin((i * 0.02) + Math.Cos(j * 0.02));
                    colorT = (int)((flameIntensity + 1) * 16 / 2) % 6;
                    c = paletaFuego[colorT];
                    lienzo.SetPixel(i, j, c);
                }
            }
            
            pictureBox1.Image = lienzo;
        }

        private void ejercP2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurvaV c1 = new CurvaV();
            c1.tipo = 0;
            c1.Radio = 1;
            c1.x0 = -5;
            c1.y0 = 0;
            c1.color0 = Color.Blue;
            c1.Encender(lienzo);
            
            CurvaV c2 = new CurvaV();
            c2.tipo = 1;
            c2.Radio = 1;
            c2.x0 = 5;
            c2.y0 = 0;
            c2.color0 = Color.Blue;
            c2.Encender(lienzo);
            
            pictureBox1.Image = lienzo;
            
            pictureBox1.Refresh();
            Thread.Sleep(2000);
            
            c2.apagar(lienzo);
            
            pictureBox1.Image = lienzo;
            
        }

        private void parabolasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PintarFondoEjes();
            
            Circunferencia vec = new Circunferencia();
            double t = -8, dt = 0.1;
            vec.Radio = 0.25; 
            
            do
            {
                vec.x0 = t;
                vec.y0 = -(Math.Pow(t, 2) + (10 * t) + 16) / 2.25;
                vec.color0 = Color.Black;
                vec.Encender(lienzo);
                
                pictureBox1.Image = lienzo;
            
                pictureBox1.Refresh();
                Thread.Sleep(10);
            
                vec.apagar(lienzo);
                
                t = t + dt;

            } while (t <= -2);
            
            pictureBox1.Image = lienzo;
            
            do
            {
                vec.x0 = t;
                vec.y0 = (4 - Math.Pow(t, 2)) / 1.333;
                vec.color0 = Color.Black;
                vec.Encender(lienzo);
                
                pictureBox1.Image = lienzo;
            
                pictureBox1.Refresh();
                Thread.Sleep(10);
            
                vec.apagar(lienzo);
                
                t = t + dt;

            } while (t <= 2);
            
            pictureBox1.Image = lienzo;
            
            do
            {
                vec.x0 = t;
                vec.y0 = -(Math.Pow(t, 2) + (-7 * t) + 10) / 1.2;
                vec.color0 = Color.Black;
                vec.Encender(lienzo);
                
                pictureBox1.Image = lienzo;
            
                pictureBox1.Refresh();
                Thread.Sleep(10);
            
                vec.apagar(lienzo);
                
                t = t + dt;

            } while (t <= 5);
            
            pictureBox1.Image = lienzo;
        }

        private void reflexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PintarFondoEjes();
            
            Segmento s = new Segmento();
            s.x0 = 1; s.y0 = 1;
            s.xf = 8; s.yf = 8.33;
            s.color0 = Color.Black;
            s.Encender(lienzo);
            
            Segmento s1 = new Segmento();
            s1.x0 = 10; s1.y0 = 6.236;
            s1.xf = 8; s1.yf = 8.33;
            s1.color0 = Color.Black;
            s1.Encender(lienzo);
            
            /*Segmento s2 = new Segmento();
            s2.x0 = 10;
            s2.xf = 3;
            s2.y0 = 0;
            s2.yf = -7.1;
            s2.color0 = Color.Black;
            s2.Encender(lienzo);*/
            
            pictureBox1.Image = lienzo;
            
            Circunferencia c = new Circunferencia();
            c.Radio = 0.5;
            double t = 0;
            do
            {
                c.x0 = (1 /*s.x0*/ * (1 - t)) + (8 /*s.xf*/ * t);
                c.y0 = (1 /*s.y0*/  * (1 - t)) + (8.33 /*s.yf*/ * t);
                c.color0 = Color.Red;
                c.Encender(lienzo);
                pictureBox1.Image = lienzo;
                pictureBox1.Refresh();
                Thread.Sleep(100);
                c.apagar(lienzo);
                pictureBox1.Image = lienzo;
                t += 0.2;
            } while (t <= 1);
            
            t = 0;
            do
            {
                c.x0 = (8 * (1 - t)) + (10 * t);
                c.y0 = (8.33 * (1 - t)) + (6.236 * t);
                c.color0 = Color.Red;
                c.Encender(lienzo);
                pictureBox1.Image = lienzo;
                pictureBox1.Refresh();
                Thread.Sleep(100);
                c.apagar(lienzo);
                pictureBox1.Image = lienzo;
                t += 0.2;
            } while (t <= 1);
            
            
          /*  t = 0;
            do
            {
                c.x0 = (10 * (1 - t)) + (3 * t);
                c.y0 = (0 * (1 - t)) + (-7.1 * t);
                c.color0 = Color.Red;
                c.Encender(lienzo);
                pictureBox1.Image = lienzo;
                pictureBox1.Refresh();
                Thread.Sleep(200);
                c.apagar(lienzo);
                pictureBox1.Image = lienzo;
                t += 0.3;
            } while (t <= 1);*/
        }

        private void curvaNivelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PintarFondoEjes();
            
            Vector vec = new Vector();
            double t = -8, dt = 0.002;
            
            do
            {
                vec.x0 = t;
                vec.y0 = 3 * Math.Pow(Math.E, (-4 * t));
                vec.color0 = Color.Red;
                vec.Encender(lienzo);
                t = t + dt;

            } while (t <= 8);

            t = -8;
            do
            {
                vec.x0 = t;
                vec.y0 = 6 * Math.Pow(Math.E, (-4 * t));
                vec.color0 = Color.Red;
                vec.Encender(lienzo);
                t = t + dt;

            } while (t <= 8);
            
            t = -8;
            do
            {
                vec.x0 = t;
                vec.y0 = 6 * Math.Pow(Math.E, (-4 * t));
                vec.color0 = Color.Red;
                vec.Encender(lienzo);
                t = t + dt;

            } while (t <= 8);
            
            t = -8;
            do
            {
                vec.x0 = t;
                vec.y0 = 8* Math.Pow(Math.E, (-4 * t));
                vec.color0 = Color.Red;
                vec.Encender(lienzo);
                t = t + dt;

            } while (t <= 8);
            
            t = -8;
            do
            {
                vec.x0 = t;
                vec.y0 = -4 * Math.Pow(Math.E, (-4 * t));
                vec.color0 = Color.Red;
                vec.Encender(lienzo);
                t = t + dt;

            } while (t <= 8);
            
            t = -8;
            do
            {
                vec.x0 = t;
                vec.y0 = -7 * Math.Pow(Math.E, (-4 * t));
                vec.color0 = Color.Red;
                vec.Encender(lienzo);
                t = t + dt;

            } while (t <= 8);
            
            t = -8;
            do
            {
                vec.x0 = t;
                vec.y0 = 5 * Math.Pow(Math.E, (-4 * t));
                vec.color0 = Color.Red;
                vec.Encender(lienzo);
                t = t + dt;

            } while (t <= 8);
            
            t = -8;
            do
            {
                vec.x0 = t;
                vec.y0 = -5 * Math.Pow(Math.E, (-4 * t));
                vec.color0 = Color.Red;
                vec.Encender(lienzo);
                t = t + dt;

            } while (t <= 8);
            
            pictureBox1.Image = lienzo;
        }
    }
}