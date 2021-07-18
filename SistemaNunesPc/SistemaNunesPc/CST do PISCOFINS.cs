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
    public partial class CST_do_PISCOFINS : Form
    {
        String cst;
        int tipoPesquisa;

        public CST_do_PISCOFINS()
        {
            InitializeComponent();
            txtCodigo.Enabled = false;
            txtDescricao.Enabled = false;
            cbxCst.Enabled = false;
            ckbBasecalculo.Enabled = false;
            txtReducaobase.Enabled = false;

            dataGridViewCst.Columns["basecalculo"].Visible = false;
            dataGridViewCst.Columns["reducaobase"].Visible = false;
            try
            {
                String Configuracao = "server=localhost;userid=root;pwd=nunespc;database=sistemanunespc;";
                MySqlConnection Conexao = new MySqlConnection(Configuracao);
                Conexao.Open();
                MySqlCommand Comando = new MySqlCommand("SELECT * FROM cst_pis_cofins", Conexao);
                MySqlDataAdapter Adp = new MySqlDataAdapter(Comando);
                DataTable dt = new DataTable();
                Adp.Fill(dt);
                dataGridViewCst.DataSource = dt;


                Conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        DataTable dataset;



        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {

            txtCodigo.Enabled = true;
            txtDescricao.Enabled = true;
            txtReducaobase.Enabled = true;
            cbxCst.Enabled = true;
            ckbBasecalculo.Enabled = true;

            Carregar car = new Carregar();
            car.ShowDialog();

            txtCodigo.Text = "";
            txtDescricao.Text = "";
            ckbBasecalculo.Checked = false;
            txtReducaobase.Text = "";
            cbxCst.SelectedItem = "";





            String Configuracao = "server=localhost;userid=root;pwd=nunespc;database=sistemanunespc;";
            MySqlConnection Conexao = new MySqlConnection(Configuracao);
            Conexao.Open();

            

            MySqlCommand Comando = new MySqlCommand("Select MAX(id+ 1) From cst_pis_cofins", Conexao);
            /* txtCodigo.Text = Comando.ExecuteScalar().ToString();*/


            //TextBox Código Recebe o Próximo Código

            txtCodigo.Text = Comando.ExecuteScalar().ToString();


            //Caso o Resultado Seja Nulo

            //Ou seja, é o Primeiro Código

            Conexao.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            String codigo = txtCodigo.Text;
            String Descricao = txtDescricao.Text;
            String basecalculo = ckbBasecalculo.Checked.ToString();
            String reducaobase = txtReducaobase.Text;



            if (cst == "Saida")
            {
                cbxCst.Text = "Saida";
            }
            if (cst == "Entrada")
            {
                cbxCst.Text = "Entrada";
            }

            try
            {
                String Configuracao = "server=localhost;userid=root;pwd=nunespc;database=sistemanunespc;";
                MySqlConnection Conexao = new MySqlConnection(Configuracao);
                Conexao.Open();
                MySqlCommand Comando = new MySqlCommand("INSERT INTO cst_pis_cofins (descricao,basecalculo,reducaobase,usocst)" + "VALUES('" + this.txtDescricao.Text + "','" + this.ckbBasecalculo.Checked.ToString() + "','" + this.txtReducaobase.Text + "','" + this.cbxCst.SelectedItem.ToString() + "')", Conexao);
                Comando.ExecuteNonQuery();
                Carregar car = new Carregar();
                car.ShowDialog();

                try
                {
                    MySqlCommand Comando1 = new MySqlCommand("SELECT * FROM cst_pis_cofins", Conexao);
                    MySqlDataAdapter Adp = new MySqlDataAdapter(Comando1);
                    DataTable dt = new DataTable();
                    Adp.Fill(dt);
                    dataGridViewCst.DataSource = dt;
                    Conexao.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                MessageBox.Show("Cadastrado com Sucesso!", "Sucesso");
                txtCodigo.Text = "";
                txtDescricao.Text = "";
                ckbBasecalculo.Checked = false;
                txtReducaobase.Text = "";
                cbxCst.SelectedItem = "";


                Conexao.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + Convert.ToString(ex), "Aviso");
            }
        }

        private void cbxCst_SelectedIndexChanged(object sender, EventArgs e)
        {
            cst = "Entrada";
            cst = "Saida";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Enabled = true;
            txtDescricao.Enabled = true;
            ckbBasecalculo.Enabled = true;
            txtReducaobase.Enabled = true;
            cbxCst.Enabled = true;


            /*txtCod.Text = dataGridViewUse.Rows[e.RowIndex].Cells["codigo"].Value.ToString();
            txtNome.Text = dataGridViewUse.Rows[e.RowIndex].Cells["nome"].Value.ToString();
            txtCpf.Text = dataGridViewUse.Rows[e.RowIndex].Cells["cpf"].Value.ToString();
            cbxGrupo.SelectedItem = dataGridViewUse.Rows[e.RowIndex].Cells["grupo"].Value.ToString();
            txtUsuario.Text = dataGridViewUse.Rows[e.RowIndex].Cells["usuario"].Value.ToString();
            txtSenha.Text = dataGridViewUse.Rows[e.RowIndex].Cells["senha"].Value.ToString();*/

            txtCodigo.Text = dataGridViewCst["id", e.RowIndex].Value.ToString();
            txtDescricao.Text = dataGridViewCst["descricao", e.RowIndex].Value.ToString();
            txtReducaobase.Text = dataGridViewCst["reducaobase", e.RowIndex].Value.ToString();
            ckbBasecalculo.Checked = dataGridViewCst["basecalculo", e.RowIndex].Value.Equals("True");
            cbxCst.SelectedItem = dataGridViewCst["usocst", e.RowIndex].Value.ToString();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                String Configuracao = "server=localhost;userid=root;pwd=nunespc;database=sistemanunespc;";
                MySqlConnection Conexao = new MySqlConnection(Configuracao);
                Conexao.Open();
                MySqlCommand Comando = new MySqlCommand("UPDATE cst_pis_cofins SET descricao = ?, usocst = ?, basecalculo = ?, reducaobase = ? WHERE id = ?", Conexao);

                Comando.Parameters.Clear();
                Comando.Parameters.Add("@descricao", MySqlDbType.VarChar, 200).Value = txtDescricao.Text;
                Comando.Parameters.Add("@usocst", MySqlDbType.VarChar, 100).Value = cbxCst.SelectedItem;
                Comando.Parameters.Add("@basecalculo", MySqlDbType.VarChar, 100).Value = ckbBasecalculo.Checked;
                Comando.Parameters.Add("@reducaobase", MySqlDbType.VarChar, 100).Value = txtReducaobase.Text;
                Comando.Parameters.Add("cst_pis_cofins", MySqlDbType.Int32).Value = txtCodigo.Text;


                Comando.CommandType = CommandType.Text;
                Comando.ExecuteNonQuery();
                Carregar car = new Carregar();
                car.ShowDialog();

                try
                {
                    MySqlCommand Comando1 = new MySqlCommand("SELECT * FROM cst_pis_cofins", Conexao);
                    MySqlDataAdapter Adp = new MySqlDataAdapter(Comando1);
                    DataTable dt = new DataTable();
                    Adp.Fill(dt);
                    dataGridViewCst.DataSource = dt;
                    Conexao.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                MessageBox.Show("Atualizado com Sucesso!");
                Conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Falha ao Atualizar " + erro);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                String Configuracao = "server=localhost;userid=root;pwd=nunespc;database=sistemanunespc;";
                MySqlConnection Conexao = new MySqlConnection(Configuracao);
                Conexao.Open();
                MySqlCommand Comando = new MySqlCommand("DELETE FROM cst_pis_cofins WHERE id ='" + this.txtCodigo.Text + "';", Conexao);
                Comando.Parameters.Clear();
                Comando.CommandType = CommandType.Text;
                Comando.ExecuteNonQuery();
                var dialogResult = MessageBox.Show("Deseja excluir o registro selecionado?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                Carregar car = new Carregar();
                car.ShowDialog();

                try
                {
                    MySqlCommand Comando1 = new MySqlCommand("SELECT * FROM cst_pis_cofins", Conexao);
                    MySqlDataAdapter Adp = new MySqlDataAdapter(Comando1);
                    DataTable dt = new DataTable();
                    Adp.Fill(dt);
                    dataGridViewCst.DataSource = dt;
                    Conexao.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                MessageBox.Show("Deletado Com Sucesso!");

                Conexao.Clone();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Falha ao Deletar" + erro);
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            tipoPesquisa = 1;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            tipoPesquisa = 2;
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (tipoPesquisa == 1)
            {
                String Configuracao2 = "server=localhost;userid=root;pwd=nunespc;database=sistemanunespc;";
                MySqlConnection Conexao2 = new MySqlConnection(Configuracao2);
                Conexao2.Open();
                MySqlCommand Comando2 = new MySqlCommand("SELECT * FROM cst_pis_cofins;", Conexao2);
                MySqlDataAdapter dta2 = new MySqlDataAdapter();
                dta2.SelectCommand = Comando2;
                dataset = new DataTable();
                dta2.Fill(dataset);
                BindingSource bs2 = new BindingSource();

                bs2.DataSource = dataset;
                dataGridViewCst.DataSource = bs2;
                dta2.Update(dataset);
                DataView dv2 = new DataView(dataset);
                dv2.RowFilter = String.Format("descricao LIKE '%{0}%'", txtPesquisa.Text);
                dataGridViewCst.DataSource = dv2;

            }
            if (tipoPesquisa == 2)
            {
                String Configuracao3 = "server=localhost;userid=root;pwd=nunespc;database=sistemanunespc;";
                MySqlConnection Conexao3 = new MySqlConnection(Configuracao3);
                Conexao3.Open();
                MySqlCommand Comando3 = new MySqlCommand("SELECT * FROM cst_pis_cofins;", Conexao3);
                MySqlDataAdapter dta3 = new MySqlDataAdapter();
                dta3.SelectCommand = Comando3;
                dataset = new DataTable();
                dta3.Fill(dataset);
                BindingSource bs3 = new BindingSource();

                bs3.DataSource = dataset;
                dataGridViewCst.DataSource = bs3;
                dta3.Update(dataset);
                DataView dv3 = new DataView(dataset);
                dv3.RowFilter = String.Format("usocst LIKE '%{0}%'", txtPesquisa.Text);
                dataGridViewCst.DataSource = dv3;

            }
        }

        private void CST_do_PISCOFINS_Load(object sender, EventArgs e)
        {

        }

        private void txtReducaobase_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }
    }
}
