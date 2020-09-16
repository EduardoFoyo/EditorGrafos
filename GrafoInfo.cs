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
        public GrafoInfo(Grafo g)
        {
            InitializeComponent();
            list_adyacencia.Hide();
            if (g.dirigido == true)
            {
                dirigido.Hide();
                list_adyacencia.Show();
            }
            this.grafo = g;
        }

        private void dirigido_CheckedChanged(object sender, EventArgs e)
        {
            grafo.dirigido = true;
            dirigido.Hide();
            list_adyacencia.Show();
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
                    mat_adyacencia += array[i, j].ToString();
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
    }
}
