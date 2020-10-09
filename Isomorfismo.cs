using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditorGrafos
{
    public partial class Isomorfismo : Form
    {
        public Grafo grafo_a;
        public Grafo grafo_b;

        public Isomorfismo(Grafo a, Grafo b)
        {   
            //Cargar todos los datos de los grafos en las vistas
            this.grafo_a = a;
            this.grafo_b = b;
            InitializeComponent();

            grafo_a.generaMatriz_Adaycencia();
            grafo_b.generaMatriz_Adaycencia();

            data_matriz_a.Columns.Clear();
            data_matriz_a.Rows.Clear();

            int[,] array = new int[grafo_a.list_vertice.Count() + 1, grafo_a.list_vertice.Count() + 1];

            for (int i = 0; i < grafo_a.list_vertice.Count(); i++)
            {
                for (int j = 0; j < grafo_a.list_vertice.Count(); j++)
                {
                    array[i, j] = 0;
                }
            }

            foreach (Arista aris in grafo_a.list_arista)
            {
                array[aris.origen.indice_vertice, aris.destino.indice_vertice] = 1;
                array[aris.destino.indice_vertice, aris.origen.indice_vertice] = 1;
            }

            data_matriz_a.Columns.Add("Index", "");

            for (int i = 0; i < array.GetLength(1) - 1; i++)
            {
                data_matriz_a.Columns.Add("Value", i.ToString());
            }

            for (int i = 0; i < grafo_a.list_vertice.Count(); i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(data_matriz_a);
                for (int j = 0; j < grafo_a.list_vertice.Count(); j++)
                {
                    if (j == 0)
                        row.Cells[j].Value = i.ToString();
                    row.Cells[j + 1].Value = array[i, j].ToString();
                }
                data_matriz_a.Rows.Add(row);
            }
            

            data_matriz_b.Columns.Clear();
            data_matriz_b.Rows.Clear();

            array = new int[grafo_b.list_vertice.Count() + 1, grafo_b.list_vertice.Count() + 1];

            for (int i = 0; i < grafo_b.list_vertice.Count(); i++)
            {
                for (int j = 0; j < grafo_b.list_vertice.Count(); j++)
                {
                    array[i, j] = 0;
                }
            }

            foreach (Arista aris in grafo_b.list_arista)
            {
                array[aris.origen.indice_vertice, aris.destino.indice_vertice] = 1;
                array[aris.destino.indice_vertice, aris.origen.indice_vertice] = 1;
            }

            data_matriz_b.Columns.Add("Index", "");

            for (int i = 0; i < array.GetLength(1) - 1; i++)
            {
                data_matriz_b.Columns.Add("Value", i.ToString());
            }

            for (int i = 0; i < grafo_b.list_vertice.Count(); i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(data_matriz_b);
                for (int j = 0; j < grafo_b.list_vertice.Count(); j++)
                {
                    if (j == 0)
                        row.Cells[j].Value = i.ToString();
                    row.Cells[j + 1].Value = array[i, j].ToString();
                }
                data_matriz_b.Rows.Add(row);
            }

            indice_grafo_label_a.Text = "Indice de Grafo: " + grafo_a.indice_grafo.ToString();
            num_vertices_a.Text = "Numero de Vertices: " + grafo_a.list_vertice.Count();
            num_aristas_a.Text = "Numero de Aristas: " + grafo_a.list_arista.Count();

            indice_grafo_label_b.Text = "Indice de Grafo: " + grafo_b.indice_grafo.ToString();
            num_vertices_b.Text = "Numero de Vertices: " + grafo_b.list_vertice.Count();
            num_aristas_b.Text = "Numero de Aristas: " + grafo_b.list_arista.Count();

            //Prueba de biyeccion a los grafos para verificar isomorfismo
            if (biyeccion(grafo_a, grafo_b))
            {
                MessageBox.Show("SON ISOMORFICOS");
            }
            else
            {
                MessageBox.Show("NO SON ISOMORFICOS");
            }

        }

        public bool biyeccion(Grafo grafo1, Grafo grafo2)
        {
            int sumaColumna = 0;

            //Generar matrices de adyacencia
            grafo1.generaMatriz_Adaycencia();
            grafo2.generaMatriz_Adaycencia();

            int[,] MatrizU = grafo1.array_adyacencia;
            int[,] MatrizV = grafo2.array_adyacencia;

            List<int> arregloGradosSalidaColumna;

            if ((grafo1.list_vertice.Count == grafo2.list_vertice.Count)) // Si tenemos el mismo número de relaciones y nodos 
            {
                if (grafo1.list_arista.Count == grafo2.list_arista.Count) // Si tenemos el mismo número de relaciones y nodos 
                {

                    for (int i = 0; i < grafo1.list_vertice.Count - 1; i++) // Calcula los grados 
                    {
                        arregloGradosSalidaColumna = new List<int>();
                        sumaColumna = grafo1.obtenGradoEntradaNodo(grafo1.list_vertice[i]);
                        for (int j = 0; j < grafo1.list_vertice.Count; j++)
                        {
                            if (MatrizU[j, i] == 1)
                            {
                                int NumAuxGrados = 0;
                                for (int z = 0; z < grafo1.list_vertice.Count; z++)
                                {
                                    NumAuxGrados += MatrizU[z, j];
                                }
                                arregloGradosSalidaColumna.Add(NumAuxGrados);
                            }
                        }
                        int colSim = buscaColumnaSimilar(sumaColumna, i + 1, MatrizV, grafo2, arregloGradosSalidaColumna);

                        if (colSim != 0)
                        {
                            //Permutar columnas con filas 
                            intercambiaColumnna(i, colSim, MatrizV, grafo1.list_vertice.Count);
                            intercambiaRenglon(i, colSim, MatrizV, grafo1.list_vertice.Count);
                            if (comparaMatrices(MatrizU, MatrizV, grafo1.list_vertice.Count))
                            {
                                ady_biy_resultante.Columns.Add("Index", "");

                                for (int j = 0; j < MatrizV.GetLength(1)-1; j++)
                                {
                                    ady_biy_resultante.Columns.Add("Value","");
                                }

                                for (int k = 0; k < grafo2.list_vertice.Count(); k++)
                                {
                                    DataGridViewRow row = new DataGridViewRow();
                                    row.CreateCells(ady_biy_resultante);
                                    for (int j = 0; j < grafo2.list_vertice.Count(); j++)
                                    {
                                        row.Cells[j].Value = MatrizV[k, j].ToString();
                                    }
                                    ady_biy_resultante.Rows.Add(row);
                                }
                                MessageBox.Show("Grafo V recorrido por biyeccion y las matrices coinciden");
                                return true;
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Los grafos no tienen el mismo número de aristas!!!!");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Los grafos no tienen el mismo número de nodos!!!!");
                return false;
            }
            return false;
        }

        private void lista_grados_a_Click(object sender, EventArgs e)
        {
            string grados_nodo = "";
            foreach (Vertice item in grafo_a.list_vertice)
            {
                int grado = item.calculaGrado(grafo_a.list_arista);
                grados_nodo += item.indice_vertice.ToString() + ".- " + grado.ToString() + "\n";
            }
            MessageBox.Show(grados_nodo);
        }

        private void lista_grados_b_Click(object sender, EventArgs e)
        {
            string grados_nodo = "";
            foreach (Vertice item in grafo_b.list_vertice)
            {
                int grado = item.calculaGrado(grafo_b.list_arista);
                grados_nodo += item.indice_vertice.ToString() + ".- " + grado.ToString() + "\n";
            }
            MessageBox.Show(grados_nodo);
        }

        //Funcion de isomorfismo por fuerza bruta
        public bool isomorfismo_fuerza_bruta(Grafo g1, Grafo g2)
        {
            if (g1 != null && g2 != null)
            {
                if (g1.list_vertice.Count == g2.list_vertice.Count)
                {
                    if (g1.list_arista.Count == g2.list_arista.Count)
                    {
                        int tam = g1.list_vertice.Count;

                        g1.generaMatriz_Adaycencia();
                        int[,] matrizGrafo1 = g1.array_adyacencia;
                        g2.generaMatriz_Adaycencia();
                        int[,] matrizGrafo2 = g2.array_adyacencia;

                        if (comparaMatriz(matrizGrafo1, matrizGrafo2, tam))
                        {
                            MessageBox.Show("Las Matrices son Iguales");
                            return true;
                        }
                        else
                        {
                            long[] fact = { 1, 2, 6, 24, 120, 720, 5040, 40320, 362880, 3628800,
                           39916800};
                            int count = g1.list_vertice.Count;
                            int[] indexp = new int[count];

                            for (int i = 0; i < count; i++)
                            {
                                indexp[i] = i;
                            }

                            for (int i = 0; i < fact[count - 1]; i++)
                            {
                                siguientePermutacion(indexp);
                                string Aux = "";
                                for (int z = 0; z < indexp.GetLength(0); z++)
                                {
                                    Aux += "{" + (z + 1) + " , " + (indexp[z] + 1) + "}   ";
                                }
                                if (PruebaPermutacion(matrizGrafo1, matrizGrafo2, indexp))
                                {
                                    MessageBox.Show("Las Matrices fueron sometidas a fuerza bruta y son iguales");
                                    return true;
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Numero de aristas diferente");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Numero de vertices diferente");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Uno o ambos nodos sobn Nulos");
                return false;
            }
            return false;
        }

        public bool comparaMatriz(int[,] matriz1, int[,] matriz2, int tamMatriz)
        {
            for (int i = 0; i < tamMatriz; i++)
            {
                for (int j = 0; j < tamMatriz; j++)
                {
                    if (matriz1[i, j] != matriz2[i, j])
                        return false;
                }
            }
            return true;
        }

        public int buscaColumnaSimilar(int GradoColumna, int PosicionColumna, int[,] Matriz, Grafo grafo, List<int> GradosSalida)
        {
            bool Bandera;
            int TamañoMatriz = grafo.list_vertice.Count;
            List<int> ListaAuxiliar = new List<int>();
            for (int i = PosicionColumna; i < TamañoMatriz; i++)
            {
                if (grafo.obtenGradoEntradaNodo(grafo.list_vertice[i]) == GradoColumna)
                {
                    Bandera = true;
                    for (int j = 0; j < grafo.list_vertice.Count; j++)
                    {
                        if (Matriz[j, i] == 1)
                        {
                            int NumAuxgrados = 0;
                            for (int z = 0; z < grafo.list_vertice.Count; z++)
                            {
                                NumAuxgrados += Matriz[z, j];
                            }
                            ListaAuxiliar.Add(NumAuxgrados);
                        }
                    }
                    ListaAuxiliar.Sort();
                    GradosSalida.Sort();
                    for (int z = 0; z < ListaAuxiliar.Count; z++)
                    {
                        if (ListaAuxiliar[z] != GradosSalida[z])
                        {
                            Bandera = false;
                        }
                    }
                    ListaAuxiliar.Clear();
                    if (Bandera)
                    {
                        return i;
                    }
                }
            }
            return 0;
        }

        public void intercambiaColumnna(int ColumnaOrigen, int ColumnaDestino, int[,] Matriz, int Tamaño)
        {
            int[,] Copia = new int[Tamaño, Tamaño];
            for (int i = 0; i < Tamaño; i++)
            {
                for (int j = 0; j < Tamaño; j++)
                {
                    Copia[i, j] = Matriz[i, j];
                }
            }

            for (int i = 0; i < Tamaño; i++)
            {
                Matriz[i, ColumnaDestino] = Copia[i, ColumnaOrigen];
                Matriz[i, ColumnaOrigen] = Copia[i, ColumnaDestino];
            }
        }

        public void intercambiaRenglon(int RenglonOrigen, int RenglonDestino, int[,] Matriz, int Tamaño)
        {
            int[,] Copia = new int[Tamaño, Tamaño];
            for (int i = 0; i < Tamaño; i++)
            {
                for (int j = 0; j < Tamaño; j++)
                {
                    Copia[i, j] = Matriz[i, j];
                }
            }

            for (int i = 0; i < Tamaño; i++)
            {
                Matriz[RenglonDestino, i] = Copia[RenglonOrigen, i];
                Matriz[RenglonOrigen, i] = Copia[RenglonDestino, i];
            }
        }

        public bool comparaMatrices(int[,] Matriz1, int[,] Matriz2, int tamaño)
        {
            bool r = true;
            for (int i = 0; i < tamaño; i++)
            {
                for (int j = 0; j < tamaño; j++)
                {
                    if (Matriz1[i, j] != Matriz2[i, j]) { return false; }
                }
            }

            return r;
        }

        private static bool siguientePermutacion(int[] numList)
        {

            var largestIndex = -1;
            for (var i = numList.Length - 2; i >= 0; i--)
            {
                if (numList[i] < numList[i + 1])
                {
                    largestIndex = i;
                    break;
                }
            }
            if (largestIndex < 0) return false;
            var largestIndex2 = -1;
            for (var i = numList.Length - 1; i >= 0; i--)
            {
                if (numList[largestIndex] < numList[i])
                {
                    largestIndex2 = i;
                    break;
                }
            }
            var tmp = numList[largestIndex];
            numList[largestIndex] = numList[largestIndex2];
            numList[largestIndex2] = tmp;
            for (int i = largestIndex + 1, j = numList.Length - 1; i < j; i++, j--)
            {
                tmp = numList[i];
                numList[i] = numList[j];
                numList[j] = tmp;
            }
            return true;
        }
        public bool PruebaPermutacion(int[,] M1, int[,] M2, int[] permutacion)
        {
            for (int i = 0; i < permutacion.Length; i++)
                for (int j = 0; j < permutacion.Length; j++)
                    if (M1[i, j] != M2[permutacion[i], permutacion[j]]) return false;
            return true;
        }

        private void fuerza_bruta_isomorfismo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se probaran ambos grafos con un algoritmo de Fuerza Bruta \n Lo que hace este algoritmo son todas las combinaciones posibles de los grafos encontrando si son isomorficos" +
                "\n(En caso de ser muchos nodos el proceso podria demorar un poco)");
            if (isomorfismo_fuerza_bruta(grafo_a, grafo_b))
            {
                MessageBox.Show("SON ISOMORFICOS");
            }
            else
            {
                MessageBox.Show("NO SON ISOMORFICOS");
            }
        }
    }
}
