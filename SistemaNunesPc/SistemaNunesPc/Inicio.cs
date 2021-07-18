using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaNunesPc
{
    public partial class frInicio : Form
    {
        public frInicio()
        {
            InitializeComponent();
            toolStripStatusLabel2.Text = "Usuario: " + Login.userConectado.ToString();


        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Carregar c = new Carregar();
            c.ShowDialog();
            CadastroFornecedor forn = new CadastroFornecedor();
            forn.Show();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Carregar c = new Carregar();
            c.ShowDialog();
            CadastroUsuario cdu = new CadastroUsuario();
            cdu.Show();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Carregar c = new Carregar();
            c.ShowDialog();
            CadastroProduto cdp = new CadastroProduto();
            cdp.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Carregar c = new Carregar();
            c.ShowDialog();
            Application.Exit();

        }

        private void logoffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Carregar c = new Carregar();
            c.ShowDialog();
            Login user = new Login();
            Close();
            user.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Carregar c = new Carregar();
            c.ShowDialog();
            CadastroCategoria cat = new CadastroCategoria();
            cat.Show();
        }

        private void unidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Carregar c = new Carregar();
            c.ShowDialog();
            Unidade uni = new Unidade();
            uni.Show();
        }

        private void categoriaDaVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Carregar c = new Carregar();
            c.ShowDialog();
            CategoriaVenda cv = new CategoriaVenda();
            cv.Show();
        }

        private void pDVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Carregar c = new Carregar();
            c.ShowDialog();
            PDV pdv = new PDV();
            pdv.ShowDialog();
        }

        private void itenDeConsumoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Carregar c = new Carregar();
            c.ShowDialog();
            ItemConsumo ic = new ItemConsumo();
            ic.Show();
        }

        private void cSTPISCONFISToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Carregar c = new Carregar();
            c.ShowDialog();
            CST_do_PISCOFINS cst= new CST_do_PISCOFINS();
            cst.Show();
        }

        private void empresasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Carregar c = new Carregar();
            c.ShowDialog();
            CadastroEmpresa emp = new CadastroEmpresa();
            emp.Show();
        }

        private void cFOPToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void naturezaDaOperaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Carregar c = new Carregar();
            c.ShowDialog();
            NaturezaOperacao cnp = new NaturezaOperacao();
            cnp.Show();
        }

        private void localDeImpressãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Carregar c = new Carregar();
            c.ShowDialog();
            Local_de_Impressao impressao = new Local_de_Impressao();
            impressao.Show();
        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            
        }

        private void toolStripStatusLabel1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            toolStripStatusLabel1.Text = DateTime.Now.ToString(); 
        }

        private void toolStripStatusLabel1_Click_2(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {
           
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cFOPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Carregar c = new Carregar();
            c.ShowDialog();
            NaturezaOperacao no = new NaturezaOperacao();
            no.ShowDialog();
        }
    }
}
