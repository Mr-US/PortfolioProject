using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Views.LoginForm;


namespace Views
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 45;
            if (panel2.Width >= 900)
            {
                
                Login login = new Login();

                //var thread = new Thread(() =>
                //{
                   
                //    Thread.Sleep(20000);
                //});

                //thread.Start();
                timer1.Stop();
                login.Show();
                this.Hide();
            }
        }
    }
}
