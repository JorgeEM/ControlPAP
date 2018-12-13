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
            this.btnVender = new System.Windows.Forms.Button();
            this.lblProducto = new System.Windows.Forms.Label();
            this.cmbBxProductos = new System.Windows.Forms.ComboBox();
            this.grpBxInfo = new System.Windows.Forms.GroupBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.picBxLogo = new System.Windows.Forms.PictureBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grpBxInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.BackColor = System.Drawing.Color.Transparent;
            this.lblCantidad.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F);
            this.lblCantidad.Location = new System.Drawing.Point(544, 135);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(83, 20);
            this.lblCantidad.TabIndex = 26;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // cmbBxCantidad
            // 
            this.cmbBxCantidad.BackColor = System.Drawing.Color.Gainsboro;
            this.cmbBxCantidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxCantidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBxCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.cmbBxCantidad.FormattingEnabled = true;
            this.cmbBxCantidad.Location = new System.Drawing.Point(642, 131);
            this.cmbBxCantidad.Name = "cmbBxCantidad";
            this.cmbBxCantidad.Size = new System.Drawing.Size(72, 28);
            this.cmbBxCantidad.TabIndex = 25;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F);
            this.lblTotal.Location = new System.Drawing.Point(576, 396);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(78, 20);
            this.lblTotal.TabIndex = 24;
            this.lblTotal.Text = "TOTAL:";
            // 
            // txtBxTotal
            // 
            this.txtBxTotal.BackColor = System.Drawing.Color.White;
            this.txtBxTotal.Enabled = false;
            this.txtBxTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtBxTotal.Location = new System.Drawing.Point(548, 425);
            this.txtBxTotal.Name = "txtBxTotal";
            this.txtBxTotal.ReadOnly = true;
            this.txtBxTotal.Size = new System.Drawing.Size(136, 27);
            this.txtBxTotal.TabIndex = 23;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.BackgroundImage = global::ControlPAP.Properties.Resources.Añadir;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Location = new System.Drawing.Point(625, 197);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(108, 109);
            this.btnAgregar.TabIndex = 22;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnVender
            // 
            this.btnVender.BackColor = System.Drawing.Color.Transparent;
            this.btnVender.BackgroundImage = global::ControlPAP.Properties.Resources.Vender;
            this.btnVender.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVender.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVender.Location = new System.Drawing.Point(702, 378);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(108, 101);
            this.btnVender.TabIndex = 21;
            this.btnVender.Text = "VENDER";
            this.btnVender.UseVisualStyleBackColor = false;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.BackColor = System.Drawing.Color.Transparent;
            this.lblProducto.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F);
            this.lblProducto.Location = new System.Drawing.Point(12, 135);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(84, 20);
            this.lblProducto.TabIndex = 20;
            this.lblProducto.Text = "Producto:";
            // 
            // cmbBxProductos
            // 
            this.cmbBxProductos.BackColor = System.Drawing.Color.Gainsboro;
            this.cmbBxProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBxProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.cmbBxProductos.FormattingEnabled = true;
            this.cmbBxProductos.Location = new System.Drawing.Point(113, 132);
            this.cmbBxProductos.Name = "cmbBxProductos";
            this.cmbBxProductos.Size = new System.Drawing.Size(398, 28);
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
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(12, 181);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowTemplate.Height = 24;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(514, 300);
            this.dgvProductos.TabIndex = 27;
            this.dgvProductos.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgvProductos_RowStateChanged);
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataSource = typeof(ControlPAP.BaseDeDatos.Producto);
            // 
            // formVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ControlPAP.Properties.Resources.FondoDetalles;
            this.ClientSize = new System.Drawing.Size(822, 493);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.cmbBxCantidad);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtBxTotal);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnVender);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.ComboBox cmbBxCantidad;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtBxTotal;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.ComboBox cmbBxProductos;
        private System.Windows.Forms.GroupBox grpBxInfo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.PictureBox picBxLogo;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private System.Windows.Forms.DataGridView dgvProductos;
    }
}