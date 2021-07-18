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
    public partial class CategoriaVenda : Form
    {
        int tipoPesquisa;
        public CategoriaVenda()
        {
            InitializeComponent();
            txtCodigo.Enabled = false;
            txtDescricao.Enabled = false;

            try
            {
                String Configuracao = "server=localhost;userid=root;pwd=nunespc;database=sistemanunespc;";
                MySqlConnection Conexao = new MySqlConnection(Configuracao);
                Conexao.Open();
                MySqlCommand Comando = new MySqlCommand("SELECT * FROM categoria_venda", Conexao);
                MySqlDataAdapter Adp = new MySqlDataAdapter(Comando);
                DataTable dt = new DataTable();
                Adp.Fill(dt);
                dataGridViewCatVen.DataSource = dt;

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

        private void button1_Click(object sender, EventArgs e)
        {
            CategoriaTouch ct = new CategoriaTouch();
            ct.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            tipoPesquisa = 2;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            tipoPesquisa = 1;
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (tipoPesquisa == 1)
            {
                String Configuracao = "server=localhost;userid=root;pwd=nunespc;database=sistemanunespc;";
                MySqlConnection Conexao = new MySqlConnection(Configuracao);
                Conexao.Open();
                MySqlCommand Comando = new MySqlCommand("SELECT * FROM categoria_venda;", Conexao);
                MySqlDataAdapter dta = new MySqlDataAdapter();
                dta.SelectCommand = Comando;
                dataset = new DataTable();
                dta.Fill(dataset);
                BindingSource bs = new BindingSource();

                bs.DataSource = dataset;
                dataGridViewCatVen.DataSource = bs;
                dta.Update(dataset);
                DataView dv = new DataView(dataset);
                dv.RowFilter = String.Format("id LIKE '%{0}%'");
                dataGridViewCatVen.DataSource = dv.ToTable();
            }
            if (tipoPesquisa == 2)
            {
                String Configuracao2 = "server=localhost;userid=root;pwd=nunespc;database=sistemanunespc;";
                MySqlConnection Conexao2 = new MySqlConnection(Configuracao2);
                Conexao2.Open();
                MySqlCommand Comando2 = new MySqlCommand("SELECT * FROM categoria_venda;", Conexao2);
                MySqlDataAdapter dta2 = new MySqlDataAdapter();
                dta2.SelectCommand = Comando2;
                dataset = new DataTable();
                dta2.Fill(dataset);
                BindingSource bs2 = new BindingSource();

                bs2.DataSource = dataset;
                dataGridViewCatVen.DataSource = bs2;
                dta2.Update(dataset);
                DataView dv2 = new DataView(dataset);
                dv2.RowFilter = String.Format("descricao LIKE '%{0}%'", txtPesquisa.Text);
                dataGridViewCatVen.DataSource = dv2;
            }
        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CtegoriVenda_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
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
                MySqlCommand Comando = new MySqlCommand("INSERT INTO categoria_venda (descricao)" + "VALUES('" + this.txtDescricao.Text + "')", Conexao);
                Comando.ExecuteNonQuery();
                Carregar car = new Carregar();
                car.ShowDialog();
                MessageBox.Show("Cadastrado com Sucesso!", "Sucesso");
                txtCodigo.Text = "";
                txtDescricao.Text = "";
                try
                {
                    MySqlCommand Comando1 = new MySqlCommand("SELECT * FROM categoria_venda", Conexao);
                    MySqlDataAdapter Adp = new MySqlDataAdapter(Comando1);
                    DataTable dt = new DataTable();
                    Adp.Fill(dt);
                    dataGridViewCatVen.DataSource = dt;
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

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtCodigo.Enabled = true;
            txtDescricao.Enabled = true;

            Carregar car = new Carregar();
            car.ShowDialog();

            String Configuracao = "server=localhost;userid=root;pwd=nunespc;database=sistemanunespc;";
            MySqlConnection Conexao = new MySqlConnection(Configuracao);
            Conexao.Open();
            MySqlCommand Comando = new MySqlCommand("Select MAX(id+ 1) From categoria_venda", Conexao);
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
                MySqlCommand Comando = new MySqlCommand("UPDATE categoria_venda SET descricao = ? WHERE id = ?", Conexao);

                Comando.Parameters.Clear();
                Comando.Parameters.Add("@nome", MySqlDbType.VarChar, 60).Value = txtDescricao.Text;
                Comando.Parameters.Add("categoria_venda", MySqlDbType.Int32).Value = txtCodigo.Text;


                Comando.CommandType = CommandType.Text;
                Comando.ExecuteNonQuery();
                Carregar car = new Carregar();
                car.ShowDialog();
                MessageBox.Show("Atualizado com Sucesso!");
                try
                {
                    MySqlCommand Comando1 = new MySqlCommand("SELECT * FROM categoria_venda", Conexao);
                    MySqlDataAdapter Adp = new MySqlDataAdapter(Comando1);
                    DataTable dt = new DataTable();
                    Adp.Fill(dt);
                    dataGridViewCatVen.DataSource = dt;
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
                MySqlCommand Comando = new MySqlCommand("DELETE FROM categoria_venda WHERE id ='" + this.txtCodigo.Text + "';", Conexao);
                Comando.Parameters.Clear();
                Comando.CommandType = CommandType.Text;
                Comando.ExecuteNonQuery();
                var dialogResult = MessageBox.Show("Deseja excluir o registro selecionado?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                Carregar car = new Carregar();
                car.ShowDialog();
                MessageBox.Show("Deletado Com Sucesso!");
                try
                {
                    MySqlCommand Comando1 = new MySqlCommand("SELECT * FROM categoria_venda", Conexao);
                    MySqlDataAdapter Adp = new MySqlDataAdapter(Comando1);
                    DataTable dt = new DataTable();
                    Adp.Fill(dt);
                    dataGridViewCatVen.DataSource = dt;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Enabled = true;
            txtDescricao.Enabled = true;


            /*txtCod.Text = dataGridViewUse.Rows[e.RowIndex].Cells["codigo"].Value.ToString();
            txtNome.Text = dataGridViewUse.Rows[e.RowIndex].Cells["nome"].Value.ToString();
            txtCpf.Text = dataGridViewUse.Rows[e.RowIndex].Cells["cpf"].Value.ToString();
            cbxGrupo.SelectedItem = dataGridViewUse.Rows[e.RowIndex].Cells["grupo"].Value.ToString();
            txtUsuario.Text = dataGridViewUse.Rows[e.RowIndex].Cells["usuario"].Value.ToString();
            txtSenha.Text = dataGridViewUse.Rows[e.RowIndex].Cells["senha"].Value.ToString();*/

            txtCodigo.Text = dataGridViewCatVen["id", e.RowIndex].Value.ToString();
            txtDescricao.Text = dataGridViewCatVen["descricao", e.RowIndex].Value.ToString();

        }

        private void dataGridViewCatVen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Enabled = true;
            txtDescricao.Enabled = true;


            /*txtCod.Text = dataGridViewUse.Rows[e.RowIndex].Cells["codigo"].Value.ToString();
            txtNome.Text = dataGridViewUse.Rows[e.RowIndex].Cells["nome"].Value.ToString();
            txtCpf.Text = dataGridViewUse.Rows[e.RowIndex].Cells["cpf"].Value.ToString();
            cbxGrupo.SelectedItem = dataGridViewUse.Rows[e.RowIndex].Cells["grupo"].Value.ToString();
            txtUsuario.Text = dataGridViewUse.Rows[e.RowIndex].Cells["usuario"].Value.ToString();
            txtSenha.Text = dataGridViewUse.Rows[e.RowIndex].Cells["senha"].Value.ToString();*/

            txtCodigo.Text = dataGridViewCatVen["id", e.RowIndex].Value.ToString();
            txtDescricao.Text = dataGridViewCatVen["descricao", e.RowIndex].Value.ToString();

        }
    }
}
