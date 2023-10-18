namespace GestionaIES
{
    partial class GestionaIES
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionaIES));
            this.logo = new System.Windows.Forms.PictureBox();
            this.enlace_web = new System.Windows.Forms.LinkLabel();
            this.label_nombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.texto_clave = new System.Windows.Forms.TextBox();
            this.texto_usuario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.ImageLocation = "";
            this.logo.Location = new System.Drawing.Point(25, 33);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(83, 81);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // enlace_web
            // 
            this.enlace_web.AutoSize = true;
            this.enlace_web.Location = new System.Drawing.Point(25, 130);
            this.enlace_web.Name = "enlace_web";
            this.enlace_web.Size = new System.Drawing.Size(83, 13);
            this.enlace_web.TabIndex = 1;
            this.enlace_web.TabStop = true;
            this.enlace_web.Text = "Enlace a la web";
            this.enlace_web.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label_nombre
            // 
            this.label_nombre.AutoSize = true;
            this.label_nombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nombre.Location = new System.Drawing.Point(276, 101);
            this.label_nombre.Name = "label_nombre";
            this.label_nombre.Size = new System.Drawing.Size(75, 19);
            this.label_nombre.TabIndex = 2;
            this.label_nombre.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(276, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Clave:";
            // 
            // texto_clave
            // 
            this.texto_clave.Location = new System.Drawing.Point(372, 144);
            this.texto_clave.Name = "texto_clave";
            this.texto_clave.PasswordChar = '*';
            this.texto_clave.Size = new System.Drawing.Size(150, 20);
            this.texto_clave.TabIndex = 4;
            // 
            // texto_usuario
            // 
            this.texto_usuario.Location = new System.Drawing.Point(372, 100);
            this.texto_usuario.Name = "texto_usuario";
            this.texto_usuario.Size = new System.Drawing.Size(150, 20);
            this.texto_usuario.TabIndex = 5;
            // 
            // GestionaIES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.texto_usuario);
            this.Controls.Add(this.texto_clave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_nombre);
            this.Controls.Add(this.enlace_web);
            this.Controls.Add(this.logo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GestionaIES";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "GestionaIES";
            this.Load += new System.EventHandler(this.GestionaIES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.LinkLabel enlace_web;
        private System.Windows.Forms.Label label_nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox texto_clave;
        private System.Windows.Forms.TextBox texto_usuario;
    }
}

