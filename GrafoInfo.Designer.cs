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
            this.grado_nodo = new System.Windows.Forms.Label();
            this.label_grado_salida = new System.Windows.Forms.Label();
            this.indice_grafo_label = new System.Windows.Forms.Label();
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
            // grado_nodo
            // 
            this.grado_nodo.AutoSize = true;
            this.grado_nodo.Location = new System.Drawing.Point(96, 13);
            this.grado_nodo.Name = "grado_nodo";
            this.grado_nodo.Size = new System.Drawing.Size(117, 17);
            this.grado_nodo.TabIndex = 4;
            this.grado_nodo.Text = "Grado del Nodo: ";
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
            // GrafoInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.indice_grafo_label);
            this.Controls.Add(this.label_grado_salida);
            this.Controls.Add(this.grado_nodo);
            this.Controls.Add(this.matriz_incidencia);
            this.Controls.Add(this.list_adyacencia);
            this.Controls.Add(this.mat_adyacencia);
            this.Controls.Add(this.dirigido);
            this.Name = "GrafoInfo";
            this.Text = "GrafoInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox dirigido;
        private System.Windows.Forms.Button mat_adyacencia;
        private System.Windows.Forms.Button list_adyacencia;
        private System.Windows.Forms.Button matriz_incidencia;
        private System.Windows.Forms.Label grado_nodo;
        private System.Windows.Forms.Label label_grado_salida;
        private System.Windows.Forms.Label indice_grafo_label;
    }
}