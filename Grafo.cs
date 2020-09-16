using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace EditorGrafos
{
    public class Grafo
    {
        public List<Arista> list_arista;
        public List<Vertice> list_vertice;
        public int indice_grafo;
        public Boolean dirigido;

        public Grafo(int x, int y, int index)
        {
            dirigido = false;
            this.indice_grafo = index;
            list_arista = new List<Arista>();
            list_vertice = new List<Vertice>();
            Vertice v = new Vertice(x, y, this.indice_grafo, 0);
            list_vertice.Add(v);
        }

        public void dibujaGrafo(Graphics g)
        {
            foreach (Arista item in list_arista)
            {
                item.dibujaArista(g);
            }

            foreach (Vertice item in list_vertice)
            {
                item.dibujaVerice(g);
            }
        }
        public Vertice buscaNodo(int x, int y)
        {
            double dist = 0;
            Vertice n = new Vertice(x,y,this.indice_grafo);
            n = null;

            foreach (Vertice nod in this.list_vertice)
            {
                dist = Math.Sqrt(Math.Pow(x - nod.x, 2) + Math.Pow(y - nod.y, 2));
                if (dist <= (nod.ANCHO / 2))
                {
                    n = nod;
                    break;
                }
            }
            return n;
        }

    }
}
