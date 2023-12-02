namespace Proyecto
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
            this.fechaPart = new System.Windows.Forms.DateTimePicker();
            this.btProgr = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.equipoL = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.escudo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.equipoV = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.escudo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(358, 79);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // fechaPart
            // 
            this.fechaPart.Checked = false;
            this.fechaPart.Location = new System.Drawing.Point(404, 76);
            this.fechaPart.MinDate = new System.DateTime(2023, 12, 2, 12, 33, 3, 0);
            this.fechaPart.Name = "fechaPart";
            this.fechaPart.Size = new System.Drawing.Size(200, 20);
            this.fechaPart.TabIndex = 1;
            this.fechaPart.Value = new System.DateTime(2023, 12, 2, 12, 33, 3, 0);
            this.fechaPart.ValueChanged += new System.EventHandler(this.fechaNac_ValueChanged);
            // 
            // btProgr
            // 
            this.btProgr.Location = new System.Drawing.Point(468, 453);
            this.btProgr.Name = "btProgr";
            this.btProgr.Size = new System.Drawing.Size(75, 23);
            this.btProgr.TabIndex = 4;
            this.btProgr.Text = "Programar";
            this.btProgr.UseVisualStyleBackColor = true;
            this.btProgr.Click += new System.EventHandler(this.b1_Click);
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
            // equipoL
            // 
            this.equipoL.FormattingEnabled = true;
            this.equipoL.Items.AddRange(new object[] {
            "Selección Brasileña",
            "Selección Japonesa",
            "Selección EEUU",
            "Selección Italiana"});
            this.equipoL.Location = new System.Drawing.Point(214, 124);
            this.equipoL.Name = "equipoL";
            this.equipoL.Size = new System.Drawing.Size(121, 21);
            this.equipoL.TabIndex = 2;
            this.equipoL.SelectedIndexChanged += new System.EventHandler(this.equipoL_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 128);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Equipo Local";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(627, 127);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Equipo Visitante";
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            this.escudo.Location = new System.Drawing.Point(210, 435);
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
            this.pictureBox1.Location = new System.Drawing.Point(722, 435);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(280, 300);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(70, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 75);
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // equipoV
            // 
            this.equipoV.FormattingEnabled = true;
            this.equipoV.Items.AddRange(new object[] {
            "Selección Brasileña",
            "Selección Japonesa",
            "Selección EEUU",
            "Selección Italiana"});
            this.equipoV.Location = new System.Drawing.Point(717, 123);
            this.equipoV.Name = "equipoV";
            this.equipoV.Size = new System.Drawing.Size(121, 21);
            this.equipoV.TabIndex = 3;
            this.equipoV.SelectedIndexChanged += new System.EventHandler(this.equipoV_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(130, 534);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(746, 18);
            this.label4.TabIndex = 52;
            this.label4.Text = "*Al seleccionar a ambos equipos como el mismo, das a entender que el partido será" +
    " un entrenamiento amistoso";
            this.label4.Visible = false;
            // 
            // NuevoPartido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1014, 561);
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
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1030, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1030, 600);
            this.Name = "NuevoPartido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programar partido";
            this.Load += new System.EventHandler(this.NuevoPartido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.escudo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker fechaPart;
        private System.Windows.Forms.Button btProgr;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ComboBox equipoL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox escudo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox equipoV;
        private System.Windows.Forms.Label label4;
    }
}