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
    public partial class CadastroCategoria : Form
    {
        int tipoPesquisa;
        public CadastroCategoria()
        {
            InitializeComponent();
            txtCodigo.Enabled = false;
            txtDescricao.Enabled = false;
            cbxAtividade.Enabled = false;
            try
            {
                String Configuracao = "server=localhost;userid=root;pwd=nunespc;database=sistemanunespc;";
                MySqlConnection Conexao = new MySqlConnection(Configuracao);
                Conexao.Open();
                MySqlCommand Comando = new MySqlCommand("SELECT * FROM categoria", Conexao);
                MySqlDataAdapter Adp = new MySqlDataAdapter(Comando);
                DataTable dt = new DataTable();
                Adp.Fill(dt);
                dataGridViewCat.DataSource = dt;

                /*MySqlDataReader reader = Comando.ExecuteReader();

                listViewUsuario.Items.Clear();

                while (reader.Read())
                {
                    String[] row = {reader.GetString(0),
                                reader.GetString(1),
                                reader.GetString(2),
                                reader.GetString(3)                           
                                };

                    var listViewItem = new ListViewItem(row);

                    listViewUsuario.Items.Add(listViewItem);*/


                Conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        DataTable dataset;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void CadastroCategoria_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtCodigo.Enabled = true;
            txtDescricao.Enabled = true;
            cbxAtividade.Enabled = true;
           

            String Configuracao = "server=localhost;userid=root;pwd=nunespc;database=sistemanunespc;";
            MySqlConnection Conexao = new MySqlConnection(Configuracao);
            Conexao.Open();
            Carregar car = new Carregar();
            car.ShowDialog();
            MySqlCommand Comando = new MySqlCommand("Select MAX(id+ 1) From categoria", Conexao);
            /* txtCodigo.Text = Comando.ExecuteScalar().ToString();*/


            //TextBox Código Recebe o Próximo Código

            txtCodigo.Text = Comando.ExecuteScalar().ToString();


            //Caso o Resultado Seja Nulo

            //Ou seja, é o Primeiro Código

            Conexao.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String codigo = txtCodigo.Text;
            String Descricao = txtDescricao.Text;
            String atividade = cbxAtividade.SelectedItem.ToString();
            


            try
            {
                String Configuracao = "server=localhost;userid=root;pwd=nunespc;database=sistemanunespc;";
                MySqlConnection Conexao = new MySqlConnection(Configuracao);
                Conexao.Open();
                MySqlCommand Comando = new MySqlCommand("INSERT INTO categoria (descricao, atividade)" + "VALUES('" + this.txtDescricao.Text + "','" + this.cbxAtividade.SelectedItem.ToString() + "')", Conexao);
                Comando.ExecuteNonQuery();

                Carregar car = new Carregar();
                car.ShowDialog();

                    try
                    {
                    MySqlCommand Comando1 = new MySqlCommand("SELECT * FROM categoria", Conexao);
                    MySqlDataAdapter Adp = new MySqlDataAdapter(Comando1);
                    DataTable dt = new DataTable();
                    Adp.Fill(dt);
                    dataGridViewCat.DataSource = dt;
                    Conexao.Close();
                    }
                    catch (Exception ex)
                    {
                    MessageBox.Show(ex.Message);
                    }
                MessageBox.Show("Usuario Cadastrado com Sucesso!", "Sucesso");
                txtCodigo.Text = "";
                txtDescricao.Text = "";
                cbxAtividade.Text = "";
                              
                Conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possivel se conectar com o Banco de Dados", "Erro de Conexao");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                String Configuracao = "server=localhost;userid=root;pwd=nunespc;database=sistemanunespc;";
                MySqlConnection Conexao = new MySqlConnection(Configuracao);
                Conexao.Open();
                MySqlCommand Comando = new MySqlCommand("UPDATE categoria SET descricao = ?, atividade = ? WHERE id = ?", Conexao);

                Comando.Parameters.Clear();
                Comando.Parameters.Add("@descricao", MySqlDbType.VarChar, 60).Value = txtDescricao.Text;
                Comando.Parameters.Add("@atividade", MySqlDbType.VarChar, 60).Value = cbxAtividade.SelectedItem;
                
                Comando.CommandType = CommandType.Text;
                Comando.ExecuteNonQuery();
                Carregar car = new Carregar();
                car.ShowDialog();

                try
                {
                    MySqlCommand Comando1 = new MySqlCommand("SELECT * FROM categoria", Conexao);
                    MySqlDataAdapter Adp = new MySqlDataAdapter(Comando1);
                    DataTable dt = new DataTable();
                    Adp.Fill(dt);
                    dataGridViewCat.DataSource = dt;
                    Conexao.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                MessageBox.Show("Usuario Atualizado com Sucesso!");
                Conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Falha ao Atualizar o Usuario" + erro);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                String Configuracao = "server=localhost;userid=root;pwd=nunespc;database=sistemanunespc;";
                MySqlConnection Conexao = new MySqlConnection(Configuracao);
                Conexao.Open();
                MySqlCommand Comando = new MySqlCommand("DELETE FROM categoria WHERE id ='" + this.txtCodigo.Text + "';", Conexao);
                Comando.Parameters.Clear();
                Comando.CommandType = CommandType.Text;
                Comando.ExecuteNonQuery();
                var dialogResult = MessageBox.Show("Deseja excluir o registro selecionado?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                Carregar car = new Carregar();
                car.ShowDialog();

                try
                {
                    MySqlCommand Comando1 = new MySqlCommand("SELECT * FROM categoria", Conexao);
                    MySqlDataAdapter Adp = new MySqlDataAdapter(Comando1);
                    DataTable dt = new DataTable();
                    Adp.Fill(dt);
                    dataGridViewCat.DataSource = dt;
                    Conexao.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                MessageBox.Show("Usuario Deletado Com Sucesso!");

                Conexao.Clone();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Falha ao Deletar o Usuario" + erro);
            }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (tipoPesquisa == 1)
            {
                String Configuracao = "server=localhost;userid=root;pwd=nunespc;database=sistemanunespc;";
                MySqlConnection Conexao = new MySqlConnection(Configuracao);
                Conexao.Open();
                MySqlCommand Comando = new MySqlCommand("SELECT * FROM categoria;", Conexao);
                MySqlDataAdapter dta = new MySqlDataAdapter();
                dta.SelectCommand = Comando;
                dataset = new DataTable();
                dta.Fill(dataset);
                BindingSource bs = new BindingSource();

                bs.DataSource = dataset;
                dataGridViewCat.DataSource = bs;
                dta.Update(dataset);
                DataView dv = new DataView(dataset);
                dv.RowFilter = String.Format("descricao LIKE '%{0}%'", txtPesquisa.Text);
                dataGridViewCat.DataSource = dv;

            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            tipoPesquisa = 1;
        }

        private void dataGridViewCat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Enabled = true;
            txtDescricao.Enabled = true;
            cbxAtividade.Enabled = true;
           
            /*txtCod.Text = dataGridViewUse.Rows[e.RowIndex].Cells["codigo"].Value.ToString();
            txtNome.Text = dataGridViewUse.Rows[e.RowIndex].Cells["nome"].Value.ToString();
            txtCpf.Text = dataGridViewUse.Rows[e.RowIndex].Cells["cpf"].Value.ToString();
            cbxGrupo.SelectedItem = dataGridViewUse.Rows[e.RowIndex].Cells["grupo"].Value.ToString();
            txtUsuario.Text = dataGridViewUse.Rows[e.RowIndex].Cells["usuario"].Value.ToString();
            txtSenha.Text = dataGridViewUse.Rows[e.RowIndex].Cells["senha"].Value.ToString();*/

            txtCodigo.Text = dataGridViewCat["id", e.RowIndex].Value.ToString();
            txtDescricao.Text = dataGridViewCat["descricao", e.RowIndex].Value.ToString();
            cbxAtividade.SelectedItem = dataGridViewCat["atividade", e.RowIndex].Value.ToString();
            
        }

        private void cbxAtividade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
