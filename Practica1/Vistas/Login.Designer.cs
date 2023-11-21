namespace Practica1
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.accept = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.enlace = new System.Windows.Forms.LinkLabel();
            this.usuario = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cuadroUsu = new System.Windows.Forms.TextBox();
            this.clave = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cuadroCont = new System.Windows.Forms.TextBox();
            this.disclaimer = new System.Windows.Forms.Label();
            this.IblError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // accept
            // 
            this.accept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.accept.Location = new System.Drawing.Point(416, 205);
            this.accept.Name = "accept";
            this.accept.Size = new System.Drawing.Size(75, 23);
            this.accept.TabIndex = 0;
            this.accept.Text = "Aceptar";
            this.accept.UseVisualStyleBackColor = true;
            this.accept.Click += new System.EventHandler(this.button1_Click);
            // 
            // cancel
            // 
            this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel.Location = new System.Drawing.Point(304, 205);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 1;
            this.cancel.Text = "Cancelar";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // enlace
            // 
            this.enlace.AutoSize = true;
            this.enlace.Location = new System.Drawing.Point(72, 176);
            this.enlace.Name = "enlace";
            this.enlace.Size = new System.Drawing.Size(83, 13);
            this.enlace.TabIndex = 2;
            this.enlace.TabStop = true;
            this.enlace.Text = "Enlace a la web";
            this.enlace.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // usuario
            // 
            this.usuario.AutoSize = true;
            this.usuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.usuario.Location = new System.Drawing.Point(241, 105);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(69, 19);
            this.usuario.TabIndex = 3;
            this.usuario.Text = "Usuario";
            this.usuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(48, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cuadroUsu
            // 
            this.cuadroUsu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuadroUsu.Location = new System.Drawing.Point(336, 105);
            this.cuadroUsu.Name = "cuadroUsu";
            this.cuadroUsu.Size = new System.Drawing.Size(150, 26);
            this.cuadroUsu.TabIndex = 5;
            this.cuadroUsu.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // clave
            // 
            this.clave.AutoSize = true;
            this.clave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.clave.Location = new System.Drawing.Point(241, 142);
            this.clave.Name = "clave";
            this.clave.Size = new System.Drawing.Size(52, 19);
            this.clave.TabIndex = 6;
            this.clave.Text = "Clave";
            this.clave.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(430, 205);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(0, 20);
            this.textBox2.TabIndex = 7;
            // 
            // cuadroCont
            // 
            this.cuadroCont.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuadroCont.Location = new System.Drawing.Point(336, 142);
            this.cuadroCont.Name = "cuadroCont";
            this.cuadroCont.PasswordChar = '*';
            this.cuadroCont.Size = new System.Drawing.Size(150, 26);
            this.cuadroCont.TabIndex = 8;
            this.cuadroCont.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // disclaimer
            // 
            this.disclaimer.AutoSize = true;
            this.disclaimer.Font = new System.Drawing.Font("MV Boli", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disclaimer.Location = new System.Drawing.Point(150, 273);
            this.disclaimer.Name = "disclaimer";
            this.disclaimer.Size = new System.Drawing.Size(496, 105);
            this.disclaimer.TabIndex = 9;
            this.disclaimer.Text = resources.GetString("disclaimer.Text");
            // 
            // IblError
            // 
            this.IblError.AutoSize = true;
            this.IblError.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IblError.ForeColor = System.Drawing.Color.Red;
            this.IblError.Location = new System.Drawing.Point(270, 245);
            this.IblError.Name = "IblError";
            this.IblError.Size = new System.Drawing.Size(221, 19);
            this.IblError.TabIndex = 10;
            this.IblError.Text = "Usuario y/o clave incorrecta";
            this.IblError.Visible = false;
            this.IblError.Click += new System.EventHandler(this.IblError_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.accept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.cancel;
            this.ClientSize = new System.Drawing.Size(807, 411);
            this.Controls.Add(this.IblError);
            this.Controls.Add(this.disclaimer);
            this.Controls.Add(this.cuadroCont);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.clave);
            this.Controls.Add(this.cuadroUsu);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.enlace);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.accept);
            this.Location = new System.Drawing.Point(50, 50);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionaIES";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.GestionaIES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button accept;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.LinkLabel enlace;
        private System.Windows.Forms.Label usuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox cuadroUsu;
        private System.Windows.Forms.Label clave;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox cuadroCont;
        private System.Windows.Forms.Label disclaimer;
        private System.Windows.Forms.Label IblError;
    }
}

