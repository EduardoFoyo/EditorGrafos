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

        public GrafoInfo(Grafo g,int indice_grafo)
        {
            InitializeComponent();
            this.grafo = g;
            this.indice_grafo = indice_grafo;

            if (g.dirigido == true)
            {
                dirigido.Hide();
            }
        }

        private void dirigido_CheckedChanged(object sender, EventArgs e)
        {
            grafo.dirigido = true;
            dirigido.Hide();
        }

        private void mat_adyacencia_Click(object sender, EventArgs e)
        {
            data_matriz.Columns.Clear();
            data_matriz.Rows.Clear();

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

            data_matriz.Columns.Add("Index", "");

            for (int i = 0; i < array.GetLength(1)-1; i++)
            {
                data_matriz.Columns.Add("Value", i.ToString());
            }

            for (int i = 0; i < grafo.list_vertice.Count(); i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(data_matriz);
                for (int j = 0; j < grafo.list_vertice.Count(); j++)
                {
                    if (j==0)
                        row.Cells[j].Value = i.ToString();
                    row.Cells[j+1].Value = array[i, j].ToString();
                }
                data_matriz.Rows.Add(row);
            }
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
            data_matriz.Columns.Clear();
            data_matriz.Rows.Clear();

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

            data_matriz.Columns.Add("Index", "");

            for (int i = 0; i < grafo.list_arista.Count(); i++)
            {
                data_matriz.Columns.Add("Value", i.ToString());
            }

            for (int i = 0; i < grafo.list_vertice.Count(); i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(data_matriz);
                for (int j = 0; j < grafo.list_arista.Count(); j++)
                {
                    if (j == 0)
                        row.Cells[j].Value = i.ToString();
                    row.Cells[j + 1].Value = array[i, j].ToString();
                }
                data_matriz.Rows.Add(row);
            }
        }

        private void grados_list_Click(object sender, EventArgs e)
        {
            string grados_nodo = "";
            foreach (Vertice item in this.grafo.list_vertice)
            {
                int grado = item.calculaGrado(grafo.list_arista);
                grados_nodo += item.indice_vertice.ToString() + ".- " + grado.ToString() + "\n";
            }
            MessageBox.Show(grados_nodo);
        }

        private void list_grados_dirigidos_Click(object sender, EventArgs e)
        {
            if (grafo.dirigido)
            {
                string grados_nodo = "";
                foreach (Vertice item in this.grafo.list_vertice)
                {
                    int grado_entrada = item.calculaGradoEntrada(grafo.list_arista);
                    int grado_salida = item.calculaGradoSalida(grafo.list_arista);
                    grados_nodo += item.indice_vertice.ToString() + ".- Grados de Entrada: " + grado_entrada.ToString() + " Grados de Salida: " + grado_salida.ToString() + "\n";
                }
                MessageBox.Show(grados_nodo);
            }
        }
    }
}
