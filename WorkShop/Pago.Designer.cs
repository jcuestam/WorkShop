namespace WorkShop
{
    partial class Pago
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
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbEmpleado = new System.Windows.Forms.ComboBox();
            this.txtPago = new System.Windows.Forms.TextBox();
            this.btnPago = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.ejemploDataSet1 = new WorkShop.EjemploDataSet1();
            this.pagosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pagosTableAdapter = new WorkShop.EjemploDataSet1TableAdapters.pagosTableAdapter();
            this.idpagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ihssDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fosoviDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netopagarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechapagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totaldeduccionesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ejemploDataSet2 = new WorkShop.EjemploDataSet2();
            this.empleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empleadoTableAdapter = new WorkShop.EjemploDataSet2TableAdapters.empleadoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejemploDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejemploDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Location = new System.Drawing.Point(38, 58);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(81, 20);
            this.lblEmpleado.TabIndex = 0;
            this.lblEmpleado.Text = "Empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pago";
            // 
            // cbEmpleado
            // 
            this.cbEmpleado.DataSource = this.empleadoBindingSource;
            this.cbEmpleado.DisplayMember = "id_empleado";
            this.cbEmpleado.FormattingEnabled = true;
            this.cbEmpleado.Location = new System.Drawing.Point(42, 82);
            this.cbEmpleado.Name = "cbEmpleado";
            this.cbEmpleado.Size = new System.Drawing.Size(227, 28);
            this.cbEmpleado.TabIndex = 2;
            this.cbEmpleado.ValueMember = "id_empleado";
            // 
            // txtPago
            // 
            this.txtPago.Location = new System.Drawing.Point(110, 136);
            this.txtPago.Name = "txtPago";
            this.txtPago.Size = new System.Drawing.Size(159, 26);
            this.txtPago.TabIndex = 3;
            // 
            // btnPago
            // 
            this.btnPago.Location = new System.Drawing.Point(42, 187);
            this.btnPago.Name = "btnPago";
            this.btnPago.Size = new System.Drawing.Size(227, 39);
            this.btnPago.TabIndex = 4;
            this.btnPago.Text = "Realizar Pago";
            this.btnPago.UseVisualStyleBackColor = true;
            this.btnPago.Click += new System.EventHandler(this.btnPago_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(42, 232);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(227, 45);
            this.btnReporte.TabIndex = 5;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpagoDataGridViewTextBoxColumn,
            this.pagoDataGridViewTextBoxColumn,
            this.ihssDataGridViewTextBoxColumn,
            this.fosoviDataGridViewTextBoxColumn,
            this.netopagarDataGridViewTextBoxColumn,
            this.fechapagoDataGridViewTextBoxColumn,
            this.totaldeduccionesDataGridViewTextBoxColumn,
            this.empleadoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pagosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(306, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(460, 182);
            this.dataGridView1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(306, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(460, 44);
            this.button1.TabIndex = 7;
            this.button1.Text = "Empleados";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ejemploDataSet1
            // 
            this.ejemploDataSet1.DataSetName = "EjemploDataSet1";
            this.ejemploDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pagosBindingSource
            // 
            this.pagosBindingSource.DataMember = "pagos";
            this.pagosBindingSource.DataSource = this.ejemploDataSet1;
            // 
            // pagosTableAdapter
            // 
            this.pagosTableAdapter.ClearBeforeFill = true;
            // 
            // idpagoDataGridViewTextBoxColumn
            // 
            this.idpagoDataGridViewTextBoxColumn.DataPropertyName = "id_pago";
            this.idpagoDataGridViewTextBoxColumn.HeaderText = "id_pago";
            this.idpagoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idpagoDataGridViewTextBoxColumn.Name = "idpagoDataGridViewTextBoxColumn";
            this.idpagoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idpagoDataGridViewTextBoxColumn.Width = 150;
            // 
            // pagoDataGridViewTextBoxColumn
            // 
            this.pagoDataGridViewTextBoxColumn.DataPropertyName = "pago";
            this.pagoDataGridViewTextBoxColumn.HeaderText = "pago";
            this.pagoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pagoDataGridViewTextBoxColumn.Name = "pagoDataGridViewTextBoxColumn";
            this.pagoDataGridViewTextBoxColumn.Width = 150;
            // 
            // ihssDataGridViewTextBoxColumn
            // 
            this.ihssDataGridViewTextBoxColumn.DataPropertyName = "ihss";
            this.ihssDataGridViewTextBoxColumn.HeaderText = "ihss";
            this.ihssDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ihssDataGridViewTextBoxColumn.Name = "ihssDataGridViewTextBoxColumn";
            this.ihssDataGridViewTextBoxColumn.Width = 150;
            // 
            // fosoviDataGridViewTextBoxColumn
            // 
            this.fosoviDataGridViewTextBoxColumn.DataPropertyName = "fosovi";
            this.fosoviDataGridViewTextBoxColumn.HeaderText = "fosovi";
            this.fosoviDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fosoviDataGridViewTextBoxColumn.Name = "fosoviDataGridViewTextBoxColumn";
            this.fosoviDataGridViewTextBoxColumn.Width = 150;
            // 
            // netopagarDataGridViewTextBoxColumn
            // 
            this.netopagarDataGridViewTextBoxColumn.DataPropertyName = "neto_pagar";
            this.netopagarDataGridViewTextBoxColumn.HeaderText = "neto_pagar";
            this.netopagarDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.netopagarDataGridViewTextBoxColumn.Name = "netopagarDataGridViewTextBoxColumn";
            this.netopagarDataGridViewTextBoxColumn.Width = 150;
            // 
            // fechapagoDataGridViewTextBoxColumn
            // 
            this.fechapagoDataGridViewTextBoxColumn.DataPropertyName = "fecha_pago";
            this.fechapagoDataGridViewTextBoxColumn.HeaderText = "fecha_pago";
            this.fechapagoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fechapagoDataGridViewTextBoxColumn.Name = "fechapagoDataGridViewTextBoxColumn";
            this.fechapagoDataGridViewTextBoxColumn.Width = 150;
            // 
            // totaldeduccionesDataGridViewTextBoxColumn
            // 
            this.totaldeduccionesDataGridViewTextBoxColumn.DataPropertyName = "total_deducciones";
            this.totaldeduccionesDataGridViewTextBoxColumn.HeaderText = "total_deducciones";
            this.totaldeduccionesDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.totaldeduccionesDataGridViewTextBoxColumn.Name = "totaldeduccionesDataGridViewTextBoxColumn";
            this.totaldeduccionesDataGridViewTextBoxColumn.Width = 150;
            // 
            // empleadoDataGridViewTextBoxColumn
            // 
            this.empleadoDataGridViewTextBoxColumn.DataPropertyName = "empleado";
            this.empleadoDataGridViewTextBoxColumn.HeaderText = "empleado";
            this.empleadoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.empleadoDataGridViewTextBoxColumn.Name = "empleadoDataGridViewTextBoxColumn";
            this.empleadoDataGridViewTextBoxColumn.Width = 150;
            // 
            // ejemploDataSet2
            // 
            this.ejemploDataSet2.DataSetName = "EjemploDataSet2";
            this.ejemploDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empleadoBindingSource
            // 
            this.empleadoBindingSource.DataMember = "empleado";
            this.empleadoBindingSource.DataSource = this.ejemploDataSet2;
            // 
            // empleadoTableAdapter
            // 
            this.empleadoTableAdapter.ClearBeforeFill = true;
            // 
            // Pago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 289);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnPago);
            this.Controls.Add(this.txtPago);
            this.Controls.Add(this.cbEmpleado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblEmpleado);
            this.Name = "Pago";
            this.Text = "Pago";
            this.Load += new System.EventHandler(this.Pago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejemploDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejemploDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbEmpleado;
        private System.Windows.Forms.TextBox txtPago;
        private System.Windows.Forms.Button btnPago;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private EjemploDataSet1 ejemploDataSet1;
        private System.Windows.Forms.BindingSource pagosBindingSource;
        private EjemploDataSet1TableAdapters.pagosTableAdapter pagosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpagoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ihssDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fosoviDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn netopagarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechapagoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totaldeduccionesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empleadoDataGridViewTextBoxColumn;
        private EjemploDataSet2 ejemploDataSet2;
        private System.Windows.Forms.BindingSource empleadoBindingSource;
        private EjemploDataSet2TableAdapters.empleadoTableAdapter empleadoTableAdapter;
    }
}