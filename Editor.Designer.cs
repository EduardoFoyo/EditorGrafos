namespace EditorGrafos
{
    partial class Editor
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.agrega_grafo = new System.Windows.Forms.Button();
            this.mover_vertice = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cargar_grafo = new System.Windows.Forms.Button();
            this.grafo_coleccion = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1340, 673);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDoubleClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // agrega_grafo
            // 
            this.agrega_grafo.Location = new System.Drawing.Point(12, 12);
            this.agrega_grafo.Name = "agrega_grafo";
            this.agrega_grafo.Size = new System.Drawing.Size(106, 31);
            this.agrega_grafo.TabIndex = 1;
            this.agrega_grafo.Text = "Agrega Grafo";
            this.agrega_grafo.UseVisualStyleBackColor = true;
            this.agrega_grafo.Click += new System.EventHandler(this.agrega_grafo_Click);
            // 
            // mover_vertice
            // 
            this.mover_vertice.AutoSize = true;
            this.mover_vertice.Location = new System.Drawing.Point(9, 76);
            this.mover_vertice.Name = "mover_vertice";
            this.mover_vertice.Size = new System.Drawing.Size(107, 21);
            this.mover_vertice.TabIndex = 5;
            this.mover_vertice.Text = "Mover Nodo";
            this.mover_vertice.UseVisualStyleBackColor = true;
            this.mover_vertice.CheckedChanged += new System.EventHandler(this.mover_vertice_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(9, 49);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(109, 21);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Mover Grafo";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cargar_grafo
            // 
            this.cargar_grafo.Location = new System.Drawing.Point(274, 12);
            this.cargar_grafo.Name = "cargar_grafo";
            this.cargar_grafo.Size = new System.Drawing.Size(119, 31);
            this.cargar_grafo.TabIndex = 7;
            this.cargar_grafo.Text = "Cargar Grafo";
            this.cargar_grafo.UseVisualStyleBackColor = true;
            this.cargar_grafo.Click += new System.EventHandler(this.cargar_grafo_Click);
            // 
            // grafo_coleccion
            // 
            this.grafo_coleccion.FormattingEnabled = true;
            this.grafo_coleccion.Items.AddRange(new object[] {
            "grafo_2_regular",
            "grafo_3_regular",
            "grafo_4_regular",
            "k1",
            "k2",
            "k3",
            "k4",
            "k5",
            "k6",
            "k7",
            "c3",
            "c4",
            "c5",
            "c6",
            "c7",
            "w3",
            "w4",
            "w5",
            "w6",
            "w7",
            "Q3"});
            this.grafo_coleccion.Location = new System.Drawing.Point(147, 16);
            this.grafo_coleccion.Name = "grafo_coleccion";
            this.grafo_coleccion.Size = new System.Drawing.Size(121, 24);
            this.grafo_coleccion.TabIndex = 8;
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 673);
            this.Controls.Add(this.grafo_coleccion);
            this.Controls.Add(this.cargar_grafo);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.mover_vertice);
            this.Controls.Add(this.agrega_grafo);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Editor";
            this.Text = "Editor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button agrega_grafo;
        private System.Windows.Forms.CheckBox mover_vertice;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button cargar_grafo;
        private System.Windows.Forms.ComboBox grafo_coleccion;
    }
}