namespace Proyecto.Vistas
{
    partial class FormVistaEquipo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVistaEquipo));
            this.databaseDataSet = new Proyecto.DatabaseDataSet();
            this.jugadoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jugadoresTableAdapter = new Proyecto.DatabaseDataSetTableAdapters.JugadoresTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idJugadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numerocamisetaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrecamisetaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posicionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechanacimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipoIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.botonCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jugadoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jugadoresBindingSource
            // 
            this.jugadoresBindingSource.DataMember = "Jugadores";
            this.jugadoresBindingSource.DataSource = this.databaseDataSet;
            // 
            // jugadoresTableAdapter
            // 
            this.jugadoresTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idJugadorDataGridViewTextBoxColumn,
            this.numerocamisetaDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidosDataGridViewTextBoxColumn,
            this.nombrecamisetaDataGridViewTextBoxColumn,
            this.posicionDataGridViewTextBoxColumn,
            this.sexoDataGridViewTextBoxColumn,
            this.fechanacimientoDataGridViewTextBoxColumn,
            this.equipoIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.jugadoresBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(944, 226);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // apellidosDataGridViewTextBoxColumn
            // 
            this.apellidosDataGridViewTextBoxColumn.DataPropertyName = "apellidos";
            this.apellidosDataGridViewTextBoxColumn.HeaderText = "apellidos";
            this.apellidosDataGridViewTextBoxColumn.Name = "apellidosDataGridViewTextBoxColumn";
            // 
            // nombrecamisetaDataGridViewTextBoxColumn
            // 
            this.nombrecamisetaDataGridViewTextBoxColumn.DataPropertyName = "nombre_camiseta";
            this.nombrecamisetaDataGridViewTextBoxColumn.HeaderText = "nombre_camiseta";
            this.nombrecamisetaDataGridViewTextBoxColumn.Name = "nombrecamisetaDataGridViewTextBoxColumn";
            // 
            // posicionDataGridViewTextBoxColumn
            // 
            this.posicionDataGridViewTextBoxColumn.DataPropertyName = "posicion";
            this.posicionDataGridViewTextBoxColumn.HeaderText = "posicion";
            this.posicionDataGridViewTextBoxColumn.Name = "posicionDataGridViewTextBoxColumn";
            // 
            // sexoDataGridViewTextBoxColumn
            // 
            this.sexoDataGridViewTextBoxColumn.DataPropertyName = "sexo";
            this.sexoDataGridViewTextBoxColumn.HeaderText = "sexo";
            this.sexoDataGridViewTextBoxColumn.Name = "sexoDataGridViewTextBoxColumn";
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Info;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 22);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(169, 27);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(499, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(424, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selecciona cualquier jugador para ver a qué equipo pertenece y en qué categoría j" +
    "uega";
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
            this.botonCancelar.Location = new System.Drawing.Point(442, 298);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(80, 70);
            this.botonCancelar.TabIndex = 21;
            this.botonCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botonCancelar.UseVisualStyleBackColor = false;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // FormVistaEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(981, 390);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormVistaEquipo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Información";
            this.Load += new System.EventHandler(this.FormVistaEquipo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jugadoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource jugadoresBindingSource;
        private DatabaseDataSetTableAdapters.JugadoresTableAdapter jugadoresTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idJugadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numerocamisetaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrecamisetaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn posicionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechanacimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipoIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botonCancelar;
    }
}