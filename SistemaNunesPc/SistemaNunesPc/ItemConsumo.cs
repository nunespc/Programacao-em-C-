using MySql.Data.MySqlClient;
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
    public partial class ItemConsumo : Form
    {
        public ItemConsumo()
        {
            InitializeComponent();

            

                try
            {
                String Configuracao = "server=localhost;userid=root;pwd=nunespc;database=sistemanunespc;";
                MySqlConnection Conexao = new MySqlConnection(Configuracao);
                Conexao.Open();
                MySqlCommand Comando = new MySqlCommand("SELECT * FROM categoria_venda", Conexao);
                MySqlDataAdapter Adp = new MySqlDataAdapter(Comando);
                DataTable dt = new DataTable();
                Adp.Fill(dt);

                cbxCategoria.ValueMember = "id";
                cbxCategoria.DisplayMember = "descricao";

                cbxCategoria.DataSource = dt;

                Conexao.Close();
            }
            catch
            {

            }

            try
            {
                String Configuracao = "server=localhost;userid=root;pwd=nunespc;database=sistemanunespc;";
                MySqlConnection Conexao = new MySqlConnection(Configuracao);
                Conexao.Open();
                MySqlCommand Comando = new MySqlCommand("SELECT * FROM unidade", Conexao);
                MySqlDataAdapter Adp = new MySqlDataAdapter(Comando);
                DataTable dt = new DataTable();
                Adp.Fill(dt);

                cbxUnidade.ValueMember = "id";
                cbxUnidade.DisplayMember = "sigla";

                cbxUnidade.DataSource = dt;

                Conexao.Close();
            }
            catch
            {
            }
            try
            {
                String Configuracao = "server=localhost;userid=root;pwd=nunespc;database=sistemanunespc;";
                MySqlConnection Conexao = new MySqlConnection(Configuracao);
                Conexao.Open();
                MySqlCommand Comando = new MySqlCommand("SELECT * FROM aliquota", Conexao);
                MySqlDataAdapter Adp = new MySqlDataAdapter(Comando);
                DataTable dt = new DataTable();
                Adp.Fill(dt);

                cbxAliquota.ValueMember = "id";
                cbxAliquota.DisplayMember = "codaliquota";

                cbxAliquota.DataSource = dt;

                Conexao.Close();
            }
            catch
            {
            }
            try
            {
                String Configuracao = "server=localhost;userid=root;pwd=nunespc;database=sistemanunespc;";
                MySqlConnection Conexao = new MySqlConnection(Configuracao);
                Conexao.Open();
                MySqlCommand Comando = new MySqlCommand("SELECT * FROM cst_pis_cofins", Conexao);
                MySqlDataAdapter Adp = new MySqlDataAdapter(Comando);
                DataTable dt = new DataTable();
                Adp.Fill(dt);

                cbxCst.ValueMember = "id";
                cbxCst.DisplayMember = "descricao";

                cbxCst.DataSource = dt;

                Conexao.Close();
            }
            catch
            {
            }

            try
            {
                String Configuracao = "server=localhost;userid=root;pwd=nunespc;database=sistemanunespc;";
                MySqlConnection Conexao = new MySqlConnection(Configuracao);
                Conexao.Open();
                MySqlCommand Comando = new MySqlCommand("SELECT * FROM cfop", Conexao);
                MySqlDataAdapter Adp = new MySqlDataAdapter(Comando);
                DataTable dt = new DataTable();
                Adp.Fill(dt);

                cbxCfopDevolucao.ValueMember = "id";
                cbxCfopDevolucao.DisplayMember = "descricao";

                cbxCfopDevolucao.DataSource = dt;

                Conexao.Close();
            }
            catch
            {
            }

            try
            {
                String Configuracao = "server=localhost;userid=root;pwd=nunespc;database=sistemanunespc;";
                MySqlConnection Conexao = new MySqlConnection(Configuracao);
                Conexao.Open();
                MySqlCommand Comando = new MySqlCommand("SELECT * FROM cfop", Conexao);
                MySqlDataAdapter Adp = new MySqlDataAdapter(Comando);
                MySqlDataReader reader = Comando.ExecuteReader();
                DataTable dt = new DataTable();
                Adp.Fill(dt);
                DataRow row = dt.NewRow(); //representa uma linha de dados em um DataTable
                row["descricao"] = "";
                cbxCfopEmissao.DataSource = dt;
                cbxCfopEmissao.ValueMember = "id";
                cbxCfopEmissao.DisplayMember = "descricao";
                



                Conexao.Close();
            }
            catch
            {
            }

            try
            {
                String Configuracao = "server=localhost;userid=root;pwd=nunespc;database=sistemanunespc;";
                MySqlConnection Conexao = new MySqlConnection(Configuracao);
                Conexao.Open();
                MySqlCommand Comando = new MySqlCommand("SELECT * FROM cfop", Conexao);
                MySqlDataAdapter Adp = new MySqlDataAdapter(Comando);
                DataTable dt = new DataTable();
                Adp.Fill(dt);
               
                
                
                this.cbxCfopVenda.ValueMember = "id";
                this.cbxCfopVenda.DisplayMember = "descricao";
                this.cbxCfopVenda.SelectedItem = "";
                this.cbxCfopVenda.Refresh();

                this.cbxCfopVenda.DataSource = dt;


                Conexao.Close();
            }
            catch
            {
            }
            try
            {
                String Configuracao = "server=localhost;userid=root;pwd=nunespc;database=sistemanunespc;";
                MySqlConnection Conexao = new MySqlConnection(Configuracao);
                Conexao.Open();
                MySqlCommand Comando = new MySqlCommand("SELECT * FROM local_impressao", Conexao);
                MySqlDataAdapter Adp = new MySqlDataAdapter(Comando);
                DataTable dt = new DataTable();
                Adp.Fill(dt);

                cbxImpressora.ValueMember = "id";
                cbxImpressora.DisplayMember = "descricao";

                cbxImpressora.DataSource = dt;

                Conexao.Close();
            }
            catch
            {
            }
            try
            {
                String Configuracao = "server=localhost;userid=root;pwd=nunespc;database=sistemanunespc;";
                MySqlConnection Conexao = new MySqlConnection(Configuracao);
                Conexao.Open();
                MySqlCommand Comando = new MySqlCommand("SELECT * FROM empresa", Conexao);
                MySqlDataAdapter Adp = new MySqlDataAdapter(Comando);
                DataTable dt = new DataTable();
                Adp.Fill(dt);

                cbxEstoque.ValueMember = "nomefantasia";
                cbxEstoque.DisplayMember = "nomefantasia";

                cbxEstoque.DataSource = dt;

                Conexao.Close();
            }
            catch
            {
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void ItemConsumo_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            String codigo = txtCodigo.Text;
            String descricao = txtDescricao.Text;
            String categoria = cbxCategoria.SelectedItem.ToString();
            String descricaoTouch = txtDescriTouch.Text;
            String preco = txtPreco.Text;
            String unidade = cbxUnidade.SelectedItem.ToString();
            String aliquota = cbxAliquota.SelectedItem.ToString();
            String federal = txtAliFederal.Text;
            String estadual = txtAliEstadual.Text;
            String municipal = txtAliMunicipal.Text;
            String estoque = cbxEstoque.SelectedItem.ToString();
            String localimpressora = cbxImpressora.SelectedItem.ToString();
            String ncm = txtNcm.Text;
            String cest = txtCest.Text;
            String cst = cbxCst.SelectedItem.ToString();
            String tipoitem = cbxTipoItem.SelectedItem.ToString();
            String genero = cbxGenero.SelectedItem.ToString();
            String cstentrada = cbxCstEntrada.SelectedItem.ToString();
            String cstpis = cbxCstPis.SelectedItem.ToString();
            String cfopdevolucao = cbxCfopDevolucao.SelectedItem.ToString();
            String cfopvenda = cbxCfopVenda.SelectedItem.ToString();
            String cfopemissao = cbxCfopEmissao.SelectedItem.ToString();






            try
            {
                String Configuracao = "server=localhost;userid=root;pwd=nunespc;database=sistemanunespc;";
                MySqlConnection Conexao = new MySqlConnection(Configuracao);
                Conexao.Open();
                MySqlCommand Comando = new MySqlCommand("INSERT INTO item (descricao,categoria,descricaoTouch,preco,unidade,aliquota,federal,estadual,municipal,estoque,localimpressora,ncm,cest,cst,tipoitem,genero,cstentrada,cstpis,cfopdevolucao,cfopvenda,cfopemissao)" + "VALUES('" + this.txtDescricao.Text + "','" + this.cbxCategoria.SelectedItem.ToString() + "','" + this.txtDescriTouch.Text + "','" + this.txtPreco.Text + "','" + this.cbxUnidade.SelectedItem.ToString() + "','" + this.cbxAliquota.SelectedItem.ToString() + "','" + this.txtAliFederal.Text + "','" + this.txtAliEstadual.Text + "','" + this.txtAliMunicipal.Text + "','" + this.cbxEstoque.SelectedItem.ToString() + "','" + this.cbxImpressora.SelectedItem.ToString() + "','" + this.txtNcm.Text + "','" + this.txtCest.Text + "','" + this.cbxCst.SelectedItem.ToString() + "','" + this.cbxTipoItem.SelectedItem.ToString() + "','" + this.cbxGenero.SelectedItem.ToString() + "','" + this.cbxCstEntrada.SelectedItem.ToString() + "','" + this.cbxCstPis.SelectedItem.ToString() + "','" + this.cbxCfopDevolucao.SelectedItem.ToString() + "','" + this.cbxCfopVenda.SelectedItem.ToString() + "','" + this.cbxCfopEmissao.SelectedItem.ToString() + "')", Conexao);
                Comando.ExecuteNonQuery();
                MessageBox.Show("Usuario Cadastrado com Sucesso!", "Sucesso");
                txtCodigo.Text = "";
                txtDescricao.Text = "";
                cbxCategoria.Text = "";
                txtDescriTouch.Text = "";
                txtPreco.Text = "";
                cbxUnidade.Text = "";
                cbxAliquota.Text = "";
                txtAliFederal.Text = "";
                txtAliEstadual.Text = "";
                txtAliMunicipal.Text = "";
                cbxEstoque.Text = "";
                cbxImpressora.Text = "";
                txtNcm.Text = "";
                txtCest.Text = "";
                cbxCst.Text = "";
                cbxTipoItem.Text = "";
                cbxGenero.Text = "";
                cbxCstEntrada.Text = "";
                cbxCstPis.Text = "";
                cbxCfopDevolucao.Text = "";
                cbxCfopVenda.Text = "";
                cbxCfopEmissao.Text = "";

                Conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possivel se conectar com o Banco de Dados", "Erro de Conexao");
            }
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Unidade u = new Unidade();
            u.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Aliquota a = new Aliquota();
            a.Show();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {

        }

        private void cbxCst_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxUnidade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxAliquota_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxCfopDevolucao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxCfopEmissao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtPreco_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void cbxCfopVenda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(txtCFOP.ToString() == "*")
            {

            }
        }
    }
}
