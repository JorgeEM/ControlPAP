using System;
using System.Windows.Forms;

namespace ControlPAP
{
    public partial class formSplashScreen : Form
    {
        public formSplashScreen()
        {
            InitializeComponent();
        }

        private void formSplashScreen_Load(object sender, EventArgs e)
        {
            var time = 5;
            timerSplash.Interval = time * 1000;
            timerSplash.Start();

            timerSplash.Tick += timerSplash_Tick;
        }

        private void timerSplash_Tick(object sender, EventArgs e)
        {
            timerSplash.Stop();
            Hide();

            var logIn = new formLogIn();
            logIn.ShowDialog(this);

            Application.Exit();
        }
    }
}