namespace Proyecto
{
    partial class FormNuevoJugador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNuevoJugador));
            this.b1 = new System.Windows.Forms.Button();
            this.fechaNac = new System.Windows.Forms.DateTimePicker();
            this.nom = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ape = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.posicion = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nomCami = new System.Windows.Forms.TextBox();
            this.numeroCami = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.equipo = new System.Windows.Forms.ComboBox();
            this.sexo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numeroCami)).BeginInit();
            this.SuspendLayout();
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(138, 420);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(75, 23);
            this.b1.TabIndex = 10;
            this.b1.Text = "Dar de Alta";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // fechaNac
            // 
            this.fechaNac.Location = new System.Drawing.Point(152, 363);
            this.fechaNac.MaxDate = new System.DateTime(2005, 12, 31, 0, 0, 0, 0);
            this.fechaNac.MinDate = new System.DateTime(1953, 1, 1, 0, 0, 0, 0);
            this.fechaNac.Name = "fechaNac";
            this.fechaNac.Size = new System.Drawing.Size(200, 20);
            this.fechaNac.TabIndex = 9;
            this.fechaNac.Value = new System.DateTime(2005, 12, 2, 0, 0, 0, 0);
            this.fechaNac.ValueChanged += new System.EventHandler(this.fechaNac_ValueChanged);
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(91, 61);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(100, 20);
            this.nom.TabIndex = 1;
            this.nom.TextChanged += new System.EventHandler(this.nom_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 366);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(108, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Fecha de Nacimiento";
            this.label8.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 64);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nombre";
            // 
            // ape
            // 
            this.ape.Location = new System.Drawing.Point(91, 98);
            this.ape.Name = "ape";
            this.ape.Size = new System.Drawing.Size(100, 20);
            this.ape.TabIndex = 2;
            this.ape.TextChanged += new System.EventHandler(this.ape_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 101);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Apellidos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 313);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "Posición";
            // 
            // posicion
            // 
            this.posicion.FormattingEnabled = true;
            this.posicion.Items.AddRange(new object[] {
            "Colocador",
            "Bloqueador Cental",
            "Libero",
            "Opuesto"});
            this.posicion.Location = new System.Drawing.Point(90, 310);
            this.posicion.Name = "posicion";
            this.posicion.Size = new System.Drawing.Size(121, 21);
            this.posicion.TabIndex = 7;
            this.posicion.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 140);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Nombre en la camiseta";
            // 
            // nomCami
            // 
            this.nomCami.Location = new System.Drawing.Point(161, 138);
            this.nomCami.Name = "nomCami";
            this.nomCami.Size = new System.Drawing.Size(100, 20);
            this.nomCami.TabIndex = 3;
            this.nomCami.TextChanged += new System.EventHandler(this.nomCami_TextChanged);
            // 
            // numeroCami
            // 
            this.numeroCami.Location = new System.Drawing.Point(161, 178);
            this.numeroCami.Maximum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.numeroCami.Name = "numeroCami";
            this.numeroCami.Size = new System.Drawing.Size(52, 20);
            this.numeroCami.TabIndex = 4;
            this.numeroCami.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeroCami.ValueChanged += new System.EventHandler(this.numeroCami_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 180);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "Número de la camiseta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 265);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 54;
            this.label6.Text = "Equipo";
            // 
            // equipo
            // 
            this.equipo.FormattingEnabled = true;
            this.equipo.Items.AddRange(new object[] {
            "Selección Brasileña",
            "Selección Japonesa",
            "Selección EEUU",
            "Selección Italiana"});
            this.equipo.Location = new System.Drawing.Point(77, 261);
            this.equipo.Name = "equipo";
            this.equipo.Size = new System.Drawing.Size(121, 21);
            this.equipo.TabIndex = 6;
            this.equipo.SelectedIndexChanged += new System.EventHandler(this.equipo_SelectedIndexChanged);
            // 
            // sexo
            // 
            this.sexo.FormattingEnabled = true;
            this.sexo.Items.AddRange(new object[] {
            "Hombre",
            "Mujer"});
            this.sexo.Location = new System.Drawing.Point(77, 218);
            this.sexo.Name = "sexo";
            this.sexo.Size = new System.Drawing.Size(121, 21);
            this.sexo.TabIndex = 5;
            this.sexo.SelectedIndexChanged += new System.EventHandler(this.sexo_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 222);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 56;
            this.label5.Text = "Sexo";
            // 
            // NuevoJugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(361, 494);
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
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(377, 533);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(377, 533);
            this.Name = "NuevoJugador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Jugador";
            this.Load += new System.EventHandler(this.NuevoJugador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numeroCami)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.DateTimePicker fechaNac;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ape;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox posicion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nomCami;
        private System.Windows.Forms.NumericUpDown numeroCami;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox equipo;
        private System.Windows.Forms.ComboBox sexo;
        private System.Windows.Forms.Label label5;
    }
}