﻿namespace Proyecto
{
    partial class NuevoPartido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoPartido));
            this.label1 = new System.Windows.Forms.Label();
            this.fechaIni = new System.Windows.Forms.DateTimePicker();
            this.b1 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.puesto = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.escudo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.escudo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(387, 78);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // fechaIni
            // 
            this.fechaIni.Location = new System.Drawing.Point(433, 75);
            this.fechaIni.Name = "fechaIni";
            this.fechaIni.Size = new System.Drawing.Size(200, 20);
            this.fechaIni.TabIndex = 3;
            this.fechaIni.Value = new System.DateTime(2023, 12, 9, 11, 0, 0, 0);
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(468, 453);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(75, 23);
            this.b1.TabIndex = 10;
            this.b1.Text = "Programar";
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
            // puesto
            // 
            this.puesto.FormattingEnabled = true;
            this.puesto.Items.AddRange(new object[] {
            "Selección Brasileña",
            "Selección Japonesa",
            "Selección EEUU",
            "Selección Italiana"});
            this.puesto.Location = new System.Drawing.Point(199, 124);
            this.puesto.Name = "puesto";
            this.puesto.Size = new System.Drawing.Size(121, 21);
            this.puesto.TabIndex = 44;
            this.puesto.SelectedIndexChanged += new System.EventHandler(this.puesto_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 128);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Equipo Local";
            this.label3.Click += new System.EventHandler(this.label8_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(614, 127);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Equipo Visitante";
            this.label2.Click += new System.EventHandler(this.label2_Click_2);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.AutoScroll = true;
            this.panel2.AutoSize = true;
            this.panel2.Location = new System.Drawing.Point(28, 153);
            this.panel2.MinimumSize = new System.Drawing.Size(456, 199);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(456, 266);
            this.panel2.TabIndex = 48;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.Location = new System.Drawing.Point(528, 153);
            this.panel1.MinimumSize = new System.Drawing.Size(456, 199);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(456, 266);
            this.panel1.TabIndex = 49;
            // 
            // escudo
            // 
            this.escudo.AccessibleDescription = "";
            this.escudo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.escudo.BackColor = System.Drawing.Color.Transparent;
            this.escudo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("escudo.BackgroundImage")));
            this.escudo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.escudo.Cursor = System.Windows.Forms.Cursors.Default;
            this.escudo.Location = new System.Drawing.Point(208, 435);
            this.escudo.MaximumSize = new System.Drawing.Size(280, 300);
            this.escudo.MinimumSize = new System.Drawing.Size(70, 75);
            this.escudo.Name = "escudo";
            this.escudo.Size = new System.Drawing.Size(70, 75);
            this.escudo.TabIndex = 50;
            this.escudo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleDescription = "";
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Location = new System.Drawing.Point(720, 435);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(280, 300);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(70, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 75);
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Selección Brasileña",
            "Selección Japonesa",
            "Selección EEUU",
            "Selección Italiana"});
            this.comboBox1.Location = new System.Drawing.Point(704, 123);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 46;
            // 
            // NuevoPartido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1014, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.escudo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.puesto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.fechaIni);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1030, 600);
            this.Name = "NuevoPartido";
            this.Text = "Programar partido";
            this.Load += new System.EventHandler(this.NuevoPartido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.escudo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker fechaIni;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ComboBox puesto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox escudo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}