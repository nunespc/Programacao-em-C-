using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaNunesPc
{
    public partial class Carregar : Form
    {
        public Carregar()
        {
            InitializeComponent();
        }

        private void circularProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            /*circularProgressBar1.Increment(1);*/
            label1.Text = circularProgressBar1.Value.ToString() + "%";

            if (circularProgressBar1.Value < 100)
            {
                circularProgressBar1.Value = circularProgressBar1.Value + 1;
                /*timer1.Stop();
                Application.Exit();*/
            }
            else
            {
                timer1.Enabled = false;
                this.Visible = false;
                

            }
        }


    

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
