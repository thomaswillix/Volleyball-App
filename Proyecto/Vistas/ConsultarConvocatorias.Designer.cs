namespace Proyecto.Vistas
{
    partial class ConsultarConvocatorias
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
            System.Windows.Forms.Button button1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarConvocatorias));
            this.titulo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.eMasc = new System.Windows.Forms.RadioButton();
            this.efem = new System.Windows.Forms.RadioButton();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.equipo = new System.Windows.Forms.ComboBox();
            button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titulo
            // 
            this.titulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.titulo.AutoSize = true;
            this.titulo.BackColor = System.Drawing.Color.Transparent;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.titulo.Location = new System.Drawing.Point(258, 56);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(283, 33);
            this.titulo.TabIndex = 11;
            this.titulo.Text = "CONVOCATORIAS";
            this.titulo.Click += new System.EventHandler(this.titulo_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.AutoScroll = true;
            this.panel2.AutoSize = true;
            this.panel2.Location = new System.Drawing.Point(201, 124);
            this.panel2.MinimumSize = new System.Drawing.Size(456, 199);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(489, 199);
            this.panel2.TabIndex = 18;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button1
            // 
            button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            button1.BackColor = System.Drawing.Color.DarkGray;
            button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            button1.ForeColor = System.Drawing.Color.Black;
            button1.Location = new System.Drawing.Point(22, 241);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(160, 23);
            button1.TabIndex = 4;
            button1.Text = "Generar lista de convocatorias";
            button1.UseVisualStyleBackColor = false;
            // 
            // eMasc
            // 
            this.eMasc.AutoSize = true;
            this.eMasc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.eMasc.Location = new System.Drawing.Point(47, 184);
            this.eMasc.Name = "eMasc";
            this.eMasc.Size = new System.Drawing.Size(73, 17);
            this.eMasc.TabIndex = 2;
            this.eMasc.TabStop = true;
            this.eMasc.Text = "Masculino";
            this.eMasc.UseVisualStyleBackColor = true;
            // 
            // efem
            // 
            this.efem.AutoSize = true;
            this.efem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.efem.Location = new System.Drawing.Point(47, 207);
            this.efem.Name = "efem";
            this.efem.Size = new System.Drawing.Size(71, 17);
            this.efem.TabIndex = 3;
            this.efem.TabStop = true;
            this.efem.Text = "Femenino";
            this.efem.UseVisualStyleBackColor = true;
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
            this.botonCancelar.Location = new System.Drawing.Point(360, 370);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(80, 70);
            this.botonCancelar.TabIndex = 17;
            this.botonCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botonCancelar.UseVisualStyleBackColor = false;
            // 
            // equipo
            // 
            this.equipo.FormattingEnabled = true;
            this.equipo.Items.AddRange(new object[] {
            "Selección Brasileña",
            "Selección Japonesa",
            "Selección EEUU",
            "Selección Italiana"});
            this.equipo.Location = new System.Drawing.Point(47, 133);
            this.equipo.Name = "equipo";
            this.equipo.Size = new System.Drawing.Size(121, 21);
            this.equipo.TabIndex = 1;
            // 
            // ConsultarConvocatorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.equipo);
            this.Controls.Add(this.efem);
            this.Controls.Add(this.eMasc);
            this.Controls.Add(button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.titulo);
            this.Name = "ConsultarConvocatorias";
            this.Text = "ConsultarConvocatorias";
            this.Load += new System.EventHandler(this.ConsultarConvocatorias_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton eMasc;
        private System.Windows.Forms.RadioButton efem;
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.ComboBox equipo;
    }
}