namespace Practica1
{
    partial class nuevo_empleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nuevo_empleado));
            this.b1 = new System.Windows.Forms.Button();
            this.presuIni = new System.Windows.Forms.NumericUpDown();
            this.presuFin = new System.Windows.Forms.NumericUpDown();
            this.codCli = new System.Windows.Forms.NumericUpDown();
            this.cod = new System.Windows.Forms.NumericUpDown();
            this.fechaFin = new System.Windows.Forms.DateTimePicker();
            this.fechaIni = new System.Windows.Forms.DateTimePicker();
            this.desc = new System.Windows.Forms.TextBox();
            this.estado = new System.Windows.Forms.CheckBox();
            this.cambios = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label122 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.presuIni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.presuFin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codCli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cod)).BeginInit();
            this.SuspendLayout();
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(112, 350);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(75, 23);
            this.b1.TabIndex = 38;
            this.b1.Text = "Dar de Alta";
            this.b1.UseVisualStyleBackColor = true;
            // 
            // presuIni
            // 
            this.presuIni.DecimalPlaces = 2;
            this.presuIni.Location = new System.Drawing.Point(150, 208);
            this.presuIni.Maximum = new decimal(new int[] {
            1874919423,
            2328306,
            0,
            0});
            this.presuIni.Name = "presuIni";
            this.presuIni.Size = new System.Drawing.Size(120, 20);
            this.presuIni.TabIndex = 37;
            // 
            // presuFin
            // 
            this.presuFin.DecimalPlaces = 2;
            this.presuFin.Location = new System.Drawing.Point(150, 239);
            this.presuFin.Maximum = new decimal(new int[] {
            1874919423,
            2328306,
            0,
            0});
            this.presuFin.Name = "presuFin";
            this.presuFin.Size = new System.Drawing.Size(120, 20);
            this.presuFin.TabIndex = 36;
            // 
            // codCli
            // 
            this.codCli.Location = new System.Drawing.Point(150, 299);
            this.codCli.Name = "codCli";
            this.codCli.Size = new System.Drawing.Size(120, 20);
            this.codCli.TabIndex = 35;
            // 
            // cod
            // 
            this.cod.BackColor = System.Drawing.SystemColors.Window;
            this.cod.Location = new System.Drawing.Point(150, 59);
            this.cod.Name = "cod";
            this.cod.Size = new System.Drawing.Size(120, 20);
            this.cod.TabIndex = 34;
            // 
            // fechaFin
            // 
            this.fechaFin.Location = new System.Drawing.Point(150, 147);
            this.fechaFin.Name = "fechaFin";
            this.fechaFin.Size = new System.Drawing.Size(200, 20);
            this.fechaFin.TabIndex = 33;
            // 
            // fechaIni
            // 
            this.fechaIni.Location = new System.Drawing.Point(150, 117);
            this.fechaIni.Name = "fechaIni";
            this.fechaIni.Size = new System.Drawing.Size(200, 20);
            this.fechaIni.TabIndex = 32;
            // 
            // desc
            // 
            this.desc.Location = new System.Drawing.Point(150, 88);
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(100, 20);
            this.desc.TabIndex = 31;
            // 
            // estado
            // 
            this.estado.AutoSize = true;
            this.estado.Location = new System.Drawing.Point(150, 180);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(56, 17);
            this.estado.TabIndex = 30;
            this.estado.Text = "Activo";
            this.estado.UseVisualStyleBackColor = true;
            // 
            // cambios
            // 
            this.cambios.AutoSize = true;
            this.cambios.Location = new System.Drawing.Point(150, 271);
            this.cambios.Name = "cambios";
            this.cambios.Size = new System.Drawing.Size(81, 17);
            this.cambios.TabIndex = 29;
            this.cambios.Text = "Actualizado";
            this.cambios.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 301);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Código de Cliente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 272);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Cambios";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 241);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Presupuesto al Final";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 210);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Presupuesto de Inicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 181);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Estado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 153);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Fecha de Fin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 123);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Fecha de Inicio";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(27, 91);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label13.Size = new System.Drawing.Size(63, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Descripción";
            // 
            // label122
            // 
            this.label122.AutoSize = true;
            this.label122.Location = new System.Drawing.Point(27, 61);
            this.label122.Name = "label122";
            this.label122.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label122.Size = new System.Drawing.Size(40, 13);
            this.label122.TabIndex = 20;
            this.label122.Text = "Código";
            // 
            // nuevo_empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(721, 418);
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
            this.Name = "nuevo_empleado";
            this.Text = "nuevo_empleado";
            this.Load += new System.EventHandler(this.nuevo_empleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.presuIni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.presuFin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codCli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.NumericUpDown presuIni;
        private System.Windows.Forms.NumericUpDown presuFin;
        private System.Windows.Forms.NumericUpDown codCli;
        private System.Windows.Forms.NumericUpDown cod;
        private System.Windows.Forms.DateTimePicker fechaFin;
        private System.Windows.Forms.DateTimePicker fechaIni;
        private System.Windows.Forms.TextBox desc;
        private System.Windows.Forms.CheckBox estado;
        private System.Windows.Forms.CheckBox cambios;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label122;
    }
}