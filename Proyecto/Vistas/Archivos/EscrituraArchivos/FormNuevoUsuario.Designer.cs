namespace Proyecto.Vistas
{
    partial class FormNuevoUsuario
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
            this.pass = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.clave = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.TextBox();
            this.usuario = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.accept = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pass
            // 
            this.pass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pass.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.Location = new System.Drawing.Point(142, 59);
            this.pass.MaximumSize = new System.Drawing.Size(300, 52);
            this.pass.MinimumSize = new System.Drawing.Size(75, 13);
            this.pass.Name = "pass";
            this.pass.PasswordChar = '*';
            this.pass.Size = new System.Drawing.Size(150, 26);
            this.pass.TabIndex = 17;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(506, 340);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(0, 20);
            this.textBox2.TabIndex = 23;
            // 
            // clave
            // 
            this.clave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clave.AutoSize = true;
            this.clave.BackColor = System.Drawing.Color.Transparent;
            this.clave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.clave.ForeColor = System.Drawing.SystemColors.Window;
            this.clave.Location = new System.Drawing.Point(15, 63);
            this.clave.MaximumSize = new System.Drawing.Size(140, 40);
            this.clave.MinimumSize = new System.Drawing.Size(35, 10);
            this.clave.Name = "clave";
            this.clave.Size = new System.Drawing.Size(52, 19);
            this.clave.TabIndex = 22;
            this.clave.Text = "Clave";
            // 
            // user
            // 
            this.user.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.user.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.Location = new System.Drawing.Point(142, 26);
            this.user.MaximumSize = new System.Drawing.Size(300, 52);
            this.user.MinimumSize = new System.Drawing.Size(75, 13);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(150, 26);
            this.user.TabIndex = 16;
            // 
            // usuario
            // 
            this.usuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usuario.AutoSize = true;
            this.usuario.BackColor = System.Drawing.Color.Transparent;
            this.usuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.usuario.ForeColor = System.Drawing.SystemColors.Window;
            this.usuario.Location = new System.Drawing.Point(15, 29);
            this.usuario.MaximumSize = new System.Drawing.Size(140, 40);
            this.usuario.MinimumSize = new System.Drawing.Size(35, 10);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(121, 19);
            this.usuario.TabIndex = 21;
            this.usuario.Text = "Nuevo usuario";
            // 
            // cancel
            // 
            this.cancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel.Location = new System.Drawing.Point(57, 104);
            this.cancel.MaximumSize = new System.Drawing.Size(150, 50);
            this.cancel.MinimumSize = new System.Drawing.Size(37, 12);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(96, 25);
            this.cancel.TabIndex = 18;
            this.cancel.Text = "Limpiar campos";
            this.cancel.UseVisualStyleBackColor = false;
            // 
            // accept
            // 
            this.accept.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.accept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.accept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.accept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.accept.Location = new System.Drawing.Point(169, 104);
            this.accept.MaximumSize = new System.Drawing.Size(150, 50);
            this.accept.MinimumSize = new System.Drawing.Size(37, 12);
            this.accept.Name = "accept";
            this.accept.Size = new System.Drawing.Size(75, 25);
            this.accept.TabIndex = 19;
            this.accept.Text = "Registrarse";
            this.accept.UseVisualStyleBackColor = false;
            // 
            // FormNuevoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(321, 173);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.clave);
            this.Controls.Add(this.user);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.accept);
            this.Name = "FormNuevoUsuario";
            this.Text = "FormNuevoUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label clave;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.Label usuario;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button accept;
    }
}