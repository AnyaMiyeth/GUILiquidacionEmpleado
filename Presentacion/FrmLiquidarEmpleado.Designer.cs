namespace Presentacion
{
    partial class FrmLiquidarEmpleado
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
            this.components = new System.ComponentModel.Container();
            this.GridLiquidacion = new System.Windows.Forms.DataGridView();
            this.liquidacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BtnLiquidar = new System.Windows.Forms.Button();
            this.CmbPeriodo = new System.Windows.Forms.ComboBox();
            this.TxtVigencia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridLiquidacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liquidacionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // GridLiquidacion
            // 
            this.GridLiquidacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridLiquidacion.Location = new System.Drawing.Point(12, 100);
            this.GridLiquidacion.Name = "GridLiquidacion";
            this.GridLiquidacion.Size = new System.Drawing.Size(800, 232);
            this.GridLiquidacion.TabIndex = 0;
            // 
            // liquidacionBindingSource
            // 
            this.liquidacionBindingSource.DataSource = typeof(Entity.Liquidacion);
            // 
            // BtnLiquidar
            // 
            this.BtnLiquidar.Location = new System.Drawing.Point(402, 12);
            this.BtnLiquidar.Name = "BtnLiquidar";
            this.BtnLiquidar.Size = new System.Drawing.Size(96, 53);
            this.BtnLiquidar.TabIndex = 2;
            this.BtnLiquidar.Text = "Liquidar";
            this.BtnLiquidar.UseVisualStyleBackColor = true;
            this.BtnLiquidar.Click += new System.EventHandler(this.BtnLiquidar_Click);
            // 
            // CmbPeriodo
            // 
            this.CmbPeriodo.FormattingEnabled = true;
            this.CmbPeriodo.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.CmbPeriodo.Location = new System.Drawing.Point(170, 52);
            this.CmbPeriodo.Name = "CmbPeriodo";
            this.CmbPeriodo.Size = new System.Drawing.Size(121, 21);
            this.CmbPeriodo.TabIndex = 3;
            // 
            // TxtVigencia
            // 
            this.TxtVigencia.Location = new System.Drawing.Point(170, 12);
            this.TxtVigencia.Name = "TxtVigencia";
            this.TxtVigencia.Size = new System.Drawing.Size(121, 20);
            this.TxtVigencia.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Vigencia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Periodo";
            // 
            // FrmLiquidarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 372);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtVigencia);
            this.Controls.Add(this.CmbPeriodo);
            this.Controls.Add(this.BtnLiquidar);
            this.Controls.Add(this.GridLiquidacion);
            this.Name = "FrmLiquidarEmpleado";
            this.Text = "Liquidar Empleado";
            ((System.ComponentModel.ISupportInitialize)(this.GridLiquidacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liquidacionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridLiquidacion;
        private System.Windows.Forms.Button BtnLiquidar;
        private System.Windows.Forms.ComboBox CmbPeriodo;
        private System.Windows.Forms.TextBox TxtVigencia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource liquidacionBindingSource;
    }
}