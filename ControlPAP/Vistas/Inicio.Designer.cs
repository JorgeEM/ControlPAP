namespace ControlPAP.Vistas
{
    partial class formInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formInicio));
            this.btnEmpleado = new System.Windows.Forms.Button();
            this.btnAlmacen = new System.Windows.Forms.Button();
            this.grpBxInfo = new System.Windows.Forms.GroupBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.picBxLogo = new System.Windows.Forms.PictureBox();
            this.grpBxInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEmpleado
            // 
            this.btnEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.btnEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEmpleado.FlatAppearance.BorderSize = 0;
            this.btnEmpleado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEmpleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEmpleado.Location = new System.Drawing.Point(501, 196);
            this.btnEmpleado.Name = "btnEmpleado";
            this.btnEmpleado.Size = new System.Drawing.Size(184, 173);
            this.btnEmpleado.TabIndex = 5;
            this.btnEmpleado.Tag = "Empleado";
            this.btnEmpleado.Text = "EMPLEADOS";
            this.btnEmpleado.UseVisualStyleBackColor = false;
            // 
            // btnAlmacen
            // 
            this.btnAlmacen.BackColor = System.Drawing.Color.Transparent;
            this.btnAlmacen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAlmacen.FlatAppearance.BorderSize = 0;
            this.btnAlmacen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAlmacen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAlmacen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlmacen.Location = new System.Drawing.Point(113, 196);
            this.btnAlmacen.Name = "btnAlmacen";
            this.btnAlmacen.Size = new System.Drawing.Size(237, 173);
            this.btnAlmacen.TabIndex = 4;
            this.btnAlmacen.Tag = "Productos";
            this.btnAlmacen.Text = "ALMACEN";
            this.btnAlmacen.UseVisualStyleBackColor = false;
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
            this.grpBxInfo.TabIndex = 3;
            this.grpBxInfo.TabStop = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblUsuario.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // formInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ControlPAP.Properties.Resources.FondoLogIn;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(822, 493);
            this.Controls.Add(this.btnEmpleado);
            this.Controls.Add(this.btnAlmacen);
            this.Controls.Add(this.grpBxInfo);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.formInicio_Load);
            this.grpBxInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEmpleado;
        private System.Windows.Forms.Button btnAlmacen;
        private System.Windows.Forms.GroupBox grpBxInfo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.PictureBox picBxLogo;
    }
}