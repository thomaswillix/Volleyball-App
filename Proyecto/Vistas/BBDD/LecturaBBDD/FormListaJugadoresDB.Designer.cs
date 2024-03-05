namespace Proyecto.Vistas
{
    partial class FormListaJugadoresDB
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListaJugadoresDB));
            this.botonCancelar = new System.Windows.Forms.Button();
            this.titulo = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idJugadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numerocamisetaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrecamisetaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posicionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechanacimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipoIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jugadoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new Proyecto.DatabaseDataSet();
            this.jugadoresTableAdapter = new Proyecto.DatabaseDataSetTableAdapters.JugadoresTableAdapter();
            this.jugadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jugadoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jugadorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // botonCancelar
            // 
            this.botonCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.botonCancelar.BackColor = System.Drawing.Color.Transparent;
            this.botonCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonCancelar.BackgroundImage")));
            this.botonCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.botonCancelar.Location = new System.Drawing.Point(317, 427);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(80, 70);
            this.botonCancelar.TabIndex = 32;
            this.botonCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botonCancelar.UseVisualStyleBackColor = false;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // titulo
            // 
            this.titulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.titulo.AutoSize = true;
            this.titulo.BackColor = System.Drawing.Color.Transparent;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.ForeColor = System.Drawing.Color.Black;
            this.titulo.Location = new System.Drawing.Point(256, 9);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(207, 39);
            this.titulo.TabIndex = 29;
            this.titulo.Text = "PLANTILLA";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idJugadorDataGridViewTextBoxColumn,
            this.numerocamisetaDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn1,
            this.apellidosDataGridViewTextBoxColumn,
            this.nombrecamisetaDataGridViewTextBoxColumn1,
            this.posicionDataGridViewTextBoxColumn1,
            this.sexoDataGridViewTextBoxColumn1,
            this.fechanacimientoDataGridViewTextBoxColumn,
            this.equipoIDDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.jugadoresBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(31, 62);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(633, 359);
            this.dataGridView2.TabIndex = 37;
            // 
            // idJugadorDataGridViewTextBoxColumn
            // 
            this.idJugadorDataGridViewTextBoxColumn.DataPropertyName = "idJugador";
            this.idJugadorDataGridViewTextBoxColumn.HeaderText = "idJugador";
            this.idJugadorDataGridViewTextBoxColumn.Name = "idJugadorDataGridViewTextBoxColumn";
            this.idJugadorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numerocamisetaDataGridViewTextBoxColumn
            // 
            this.numerocamisetaDataGridViewTextBoxColumn.DataPropertyName = "numero_camiseta";
            this.numerocamisetaDataGridViewTextBoxColumn.HeaderText = "numero_camiseta";
            this.numerocamisetaDataGridViewTextBoxColumn.Name = "numerocamisetaDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn1
            // 
            this.nombreDataGridViewTextBoxColumn1.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn1.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn1.Name = "nombreDataGridViewTextBoxColumn1";
            // 
            // apellidosDataGridViewTextBoxColumn
            // 
            this.apellidosDataGridViewTextBoxColumn.DataPropertyName = "apellidos";
            this.apellidosDataGridViewTextBoxColumn.HeaderText = "apellidos";
            this.apellidosDataGridViewTextBoxColumn.Name = "apellidosDataGridViewTextBoxColumn";
            // 
            // nombrecamisetaDataGridViewTextBoxColumn1
            // 
            this.nombrecamisetaDataGridViewTextBoxColumn1.DataPropertyName = "nombre_camiseta";
            this.nombrecamisetaDataGridViewTextBoxColumn1.HeaderText = "nombre_camiseta";
            this.nombrecamisetaDataGridViewTextBoxColumn1.Name = "nombrecamisetaDataGridViewTextBoxColumn1";
            // 
            // posicionDataGridViewTextBoxColumn1
            // 
            this.posicionDataGridViewTextBoxColumn1.DataPropertyName = "posicion";
            this.posicionDataGridViewTextBoxColumn1.HeaderText = "posicion";
            this.posicionDataGridViewTextBoxColumn1.Name = "posicionDataGridViewTextBoxColumn1";
            // 
            // sexoDataGridViewTextBoxColumn1
            // 
            this.sexoDataGridViewTextBoxColumn1.DataPropertyName = "sexo";
            this.sexoDataGridViewTextBoxColumn1.HeaderText = "sexo";
            this.sexoDataGridViewTextBoxColumn1.Name = "sexoDataGridViewTextBoxColumn1";
            // 
            // fechanacimientoDataGridViewTextBoxColumn
            // 
            this.fechanacimientoDataGridViewTextBoxColumn.DataPropertyName = "fecha_nacimiento";
            this.fechanacimientoDataGridViewTextBoxColumn.HeaderText = "fecha_nacimiento";
            this.fechanacimientoDataGridViewTextBoxColumn.Name = "fechanacimientoDataGridViewTextBoxColumn";
            // 
            // equipoIDDataGridViewTextBoxColumn
            // 
            this.equipoIDDataGridViewTextBoxColumn.DataPropertyName = "EquipoID";
            this.equipoIDDataGridViewTextBoxColumn.HeaderText = "EquipoID";
            this.equipoIDDataGridViewTextBoxColumn.Name = "equipoIDDataGridViewTextBoxColumn";
            // 
            // jugadoresBindingSource
            // 
            this.jugadoresBindingSource.DataMember = "Jugadores";
            this.jugadoresBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jugadoresTableAdapter
            // 
            this.jugadoresTableAdapter.ClearBeforeFill = true;
            // 
            // jugadorBindingSource
            // 
            this.jugadorBindingSource.DataSource = typeof(Jugador);
            // 
            // FormListaJugadoresDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 509);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.titulo);
            this.Name = "FormListaJugadoresDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormListaJugadoresDB";
            this.Load += new System.EventHandler(this.FormListaJugadoresDB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jugadoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jugadorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.BindingSource jugadorBindingSource;
        private System.Windows.Forms.DataGridView dataGridView2;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource jugadoresBindingSource;
        private DatabaseDataSetTableAdapters.JugadoresTableAdapter jugadoresTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idJugadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numerocamisetaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrecamisetaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn posicionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechanacimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipoIDDataGridViewTextBoxColumn;
    }
}