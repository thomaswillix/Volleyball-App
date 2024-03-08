namespace Proyecto.Vistas
{
    partial class FormListaPartidosDB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListaPartidosDB));
            this.botonCancelar = new System.Windows.Forms.Button();
            this.titulo = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.botonCancelar.Location = new System.Drawing.Point(192, 275);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(80, 70);
            this.botonCancelar.TabIndex = 20;
            this.botonCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botonCancelar.UseVisualStyleBackColor = false;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // titulo
            // 
            this.titulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.titulo.AutoSize = true;
            this.titulo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.ForeColor = System.Drawing.Color.Black;
            this.titulo.Location = new System.Drawing.Point(88, 33);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(283, 33);
            this.titulo.TabIndex = 19;
            this.titulo.Text = "CONVOCATORIAS";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(421, 190);
            this.dataGridView1.TabIndex = 21;
            // 
            // FormListaPartidosDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(467, 357);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.titulo);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormListaPartidosDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Partidos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}