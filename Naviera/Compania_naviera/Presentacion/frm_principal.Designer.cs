namespace Compania_naviera.Presentacion
{
    partial class frm_principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasajerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itinerariosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tripulacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.organizacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itinerariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.puertosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viajesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.organizacionToolStripMenuItem,
            this.viajesToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pasajerosToolStripMenuItem,
            this.itinerariosToolStripMenuItem1,
            this.tripulacionToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Soporte";
            // 
            // pasajerosToolStripMenuItem
            // 
            this.pasajerosToolStripMenuItem.Name = "pasajerosToolStripMenuItem";
            this.pasajerosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pasajerosToolStripMenuItem.Text = "Navio";
            this.pasajerosToolStripMenuItem.Click += new System.EventHandler(this.PasajerosToolStripMenuItem_Click);
            // 
            // itinerariosToolStripMenuItem1
            // 
            this.itinerariosToolStripMenuItem1.Name = "itinerariosToolStripMenuItem1";
            this.itinerariosToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.itinerariosToolStripMenuItem1.Text = "Itinerarios";
            this.itinerariosToolStripMenuItem1.Click += new System.EventHandler(this.ItinerariosToolStripMenuItem1_Click);
            // 
            // tripulacionToolStripMenuItem
            // 
            this.tripulacionToolStripMenuItem.Name = "tripulacionToolStripMenuItem";
            this.tripulacionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tripulacionToolStripMenuItem.Text = "Tripulacion";
            // 
            // organizacionToolStripMenuItem
            // 
            this.organizacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itinerariosToolStripMenuItem,
            this.puertosToolStripMenuItem});
            this.organizacionToolStripMenuItem.Name = "organizacionToolStripMenuItem";
            this.organizacionToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.organizacionToolStripMenuItem.Text = "Operaciones";
            // 
            // itinerariosToolStripMenuItem
            // 
            this.itinerariosToolStripMenuItem.Name = "itinerariosToolStripMenuItem";
            this.itinerariosToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.itinerariosToolStripMenuItem.Text = "Viaje";
            // 
            // puertosToolStripMenuItem
            // 
            this.puertosToolStripMenuItem.Name = "puertosToolStripMenuItem";
            this.puertosToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.puertosToolStripMenuItem.Text = "Seguimiento Viaje";
            // 
            // viajesToolStripMenuItem
            // 
            this.viajesToolStripMenuItem.Name = "viajesToolStripMenuItem";
            this.viajesToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.viajesToolStripMenuItem.Text = "Informes";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItem_Click);
            // 
            // frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Compania_naviera.Properties.Resources.Fondo_principal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_principal";
            this.Text = "frm_principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasajerosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem organizacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itinerariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem puertosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viajesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itinerariosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tripulacionToolStripMenuItem;
    }
}