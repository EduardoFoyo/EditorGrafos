using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace EditorGrafos
{
    public class Vertice
    {
        public int indice_grafo;
        public int indice_vertice;
        public int x;
        public int y;
        public int ALTURA = 26;
        public int ANCHO = 26;
        public int RADIO = 26 / 2;


        public Vertice(int x, int y,int index_grafo = -1, int indice_vertice = -1)
        {
            this.x = x;
            this.y = y;
            this.indice_grafo = index_grafo;
            this.indice_vertice = indice_vertice;
        }

        public void dibujaVerice(Graphics g)
        {
            Pen p = new Pen(Color.Black, 1);
            SolidBrush solidBrush = new SolidBrush(Color.White);
            Rectangle rec = new Rectangle(this.x-13, this.y-13, ANCHO, ALTURA);
            g.FillEllipse(solidBrush, rec);
            g.DrawEllipse(p, rec);
            g.DrawString(indice_vertice.ToString(), new Font("Arial", 10), Brushes.Black, this.x-6, this.y-6);
        }

        public int calculaGrado(List<Arista> list_arista)
        {
            int grado = 0;
            foreach (var item in list_arista)
            {
                if (item.origen == this)
                {
                    grado++;
                }
                else if(item.destino == this)
                {
                    grado++;
                }
            }
            return grado;
        }

        public int calculaGradoSalida(List<Arista> list_arista)
        {
            int grado = 0;
            foreach (var item in list_arista)
            {
                if (item.origen == this)
                {
                    grado++;
                }
            }
            return grado;
        }

        public int calculaGradoEntrada(List<Arista> list_arista)
        {
            int grado = 0;
            foreach (var item in list_arista)
            {
                if (item.destino == this)
                {
                    grado++;
                }
            }
            return grado;
        }
    }
}
