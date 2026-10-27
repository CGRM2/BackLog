namespace BackLog
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblEstadoBD = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabFechas = new System.Windows.Forms.TabPage();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabFechas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.SuspendLayout();
            this.lblEstadoBD.AutoSize = true;
            this.lblEstadoBD.Location = new System.Drawing.Point(12, 15);
            this.lblEstadoBD.Name = "lblEstadoBD";
            this.lblEstadoBD.Text = "Estado BD: Comprobando conexión...";
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabFechas);
            this.tabControl1.Location = new System.Drawing.Point(12, 45);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Size = new System.Drawing.Size(776, 393);
            this.tabFechas.Size = new System.Drawing.Size(768, 367);
            this.tabFechas.Controls.Add(this.lblFechaInicio);
            this.tabFechas.Controls.Add(this.dtpFechaInicio);
            this.tabFechas.Controls.Add(this.btnConsultar);
            this.tabFechas.Controls.Add(this.dgvVentas);
            this.tabFechas.Name = "tabFechas";
            this.tabFechas.Text = "Filtro por Fechas";
            this.tabFechas.UseVisualStyleBackColor = true;
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Location = new System.Drawing.Point(15, 23);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Text = "Mostrar ventas realizadas desde:";
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(195, 19);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(130, 20);
            this.btnConsultar.Location = new System.Drawing.Point(345, 16);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(145, 27);
            this.btnConsultar.Text = "Consultar Ventas";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            this.dgvVentas.AllowUserToAddRows = false;
            this.dgvVentas.AllowUserToDeleteRows = false;
            this.dgvVentas.ReadOnly = true;
            this.dgvVentas.AutoGenerateColumns = false;
            this.dgvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVentas.Anchor = this.tabControl1.Anchor;
            this.dgvVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.colId, this.colCliente, this.colMonto, this.colFechaVenta });
            this.dgvVentas.Location = new System.Drawing.Point(18, 63);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.Size = new System.Drawing.Size(732, 283);
            this.dgvVentas.RowHeadersVisible = false;
            this.dgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.FillWeight = 35;
            this.colCliente.DataPropertyName = "Cliente";
            this.colCliente.HeaderText = "Cliente";
            this.colCliente.Name = "colCliente";
            this.colCliente.FillWeight = 150;
            this.colMonto.DataPropertyName = "Monto";
            this.colMonto.HeaderText = "Monto ($)";
            this.colMonto.Name = "colMonto";
            this.colMonto.DefaultCellStyle.Format = "N2";
            this.colMonto.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colFechaVenta.DataPropertyName = "FechaVenta";
            this.colFechaVenta.HeaderText = "Fecha de Venta";
            this.colFechaVenta.Name = "colFechaVenta";
            this.colFechaVenta.FillWeight = 130;
            this.colFechaVenta.DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.MinimumSize = new System.Drawing.Size(700, 350);
            this.Controls.Add(this.lblEstadoBD);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Gestor de Ventas LocalDB - Filtro por Fechas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabFechas.ResumeLayout(false);
            this.tabFechas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblEstadoBD;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabFechas;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaVenta;
    }
}

