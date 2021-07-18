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
    public partial class Local_de_Impressao : Form
    {
        int tipoPesquisa;

        public Local_de_Impressao()
        {
            InitializeComponent();
            txtCodigo.Enabled = false;
            txtDescricao.Enabled = false;

            try
            {
                String Configuracao = "server=localhost;userid=root;pwd=nunespc;database=sistemanunespc;";
                MySqlConnection Conexao = new MySqlConnection(Configuracao);
                Conexao.Open();
                MySqlCommand Comando = new MySqlCommand("SELECT * FROM local_impressao", Conexao);
                MySqlDataAdapter Adp = new MySqlDataAdapter(Comando);
                DataTable dt = new DataTable();
                Adp.Fill(dt);
                dataGridViewImpressao.DataSource = dt;

              Conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        DataTable dataset;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            String descricao = txtDescricao.Text;
            


            try
            {
                String Configuracao = "server=localhost;userid=root;pwd=nunespc;database=sistemanunespc;";
                MySqlConnection Conexao = new MySqlConnection(Configuracao);
                Conexao.Open();
                MySqlCommand Comando = new MySqlCommand("INSERT INTO local_impressao (descricao)" + "VALUES('" + this.txtDescricao.Text + "')", Conexao);
                Comando.ExecuteNonQuery();

                Carregar car = new Carregar();
                car.ShowDialog();

                try
                {
                    MySqlCommand Comando1 = new MySqlCommand("SELECT * FROM local_impressao", Conexao);
                    MySqlDataAdapter Adp = new MySqlDataAdapter(Comando1);
                    DataTable dt = new DataTable();
                    Adp.Fill(dt);
                    dataGridViewImpressao.DataSource = dt;
                    Conexao.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                MessageBox.Show("Cadastrado com Sucesso!", "Sucesso");
                txtCodigo.Text = "";
                txtDescricao.Text = "";
                
                Conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possivel se conectar com o Banco de Dados", "Erro de Conexao");
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtCodigo.Enabled = true;
            txtDescricao.Enabled = true;

            txtCodigo.Text = "";
            txtDescricao.Text = "";
            



            String Configuracao = "server=localhost;userid=root;pwd=nunespc;database=sistemanunespc;";
            MySqlConnection Conexao = new MySqlConnection(Configuracao);
            Conexao.Open();

            Carregar car = new Carregar();
            car.ShowDialog();


            MySqlCommand Comando = new MySqlCommand("Select MAX(id+ 1) From local_impressao", Conexao);
            /* txtCodigo.Text = Comando.ExecuteScalar().ToString();*/


            //TextBox Código Recebe o Próximo Código

            txtCodigo.Text = Comando.ExecuteScalar().ToString();


            //Caso o Resultado Seja Nulo

            //Ou seja, é o Primeiro Código

            Conexao.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                String Configuracao = "server=localhost;userid=root;pwd=nunespc;database=sistemanunespc;";
                MySqlConnection Conexao = new MySqlConnection(Configuracao);
                Conexao.Open();
                MySqlCommand Comando = new MySqlCommand("UPDATE local_impressao SET descricao = ? WHERE id = ?", Conexao);

                Comando.Parameters.Clear();
                Comando.Parameters.Add("@descricao", MySqlDbType.VarChar, 60).Value = txtDescricao.Text;
                Comando.Parameters.Add("local_impressao", MySqlDbType.Int32).Value = txtCodigo.Text;


                Comando.CommandType = CommandType.Text;
                Comando.ExecuteNonQuery();
                Carregar c = new Carregar();
                c.ShowDialog();

                try
                {
                    MySqlCommand Comando1 = new MySqlCommand("SELECT * FROM local_impressao", Conexao);
                    MySqlDataAdapter Adp = new MySqlDataAdapter(Comando1);
                    DataTable dt = new DataTable();
                    Adp.Fill(dt);
                    dataGridViewImpressao.DataSource = dt;
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
                MessageBox.Show("Falha ao Atualizar" + erro);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                String Configuracao = "server=localhost;userid=root;pwd=nunespc;database=sistemanunespc;";
                MySqlConnection Conexao = new MySqlConnection(Configuracao);
                Conexao.Open();
                MySqlCommand Comando = new MySqlCommand("DELETE FROM local_impressao WHERE id ='" + this.txtCodigo.Text + "';", Conexao);
                Comando.Parameters.Clear();
                Comando.CommandType = CommandType.Text;
                Comando.ExecuteNonQuery();
                var dialogResult = MessageBox.Show("Deseja excluir o registro selecionado?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                Carregar car = new Carregar();
                car.ShowDialog();
                try
                {
                    MySqlCommand Comando1 = new MySqlCommand("SELECT * FROM local_impressao", Conexao);
                    MySqlDataAdapter Adp = new MySqlDataAdapter(Comando1);
                    DataTable dt = new DataTable();
                    Adp.Fill(dt);
                    dataGridViewImpressao.DataSource = dt;
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

        private void dataGridViewImpressao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Enabled = true;
            txtDescricao.Enabled = true;
            
          
            txtCodigo.Text = dataGridViewImpressao["id", e.RowIndex].Value.ToString();
            txtDescricao.Text = dataGridViewImpressao["descricao", e.RowIndex].Value.ToString();
            
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (tipoPesquisa == 1)
            {
                String Configuracao = "server=localhost;userid=root;pwd=nunespc;database=sistemanunespc;";
                MySqlConnection Conexao = new MySqlConnection(Configuracao);
                Conexao.Open();
                MySqlCommand Comando = new MySqlCommand("SELECT * FROM local_impressao;", Conexao);
                MySqlDataAdapter dta = new MySqlDataAdapter();
                dta.SelectCommand = Comando;
                dataset = new DataTable();
                dta.Fill(dataset);
                BindingSource bs = new BindingSource();

                bs.DataSource = dataset;
                dataGridViewImpressao.DataSource = bs;
                dta.Update(dataset);
                DataView dv = new DataView(dataset);
                dv.RowFilter = String.Format("codigo LIKE '%{0}%'", txtPesquisa.Text);
                dataGridViewImpressao.DataSource = dv;
            }
            if (tipoPesquisa == 2)
            {
                String Configuracao2 = "server=localhost;userid=root;pwd=nunespc;database=sistemanunespc;";
                MySqlConnection Conexao2 = new MySqlConnection(Configuracao2);
                Conexao2.Open();
                MySqlCommand Comando2 = new MySqlCommand("SELECT * FROM local_impressao;", Conexao2);
                MySqlDataAdapter dta2 = new MySqlDataAdapter();
                dta2.SelectCommand = Comando2;
                dataset = new DataTable();
                dta2.Fill(dataset);
                BindingSource bs2 = new BindingSource();

                bs2.DataSource = dataset;
                dataGridViewImpressao.DataSource = bs2;
                dta2.Update(dataset);
                DataView dv2 = new DataView(dataset);
                dv2.RowFilter = String.Format("descricao LIKE '%{0}%'", txtPesquisa.Text);
                dataGridViewImpressao.DataSource = dv2;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            tipoPesquisa = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            tipoPesquisa = 2;
        }
    }
}
