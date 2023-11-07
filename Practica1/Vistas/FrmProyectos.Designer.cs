namespace Practica1
{
    partial class FrmProyectos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProyectos));
            this.titulo = new System.Windows.Forms.Label();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.ordenarFecha = new System.Windows.Forms.Button();
            this.botonImprimir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ordenarNombre = new System.Windows.Forms.Button();
            this.btElim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.Location = new System.Drawing.Point(154, 67);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(467, 39);
            this.titulo.TabIndex = 0;
            this.titulo.Text = "LISTADO DE PROYECTOS";
            this.titulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // botonCancelar
            // 
            this.botonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCancelar.Location = new System.Drawing.Point(556, 358);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(75, 23);
            this.botonCancelar.TabIndex = 1;
            this.botonCancelar.Text = "Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // ordenarFecha
            // 
            this.ordenarFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordenarFecha.Location = new System.Drawing.Point(197, 397);
            this.ordenarFecha.Name = "ordenarFecha";
            this.ordenarFecha.Size = new System.Drawing.Size(171, 23);
            this.ordenarFecha.TabIndex = 2;
            this.ordenarFecha.Text = "Ordenar Fecha de Inicio";
            this.ordenarFecha.UseVisualStyleBackColor = true;
            this.ordenarFecha.Click += new System.EventHandler(this.button2_Click);
            // 
            // botonImprimir
            // 
            this.botonImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonImprimir.Location = new System.Drawing.Point(152, 358);
            this.botonImprimir.Name = "botonImprimir";
            this.botonImprimir.Size = new System.Drawing.Size(75, 23);
            this.botonImprimir.TabIndex = 3;
            this.botonImprimir.Text = "Imprimir";
            this.botonImprimir.UseVisualStyleBackColor = true;
            this.botonImprimir.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(152, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 203);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proyectos";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ordenarNombre
            // 
            this.ordenarNombre.Location = new System.Drawing.Point(332, 358);
            this.ordenarNombre.Name = "ordenarNombre";
            this.ordenarNombre.Size = new System.Drawing.Size(133, 23);
            this.ordenarNombre.TabIndex = 5;
            this.ordenarNombre.Text = "Ordenar Nombre";
            this.ordenarNombre.UseVisualStyleBackColor = true;
            this.ordenarNombre.Click += new System.EventHandler(this.ordenarNombre_Click);
            // 
            // btElim
            // 
            this.btElim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btElim.Location = new System.Drawing.Point(475, 397);
            this.btElim.Name = "btElim";
            this.btElim.Size = new System.Drawing.Size(75, 23);
            this.btElim.TabIndex = 6;
            this.btElim.Text = "Eliminar";
            this.btElim.UseVisualStyleBackColor = true;
            this.btElim.Click += new System.EventHandler(this.btElim_Click);
            // 
            // FrmProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(830, 446);
            this.Controls.Add(this.btElim);
            this.Controls.Add(this.ordenarNombre);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.botonImprimir);
            this.Controls.Add(this.ordenarFecha);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.titulo);
            this.Name = "FrmProyectos";
            this.Text = "FrmProyectos";
            this.Load += new System.EventHandler(this.FrmProyectos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.Button ordenarFecha;
        private System.Windows.Forms.Button botonImprimir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ordenarNombre;
        private System.Windows.Forms.Button btElim;
    }
}