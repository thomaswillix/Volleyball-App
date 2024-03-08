namespace Proyecto.Vistas
{
    partial class FormNuevoJugadorDB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNuevoJugadorDB));
            this.sexo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.equipo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numeroCami = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.posicion = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nomCami = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ape = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.b1 = new System.Windows.Forms.Button();
            this.fechaNac = new System.Windows.Forms.DateTimePicker();
            this.nom = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.databaseDataSet = new Proyecto.DatabaseDataSet();
            this.equiposBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.equiposTableAdapter = new Proyecto.DatabaseDataSetTableAdapters.EquiposTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.numeroCami)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equiposBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sexo
            // 
            this.sexo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sexo.FormattingEnabled = true;
            this.sexo.Items.AddRange(new object[] {
            "Hombre",
            "Mujer"});
            this.sexo.Location = new System.Drawing.Point(60, 190);
            this.sexo.Name = "sexo";
            this.sexo.Size = new System.Drawing.Size(121, 21);
            this.sexo.TabIndex = 61;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 194);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 73;
            this.label5.Text = "Sexo";
            // 
            // equipo
            // 
            this.equipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.equipo.DataSource = this.equiposBindingSource;
            this.equipo.DisplayMember = "nombre";
            this.equipo.FormattingEnabled = true;
            this.equipo.Location = new System.Drawing.Point(60, 233);
            this.equipo.Name = "equipo";
            this.equipo.Size = new System.Drawing.Size(121, 21);
            this.equipo.TabIndex = 62;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 237);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 72;
            this.label6.Text = "Equipo";
            // 
            // numeroCami
            // 
            this.numeroCami.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numeroCami.Location = new System.Drawing.Point(144, 150);
            this.numeroCami.Maximum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.numeroCami.Name = "numeroCami";
            this.numeroCami.Size = new System.Drawing.Size(52, 20);
            this.numeroCami.TabIndex = 60;
            this.numeroCami.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 152);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 71;
            this.label4.Text = "Número de la camiseta";
            // 
            // posicion
            // 
            this.posicion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.posicion.FormattingEnabled = true;
            this.posicion.Items.AddRange(new object[] {
            "Colocador",
            "Bloqueador Cental",
            "Libero",
            "Opuesto"});
            this.posicion.Location = new System.Drawing.Point(73, 282);
            this.posicion.Name = "posicion";
            this.posicion.Size = new System.Drawing.Size(121, 21);
            this.posicion.TabIndex = 63;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 285);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 70;
            this.label7.Text = "Posición";
            // 
            // nomCami
            // 
            this.nomCami.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nomCami.Location = new System.Drawing.Point(144, 110);
            this.nomCami.Name = "nomCami";
            this.nomCami.Size = new System.Drawing.Size(100, 20);
            this.nomCami.TabIndex = 59;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 112);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 69;
            this.label3.Text = "Nombre en la camiseta";
            // 
            // ape
            // 
            this.ape.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ape.Location = new System.Drawing.Point(74, 70);
            this.ape.Name = "ape";
            this.ape.Size = new System.Drawing.Size(100, 20);
            this.ape.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 68;
            this.label2.Text = "Apellidos";
            // 
            // b1
            // 
            this.b1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b1.Location = new System.Drawing.Point(121, 392);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(75, 23);
            this.b1.TabIndex = 65;
            this.b1.Text = "Dar de Alta";
            this.b1.UseVisualStyleBackColor = true;
            // 
            // fechaNac
            // 
            this.fechaNac.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fechaNac.Location = new System.Drawing.Point(135, 335);
            this.fechaNac.MaxDate = new System.DateTime(2005, 12, 31, 0, 0, 0, 0);
            this.fechaNac.MinDate = new System.DateTime(1953, 1, 1, 0, 0, 0, 0);
            this.fechaNac.Name = "fechaNac";
            this.fechaNac.Size = new System.Drawing.Size(200, 20);
            this.fechaNac.TabIndex = 64;
            this.fechaNac.Value = new System.DateTime(2005, 12, 2, 0, 0, 0, 0);
            // 
            // nom
            // 
            this.nom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nom.Location = new System.Drawing.Point(74, 33);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(100, 20);
            this.nom.TabIndex = 57;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 338);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(108, 13);
            this.label8.TabIndex = 67;
            this.label8.Text = "Fecha de Nacimiento";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 66;
            this.label1.Text = "Nombre";
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // equiposBindingSource
            // 
            this.equiposBindingSource.DataMember = "Equipos";
            this.equiposBindingSource.DataSource = this.databaseDataSet;
            // 
            // equiposTableAdapter
            // 
            this.equiposTableAdapter.ClearBeforeFill = true;
            // 
            // FormNuevoJugadorDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(349, 473);
            this.Controls.Add(this.sexo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.equipo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numeroCami);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.posicion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nomCami);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ape);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.fechaNac);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormNuevoJugadorDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Jugador";
            this.Load += new System.EventHandler(this.FormNuevoJugadorDB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numeroCami)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equiposBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox sexo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox equipo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numeroCami;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox posicion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nomCami;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ape;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.DateTimePicker fechaNac;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource equiposBindingSource;
        private DatabaseDataSetTableAdapters.EquiposTableAdapter equiposTableAdapter;
    }
}