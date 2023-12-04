namespace Proyecto
{
    partial class VistaListaJugadores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaListaJugadores));
            this.botonCancelar = new System.Windows.Forms.Button();
            this.btElim = new System.Windows.Forms.Button();
            this.ordenarNombre = new System.Windows.Forms.Button();
            this.ordenarFecha = new System.Windows.Forms.Button();
            this.botonImprimir = new System.Windows.Forms.Button();
            this.titulo = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // botonCancelar
            // 
            this.botonCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.botonCancelar.BackColor = System.Drawing.Color.Transparent;
            this.botonCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonCancelar.BackgroundImage")));
            this.botonCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.botonCancelar.Location = new System.Drawing.Point(389, 403);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(80, 70);
            this.botonCancelar.TabIndex = 24;
            this.botonCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botonCancelar.UseVisualStyleBackColor = false;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // btElim
            // 
            this.btElim.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btElim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btElim.Location = new System.Drawing.Point(573, 102);
            this.btElim.Name = "btElim";
            this.btElim.Size = new System.Drawing.Size(75, 23);
            this.btElim.TabIndex = 23;
            this.btElim.Text = "Eliminar";
            this.btElim.UseVisualStyleBackColor = true;
            this.btElim.Click += new System.EventHandler(this.btElim_Click);
            // 
            // ordenarNombre
            // 
            this.ordenarNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ordenarNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordenarNombre.Location = new System.Drawing.Point(424, 102);
            this.ordenarNombre.Name = "ordenarNombre";
            this.ordenarNombre.Size = new System.Drawing.Size(133, 23);
            this.ordenarNombre.TabIndex = 22;
            this.ordenarNombre.Text = "Ordenar por nombre";
            this.ordenarNombre.UseVisualStyleBackColor = true;
            this.ordenarNombre.Click += new System.EventHandler(this.ordenarNombre_Click);
            // 
            // ordenarFecha
            // 
            this.ordenarFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ordenarFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordenarFecha.Location = new System.Drawing.Point(287, 102);
            this.ordenarFecha.Name = "ordenarFecha";
            this.ordenarFecha.Size = new System.Drawing.Size(122, 23);
            this.ordenarFecha.TabIndex = 21;
            this.ordenarFecha.Text = "Ordenar por edad";
            this.ordenarFecha.UseVisualStyleBackColor = true;
            this.ordenarFecha.Click += new System.EventHandler(this.ordenarFecha_Click);
            // 
            // botonImprimir
            // 
            this.botonImprimir.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.botonImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonImprimir.Location = new System.Drawing.Point(196, 102);
            this.botonImprimir.Name = "botonImprimir";
            this.botonImprimir.Size = new System.Drawing.Size(75, 23);
            this.botonImprimir.TabIndex = 20;
            this.botonImprimir.Text = "Mostrar";
            this.botonImprimir.UseVisualStyleBackColor = true;
            this.botonImprimir.Click += new System.EventHandler(this.botonImprimir_Click);
            // 
            // titulo
            // 
            this.titulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.titulo.AutoSize = true;
            this.titulo.BackColor = System.Drawing.Color.Transparent;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.ForeColor = System.Drawing.Color.Black;
            this.titulo.Location = new System.Drawing.Point(189, 22);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(466, 39);
            this.titulo.TabIndex = 19;
            this.titulo.Text = "LISTADO DE JUGADORES";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(167, 143);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(511, 226);
            this.listView1.TabIndex = 25;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // ListaJugadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(834, 481);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.btElim);
            this.Controls.Add(this.ordenarNombre);
            this.Controls.Add(this.ordenarFecha);
            this.Controls.Add(this.botonImprimir);
            this.Controls.Add(this.titulo);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(850, 520);
            this.MinimumSize = new System.Drawing.Size(825, 520);
            this.Name = "ListaJugadores";
            this.Text = "FrmEmpleados";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ListaJugadores_FormClosing);
            this.Load += new System.EventHandler(this.FrmEmpleados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.Button btElim;
        private System.Windows.Forms.Button ordenarNombre;
        private System.Windows.Forms.Button ordenarFecha;
        private System.Windows.Forms.Button botonImprimir;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.ListView listView1;
    }
}