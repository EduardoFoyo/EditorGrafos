namespace EditorGrafos
{
    partial class GrafoInfo
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
            this.dirigido = new System.Windows.Forms.CheckBox();
            this.mat_adyacencia = new System.Windows.Forms.Button();
            this.list_adyacencia = new System.Windows.Forms.Button();
            this.matriz_incidencia = new System.Windows.Forms.Button();
            this.label_grado_salida = new System.Windows.Forms.Label();
            this.indice_grafo_label = new System.Windows.Forms.Label();
            this.data_matriz = new System.Windows.Forms.DataGridView();
            this.grados_list = new System.Windows.Forms.Button();
            this.list_grados_dirigidos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_matriz)).BeginInit();
            this.SuspendLayout();
            // 
            // dirigido
            // 
            this.dirigido.AutoSize = true;
            this.dirigido.Location = new System.Drawing.Point(12, 12);
            this.dirigido.Name = "dirigido";
            this.dirigido.Size = new System.Drawing.Size(78, 21);
            this.dirigido.TabIndex = 0;
            this.dirigido.Text = "Dirigido";
            this.dirigido.UseVisualStyleBackColor = true;
            this.dirigido.CheckedChanged += new System.EventHandler(this.dirigido_CheckedChanged);
            // 
            // mat_adyacencia
            // 
            this.mat_adyacencia.Location = new System.Drawing.Point(625, 12);
            this.mat_adyacencia.Name = "mat_adyacencia";
            this.mat_adyacencia.Size = new System.Drawing.Size(163, 26);
            this.mat_adyacencia.TabIndex = 1;
            this.mat_adyacencia.Text = "Matriz de Adyacencia";
            this.mat_adyacencia.UseVisualStyleBackColor = true;
            this.mat_adyacencia.Click += new System.EventHandler(this.mat_adyacencia_Click);
            // 
            // list_adyacencia
            // 
            this.list_adyacencia.Location = new System.Drawing.Point(625, 44);
            this.list_adyacencia.Name = "list_adyacencia";
            this.list_adyacencia.Size = new System.Drawing.Size(163, 26);
            this.list_adyacencia.TabIndex = 2;
            this.list_adyacencia.Text = "Lista de Adyacencia";
            this.list_adyacencia.UseVisualStyleBackColor = true;
            this.list_adyacencia.Click += new System.EventHandler(this.list_adyacencia_Click);
            // 
            // matriz_incidencia
            // 
            this.matriz_incidencia.Location = new System.Drawing.Point(625, 76);
            this.matriz_incidencia.Name = "matriz_incidencia";
            this.matriz_incidencia.Size = new System.Drawing.Size(163, 27);
            this.matriz_incidencia.TabIndex = 3;
            this.matriz_incidencia.Text = "Matriz de Incidencia";
            this.matriz_incidencia.UseVisualStyleBackColor = true;
            this.matriz_incidencia.Click += new System.EventHandler(this.matriz_incidencia_Click);
            // 
            // label_grado_salida
            // 
            this.label_grado_salida.AutoSize = true;
            this.label_grado_salida.Location = new System.Drawing.Point(96, 44);
            this.label_grado_salida.Name = "label_grado_salida";
            this.label_grado_salida.Size = new System.Drawing.Size(0, 17);
            this.label_grado_salida.TabIndex = 5;
            // 
            // indice_grafo_label
            // 
            this.indice_grafo_label.AutoSize = true;
            this.indice_grafo_label.Location = new System.Drawing.Point(431, 18);
            this.indice_grafo_label.Name = "indice_grafo_label";
            this.indice_grafo_label.Size = new System.Drawing.Size(0, 17);
            this.indice_grafo_label.TabIndex = 6;
            // 
            // data_matriz
            // 
            this.data_matriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_matriz.Location = new System.Drawing.Point(12, 129);
            this.data_matriz.Name = "data_matriz";
            this.data_matriz.RowTemplate.Height = 24;
            this.data_matriz.Size = new System.Drawing.Size(776, 309);
            this.data_matriz.TabIndex = 7;
            // 
            // grados_list
            // 
            this.grados_list.Location = new System.Drawing.Point(457, 14);
            this.grados_list.Name = "grados_list";
            this.grados_list.Size = new System.Drawing.Size(153, 23);
            this.grados_list.TabIndex = 8;
            this.grados_list.Text = "Lista de Grados";
            this.grados_list.UseVisualStyleBackColor = true;
            this.grados_list.Click += new System.EventHandler(this.grados_list_Click);
            // 
            // list_grados_dirigidos
            // 
            this.list_grados_dirigidos.Location = new System.Drawing.Point(457, 47);
            this.list_grados_dirigidos.Name = "list_grados_dirigidos";
            this.list_grados_dirigidos.Size = new System.Drawing.Size(153, 23);
            this.list_grados_dirigidos.TabIndex = 9;
            this.list_grados_dirigidos.Text = "Lista de Grados Dirigidos";
            this.list_grados_dirigidos.UseVisualStyleBackColor = true;
            this.list_grados_dirigidos.Click += new System.EventHandler(this.list_grados_dirigidos_Click);
            // 
            // GrafoInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.list_grados_dirigidos);
            this.Controls.Add(this.grados_list);
            this.Controls.Add(this.data_matriz);
            this.Controls.Add(this.indice_grafo_label);
            this.Controls.Add(this.label_grado_salida);
            this.Controls.Add(this.matriz_incidencia);
            this.Controls.Add(this.list_adyacencia);
            this.Controls.Add(this.mat_adyacencia);
            this.Controls.Add(this.dirigido);
            this.Name = "GrafoInfo";
            this.Text = "GrafoInfo";
            ((System.ComponentModel.ISupportInitialize)(this.data_matriz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox dirigido;
        private System.Windows.Forms.Button mat_adyacencia;
        private System.Windows.Forms.Button list_adyacencia;
        private System.Windows.Forms.Button matriz_incidencia;
        private System.Windows.Forms.Label label_grado_salida;
        private System.Windows.Forms.Label indice_grafo_label;
        private System.Windows.Forms.DataGridView data_matriz;
        private System.Windows.Forms.Button grados_list;
        private System.Windows.Forms.Button list_grados_dirigidos;
    }
}