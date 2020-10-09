using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;

namespace EditorGrafos
{
    [Serializable]
    public class Arista
    {
        public Vertice origen;   //Vertice U
        public Vertice destino;  //Vertice V

        public int indice_grafo;
        public int indice_arista;

        public List<Grafo> list_grafo;
        
        

        public Arista(Vertice v1, Vertice v2,List<Grafo> list_grafo, int indice_arista = -1, int index = -1)
        {
            this.list_grafo = list_grafo;
            origen = v1;
            destino = v2;
            this.indice_grafo = index;
            this.indice_arista = indice_arista;
        }

        public void dibujaArista(Graphics g)
        {
            GraphicsPath gpLin;
            Pen lin, linSola;

            lin = new Pen(Brushes.DimGray, 3); // linea para nodos dirigidos
            linSola = new Pen(Brushes.DimGray, 3); //linea para nodos no dirigidos

            gpLin = new GraphicsPath();
            gpLin.AddLine(new Point(0, 0), new Point(3, -3));
            gpLin.AddLine(new Point(0, 0), new Point(-3, -3));
            lin.CustomEndCap = new CustomLineCap(null, gpLin);

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

            if (list_grafo[origen.indice_grafo].dirigido == true) //Verifica si grafo es dirigido o no dirigido 
            {
                if (origen.indice_vertice == destino.indice_vertice)
                {
                    g.DrawArc(lin, origen.x - 26, origen.y - 26, 26, 26, 45, 310);
                }
                else
                {
                    g.DrawLine(lin, pin, pfin);
                }
            }
            else
            {
                if (origen.indice_vertice == destino.indice_vertice)
                {
                    g.DrawArc(linSola, origen.x - 26, origen.y - 26, 26, 26, 45, 310);

                }
                else
                {
                    g.DrawLine(linSola, pin, pfin);
                }
            }
            
            //Muestra indice de la arista a la mitad de la misma
            string drawString = indice_arista.ToString();
            Font drawFont = new Font("Arial", 16);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            float x = (origen.x + destino.x) / 2 - 20;
            float y = (origen.y + destino.y) / 2 - 20;
            StringFormat drawFormat = new StringFormat();
            g.DrawString(drawString, drawFont, drawBrush, x, y, drawFormat);
        }
    }
}
