namespace Practica1
{
    partial class PrincipalJug
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalJug));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bienv = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empleadosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(19, 6, 0, 6);
            this.menuStrip1.Size = new System.Drawing.Size(784, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaToolStripMenuItem1});
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(70, 19);
            this.empleadosToolStripMenuItem.Text = "Consultar";
            // 
            // altaToolStripMenuItem1
            // 
            this.altaToolStripMenuItem1.Name = "altaToolStripMenuItem1";
            this.altaToolStripMenuItem1.Size = new System.Drawing.Size(150, 22);
            this.altaToolStripMenuItem1.Text = "Convocatorias";
            this.altaToolStripMenuItem1.Click += new System.EventHandler(this.altaToolStripMenuItem1_Click);
            // 
            // bienv
            // 
            this.bienv.AutoSize = true;
            this.bienv.BackColor = System.Drawing.Color.Transparent;
            this.bienv.Font = new System.Drawing.Font("Segoe UI Emoji", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bienv.ForeColor = System.Drawing.Color.White;
            this.bienv.Location = new System.Drawing.Point(45, 55);
            this.bienv.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.bienv.Name = "bienv";
            this.bienv.Size = new System.Drawing.Size(207, 46);
            this.bienv.TabIndex = 1;
            this.bienv.Text = "Bienvenid@";
            this.bienv.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(344, 493);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 32);
            this.label2.TabIndex = 17;
            this.label2.Text = "Cerrar aplicación";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // botonCancelar
            // 
            this.botonCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.botonCancelar.BackColor = System.Drawing.Color.Transparent;
            this.botonCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonCancelar.BackgroundImage")));
            this.botonCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.botonCancelar.FlatAppearance.BorderSize = 0;
            this.botonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.botonCancelar.Location = new System.Drawing.Point(377, 454);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(36, 36);
            this.botonCancelar.TabIndex = 18;
            this.botonCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botonCancelar.UseVisualStyleBackColor = false;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // PrincipalJug
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bienv);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrincipalJug";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Jugador";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Principal_FormClosing);
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaToolStripMenuItem1;
        private System.Windows.Forms.Label bienv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button botonCancelar;
    }
}