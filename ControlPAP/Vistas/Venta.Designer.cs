namespace ControlPAP.Vistas
{
    partial class formVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formVenta));
            this.lblCantidad = new System.Windows.Forms.Label();
            this.cmbBxCantidad = new System.Windows.Forms.ComboBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtBxTotal = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnComprar = new System.Windows.Forms.Button();
            this.lblProducto = new System.Windows.Forms.Label();
            this.cmbBxProductos = new System.Windows.Forms.ComboBox();
            this.grpBxInfo = new System.Windows.Forms.GroupBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.picBxLogo = new System.Windows.Forms.PictureBox();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpBxInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.BackColor = System.Drawing.Color.Transparent;
            this.lblCantidad.Location = new System.Drawing.Point(397, 135);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(68, 17);
            this.lblCantidad.TabIndex = 26;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // cmbBxCantidad
            // 
            this.cmbBxCantidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxCantidad.FormattingEnabled = true;
            this.cmbBxCantidad.Location = new System.Drawing.Point(471, 132);
            this.cmbBxCantidad.Name = "cmbBxCantidad";
            this.cmbBxCantidad.Size = new System.Drawing.Size(55, 24);
            this.cmbBxCantidad.TabIndex = 25;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Location = new System.Drawing.Point(581, 364);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(58, 17);
            this.lblTotal.TabIndex = 24;
            this.lblTotal.Text = "TOTAL:";
            // 
            // txtBxTotal
            // 
            this.txtBxTotal.Enabled = false;
            this.txtBxTotal.Location = new System.Drawing.Point(645, 361);
            this.txtBxTotal.Name = "txtBxTotal";
            this.txtBxTotal.ReadOnly = true;
            this.txtBxTotal.Size = new System.Drawing.Size(127, 22);
            this.txtBxTotal.TabIndex = 23;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Location = new System.Drawing.Point(576, 181);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(207, 56);
            this.btnAgregar.TabIndex = 22;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnComprar
            // 
            this.btnComprar.BackColor = System.Drawing.Color.Transparent;
            this.btnComprar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnComprar.Location = new System.Drawing.Point(576, 407);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(207, 64);
            this.btnComprar.TabIndex = 21;
            this.btnComprar.Text = "COMPRAR";
            this.btnComprar.UseVisualStyleBackColor = false;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.BackColor = System.Drawing.Color.Transparent;
            this.lblProducto.Location = new System.Drawing.Point(12, 135);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(69, 17);
            this.lblProducto.TabIndex = 20;
            this.lblProducto.Text = "Producto:";
            // 
            // cmbBxProductos
            // 
            this.cmbBxProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxProductos.FormattingEnabled = true;
            this.cmbBxProductos.Location = new System.Drawing.Point(87, 132);
            this.cmbBxProductos.Name = "cmbBxProductos";
            this.cmbBxProductos.Size = new System.Drawing.Size(248, 24);
            this.cmbBxProductos.TabIndex = 19;
            this.cmbBxProductos.SelectedIndexChanged += new System.EventHandler(this.cmbBxProductos_SelectedIndexChanged);
            // 
            // grpBxInfo
            // 
            this.grpBxInfo.BackColor = System.Drawing.Color.Transparent;
            this.grpBxInfo.Controls.Add(this.lblUsuario);
            this.grpBxInfo.Controls.Add(this.picBxLogo);
            this.grpBxInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpBxInfo.Location = new System.Drawing.Point(0, 0);
            this.grpBxInfo.Name = "grpBxInfo";
            this.grpBxInfo.Size = new System.Drawing.Size(822, 95);
            this.grpBxInfo.TabIndex = 17;
            this.grpBxInfo.TabStop = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblUsuario.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Italic);
            this.lblUsuario.Location = new System.Drawing.Point(569, 18);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(250, 74);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Usuario";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // picBxLogo
            // 
            this.picBxLogo.BackgroundImage = global::ControlPAP.Properties.Resources.Banner;
            this.picBxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBxLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.picBxLogo.Location = new System.Drawing.Point(3, 18);
            this.picBxLogo.Name = "picBxLogo";
            this.picBxLogo.Size = new System.Drawing.Size(560, 74);
            this.picBxLogo.TabIndex = 1;
            this.picBxLogo.TabStop = false;
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataSource = typeof(ControlPAP.BaseDeDatos.Producto);
            // 
            // productoDataGridView
            // 
            this.productoDataGridView.AllowUserToAddRows = false;
            this.productoDataGridView.AutoGenerateColumns = false;
            this.productoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.productoDataGridView.DataSource = this.productoBindingSource;
            this.productoDataGridView.Location = new System.Drawing.Point(12, 181);
            this.productoDataGridView.Name = "productoDataGridView";
            this.productoDataGridView.ReadOnly = true;
            this.productoDataGridView.RowTemplate.Height = 24;
            this.productoDataGridView.Size = new System.Drawing.Size(530, 300);
            this.productoDataGridView.TabIndex = 26;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idProducto";
            this.dataGridViewTextBoxColumn1.HeaderText = "idProducto";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "descripcion";
            this.dataGridViewTextBoxColumn3.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "precio";
            this.dataGridViewTextBoxColumn4.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "existencia";
            this.dataGridViewTextBoxColumn5.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "descuento";
            this.dataGridViewTextBoxColumn6.HeaderText = "Descuento";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // formVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 493);
            this.Controls.Add(this.productoDataGridView);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.cmbBxCantidad);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtBxTotal);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.cmbBxProductos);
            this.Controls.Add(this.grpBxInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Venta";
            this.Load += new System.EventHandler(this.formVenta_Load);
            this.grpBxInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.ComboBox cmbBxCantidad;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtBxTotal;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.ComboBox cmbBxProductos;
        private System.Windows.Forms.GroupBox grpBxInfo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.PictureBox picBxLogo;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private System.Windows.Forms.DataGridView productoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}