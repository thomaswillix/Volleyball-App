namespace Proyecto.Vistas
{
    partial class ConsultarConvocatorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarConvocatorias));
            this.botonCancelar = new System.Windows.Forms.Button();
            this.btElim = new System.Windows.Forms.Button();
            this.ordenarNombre = new System.Windows.Forms.Button();
            this.ordenarFecha = new System.Windows.Forms.Button();
            this.botonImprimir = new System.Windows.Forms.Button();
            this.titulo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
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
            this.botonCancelar.Location = new System.Drawing.Point(335, 387);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(80, 70);
            this.botonCancelar.TabIndex = 17;
            this.botonCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botonCancelar.UseVisualStyleBackColor = false;
            // 
            // btElim
            // 
            this.btElim.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btElim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btElim.Location = new System.Drawing.Point(205, 123);
            this.btElim.Name = "btElim";
            this.btElim.Size = new System.Drawing.Size(75, 23);
            this.btElim.TabIndex = 16;
            this.btElim.Text = "Eliminar";
            this.btElim.UseVisualStyleBackColor = true;
            // 
            // ordenarNombre
            // 
            this.ordenarNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ordenarNombre.Location = new System.Drawing.Point(465, 123);
            this.ordenarNombre.Name = "ordenarNombre";
            this.ordenarNombre.Size = new System.Drawing.Size(133, 23);
            this.ordenarNombre.TabIndex = 15;
            this.ordenarNombre.Text = "Ordenar por nombre";
            this.ordenarNombre.UseVisualStyleBackColor = true;
            // 
            // ordenarFecha
            // 
            this.ordenarFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ordenarFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordenarFecha.Location = new System.Drawing.Point(286, 123);
            this.ordenarFecha.Name = "ordenarFecha";
            this.ordenarFecha.Size = new System.Drawing.Size(171, 23);
            this.ordenarFecha.TabIndex = 14;
            this.ordenarFecha.Text = "Ordenar por edad";
            this.ordenarFecha.UseVisualStyleBackColor = true;
            // 
            // botonImprimir
            // 
            this.botonImprimir.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.botonImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonImprimir.Location = new System.Drawing.Point(124, 123);
            this.botonImprimir.Name = "botonImprimir";
            this.botonImprimir.Size = new System.Drawing.Size(75, 23);
            this.botonImprimir.TabIndex = 13;
            this.botonImprimir.Text = "Imprimir";
            this.botonImprimir.UseVisualStyleBackColor = true;
            // 
            // titulo
            // 
            this.titulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.titulo.AutoSize = true;
            this.titulo.BackColor = System.Drawing.Color.Transparent;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.ForeColor = System.Drawing.Color.Black;
            this.titulo.Location = new System.Drawing.Point(133, 60);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(466, 39);
            this.titulo.TabIndex = 11;
            this.titulo.Text = "LISTADO DE JUGADORES";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.AutoScroll = true;
            this.panel2.AutoSize = true;
            this.panel2.Location = new System.Drawing.Point(133, 152);
            this.panel2.MinimumSize = new System.Drawing.Size(456, 199);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(456, 199);
            this.panel2.TabIndex = 18;
            // 
            // ConsultarConvocatorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.btElim);
            this.Controls.Add(this.ordenarNombre);
            this.Controls.Add(this.ordenarFecha);
            this.Controls.Add(this.botonImprimir);
            this.Controls.Add(this.titulo);
            this.Name = "ConsultarConvocatorias";
            this.Text = "ConsultarConvocatorias";
            this.Load += new System.EventHandler(this.ConsultarConvocatorias_Load);
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
        private System.Windows.Forms.Panel panel2;
    }
}