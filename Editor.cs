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
    public partial class Editor : Form
    {
        List<Grafo> list_grafo;
        Boolean bandera_agrega_vertice;
        Boolean bandera_agrega_grafo;
        Boolean bandera_agrega_arista;
        Boolean bandera_agrega_arista_segundo;
        Boolean bandera_mover_vertices;
        Boolean bandera_moviendo_vartice;
        Boolean bandera_mover_grafo;
        Boolean bandera_moviendo_grafo;
        Vertice auxv1 = new Vertice(0, 0);
        Vertice auxv2 = new Vertice(0, 0);
        Vertice aux_mover_nodo = new Vertice(0, 0);
        Vertice nuevo_nodo;

        int coordenada_mover_grafo_x;
        int coordenada_mover_grafo_y;
        int id_grafo_en_movimiento;

        public Editor()
        {
            InitializeComponent();
            list_grafo = new List<Grafo>();
            bandera_agrega_vertice = false;
            bandera_agrega_grafo = false;
            bandera_agrega_arista = false;
            bandera_agrega_arista_segundo = false;
            bandera_mover_vertices = false;
            bandera_moviendo_vartice = false;
            bandera_mover_grafo = false;
            bandera_moviendo_grafo = false;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Grafo item in list_grafo)
            {
                item.dibujaGrafo(e.Graphics);
            }
            if (nuevo_nodo != null)
            {
                nuevo_nodo.dibujaVerice(e.Graphics);
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (bandera_agrega_grafo == true)
                {
                    Grafo g = new Grafo(e.X, e.Y, list_grafo.Count);
                    list_grafo.Add(g);
                    bandera_agrega_grafo = false;
                }
                if (bandera_agrega_vertice == true)
                {
                    nuevo_nodo = new Vertice(e.X, e.Y);
                    bandera_agrega_vertice = false;
                }

                //Segundo Click a los grafos 
                if (bandera_agrega_arista == true && bandera_agrega_arista_segundo == true)
                {
                    bandera_agrega_arista = false;
                    bandera_agrega_arista_segundo = false;

                    double dist = 0;

                    if (nuevo_nodo != null)
                    {
                        dist = Math.Sqrt(Math.Pow(e.X - nuevo_nodo.x, 2) + Math.Pow(e.Y - nuevo_nodo.y, 2));
                        if (dist <= (nuevo_nodo.ANCHO / 2))
                            auxv2 = nuevo_nodo;
                    }

                    Vertice aux;
                    foreach (Grafo item in list_grafo)
                    {
                        aux = item.buscaNodo(e.X, e.Y);
                        if (aux != null)
                        {
                            auxv2 = aux;
                            break;
                        }
                    }
                    

                    Arista nueva_arista = new Arista(this.auxv1, this.auxv2, list_grafo);

                    foreach (Grafo item in list_grafo)
                    {
                        if (item.indice_grafo == auxv1.indice_grafo || item.indice_grafo == auxv2.indice_grafo)
                        {                           
                            if (-1 == auxv1.indice_grafo)
                            {
                                nueva_arista.origen.indice_grafo = auxv2.indice_grafo;
                                auxv1.indice_vertice = item.list_vertice.Count();
                                item.list_vertice.Add(this.auxv1);
                            }
                            else if(-1 == auxv2.indice_grafo)
                            {
                                nueva_arista.destino.indice_grafo = auxv1.indice_grafo;
                                auxv2.indice_vertice = item.list_vertice.Count();
                                item.list_vertice.Add(this.auxv2);
                            }
                            nueva_arista.indice_grafo = item.indice_grafo;
                            item.list_arista.Add(nueva_arista);
                            break;
                        }
                    }
                }

                if (bandera_agrega_arista == true && bandera_agrega_arista_segundo == false)
                {
                    double dist = 0;
                    bandera_agrega_arista_segundo = true;
                    if (nuevo_nodo != null)
                    {
                        dist = Math.Sqrt(Math.Pow(e.X - nuevo_nodo.x, 2) + Math.Pow(e.Y - nuevo_nodo.y, 2));
                        if (dist <= (nuevo_nodo.ANCHO / 2))
                            auxv1 = nuevo_nodo;
                    }

                    Vertice aux;
                    foreach (Grafo item in list_grafo)
                    {
                        aux = item.buscaNodo(e.X, e.Y);
                        if (aux != null)
                        {
                            auxv1 = aux;
                            break;
                        }
                    }
                }
            }
            pictureBox1.Invalidate();
        }

        private void agrega_grafo_Click(object sender, EventArgs e)
        {
            bandera_agrega_grafo = !bandera_agrega_grafo;
        }

        private void agrega_vertice_Click(object sender, EventArgs e)
        {
            bandera_agrega_vertice = !bandera_agrega_vertice;
        }

        private void agrega_arista_Click(object sender, EventArgs e)
        {
            bandera_agrega_arista = !bandera_agrega_arista;
        }

        private void mover_vertice_CheckedChanged(object sender, EventArgs e)
        {
            this.bandera_mover_vertices = !this.bandera_mover_vertices;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.bandera_mover_grafo = !this.bandera_mover_grafo ;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (bandera_mover_vertices != false)
            {
                Vertice aux;
                foreach (Grafo item in list_grafo)
                {
                    aux = item.buscaNodo(e.X, e.Y);
                    if (aux != null)
                    {
                        bandera_moviendo_vartice = true;
                        this.aux_mover_nodo = aux;
                        break;
                    }
                }
            }

            if (bandera_mover_grafo != false)
            {
                Vertice aux;
                foreach (Grafo item in list_grafo)
                {
                    aux = item.buscaNodo(e.X, e.Y);
                    if (aux != null)
                    {
                        coordenada_mover_grafo_x = aux.x;
                        coordenada_mover_grafo_y = aux.y;

                        bandera_moviendo_grafo = true;
                        id_grafo_en_movimiento = aux.indice_grafo;
                        break;
                    }
                }
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (bandera_mover_vertices != false && bandera_moviendo_vartice != false)
            {
                this.aux_mover_nodo.x = e.X;
                this.aux_mover_nodo.y = e.Y;
                pictureBox1.Invalidate();
            }

            if (bandera_moviendo_grafo !=false && bandera_moviendo_grafo != false)
            {
                int incremento_x = e.X - coordenada_mover_grafo_x;
                int incremento_y = e.Y - coordenada_mover_grafo_y;
                foreach (Grafo item in list_grafo)
                {
                    if (item.indice_grafo == id_grafo_en_movimiento)
                    {
                        foreach (Vertice item_vertice in item.list_vertice)
                        {
                            item_vertice.x += incremento_x;
                            item_vertice.y += incremento_y;
                            pictureBox1.Invalidate();
                        }
                    }
                }
                coordenada_mover_grafo_x = e.X;
                coordenada_mover_grafo_y = e.Y;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            bandera_moviendo_vartice = false;
            bandera_moviendo_grafo = false;
        }

        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Vertice aux;
                foreach (Grafo item in list_grafo)
                {
                    aux = item.buscaNodo(e.X, e.Y);
                    if (aux != null)
                    {
                        Grafo gi_aux = list_grafo[aux.indice_grafo];
                        GrafoInfo gi = new GrafoInfo(gi_aux);
                        gi.Show();
                        pictureBox1.Invalidate();
                        break;
                    }
                }
            }
        }
    }
}
