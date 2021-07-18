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
    public partial class PDV : Form
    {
        
        
        public PDV()
        {
            InitializeComponent();
        }
        private void fazOqVcQuer()
        {
            
            try
            {
                if (txtValorUnitario.Text == "" && txtQuantidade.Text == "")
                {

                    lblValortotal.Text = "";

                }
                else if (txtValorUnitario.Text == "")
                {
                    
                  Convert.ToDecimal(txtQuantidade.Text).ToString();

                }
                else if (txtQuantidade.Text == "" )
                {
                    lblValortotal.Text =
                   Convert.ToDecimal(txtValorUnitario.Text).ToString("C");


                }else{
                    lblValortotal.Text =
                       (Convert.ToDecimal(txtQuantidade.Text)
                       *
                       Convert.ToDecimal(txtValorUnitario.Text)).ToString("C");
                }
            }
            catch (Exception)
            {
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {
                    }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            


        }

        private void lblValortotal_Click(object sender, EventArgs e)
        {

        }

        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {
            fazOqVcQuer();
            
        }

        private void txtValorUnitario_TextChanged(object sender, EventArgs e)
        {
            fazOqVcQuer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mesa mesa = new Mesa();
            mesa.ShowDialog();
            PDV pdv = new PDV();
            pdv.Close();
        }
    }
}
