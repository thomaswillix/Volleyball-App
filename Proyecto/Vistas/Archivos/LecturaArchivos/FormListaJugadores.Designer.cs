namespace Proyecto.Vistas
{
    partial class FormListaJugadores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListaJugadores));
            this.botonCancelar = new System.Windows.Forms.Button();
            this.ordenarNombre = new System.Windows.Forms.Button();
            this.ordenarFecha = new System.Windows.Forms.Button();
            this.titulo = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.nomLista = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.apeLista = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.posLista = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.numCamiLista = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.equipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonCancelar
            // 
            this.botonCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.botonCancelar.BackColor = System.Drawing.Color.Transparent;
            this.botonCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonCancelar.BackgroundImage")));
            this.botonCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.botonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.botonCancelar.Location = new System.Drawing.Point(388, 388);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(80, 70);
            this.botonCancelar.TabIndex = 24;
            this.botonCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botonCancelar.UseVisualStyleBackColor = false;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // ordenarNombre
            // 
            this.ordenarNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ordenarNombre.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ordenarNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordenarNombre.Location = new System.Drawing.Point(5, 211);
            this.ordenarNombre.Name = "ordenarNombre";
            this.ordenarNombre.Size = new System.Drawing.Size(106, 23);
            this.ordenarNombre.TabIndex = 22;
            this.ordenarNombre.Text = "Alfabéticamente";
            this.ordenarNombre.UseVisualStyleBackColor = true;
            this.ordenarNombre.Click += new System.EventHandler(this.ordenarNombre_Click);
            // 
            // ordenarFecha
            // 
            this.ordenarFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ordenarFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordenarFecha.Location = new System.Drawing.Point(5, 178);
            this.ordenarFecha.Name = "ordenarFecha";
            this.ordenarFecha.Size = new System.Drawing.Size(106, 23);
            this.ordenarFecha.TabIndex = 21;
            this.ordenarFecha.Text = "Edad";
            this.ordenarFecha.UseVisualStyleBackColor = true;
            this.ordenarFecha.Click += new System.EventHandler(this.ordenarFecha_Click);
            // 
            // titulo
            // 
            this.titulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.titulo.AutoSize = true;
            this.titulo.BackColor = System.Drawing.Color.Transparent;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.ForeColor = System.Drawing.Color.Black;
            this.titulo.Location = new System.Drawing.Point(331, 45);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(207, 39);
            this.titulo.TabIndex = 19;
            this.titulo.Text = "PLANTILLA";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nomLista,
            this.apeLista,
            this.posLista,
            this.numCamiLista,
            this.equipo});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(134, 111);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(637, 259);
            this.listView1.TabIndex = 25;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // nomLista
            // 
            this.nomLista.Text = "Nombre";
            this.nomLista.Width = 128;
            // 
            // apeLista
            // 
            this.apeLista.Text = "Apellidos";
            this.apeLista.Width = 162;
            // 
            // posLista
            // 
            this.posLista.Text = "Posición";
            this.posLista.Width = 154;
            // 
            // numCamiLista
            // 
            this.numCamiLista.Text = "Dorsal";
            this.numCamiLista.Width = 66;
            // 
            // equipo
            // 
            this.equipo.Text = "Equipo";
            this.equipo.Width = 121;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "Ordenar";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(5, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "Dorsal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormListaJugadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CancelButton = this.botonCancelar;
            this.ClientSize = new System.Drawing.Size(834, 481);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.ordenarNombre);
            this.Controls.Add(this.ordenarFecha);
            this.Controls.Add(this.titulo);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(850, 520);
            this.MinimumSize = new System.Drawing.Size(825, 520);
            this.Name = "FormListaJugadores";
            this.Text = "Lista de jugadores";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ListaJugadores_FormClosing);
            this.Load += new System.EventHandler(this.FrmEmpleados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.Button ordenarNombre;
        private System.Windows.Forms.Button ordenarFecha;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader nomLista;
        private System.Windows.Forms.ColumnHeader apeLista;
        private System.Windows.Forms.ColumnHeader posLista;
        private System.Windows.Forms.ColumnHeader numCamiLista;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader equipo;
    }
}