namespace Proyecto
{
    partial class NuevoJugador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoJugador));
            this.b1 = new System.Windows.Forms.Button();
            this.fechaNac = new System.Windows.Forms.DateTimePicker();
            this.nom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.ape1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tlf = new System.Windows.Forms.NumericUpDown();
            this.correo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.numSS = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.come = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.puesto = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ape2 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tlf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(86, 364);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(75, 23);
            this.b1.TabIndex = 11;
            this.b1.Text = "Dar de Alta";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // fechaNac
            // 
            this.fechaNac.Location = new System.Drawing.Point(517, 246);
            this.fechaNac.MaxDate = new System.DateTime(2005, 12, 31, 0, 0, 0, 0);
            this.fechaNac.MinDate = new System.DateTime(1953, 1, 1, 0, 0, 0, 0);
            this.fechaNac.Name = "fechaNac";
            this.fechaNac.Size = new System.Drawing.Size(200, 20);
            this.fechaNac.TabIndex = 9;
            this.fechaNac.Value = new System.DateTime(2005, 12, 31, 0, 0, 0, 0);
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(168, 95);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(100, 20);
            this.nom.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(394, 196);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Teléfono";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(394, 252);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Fecha de Nacimiento";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(106, 98);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Nombre";
            // 
            // ape1
            // 
            this.ape1.Location = new System.Drawing.Point(168, 123);
            this.ape1.Name = "ape1";
            this.ape1.Size = new System.Drawing.Size(100, 20);
            this.ape1.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(106, 126);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "Apellidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(394, 168);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Puesto";
            // 
            // tlf
            // 
            this.tlf.Location = new System.Drawing.Point(517, 194);
            this.tlf.Maximum = new decimal(new int[] {
            699999999,
            0,
            0,
            0});
            this.tlf.Minimum = new decimal(new int[] {
            600000000,
            0,
            0,
            0});
            this.tlf.Name = "tlf";
            this.tlf.Size = new System.Drawing.Size(120, 20);
            this.tlf.TabIndex = 7;
            this.tlf.Value = new decimal(new int[] {
            600000000,
            0,
            0,
            0});
            this.tlf.ValueChanged += new System.EventHandler(this.tlf_ValueChanged);
            // 
            // correo
            // 
            this.correo.Location = new System.Drawing.Point(517, 220);
            this.correo.Name = "correo";
            this.correo.Size = new System.Drawing.Size(100, 20);
            this.correo.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(394, 223);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 46;
            this.label10.Text = "Correo";
            // 
            // numSS
            // 
            this.numSS.Location = new System.Drawing.Point(517, 279);
            this.numSS.Name = "numSS";
            this.numSS.Size = new System.Drawing.Size(120, 20);
            this.numSS.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(394, 281);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Número de la SS";
            // 
            // come
            // 
            this.come.Location = new System.Drawing.Point(517, 308);
            this.come.Name = "come";
            this.come.Size = new System.Drawing.Size(100, 20);
            this.come.TabIndex = 11;
            this.come.TextChanged += new System.EventHandler(this.come_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(394, 311);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Comentarios";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // puesto
            // 
            this.puesto.FormattingEnabled = true;
            this.puesto.Items.AddRange(new object[] {
            "comercial",
            "jefe",
            "programador"});
            this.puesto.Location = new System.Drawing.Point(516, 165);
            this.puesto.Name = "puesto";
            this.puesto.Size = new System.Drawing.Size(121, 21);
            this.puesto.TabIndex = 6;
            this.puesto.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(318, 98);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(115, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "Nombre en la camiseta";
            // 
            // ape2
            // 
            this.ape2.Location = new System.Drawing.Point(450, 96);
            this.ape2.Name = "ape2";
            this.ape2.Size = new System.Drawing.Size(100, 20);
            this.ape2.TabIndex = 5;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(450, 124);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(52, 20);
            this.numericUpDown1.TabIndex = 51;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(318, 126);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(115, 13);
            this.label6.TabIndex = 52;
            this.label6.Text = "Número de la camiseta";
            // 
            // NuevoJugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1014, 561);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.puesto);
            this.Controls.Add(this.come);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numSS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.correo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tlf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ape2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ape1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.fechaNac);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label13);
            this.Name = "NuevoJugador";
            this.Text = "nuevo_empleado";
            this.Load += new System.EventHandler(this.NuevoJugador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tlf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.DateTimePicker fechaNac;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox ape1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown tlf;
        private System.Windows.Forms.TextBox correo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numSS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox come;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox puesto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ape2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label6;
    }
}