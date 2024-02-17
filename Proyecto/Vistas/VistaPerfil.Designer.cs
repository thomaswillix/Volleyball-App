namespace Proyecto.Vistas
{
    partial class VistaPerfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaPerfil));
            this.pfp = new System.Windows.Forms.PictureBox();
            this.nombre = new System.Windows.Forms.Label();
            this.apell = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateBir = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btSave = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.nom = new System.Windows.Forms.Label();
            this.apes = new System.Windows.Forms.Label();
            this.fechaNac = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pfp)).BeginInit();
            this.SuspendLayout();
            // 
            // pfp
            // 
            this.pfp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pfp.BackColor = System.Drawing.Color.Transparent;
            this.pfp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pfp.Location = new System.Drawing.Point(29, 27);
            this.pfp.Name = "pfp";
            this.pfp.Size = new System.Drawing.Size(178, 159);
            this.pfp.TabIndex = 0;
            this.pfp.TabStop = false;
            // 
            // nombre
            // 
            this.nombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nombre.AutoSize = true;
            this.nombre.Location = new System.Drawing.Point(213, 57);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(44, 13);
            this.nombre.TabIndex = 1;
            this.nombre.Text = "Nombre";
            // 
            // apell
            // 
            this.apell.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.apell.AutoSize = true;
            this.apell.Location = new System.Drawing.Point(207, 96);
            this.apell.Name = "apell";
            this.apell.Size = new System.Drawing.Size(49, 13);
            this.apell.TabIndex = 2;
            this.apell.Text = "Apellidos";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(263, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Location = new System.Drawing.Point(263, 92);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker1.Location = new System.Drawing.Point(163, 214);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // dateBir
            // 
            this.dateBir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateBir.AutoSize = true;
            this.dateBir.Location = new System.Drawing.Point(51, 218);
            this.dateBir.Name = "dateBir";
            this.dateBir.Size = new System.Drawing.Size(106, 13);
            this.dateBir.TabIndex = 8;
            this.dateBir.Text = "Fecha de nacimiento";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btSave
            // 
            this.btSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btSave.Location = new System.Drawing.Point(112, 275);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(95, 23);
            this.btSave.TabIndex = 10;
            this.btSave.Text = "Guardar cambios";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btEdit
            // 
            this.btEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btEdit.Location = new System.Drawing.Point(200, 275);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(52, 23);
            this.btEdit.TabIndex = 11;
            this.btEdit.Text = "Editar";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btCancel
            // 
            this.btCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btCancel.Location = new System.Drawing.Point(242, 275);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 12;
            this.btCancel.Text = "Cancelar";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(0, 0);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(100, 23);
            this.nom.TabIndex = 19;
            // 
            // apes
            // 
            this.apes.Location = new System.Drawing.Point(0, 0);
            this.apes.Name = "apes";
            this.apes.Size = new System.Drawing.Size(100, 23);
            this.apes.TabIndex = 18;
            // 
            // fechaNac
            // 
            this.fechaNac.Location = new System.Drawing.Point(0, 0);
            this.fechaNac.Name = "fechaNac";
            this.fechaNac.Size = new System.Drawing.Size(100, 23);
            this.fechaNac.TabIndex = 17;
            // 
            // VistaPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(401, 335);
            this.Controls.Add(this.fechaNac);
            this.Controls.Add(this.apes);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.dateBir);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.apell);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.pfp);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(417, 374);
            this.Name = "VistaPerfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mi perfil";
            this.Load += new System.EventHandler(this.VistaPerfil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pfp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pfp;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Label apell;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label dateBir;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Label nom;
        private System.Windows.Forms.Label apes;
        private System.Windows.Forms.Label fechaNac;
    }
}