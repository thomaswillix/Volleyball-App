﻿namespace Proyecto.Vistas.Escritura_BBDD
{
    partial class FormNuevoPartidoDB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNuevoPartidoDB));
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.escudo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.equipoV = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.equipoL = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btProgr = new System.Windows.Forms.Button();
            this.fechaPart = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.escudo)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(136, 498);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(746, 18);
            this.label4.TabIndex = 64;
            this.label4.Text = "*Al seleccionar a ambos equipos como el mismo, das a entender que el partido será" +
    " un entrenamiento amistoso";
            this.label4.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleDescription = "";
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Location = new System.Drawing.Point(717, 399);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(280, 300);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(70, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 75);
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // escudo
            // 
            this.escudo.AccessibleDescription = "";
            this.escudo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.escudo.BackColor = System.Drawing.Color.Transparent;
            this.escudo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("escudo.BackgroundImage")));
            this.escudo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.escudo.Cursor = System.Windows.Forms.Cursors.Default;
            this.escudo.Location = new System.Drawing.Point(205, 399);
            this.escudo.MaximumSize = new System.Drawing.Size(280, 300);
            this.escudo.MinimumSize = new System.Drawing.Size(70, 75);
            this.escudo.Name = "escudo";
            this.escudo.Size = new System.Drawing.Size(70, 75);
            this.escudo.TabIndex = 62;
            this.escudo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.Location = new System.Drawing.Point(523, 117);
            this.panel1.MinimumSize = new System.Drawing.Size(456, 199);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(456, 266);
            this.panel1.TabIndex = 61;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.AutoScroll = true;
            this.panel2.AutoSize = true;
            this.panel2.Location = new System.Drawing.Point(23, 117);
            this.panel2.MinimumSize = new System.Drawing.Size(456, 199);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(456, 266);
            this.panel2.TabIndex = 60;
            // 
            // equipoV
            // 
            this.equipoV.FormattingEnabled = true;
            this.equipoV.Items.AddRange(new object[] {
            "Selección Brasileña",
            "Selección Japonesa",
            "Selección EEUU",
            "Selección Italiana"});
            this.equipoV.Location = new System.Drawing.Point(703, 84);
            this.equipoV.Name = "equipoV";
            this.equipoV.Size = new System.Drawing.Size(121, 21);
            this.equipoV.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(613, 88);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 59;
            this.label2.Text = "Equipo Visitante";
            // 
            // equipoL
            // 
            this.equipoL.FormattingEnabled = true;
            this.equipoL.Items.AddRange(new object[] {
            "Selección Brasileña",
            "Selección Japonesa",
            "Selección EEUU",
            "Selección Italiana"});
            this.equipoL.Location = new System.Drawing.Point(200, 85);
            this.equipoL.Name = "equipoL";
            this.equipoL.Size = new System.Drawing.Size(121, 21);
            this.equipoL.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 89);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 58;
            this.label3.Text = "Equipo Local";
            // 
            // btProgr
            // 
            this.btProgr.Location = new System.Drawing.Point(362, 364);
            this.btProgr.Name = "btProgr";
            this.btProgr.Size = new System.Drawing.Size(75, 23);
            this.btProgr.TabIndex = 57;
            this.btProgr.Text = "Programar";
            this.btProgr.UseVisualStyleBackColor = true;
            // 
            // fechaPart
            // 
            this.fechaPart.Checked = false;
            this.fechaPart.Location = new System.Drawing.Point(390, 37);
            this.fechaPart.MinDate = new System.DateTime(2023, 12, 2, 12, 33, 3, 0);
            this.fechaPart.Name = "fechaPart";
            this.fechaPart.Size = new System.Drawing.Size(200, 20);
            this.fechaPart.TabIndex = 53;
            this.fechaPart.Value = new System.DateTime(2023, 12, 2, 12, 33, 3, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(344, 40);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Fecha";
            // 
            // FormNuevoPartidoDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1002, 556);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.escudo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.equipoV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.equipoL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btProgr);
            this.Controls.Add(this.fechaPart);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormNuevoPartidoDB";
            this.Text = "FormNuevoPartidoDB";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.escudo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox escudo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox equipoV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox equipoL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btProgr;
        private System.Windows.Forms.DateTimePicker fechaPart;
        private System.Windows.Forms.Label label1;
    }
}