namespace Proyecto
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.cuadroCont = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cuadroUsu = new System.Windows.Forms.TextBox();
            this.cancel = new System.Windows.Forms.Button();
            this.accept = new System.Windows.Forms.Button();
            this.escudo = new System.Windows.Forms.PictureBox();
            this.clave = new System.Windows.Forms.Label();
            this.usuario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.escudo)).BeginInit();
            this.SuspendLayout();
            // 
            // cuadroCont
            // 
            this.cuadroCont.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cuadroCont.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuadroCont.Location = new System.Drawing.Point(195, 216);
            this.cuadroCont.MaximumSize = new System.Drawing.Size(300, 52);
            this.cuadroCont.MinimumSize = new System.Drawing.Size(75, 13);
            this.cuadroCont.Name = "cuadroCont";
            this.cuadroCont.PasswordChar = '*';
            this.cuadroCont.Size = new System.Drawing.Size(150, 26);
            this.cuadroCont.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(339, 278);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(0, 20);
            this.textBox2.TabIndex = 14;
            // 
            // cuadroUsu
            // 
            this.cuadroUsu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cuadroUsu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuadroUsu.Location = new System.Drawing.Point(195, 179);
            this.cuadroUsu.MaximumSize = new System.Drawing.Size(300, 52);
            this.cuadroUsu.MinimumSize = new System.Drawing.Size(75, 13);
            this.cuadroUsu.Name = "cuadroUsu";
            this.cuadroUsu.Size = new System.Drawing.Size(150, 26);
            this.cuadroUsu.TabIndex = 1;
            // 
            // cancel
            // 
            this.cancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel.Location = new System.Drawing.Point(172, 266);
            this.cancel.MaximumSize = new System.Drawing.Size(150, 50);
            this.cancel.MinimumSize = new System.Drawing.Size(37, 12);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(96, 25);
            this.cancel.TabIndex = 3;
            this.cancel.Text = "Limpiar campos";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // accept
            // 
            this.accept.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.accept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.accept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.accept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.accept.Location = new System.Drawing.Point(284, 266);
            this.accept.MaximumSize = new System.Drawing.Size(150, 50);
            this.accept.MinimumSize = new System.Drawing.Size(37, 12);
            this.accept.Name = "accept";
            this.accept.Size = new System.Drawing.Size(75, 25);
            this.accept.TabIndex = 4;
            this.accept.Text = "Validar";
            this.accept.UseVisualStyleBackColor = false;
            this.accept.Click += new System.EventHandler(this.accept_Click);
            // 
            // escudo
            // 
            this.escudo.AccessibleDescription = "";
            this.escudo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.escudo.BackColor = System.Drawing.Color.Transparent;
            this.escudo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("escudo.BackgroundImage")));
            this.escudo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.escudo.Cursor = System.Windows.Forms.Cursors.Default;
            this.escudo.Location = new System.Drawing.Point(199, 22);
            this.escudo.MaximumSize = new System.Drawing.Size(280, 300);
            this.escudo.MinimumSize = new System.Drawing.Size(70, 75);
            this.escudo.Name = "escudo";
            this.escudo.Size = new System.Drawing.Size(140, 151);
            this.escudo.TabIndex = 15;
            this.escudo.TabStop = false;
            this.escudo.MouseHover += new System.EventHandler(this.escudo_MouseHover);
            // 
            // clave
            // 
            this.clave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clave.AutoSize = true;
            this.clave.BackColor = System.Drawing.Color.Transparent;
            this.clave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.clave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clave.Location = new System.Drawing.Point(107, 219);
            this.clave.MaximumSize = new System.Drawing.Size(140, 40);
            this.clave.MinimumSize = new System.Drawing.Size(35, 10);
            this.clave.Name = "clave";
            this.clave.Size = new System.Drawing.Size(52, 19);
            this.clave.TabIndex = 13;
            this.clave.Text = "Clave";
            // 
            // usuario
            // 
            this.usuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usuario.AutoSize = true;
            this.usuario.BackColor = System.Drawing.Color.Transparent;
            this.usuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.usuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.usuario.Location = new System.Drawing.Point(107, 182);
            this.usuario.MaximumSize = new System.Drawing.Size(140, 40);
            this.usuario.MinimumSize = new System.Drawing.Size(35, 10);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(69, 19);
            this.usuario.TabIndex = 11;
            this.usuario.Text = "Usuario";
            // 
            // Login
            // 
            this.AcceptButton = this.accept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(522, 358);
            this.Controls.Add(this.escudo);
            this.Controls.Add(this.cuadroCont);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.clave);
            this.Controls.Add(this.cuadroUsu);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.accept);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(365, 355);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.escudo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cuadroCont;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox cuadroUsu;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button accept;
        private System.Windows.Forms.PictureBox escudo;
        private System.Windows.Forms.Label clave;
        private System.Windows.Forms.Label usuario;
    }
}

