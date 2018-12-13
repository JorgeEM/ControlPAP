using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            int time = 5;
            timerSplash.Interval = time * 1000;
            timerSplash.Start();

            timerSplash.Tick += timerSplash_Tick;
        }

        private void timerSplash_Tick(object sender, EventArgs e)
        {
            timerSplash.Stop();
            Hide();

            formLogIn logIn = new formLogIn();
            logIn.ShowDialog(this);

            Application.Exit();
        }
    }
}
