namespace ControlPAP
{
    partial class formSplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formSplashScreen));
            this.picBxLogo = new System.Windows.Forms.PictureBox();
            this.picBxPapeleria = new System.Windows.Forms.PictureBox();
            this.timerSplash = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picBxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxPapeleria)).BeginInit();
            this.SuspendLayout();
            // 
            // picBxLogo
            // 
            this.picBxLogo.BackColor = System.Drawing.Color.Transparent;
            this.picBxLogo.BackgroundImage = global::ControlPAP.Properties.Resources.Logo;
            this.picBxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBxLogo.Location = new System.Drawing.Point(215, 75);
            this.picBxLogo.Name = "picBxLogo";
            this.picBxLogo.Size = new System.Drawing.Size(136, 99);
            this.picBxLogo.TabIndex = 3;
            this.picBxLogo.TabStop = false;
            // 
            // picBxPapeleria
            // 
            this.picBxPapeleria.BackColor = System.Drawing.Color.Transparent;
            this.picBxPapeleria.BackgroundImage = global::ControlPAP.Properties.Resources.Papeleria;
            this.picBxPapeleria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBxPapeleria.Location = new System.Drawing.Point(158, 190);
            this.picBxPapeleria.Name = "picBxPapeleria";
            this.picBxPapeleria.Size = new System.Drawing.Size(506, 227);
            this.picBxPapeleria.TabIndex = 2;
            this.picBxPapeleria.TabStop = false;
            // 
            // timerSplash
            // 
            this.timerSplash.Tick += new System.EventHandler(this.timerSplash_Tick);
            // 
            // formSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::ControlPAP.Properties.Resources.SplashScreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(840, 540);
            this.Controls.Add(this.picBxLogo);
            this.Controls.Add(this.picBxPapeleria);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formSplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash Screen";
            this.Load += new System.EventHandler(this.formSplashScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxPapeleria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBxLogo;
        private System.Windows.Forms.PictureBox picBxPapeleria;
        private System.Windows.Forms.Timer timerSplash;
    }
}

