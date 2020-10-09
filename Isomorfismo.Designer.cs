namespace EditorGrafos
{
    partial class Isomorfismo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.data_matriz_a = new System.Windows.Forms.DataGridView();
            this.data_matriz_b = new System.Windows.Forms.DataGridView();
            this.num_aristas_a = new System.Windows.Forms.Label();
            this.num_vertices_a = new System.Windows.Forms.Label();
            this.indice_grafo_label_a = new System.Windows.Forms.Label();
            this.num_aristas_b = new System.Windows.Forms.Label();
            this.num_vertices_b = new System.Windows.Forms.Label();
            this.indice_grafo_label_b = new System.Windows.Forms.Label();
            this.lista_grados_a = new System.Windows.Forms.Button();
            this.lista_grados_b = new System.Windows.Forms.Button();
            this.ady_biy_resultante = new System.Windows.Forms.DataGridView();
            this.fuerza_bruta_isomorfismo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_matriz_a)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_matriz_b)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ady_biy_resultante)).BeginInit();
            this.SuspendLayout();
            // 
            // data_matriz_a
            // 
            this.data_matriz_a.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_matriz_a.Location = new System.Drawing.Point(15, 114);
            this.data_matriz_a.Name = "data_matriz_a";
            this.data_matriz_a.RowTemplate.Height = 24;
            this.data_matriz_a.Size = new System.Drawing.Size(605, 174);
            this.data_matriz_a.TabIndex = 8;
            // 
            // data_matriz_b
            // 
            this.data_matriz_b.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_matriz_b.Location = new System.Drawing.Point(628, 114);
            this.data_matriz_b.Name = "data_matriz_b";
            this.data_matriz_b.RowTemplate.Height = 24;
            this.data_matriz_b.Size = new System.Drawing.Size(605, 174);
            this.data_matriz_b.TabIndex = 9;
            // 
            // num_aristas_a
            // 
            this.num_aristas_a.AutoSize = true;
            this.num_aristas_a.Location = new System.Drawing.Point(12, 54);
            this.num_aristas_a.Name = "num_aristas_a";
            this.num_aristas_a.Size = new System.Drawing.Size(16, 17);
            this.num_aristas_a.TabIndex = 18;
            this.num_aristas_a.Text = "a";
            // 
            // num_vertices_a
            // 
            this.num_vertices_a.AutoSize = true;
            this.num_vertices_a.Location = new System.Drawing.Point(12, 33);
            this.num_vertices_a.Name = "num_vertices_a";
            this.num_vertices_a.Size = new System.Drawing.Size(16, 17);
            this.num_vertices_a.TabIndex = 17;
            this.num_vertices_a.Text = "a";
            // 
            // indice_grafo_label_a
            // 
            this.indice_grafo_label_a.AutoSize = true;
            this.indice_grafo_label_a.Location = new System.Drawing.Point(12, 9);
            this.indice_grafo_label_a.Name = "indice_grafo_label_a";
            this.indice_grafo_label_a.Size = new System.Drawing.Size(16, 17);
            this.indice_grafo_label_a.TabIndex = 16;
            this.indice_grafo_label_a.Text = "a";
            // 
            // num_aristas_b
            // 
            this.num_aristas_b.AutoSize = true;
            this.num_aristas_b.Location = new System.Drawing.Point(639, 54);
            this.num_aristas_b.Name = "num_aristas_b";
            this.num_aristas_b.Size = new System.Drawing.Size(16, 17);
            this.num_aristas_b.TabIndex = 21;
            this.num_aristas_b.Text = "a";
            // 
            // num_vertices_b
            // 
            this.num_vertices_b.AutoSize = true;
            this.num_vertices_b.Location = new System.Drawing.Point(639, 33);
            this.num_vertices_b.Name = "num_vertices_b";
            this.num_vertices_b.Size = new System.Drawing.Size(16, 17);
            this.num_vertices_b.TabIndex = 20;
            this.num_vertices_b.Text = "a";
            // 
            // indice_grafo_label_b
            // 
            this.indice_grafo_label_b.AutoSize = true;
            this.indice_grafo_label_b.Location = new System.Drawing.Point(639, 9);
            this.indice_grafo_label_b.Name = "indice_grafo_label_b";
            this.indice_grafo_label_b.Size = new System.Drawing.Size(16, 17);
            this.indice_grafo_label_b.TabIndex = 19;
            this.indice_grafo_label_b.Text = "a";
            // 
            // lista_grados_a
            // 
            this.lista_grados_a.Location = new System.Drawing.Point(15, 85);
            this.lista_grados_a.Name = "lista_grados_a";
            this.lista_grados_a.Size = new System.Drawing.Size(200, 23);
            this.lista_grados_a.TabIndex = 22;
            this.lista_grados_a.Text = "Lista de Grados";
            this.lista_grados_a.UseVisualStyleBackColor = true;
            this.lista_grados_a.Click += new System.EventHandler(this.lista_grados_a_Click);
            // 
            // lista_grados_b
            // 
            this.lista_grados_b.Location = new System.Drawing.Point(642, 85);
            this.lista_grados_b.Name = "lista_grados_b";
            this.lista_grados_b.Size = new System.Drawing.Size(200, 23);
            this.lista_grados_b.TabIndex = 23;
            this.lista_grados_b.Text = "Lista de Grados";
            this.lista_grados_b.UseVisualStyleBackColor = true;
            this.lista_grados_b.Click += new System.EventHandler(this.lista_grados_b_Click);
            // 
            // ady_biy_resultante
            // 
            this.ady_biy_resultante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ady_biy_resultante.Location = new System.Drawing.Point(628, 330);
            this.ady_biy_resultante.Name = "ady_biy_resultante";
            this.ady_biy_resultante.RowTemplate.Height = 24;
            this.ady_biy_resultante.Size = new System.Drawing.Size(605, 174);
            this.ady_biy_resultante.TabIndex = 24;
            // 
            // fuerza_bruta_isomorfismo
            // 
            this.fuerza_bruta_isomorfismo.Location = new System.Drawing.Point(482, 555);
            this.fuerza_bruta_isomorfismo.Name = "fuerza_bruta_isomorfismo";
            this.fuerza_bruta_isomorfismo.Size = new System.Drawing.Size(260, 37);
            this.fuerza_bruta_isomorfismo.TabIndex = 25;
            this.fuerza_bruta_isomorfismo.Text = "Fuerza Bruta";
            this.fuerza_bruta_isomorfismo.UseVisualStyleBackColor = true;
            this.fuerza_bruta_isomorfismo.Click += new System.EventHandler(this.fuerza_bruta_isomorfismo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(625, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Matriz Resultante Biyeccion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(438, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Matriz de Adyacencia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1051, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Matriz de Adyacencia";
            // 
            // Isomorfismo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 604);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fuerza_bruta_isomorfismo);
            this.Controls.Add(this.ady_biy_resultante);
            this.Controls.Add(this.lista_grados_b);
            this.Controls.Add(this.lista_grados_a);
            this.Controls.Add(this.num_aristas_b);
            this.Controls.Add(this.num_vertices_b);
            this.Controls.Add(this.indice_grafo_label_b);
            this.Controls.Add(this.num_aristas_a);
            this.Controls.Add(this.num_vertices_a);
            this.Controls.Add(this.indice_grafo_label_a);
            this.Controls.Add(this.data_matriz_b);
            this.Controls.Add(this.data_matriz_a);
            this.Name = "Isomorfismo";
            this.Text = "Isomorfismo";
            ((System.ComponentModel.ISupportInitialize)(this.data_matriz_a)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_matriz_b)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ady_biy_resultante)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_matriz_a;
        private System.Windows.Forms.DataGridView data_matriz_b;
        private System.Windows.Forms.Label num_aristas_a;
        private System.Windows.Forms.Label num_vertices_a;
        private System.Windows.Forms.Label indice_grafo_label_a;
        private System.Windows.Forms.Label num_aristas_b;
        private System.Windows.Forms.Label num_vertices_b;
        private System.Windows.Forms.Label indice_grafo_label_b;
        private System.Windows.Forms.Button lista_grados_a;
        private System.Windows.Forms.Button lista_grados_b;
        private System.Windows.Forms.DataGridView ady_biy_resultante;
        private System.Windows.Forms.Button fuerza_bruta_isomorfismo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}