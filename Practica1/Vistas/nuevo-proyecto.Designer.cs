namespace Practica1
{
    partial class nuevo_proyecto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nuevo_proyecto));
            this.label122 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cambios = new System.Windows.Forms.CheckBox();
            this.estado = new System.Windows.Forms.CheckBox();
            this.desc = new System.Windows.Forms.TextBox();
            this.fechaIni = new System.Windows.Forms.DateTimePicker();
            this.fechaFin = new System.Windows.Forms.DateTimePicker();
            this.cod = new System.Windows.Forms.NumericUpDown();
            this.codCli = new System.Windows.Forms.NumericUpDown();
            this.presuFin = new System.Windows.Forms.NumericUpDown();
            this.presuIni = new System.Windows.Forms.NumericUpDown();
            this.b1 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codCli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.presuFin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.presuIni)).BeginInit();
            this.SuspendLayout();
            // 
            // label122
            // 
            this.label122.AutoSize = true;
            this.label122.Location = new System.Drawing.Point(67, 58);
            this.label122.Name = "label122";
            this.label122.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label122.Size = new System.Drawing.Size(40, 13);
            this.label122.TabIndex = 0;
            this.label122.Text = "Código";
            this.label122.Click += new System.EventHandler(this.label1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(67, 88);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label13.Size = new System.Drawing.Size(63, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Descripción";
            this.label13.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 120);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha de Inicio";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 150);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha de Fin";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 178);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Estado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 207);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Presupuesto de Inicio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 238);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Presupuesto al Final";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 269);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Cambios";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(67, 298);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Código de Cliente";
            // 
            // cambios
            // 
            this.cambios.AutoSize = true;
            this.cambios.Location = new System.Drawing.Point(190, 268);
            this.cambios.Name = "cambios";
            this.cambios.Size = new System.Drawing.Size(81, 17);
            this.cambios.TabIndex = 8;
            this.cambios.Text = "Actualizado";
            this.cambios.UseVisualStyleBackColor = true;
            this.cambios.CheckedChanged += new System.EventHandler(this.cambios_CheckedChanged);
            this.cambios.MouseDown += new System.Windows.Forms.MouseEventHandler(this.checkBox1_MouseDown);
            this.cambios.MouseEnter += new System.EventHandler(this.checkBox1_MouseEnter);
            this.cambios.MouseHover += new System.EventHandler(this.checkBox1_MouseHover);
            // 
            // estado
            // 
            this.estado.AutoSize = true;
            this.estado.Location = new System.Drawing.Point(190, 177);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(56, 17);
            this.estado.TabIndex = 5;
            this.estado.Text = "Activo";
            this.estado.UseVisualStyleBackColor = true;
            this.estado.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            this.estado.MouseHover += new System.EventHandler(this.checkBox2_MouseHover);
            // 
            // desc
            // 
            this.desc.Location = new System.Drawing.Point(190, 85);
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(100, 20);
            this.desc.TabIndex = 2;
            // 
            // fechaIni
            // 
            this.fechaIni.Location = new System.Drawing.Point(190, 114);
            this.fechaIni.Name = "fechaIni";
            this.fechaIni.Size = new System.Drawing.Size(200, 20);
            this.fechaIni.TabIndex = 3;
            // 
            // fechaFin
            // 
            this.fechaFin.Location = new System.Drawing.Point(190, 144);
            this.fechaFin.Name = "fechaFin";
            this.fechaFin.Size = new System.Drawing.Size(200, 20);
            this.fechaFin.TabIndex = 4;
            // 
            // cod
            // 
            this.cod.BackColor = System.Drawing.SystemColors.Window;
            this.cod.Location = new System.Drawing.Point(190, 56);
            this.cod.Name = "cod";
            this.cod.Size = new System.Drawing.Size(120, 20);
            this.cod.TabIndex = 1;
            this.cod.ValueChanged += new System.EventHandler(this.cod_ValueChanged);
            // 
            // codCli
            // 
            this.codCli.Location = new System.Drawing.Point(190, 296);
            this.codCli.Name = "codCli";
            this.codCli.Size = new System.Drawing.Size(120, 20);
            this.codCli.TabIndex = 9;
            // 
            // presuFin
            // 
            this.presuFin.DecimalPlaces = 2;
            this.presuFin.Location = new System.Drawing.Point(190, 236);
            this.presuFin.Maximum = new decimal(new int[] {
            1874919423,
            2328306,
            0,
            0});
            this.presuFin.Name = "presuFin";
            this.presuFin.Size = new System.Drawing.Size(120, 20);
            this.presuFin.TabIndex = 7;
            // 
            // presuIni
            // 
            this.presuIni.DecimalPlaces = 2;
            this.presuIni.Location = new System.Drawing.Point(190, 205);
            this.presuIni.Maximum = new decimal(new int[] {
            1874919423,
            2328306,
            0,
            0});
            this.presuIni.Name = "presuIni";
            this.presuIni.Size = new System.Drawing.Size(120, 20);
            this.presuIni.TabIndex = 6;
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(152, 347);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(75, 23);
            this.b1.TabIndex = 10;
            this.b1.Text = "Dar de Alta";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // nuevo_proyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(723, 389);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.presuIni);
            this.Controls.Add(this.presuFin);
            this.Controls.Add(this.codCli);
            this.Controls.Add(this.cod);
            this.Controls.Add(this.fechaFin);
            this.Controls.Add(this.fechaIni);
            this.Controls.Add(this.desc);
            this.Controls.Add(this.estado);
            this.Controls.Add(this.cambios);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label122);
            this.Name = "nuevo_proyecto";
            this.Text = "nuevo_proyecto";
            this.Load += new System.EventHandler(this.nuevo_proyecto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codCli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.presuFin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.presuIni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label122;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cambios;
        private System.Windows.Forms.CheckBox estado;
        private System.Windows.Forms.TextBox desc;
        private System.Windows.Forms.DateTimePicker fechaIni;
        private System.Windows.Forms.DateTimePicker fechaFin;
        private System.Windows.Forms.NumericUpDown cod;
        private System.Windows.Forms.NumericUpDown codCli;
        private System.Windows.Forms.NumericUpDown presuFin;
        private System.Windows.Forms.NumericUpDown presuIni;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
    }
}