using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace EditorGrafos
{
    public class Arista
    {
        public Vertice origen;
        public Vertice destino;
        public int indice_grafo;
        public int peso;
        public List<Grafo> list_grafo;
        GraphicsPath gpLin;
        Pen lin, linSola;

        public Arista(Vertice v1, Vertice v2,List<Grafo> list_grafo, int index = -1)
        {
            this.list_grafo = list_grafo;
            origen = v1;
            destino = v2;
            this.indice_grafo = index;

            lin = new Pen(Brushes.DimGray, 3); // linea para nodos dirigidos
            linSola = new Pen(Brushes.DimGray, 3); //linea para nodos no dirigidos
            gpLin = new GraphicsPath();
            gpLin.AddLine(new Point(0, 0), new Point(3, -3));
            gpLin.AddLine(new Point(0, 0), new Point(-3, -3));
            lin.CustomEndCap = new CustomLineCap(null, gpLin);
        }

        public void dibujaArista(Graphics g)
        {
            double tg = (double)(origen.y - destino.y) / (destino.x - origen.x);
            double atg = Math.Atan(tg);

            int a = (int)(13 * Math.Cos(atg));
            int b = (int)(13 * Math.Sin(atg));

            if ((origen.x < destino.x))
            {
                a *= -1;
                b *= -1;
            }

            Point pfin = new Point(destino.x + a, destino.y - b);
            Point pin = new Point(origen.x - a, origen.y + b);
            if (list_grafo[origen.indice_grafo].dirigido == true)
            {
                g.DrawLine(lin, pin, pfin);
            }
            else
            {
                g.DrawLine(linSola, pin, pfin);
            }
        }
    }
}
