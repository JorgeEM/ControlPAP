using System;

namespace ControlPAP
{
    partial class formLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formLogIn));
            this.txtBxContraseña = new System.Windows.Forms.TextBox();
            this.txtBxUsuario = new System.Windows.Forms.TextBox();
            this.picBxContraseña = new System.Windows.Forms.PictureBox();
            this.picBxUsuario = new System.Windows.Forms.PictureBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.picBxLogo = new System.Windows.Forms.PictureBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBxContraseña)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBxContraseña
            // 
            this.txtBxContraseña.Font = new System.Drawing.Font("Lucida Fax", 16.2F, System.Drawing.FontStyle.Bold);
            this.txtBxContraseña.Location = new System.Drawing.Point(306, 279);
            this.txtBxContraseña.Name = "txtBxContraseña";
            this.txtBxContraseña.PasswordChar = '*';
            this.txtBxContraseña.Size = new System.Drawing.Size(250, 39);
            this.txtBxContraseña.TabIndex = 7;
            // 
            // txtBxUsuario
            // 
            this.txtBxUsuario.Font = new System.Drawing.Font("Lucida Fax", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxUsuario.Location = new System.Drawing.Point(306, 208);
            this.txtBxUsuario.Name = "txtBxUsuario";
            this.txtBxUsuario.Size = new System.Drawing.Size(250, 39);
            this.txtBxUsuario.TabIndex = 5;
            // 
            // picBxContraseña
            // 
            this.picBxContraseña.BackColor = System.Drawing.Color.Transparent;
            this.picBxContraseña.BackgroundImage = global::ControlPAP.Properties.Resources.Pass;
            this.picBxContraseña.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBxContraseña.Cursor = System.Windows.Forms.Cursors.Default;
            this.picBxContraseña.Location = new System.Drawing.Point(242, 279);
            this.picBxContraseña.Name = "picBxContraseña";
            this.picBxContraseña.Size = new System.Drawing.Size(45, 39);
            this.picBxContraseña.TabIndex = 10;
            this.picBxContraseña.TabStop = false;
            // 
            // picBxUsuario
            // 
            this.picBxUsuario.BackColor = System.Drawing.Color.Transparent;
            this.picBxUsuario.BackgroundImage = global::ControlPAP.Properties.Resources.User;
            this.picBxUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBxUsuario.Cursor = System.Windows.Forms.Cursors.Default;
            this.picBxUsuario.Location = new System.Drawing.Point(242, 208);
            this.picBxUsuario.Name = "picBxUsuario";
            this.picBxUsuario.Size = new System.Drawing.Size(45, 39);
            this.picBxUsuario.TabIndex = 9;
            this.picBxUsuario.TabStop = false;
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.Transparent;
            this.btnEntrar.BackgroundImage = global::ControlPAP.Properties.Resources.ButtonInicio;
            this.btnEntrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEntrar.FlatAppearance.BorderSize = 0;
            this.btnEntrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEntrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.Location = new System.Drawing.Point(317, 359);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(222, 62);
            this.btnEntrar.TabIndex = 8;
            this.btnEntrar.Text = "ENTRAR";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // picBxLogo
            // 
            this.picBxLogo.BackColor = System.Drawing.Color.Transparent;
            this.picBxLogo.BackgroundImage = global::ControlPAP.Properties.Resources.Banner;
            this.picBxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picBxLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.picBxLogo.Location = new System.Drawing.Point(0, 0);
            this.picBxLogo.Name = "picBxLogo";
            this.picBxLogo.Size = new System.Drawing.Size(822, 110);
            this.picBxLogo.TabIndex = 6;
            this.picBxLogo.TabStop = false;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistrar.BackgroundImage = global::ControlPAP.Properties.Resources.ButtonInicio;
            this.btnRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(12, 419);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(222, 62);
            this.btnRegistrar.TabIndex = 11;
            this.btnRegistrar.Text = "REGISTRAR";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // formLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ControlPAP.Properties.Resources.FondoLogIn;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(822, 493);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.picBxContraseña);
            this.Controls.Add(this.picBxUsuario);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.txtBxContraseña);
            this.Controls.Add(this.txtBxUsuario);
            this.Controls.Add(this.picBxLogo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formLogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Log-In";
            this.Load += new System.EventHandler(this.formLogIn_Load);
            this.VisibleChanged += new System.EventHandler(this.formLogIn_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.picBxContraseña)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBxContraseña;
        private System.Windows.Forms.PictureBox picBxUsuario;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.TextBox txtBxContraseña;
        private System.Windows.Forms.TextBox txtBxUsuario;
        private System.Windows.Forms.PictureBox picBxLogo;
        private System.Windows.Forms.Button btnRegistrar;
    }
}