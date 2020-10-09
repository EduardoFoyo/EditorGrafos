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
    public class Grafo
    {
        public List<Arista> list_arista;
        public List<Vertice> list_vertice;
        public int indice_grafo { get; set; }
        public Boolean dirigido;

        public int[,] array_adyacencia; 

        public Grafo(int x, int y, int index)
        {
            dirigido = false;
            this.indice_grafo = index;
            list_arista = new List<Arista>();
            list_vertice = new List<Vertice>();
            Vertice v = new Vertice(x, y, this.indice_grafo, 0);
            list_vertice.Add(v); //Agrega el primer nodo a la lista del grafo
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
        public Vertice buscaNodo(int x, int y) //Busca nodo por cordenadas 
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

        public void generaMatriz_Adaycencia() 
        {
            array_adyacencia = new int[this.list_vertice.Count() + 1, this.list_vertice.Count() + 1];

            for (int i = 0; i < this.list_vertice.Count(); i++)
            {
                for (int j = 0; j < this.list_vertice.Count(); j++)
                {
                    array_adyacencia[i, j] = 0;
                }
            }

            foreach (Arista aris in this.list_arista)
            {
                array_adyacencia[aris.origen.indice_vertice, aris.destino.indice_vertice] = 1;
                array_adyacencia[aris.destino.indice_vertice, aris.origen.indice_vertice] = 1;
            }
        }

        public int obtenGradoEntradaNodo(Vertice v)
        {
            int grado = 0;
            foreach (Arista item in list_arista)
            {
                if (item.origen == v)
                {
                    grado++;
                }
                else if (item.destino == v)
                {
                    grado++;
                }
            }
            return grado;
        }

        public void actualiza_grafo_guardado(List<Grafo> list_grafo) //Actualiza los datos del grafo cuando es corgado de un archivo
        {
            foreach (Arista a in list_arista)
            {
                //Actualiza indices del grafo agregado
                a.list_grafo = list_grafo;
                a.indice_grafo = this.indice_grafo;
                a.origen.indice_grafo = this.indice_grafo;
                a.destino.indice_grafo = this.indice_grafo;
            }
        }

    }
}
