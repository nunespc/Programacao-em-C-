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
    public partial class Aliquota : Form
    {
        public Aliquota()
        {
            InitializeComponent();
            txtCodigo.Enabled = false;
            txtAliquota.Enabled = false;
            txtDescricao.Enabled = false;       

            try
            {
                String Configuracao = "server=localhost;userid=root;pwd=nunespc;database=sistemanunespc;";
                MySqlConnection Conexao = new MySqlConnection(Configuracao);
                Conexao.Open();
                MySqlCommand Comando = new MySqlCommand("SELECT * FROM aliquota", Conexao);
                MySqlDataAdapter Adp = new MySqlDataAdapter(Comando);
                DataTable dt = new DataTable();
                Adp.Fill(dt);
                dataGridViewAli.DataSource = dt;

                Conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        DataTable dataset;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            String nome = txtAliquota.Text;
            String cpf = txtDescricao.Text;
            


            try
            {
                String Configuracao = "server=localhost;userid=root;pwd=nunespc;database=sistemanunespc;";
                MySqlConnection Conexao = new MySqlConnection(Configuracao);
                Conexao.Open();
                MySqlCommand Comando = new MySqlCommand("INSERT INTO aliquota (codaliquota, descricao)" + "VALUES('" + this.txtAliquota.Text + "','" + this.txtDescricao.Text + "')", Conexao);
                Comando.ExecuteNonQuery();
                MessageBox.Show("Cadastrado com Sucesso!", "Sucesso");
                txtCodigo.Text = "";
                txtAliquota.Text = "";
                txtDescricao.Text = "";

                Carregar car = new Carregar();
                car.ShowDialog();

                    try
                    {
                        MySqlCommand Comando1 = new MySqlCommand("SELECT * FROM aliquota", Conexao);
                        MySqlDataAdapter Adp = new MySqlDataAdapter(Comando1);
                        DataTable dt = new DataTable();
                        Adp.Fill(dt);
                        dataGridViewAli.DataSource = dt;
                        Conexao.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                Conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possivel se conectar com o Banco de Dados", "Erro de Conexao");
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            try
            {
                String Configuracao = "server=localhost;userid=root;pwd=nunespc;database=sistemanunespc;";
                MySqlConnection Conexao = new MySqlConnection(Configuracao);
                Conexao.Open();
                MySqlCommand Comando = new MySqlCommand("UPDATE aliquota SET codaliquota = ?, descricao = ? WHERE id = ?", Conexao);

                Comando.Parameters.Clear();
                Comando.Parameters.Add("@codaliquota", MySqlDbType.VarChar, 60).Value = txtAliquota.Text;
                Comando.Parameters.Add("@descricao", MySqlDbType.VarChar, 60).Value = txtDescricao.Text;
                Comando.Parameters.Add("aliquota", MySqlDbType.Int32).Value = txtCodigo.Text;


                Comando.CommandType = CommandType.Text;
                Comando.ExecuteNonQuery();
                MessageBox.Show("Atualizado com Sucesso!");

                Carregar car = new Carregar();
                car.ShowDialog();

                        try
                        {
                            MySqlCommand Comando1 = new MySqlCommand("SELECT * FROM aliquota", Conexao);
                            MySqlDataAdapter Adp = new MySqlDataAdapter(Comando1);
                            DataTable dt = new DataTable();
                            Adp.Fill(dt);
                            dataGridViewAli.DataSource = dt;
                            Conexao.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
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
                MySqlCommand Comando = new MySqlCommand("DELETE FROM aliquota WHERE id ='" + this.txtCodigo.Text + "';", Conexao);
                Comando.Parameters.Clear();
                Comando.CommandType = CommandType.Text;
                Comando.ExecuteNonQuery();
                MessageBox.Show("Deletado Com Sucesso!");
                Carregar car = new Carregar();
                car.ShowDialog();

                        try
                        {
                            MySqlCommand Comando1 = new MySqlCommand("SELECT * FROM aliquota", Conexao);
                            MySqlDataAdapter Adp = new MySqlDataAdapter(Comando1);
                            DataTable dt = new DataTable();
                            Adp.Fill(dt);
                            dataGridViewAli.DataSource = dt;
                            Conexao.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                Conexao.Clone();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Falha ao Deletar" + erro);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtCodigo.Enabled = true;
            txtAliquota.Enabled = true;
            txtDescricao.Enabled = true;
            



            String Configuracao = "server=localhost;userid=root;pwd=nunespc;database=sistemanunespc;";
            MySqlConnection Conexao = new MySqlConnection(Configuracao);
            Conexao.Open();

                Carregar car = new Carregar();
                car.ShowDialog();

            MySqlCommand Comando = new MySqlCommand("Select MAX(id+ 1) From aliquota", Conexao);
            /* txtCodigo.Text = Comando.ExecuteScalar().ToString();*/


            //TextBox Código Recebe o Próximo Código

            txtCodigo.Text = Comando.ExecuteScalar().ToString();


            //Caso o Resultado Seja Nulo

            //Ou seja, é o Primeiro Código

            Conexao.Close();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Enabled = true;
            txtAliquota.Enabled = true;
            txtDescricao.Enabled = true;
            

            /*txtCod.Text = dataGridViewUse.Rows[e.RowIndex].Cells["codigo"].Value.ToString();
            txtNome.Text = dataGridViewUse.Rows[e.RowIndex].Cells["nome"].Value.ToString();
            txtCpf.Text = dataGridViewUse.Rows[e.RowIndex].Cells["cpf"].Value.ToString();
            cbxGrupo.SelectedItem = dataGridViewUse.Rows[e.RowIndex].Cells["grupo"].Value.ToString();
            txtUsuario.Text = dataGridViewUse.Rows[e.RowIndex].Cells["usuario"].Value.ToString();
            txtSenha.Text = dataGridViewUse.Rows[e.RowIndex].Cells["senha"].Value.ToString();*/

            txtCodigo.Text = dataGridViewAli["id", e.RowIndex].Value.ToString();
            txtAliquota.Text = dataGridViewAli["codaliquota", e.RowIndex].Value.ToString();
            txtDescricao.Text = dataGridViewAli["descricao", e.RowIndex].Value.ToString();
            
        }

        private void Aliquota_Load(object sender, EventArgs e)
        {

        }
    }
}
