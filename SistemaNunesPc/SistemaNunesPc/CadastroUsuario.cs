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
    public partial class CadastroUsuario : Form
    {
        int tipoPesquisa;

        public CadastroUsuario()
        {
            InitializeComponent();
            txtCod.Enabled = false;
            txtNome.Enabled = false;
            txtCpf.Enabled = false;
            cbxGrupo.Enabled = false;
            txtUsuario.Enabled = false;
            txtSenha.Enabled = false;

            dataGridViewUse.Columns["senha"].Visible = false;
            dataGridViewUse.Columns["usuario"].Visible = false;

            /*listViewUsuario.View = View.Details;

            listViewUsuario.LabelEdit = true;

            listViewUsuario.AllowColumnReorder = true;

            listViewUsuario.FullRowSelect = true;

            listViewUsuario.GridLines = true;

            listViewUsuario.Columns.Add("Codigo", 30, HorizontalAlignment.Left);
            listViewUsuario.Columns.Add("Nome", 50, HorizontalAlignment.Left);
            listViewUsuario.Columns.Add("CPF", 150, HorizontalAlignment.Left);
            listViewUsuario.Columns.Add("Grupo", 150, HorizontalAlignment.Left);*/

            try
            {
                String Configuracao = "server=localhost;userid=root;pwd=nunespc;database=sistemanunespc;";
                MySqlConnection Conexao = new MySqlConnection(Configuracao);
                Conexao.Open();
                MySqlCommand Comando = new MySqlCommand("SELECT * FROM usuario", Conexao);
                MySqlDataAdapter Adp = new MySqlDataAdapter(Comando);
                DataTable dt = new DataTable();
                Adp.Fill(dt);
                dataGridViewUse.DataSource = dt;


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


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CadastroUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            String nome = txtNome.Text;
            String cpf = txtCpf.Text;
            String grupo = cbxGrupo.SelectedItem.ToString();
            String usuario = txtUsuario.Text;
            String senha = txtSenha.Text;

            
            try
            {
                String Configuracao = "server=localhost;userid=root;pwd=nunespc;database=sistemanunespc;";
                MySqlConnection Conexao = new MySqlConnection(Configuracao);
                Conexao.Open();
                MySqlCommand Comando = new MySqlCommand("INSERT INTO usuario (nome, cpf, grupo, usuario, senha)" + "VALUES('" + this.txtNome.Text + "','" + this.txtCpf.Text + "','" + this.cbxGrupo.SelectedItem.ToString() + "','" + this.txtUsuario.Text + "','" + this.txtSenha.Text + "')", Conexao);
                Comando.ExecuteNonQuery();

                Carregar car = new Carregar();
                car.ShowDialog();

                        try
                        {
                            MySqlCommand Comando1 = new MySqlCommand("SELECT * FROM usuario", Conexao);
                            MySqlDataAdapter Adp = new MySqlDataAdapter(Comando1);
                            DataTable dt = new DataTable();
                            Adp.Fill(dt);
                            dataGridViewUse.DataSource = dt;
                            Conexao.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                MessageBox.Show("Usuario Cadastrado com Sucesso!", "Sucesso");
                txtCod.Text = "";
                txtNome.Text = "";
                txtCpf.Text = "";
                cbxGrupo.Text = "";
                txtUsuario.Text = "";
                txtSenha.Text = "";
                Conexao.Close();
            }
            catch(Exception erro)
            {
                MessageBox.Show("Não foi possivel se conectar com o Banco de Dados", "Erro de Conexao");
            }


        }

        private void cbxGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void tableUpdateStatementBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                String Configuracao = "server=localhost;userid=root;pwd=nunespc;database=sistemanunespc;";
                MySqlConnection Conexao = new MySqlConnection(Configuracao);
                Conexao.Open();
                MySqlCommand Comando = new MySqlCommand("UPDATE usuario SET nome = ?, cpf = ?, grupo = ?, usuario = ?, senha = ? WHERE id = ?", Conexao);
                
                Comando.Parameters.Clear();
                Comando.Parameters.Add("@nome", MySqlDbType.VarChar, 60).Value = txtNome.Text;
                Comando.Parameters.Add("@cpf", MySqlDbType.VarChar, 60).Value = txtCpf.Text;
                Comando.Parameters.Add("@grupo", MySqlDbType.VarChar, 60).Value = cbxGrupo.SelectedItem;
                Comando.Parameters.Add("@usuario", MySqlDbType.VarChar, 60).Value = txtUsuario.Text;
                Comando.Parameters.Add("@senha", MySqlDbType.VarChar, 60).Value = txtSenha.Text;
                Comando.Parameters.Add("usuario", MySqlDbType.Int32).Value = txtCod.Text;
                

                Comando.CommandType = CommandType.Text;
                Comando.ExecuteNonQuery();
                
                Carregar car = new Carregar();
                car.ShowDialog();
                        try
                        {
                            MySqlCommand Comando1 = new MySqlCommand("SELECT * FROM usuario", Conexao);
                            MySqlDataAdapter Adp = new MySqlDataAdapter(Comando1);
                            DataTable dt = new DataTable();
                            Adp.Fill(dt);
                            dataGridViewUse.DataSource = dt;
                            Conexao.Close();
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
                        }

                MessageBox.Show("Usuario Atualizado com Sucesso!");
                Conexao.Close();
            }
            catch(Exception erro)
            {
                MessageBox.Show("Falha ao Atualizar o Usuario" + erro);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                String Configuracao = "server=localhost;userid=root;pwd=nunespc;database=sistemanunespc;";
                MySqlConnection Conexao = new MySqlConnection(Configuracao);
                Conexao.Open();
                MySqlCommand Comando = new MySqlCommand("DELETE FROM usuario WHERE id ='" + this.txtCod.Text + "';", Conexao);
                Comando.Parameters.Clear();
                Comando.CommandType = CommandType.Text;
                Comando.ExecuteNonQuery();
                var dialogResult = MessageBox.Show("Deseja excluir o registro selecionado?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                Carregar car = new Carregar();
                car.ShowDialog();

                try
                    {
                         MySqlCommand Comando1 = new MySqlCommand("SELECT * FROM usuario", Conexao);
                         MySqlDataAdapter Adp = new MySqlDataAdapter(Comando1);
                         DataTable dt = new DataTable();
                         Adp.Fill(dt);
                         dataGridViewUse.DataSource = dt;
                         Conexao.Close();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }

                MessageBox.Show("Usuario Deletado Com Sucesso!");
                Conexao.Clone();
            }
            catch(Exception erro)
            {
                MessageBox.Show("Falha ao Deletar o Usuario" + erro);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {

            Carregar car = new Carregar();
            car.ShowDialog();

            txtCod.Enabled = true;
            txtNome.Enabled = true;
            txtCpf.Enabled = true;
            cbxGrupo.Enabled = true;
            txtUsuario.Enabled = true;
            txtSenha.Enabled = true;

            txtCod.Text = "";
            txtNome.Text = "";
            txtCpf.Text = "";
            cbxGrupo.Text = "";
            txtUsuario.Text = "";
            txtSenha.Text = "";




            String Configuracao = "server=localhost;userid=root;pwd=nunespc;database=sistemanunespc;";
            MySqlConnection Conexao = new MySqlConnection(Configuracao);
            Conexao.Open();

                    

            MySqlCommand Comando = new MySqlCommand("Select MAX(id+ 1) From usuario", Conexao);
            /* txtCodigo.Text = Comando.ExecuteScalar().ToString();*/


            //TextBox Código Recebe o Próximo Código

            txtCod.Text = Comando.ExecuteScalar().ToString();


            //Caso o Resultado Seja Nulo

            //Ou seja, é o Primeiro Código

            Conexao.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCod.Enabled = true;
            txtNome.Enabled = true;
            txtCpf.Enabled = true;
            cbxGrupo.Enabled = true;
            txtUsuario.Enabled = true;
            txtSenha.Enabled = true;
            
            /*txtCod.Text = dataGridViewUse.Rows[e.RowIndex].Cells["codigo"].Value.ToString();
            txtNome.Text = dataGridViewUse.Rows[e.RowIndex].Cells["nome"].Value.ToString();
            txtCpf.Text = dataGridViewUse.Rows[e.RowIndex].Cells["cpf"].Value.ToString();
            cbxGrupo.SelectedItem = dataGridViewUse.Rows[e.RowIndex].Cells["grupo"].Value.ToString();
            txtUsuario.Text = dataGridViewUse.Rows[e.RowIndex].Cells["usuario"].Value.ToString();
            txtSenha.Text = dataGridViewUse.Rows[e.RowIndex].Cells["senha"].Value.ToString();*/

            txtCod.Text = dataGridViewUse["id", e.RowIndex].Value.ToString();
            txtNome.Text = dataGridViewUse["nome", e.RowIndex].Value.ToString();
            txtCpf.Text = dataGridViewUse["cpf", e.RowIndex].Value.ToString();
            cbxGrupo.SelectedItem = dataGridViewUse["grupo", e.RowIndex].Value.ToString();
            txtUsuario.Text = dataGridViewUse["usuario", e.RowIndex].Value.ToString();
            txtSenha.Text = dataGridViewUse["senha", e.RowIndex].Value.ToString();


            

            




        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            tipoPesquisa = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            tipoPesquisa = 2;
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
                       
            if (tipoPesquisa == 1)
            {
                String Configuracao = "server=localhost;userid=root;pwd=nunespc;database=sistemanunespc;";
                MySqlConnection Conexao = new MySqlConnection(Configuracao);
                Conexao.Open();
                MySqlCommand Comando = new MySqlCommand("SELECT * FROM usuario;", Conexao);
                MySqlDataAdapter dta = new MySqlDataAdapter();
                dta.SelectCommand = Comando;
                dataset = new DataTable();
                dta.Fill(dataset);
                BindingSource bs = new BindingSource();

                bs.DataSource = dataset;
                dataGridViewUse.DataSource = bs;
                dta.Update(dataset);
                DataView dv = new DataView(dataset);
                dv.RowFilter = String.Format("cpf LIKE '%{0}%'", txtPesquisa.Text);
                dataGridViewUse.DataSource = dv;

            }
            if (tipoPesquisa == 2)
            {
                String Configuracao = "server=localhost;userid=root;pwd=nunespc;database=sistemanunespc;";
                MySqlConnection Conexao = new MySqlConnection(Configuracao);
                Conexao.Open();
                MySqlCommand Comando = new MySqlCommand("SELECT * FROM usuario;", Conexao);
                MySqlDataAdapter dta3 = new MySqlDataAdapter();
                dta3.SelectCommand = Comando;
                dataset = new DataTable();
                dta3.Fill(dataset);
                BindingSource bs3 = new BindingSource();

                bs3.DataSource = dataset;
                dataGridViewUse.DataSource = bs3;
                dta3.Update(dataset);
                DataView dv3 = new DataView(dataset);
                dv3.RowFilter = String.Format("nome LIKE '%{0}%'", txtPesquisa.Text);
                dataGridViewUse.DataSource = dv3;

            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCod_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

