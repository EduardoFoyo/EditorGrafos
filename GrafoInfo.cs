using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditorGrafos
{
    public partial class GrafoInfo : Form
    {
        public Grafo grafo;
        public int indice_grafo;
        public int grado;
        public int grado_entrada;
        public int grado_salida;

        public GrafoInfo(Grafo g,int indice_grafo, int grado, int grado_entrada, int grado_salida_nodo)
        {
            InitializeComponent();
            this.indice_grafo = indice_grafo;
            this.grado = grado;
            indice_grafo_label.Text = "Indice de Grafo: " + indice_grafo.ToString();
            grado_nodo.Text = "Grado del Nodo: "+grado.ToString();
            this.grado_entrada = grado_entrada;
            this.grado_salida = grado_salida_nodo;

            if (g.dirigido == true)
            {
                dirigido.Hide();
                grado_nodo.Text = "Grado de Entrada del Nodo: " + grado_entrada.ToString();
                label_grado_salida.Text = "Grado de Salida del Nodo: " + grado_salida_nodo.ToString();
            }
            this.grafo = g;
        }

        private void dirigido_CheckedChanged(object sender, EventArgs e)
        {
            grafo.dirigido = true;
            dirigido.Hide();
            grado_nodo.Text = "Grado de Entrada del Nodo: " + this.grado_entrada.ToString();
            label_grado_salida.Text = "Grado de Salida del Nodo: " + this.grado_salida.ToString();
        }

        private void mat_adyacencia_Click(object sender, EventArgs e)
        {
            string mat_adyacencia = "";

            int[,] array = new int[grafo.list_vertice.Count() + 1, grafo.list_vertice.Count() + 1];

            for (int i = 0; i < grafo.list_vertice.Count(); i++)
            {
                for (int j = 0; j < grafo.list_vertice.Count(); j++)
                {
                    array[i, j] = 0;
                }
            }

            foreach (Arista aris in grafo.list_arista)
            {
                array[aris.origen.indice_vertice, aris.destino.indice_vertice] = 1;
                array[aris.destino.indice_vertice, aris.origen.indice_vertice] = 1;
            }

            for (int i = 0; i < grafo.list_vertice.Count(); i++)
            {
                for (int j = 0; j < grafo.list_vertice.Count(); j++)
                {
                    mat_adyacencia += " "+array[i, j].ToString()+" ";
                }
                mat_adyacencia += "\n";
            }

            MessageBox.Show(mat_adyacencia);
        }

        private void list_adyacencia_Click(object sender, EventArgs e)
        {
            string lista_adyacencia = "";
            foreach (Vertice vert in grafo.list_vertice)
            {
                foreach (Arista aris in grafo.list_arista)
                {
                    if (vert == aris.origen)
                    {
                        lista_adyacencia += "Origen: " + aris.origen.indice_vertice.ToString() + " Destino: " + aris.destino.indice_vertice.ToString();
                        lista_adyacencia += "\n";
                    }
                }
            }
            MessageBox.Show(lista_adyacencia);
        }

        private void matriz_incidencia_Click(object sender, EventArgs e)
        {
            string matriz_incidencia = "";

            int[,] array = new int[grafo.list_vertice.Count() + 1, grafo.list_arista.Count() + 1];

            for (int i = 0; i < grafo.list_vertice.Count(); i++)
            {
                for (int j = 0; j < grafo.list_arista.Count(); j++)
                {
                    array[i, j] = 0;
                }
            }

            for (int i = 0; i < grafo.list_vertice.Count(); i++)
            {
                for (int j = 0; j < grafo.list_arista.Count(); j++)
                {
                    if (grafo.list_vertice[i] == grafo.list_arista[j].origen)
                    {
                        array[i, j] = 1;
                    }
                    else if (grafo.list_vertice[i] == grafo.list_arista[j].destino)
                    {
                        array[i, j] = -1;
                    }
                }
            }

            for (int i = 0; i < grafo.list_vertice.Count(); i++)
            {
                for (int j = 0; j < grafo.list_arista.Count(); j++)
                {
                    matriz_incidencia += " " + array[i, j].ToString() + " ";
                }
                matriz_incidencia += "\n";
            }

            MessageBox.Show(matriz_incidencia);

        }
    }
}
