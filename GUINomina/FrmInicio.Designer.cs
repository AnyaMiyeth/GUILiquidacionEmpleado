namespace GUINomina
{
    partial class FrmInicio
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.empladoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadoContratistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadoPlantaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nominaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liqudaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairDeAplicaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empladoToolStripMenuItem,
            this.nominaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(627, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // empladoToolStripMenuItem
            // 
            this.empladoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empleadoContratistaToolStripMenuItem,
            this.empleadoPlantaToolStripMenuItem});
            this.empladoToolStripMenuItem.Name = "empladoToolStripMenuItem";
            this.empladoToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.empladoToolStripMenuItem.Text = "Emplado";
            this.empladoToolStripMenuItem.Click += new System.EventHandler(this.empladoToolStripMenuItem_Click);
            // 
            // empleadoContratistaToolStripMenuItem
            // 
            this.empleadoContratistaToolStripMenuItem.Name = "empleadoContratistaToolStripMenuItem";
            this.empleadoContratistaToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.empleadoContratistaToolStripMenuItem.Text = "Empleado Contratista";
            this.empleadoContratistaToolStripMenuItem.Click += new System.EventHandler(this.empleadoContratistaToolStripMenuItem_Click);
            // 
            // empleadoPlantaToolStripMenuItem
            // 
            this.empleadoPlantaToolStripMenuItem.Name = "empleadoPlantaToolStripMenuItem";
            this.empleadoPlantaToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.empleadoPlantaToolStripMenuItem.Text = "Empleado Planta";
            // 
            // nominaToolStripMenuItem
            // 
            this.nominaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.liqudaciónToolStripMenuItem});
            this.nominaToolStripMenuItem.Name = "nominaToolStripMenuItem";
            this.nominaToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.nominaToolStripMenuItem.Text = "Nómina";
            // 
            // liqudaciónToolStripMenuItem
            // 
            this.liqudaciónToolStripMenuItem.Name = "liqudaciónToolStripMenuItem";
            this.liqudaciónToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.liqudaciónToolStripMenuItem.Text = "Liqudación";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairDeAplicaciónToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // sairDeAplicaciónToolStripMenuItem
            // 
            this.sairDeAplicaciónToolStripMenuItem.Name = "sairDeAplicaciónToolStripMenuItem";
            this.sairDeAplicaciónToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.sairDeAplicaciónToolStripMenuItem.Text = "Salir de Aplicación";
            this.sairDeAplicaciónToolStripMenuItem.Click += new System.EventHandler(this.sairDeAplicaciónToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 323);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmInicio";
            this.Text = "Liquidacion de nomina Inveralia  SAS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem empladoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadoContratistaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadoPlantaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nominaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liqudaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairDeAplicaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
    }
}

