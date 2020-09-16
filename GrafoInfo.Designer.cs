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
            // GrafoInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}