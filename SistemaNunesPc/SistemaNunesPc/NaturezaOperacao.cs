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
    public partial class NaturezaOperacao : Form



    {
        public string valor1;
        public string valor2;

       
        String tipo;
        String uso;
        int tipoPesquisa;
        public NaturezaOperacao()
        {
            string _valor1;
            string _valor2;




            InitializeComponent();
            txtCodigo.Enabled = false;
            txtDescricao.Enabled = false;
            txtCFOPConsu.Enabled = false;
            txtCFOPForaEsta.Enabled = false;
            cbxTipo.Enabled = false;
            cbxUso.Enabled = false;
            txtCFOPRev.Enabled = false;
            lblCFOPConsu.Enabled = false;
            lblCFOPForaEsta.Enabled = false;
            lblCFOPRev.Enabled = false;
            pnCFOPConsu.Enabled = false;
            pnCFOPForaEsta.Enabled = false;
            pnCFOPRev.Enabled = false;
            btnCFOPForaEsta.Enabled = false;
            btnCFOPConsu.Enabled = false;
            btnCFOPRev.Enabled = false;

            dataGridViewCfop.Columns["id"].Visible = false;
            dataGridViewCfop.Columns["id_cfop_consumo"].Visible = false;
            dataGridViewCfop.Columns["id_cfop_revenda"].Visible = false;
            dataGridViewCfop.Columns["id_cfop_fora_estado"].Visible = false;




            try
            {
                String Configuracao = "server=localhost;userid=root;pwd=nunespc;database=sistemanunespc;";
                MySqlConnection Conexao = new MySqlConnection(Configuracao);
                Conexao.Open();
                MySqlCommand Comando = new MySqlCommand("SELECT * FROM natureza_operacao", Conexao);
                MySqlDataAdapter Adp = new MySqlDataAdapter(Comando);
                DataTable dt = new DataTable();
                Adp.Fill(dt);
                dataGridViewCfop.DataSource = dt;


                Conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
                /*cbxCFOPConsu.DataSource = dt1;
                cbxCFOPConsu.ValueMember = "descricao";
                cbxCFOPConsu.DisplayMember = "descricao";

            
           
            try
            {
                String Configuracao2 = "server=localhost;userid=root;pwd=nunespc;database=sistemanunespc;";
                MySqlConnection Conexao2 = new MySqlConnection(Configuracao2);
                Conexao2.Open();
                MySqlCommand Comando2 = new MySqlCommand("SELECT * FROM cfop", Conexao2);
                MySqlDataAdapter Adp2 = new MySqlDataAdapter(Comando2);
                DataTable dt2 = new DataTable();
                Adp2.Fill(dt2);


                ValueMember = "descricao";
                cbxCFOPForaEsta.DisplayMember = "descricao";
                cbxCFOPForaEsta.DataSource = dt2;
                
                

                Conexao2.Close();
            }
            catch
            {
            }
            try
            {
                String Configuracao3 = "server=localhost;userid=root;pwd=nunespc;database=sistemanunespc;";
                MySqlConnection Conexao3 = new MySqlConnection(Configuracao3);
                Conexao3.Open();
                MySqlCommand Comando3 = new MySqlCommand("SELECT * FROM cfop", Conexao3);
                MySqlDataAdapter Adp3 = new MySqlDataAdapter(Comando3);
                DataTable dt3 = new DataTable();
                Adp3.Fill(dt3);

                lblCFOPRev.Text = "descricao";
                lblCFOPRev.Text = "descricao";
                cbxCFOPRev.DataSource = dt3;

                Conexao3.Close();
            }
            catch
            {
            }*/
           

        }

        

        DataTable dataset;
        public NaturezaOperacao(string valor)
        {
            InitializeComponent();

            lblCFOPConsu.Text = valor;

         
        
            
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Enabled = true;
            txtDescricao.Enabled = true;
            txtCFOPConsu.Enabled = true;
            txtCFOPForaEsta.Enabled = true;
            txtCFOPRev.Enabled = true;
            cbxTipo.Enabled = true;
            cbxUso.Enabled = true;
            btnCFOPConsu.Enabled = true;
            btnCFOPForaEsta.Enabled = true;
            btnCFOPRev.Enabled = true;





            /*txtCod.Text = dataGridViewUse.Rows[e.RowIndex].Cells["codigo"].Value.ToString();
            txtNome.Text = dataGridViewUse.Rows[e.RowIndex].Cells["nome"].Value.ToString();
            txtCpf.Text = dataGridViewUse.Rows[e.RowIndex].Cells["cpf"].Value.ToString();
            cbxGrupo.SelectedItem = dataGridViewUse.Rows[e.RowIndex].Cells["grupo"].Value.ToString();
            txtUsuario.Text = dataGridViewUse.Rows[e.RowIndex].Cells["usuario"].Value.ToString();
            txtSenha.Text = dataGridViewUse.Rows[e.RowIndex].Cells["senha"].Value.ToString();*/

            txtCFOPConsu.Text = dataGridViewCfop["id_cfop_consumo", e.RowIndex].Value.ToString();
            txtCFOPForaEsta.Text = dataGridViewCfop["id_cfop_fora_estado", e.RowIndex].Value.ToString();
            txtCFOPRev.Text = dataGridViewCfop["id_cfop_revenda", e.RowIndex].Value.ToString();
            txtCodigo.Text = dataGridViewCfop["codigo_cfop", e.RowIndex].Value.ToString();
            txtDescricao.Text = dataGridViewCfop["descricao", e.RowIndex].Value.ToString();
            checkBoxICMS.Checked = dataGridViewCfop["destacaricms", e.RowIndex].Value.Equals("True");
            lblCFOPConsu.Text = dataGridViewCfop["cfop_consumo", e.RowIndex].Value.ToString();
            lblCFOPForaEsta.Text = dataGridViewCfop["cfop_fora_estado", e.RowIndex].Value.ToString();
            lblCFOPRev.Text = dataGridViewCfop["cfop_revenda", e.RowIndex].Value.ToString();
            cbxTipo.SelectedItem = dataGridViewCfop["tipo_", e.RowIndex].Value.ToString();
            cbxUso.SelectedItem = dataGridViewCfop["uso_", e.RowIndex].Value.ToString();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Carregar car = new Carregar();
            car.ShowDialog();

            if (txtCodigo.Enabled.Equals(false)){
                txtCodigo.Enabled = true;
                txtDescricao.Enabled = true;
                checkBoxICMS.Checked = true;
                txtCFOPConsu.Enabled = true;
                txtCFOPForaEsta.Enabled = true;
                txtCFOPRev.Enabled = true;
                cbxTipo.Enabled = true;
                cbxUso.Enabled = true;
                btnCFOPRev.Enabled = true;
                btnCFOPForaEsta.Enabled = true;
                btnCFOPConsu.Enabled = true;
            }
            if (txtCodigo.Equals(txtCodigo)){
                txtCodigo.Text = "";
                txtDescricao.Text = "";
                checkBoxICMS.Checked = false;
                txtCFOPConsu.Text = "";
                txtCFOPForaEsta.Text = "";
                txtCFOPRev.Text = "";
                cbxTipo.Text = "";
                cbxUso.Text = "";
                lblCFOPForaEsta.Text = "Descrição";
                lblCFOPRev.Text = "Descrição";
                lblCFOPConsu.Text = "Descrição";
                
            }
           

            
            

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            String codigo = txtCodigo.Text;
            String descricao = txtDescricao.Text;
            String uso = cbxUso.SelectedItem.ToString();
            String tipo = cbxTipo.SelectedItem.ToString();

            if (uso == "Fora do Estado")
            {
                cbxUso.Text = "Fora do Estado";
            }
            if (uso == "Dentro do Estado")
            {
                cbxUso.Text = "Dentro do Estado";
            }

            if (tipo == "Entrada")
            {
                cbxTipo.Text = "Entrada";
            }
            if (tipo == "Saida")
            {
                cbxTipo.Text = "Saida";
            }

            try
            {
                String Configuracao = "server=localhost;userid=root;pwd=nunespc;database=sistemanunespc;";
                MySqlConnection Conexao = new MySqlConnection(Configuracao);
                Conexao.Open();
                MySqlCommand Comando = new MySqlCommand("INSERT INTO natureza_operacao (codigo_cfop, descricao, destacaricms, cfop_consumo, id_cfop_consumo, cfop_revenda, id_cfop_revenda, cfop_fora_estado,id_cfop_fora_estado,uso,tipo)" + "VALUES('" + this.txtCodigo.Text + "','" + this.txtDescricao.Text + "','" + this.checkBoxICMS.Checked + "','" + this.lblCFOPConsu.Text + "','" + this.txtCFOPConsu.Text + "','" + this.lblCFOPRev.Text + "','" + this.txtCFOPRev.Text + "','" + this.lblCFOPForaEsta.Text + "','" + this.txtCFOPForaEsta.Text + "','" + this.cbxUso.SelectedItem.ToString() + "','" + this.cbxTipo.SelectedItem.ToString() + "')", Conexao);
                Comando.ExecuteNonQuery();
                Carregar car = new Carregar();
                car.ShowDialog();

                try
                {
                    MySqlCommand Comando1 = new MySqlCommand("SELECT * FROM natureza_operacao", Conexao);
                    MySqlDataAdapter Adp = new MySqlDataAdapter(Comando1);
                    DataTable dt = new DataTable();
                    Adp.Fill(dt);
                    dataGridViewCfop.DataSource = dt;
                    Conexao.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                MessageBox.Show("Cadastrado com Sucesso!", "Sucesso");
                txtCodigo.Text = "";
                txtDescricao.Text = "";
                checkBoxICMS.Checked = false;
                txtCFOPConsu.Text = "";
                txtCFOPForaEsta.Text = "";
                txtCFOPRev.Text = "";
                cbxTipo.Text = "";
                cbxUso.Text = "";


                Conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Dados Já Cadastrado", "Erro de Conexao");
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                String Configuracao = "server=localhost;userid=root;pwd=nunespc;database=sistemanunespc;";
                MySqlConnection Conexao = new MySqlConnection(Configuracao);
                Conexao.Open();
                MySqlCommand Comando = new MySqlCommand("UPDATE natureza_operacao SET descricao = ?, destacaricms = ?,cfop_consumo = ?, id_cfop_consumo = ?, cfop_fora_estado = ?, id_cfop_fora_estado = ?, cfop_revenda = ?, id_cfop_revenda = ?, tipo = ?, uso = ? WHERE codigo_cfop = ?", Conexao);

                Comando.Parameters.Clear();
                Comando.Parameters.Add("@descricao", MySqlDbType.VarChar, 200).Value = txtDescricao.Text;
                Comando.Parameters.Add("@destacaricms", MySqlDbType.VarChar, 200).Value = checkBoxICMS.Checked;
                Comando.Parameters.Add("@cfop_consumo", MySqlDbType.VarChar, 200).Value = lblCFOPConsu.Text;
                Comando.Parameters.Add("@id_cfop_consumo", MySqlDbType.VarChar, 200).Value = txtCFOPConsu.Text;
                Comando.Parameters.Add("@cfop_fora_estado", MySqlDbType.VarChar, 100).Value = lblCFOPForaEsta.Text;
                Comando.Parameters.Add("@id_cfop_fora_estado", MySqlDbType.VarChar, 100).Value = txtCFOPForaEsta.Text;
                Comando.Parameters.Add("@cfop_revenda", MySqlDbType.VarChar, 100).Value = lblCFOPRev.Text;
                Comando.Parameters.Add("@id_cfop_revenda", MySqlDbType.VarChar, 100).Value = txtCFOPRev.Text;
                Comando.Parameters.Add("@tipo", MySqlDbType.VarChar, 100).Value = cbxTipo.SelectedItem;
                Comando.Parameters.Add("@uso", MySqlDbType.VarChar, 100).Value = cbxUso.SelectedItem;
                Comando.Parameters.Add("cfop", MySqlDbType.Int32).Value = txtCodigo.Text;


                Comando.CommandType = CommandType.Text;
                Comando.ExecuteNonQuery();
                Carregar car = new Carregar();
                car.ShowDialog();

                try
                {
                    MySqlCommand Comando1 = new MySqlCommand("SELECT * FROM natureza_operacao", Conexao);
                    MySqlDataAdapter Adp = new MySqlDataAdapter(Comando1);
                    DataTable dt = new DataTable();
                    Adp.Fill(dt);
                    dataGridViewCfop.DataSource = dt;
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
                MySqlCommand Comando = new MySqlCommand("DELETE FROM natureza_operacao WHERE codigo_cfop ='" + this.txtCodigo.Text + "';", Conexao);
                Comando.Parameters.Clear();
                Comando.CommandType = CommandType.Text;
                Comando.ExecuteNonQuery();
                var dialogResult = MessageBox.Show("Deseja excluir o registro selecionado?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                Carregar car = new Carregar();
                car.ShowDialog();

                try
                {
                    MySqlCommand Comando1 = new MySqlCommand("SELECT * FROM natureza_operacao", Conexao);
                    MySqlDataAdapter Adp = new MySqlDataAdapter(Comando1);
                    DataTable dt = new DataTable();
                    Adp.Fill(dt);
                    dataGridViewCfop.DataSource = dt;
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

        private void CFOP_Load(object sender, EventArgs e)
        {
           
            
            txtCFOPConsu.Text = "";
            txtCFOPForaEsta.Text = "";
            txtCFOPRev.Text = "";
            txtCFOPConsu.Text = valor1;
            lblCFOPConsu.Text = valor2;
            
        }

        private void cbxCFOPRev_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void cbxCFOPForaEsta_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxUso_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /*private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(txtCFOP.Text == "*")
            {
                Localizar loc = new Localizar();
                loc.Show();
                txtCFOP.Clear();
            }
        }*/

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Localizar loc = new Localizar();
            loc.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtCFOPConsumo_TextChanged(object sender, EventArgs e)
        {


            if (txtCFOPConsu.Text == "*")
            {
                Localizar loc = new Localizar();
                loc.Show();
                txtCFOPConsu.Text = "";
            }
            if (txtCFOPConsu.Text == "")
            {
                lblCFOPForaEsta.Text = "Descrição";
                lblCFOPRev.Text = "Descrição";
                valor2 = "Descrição";
            }
            else
            {
                String Configuracao = "server=localhost;userid=root;pwd=nunespc;database=sistemanunespc;";
                MySqlConnection Conexao = new MySqlConnection(Configuracao);
                MySqlCommand Comando = new MySqlCommand("SELECT * FROM natureza_operacao WHERE codigo_cfop =" + txtCFOPConsu.Text, Conexao);
                MySqlDataAdapter Adp = new MySqlDataAdapter(Comando);

                try
                {

                    Conexao.Open();


                    MySqlDataReader dr = Comando.ExecuteReader();
                    while (dr.Read())
                    {
                        lblCFOPConsu.Text = dr["descricao"].ToString();
                        
                    }
                    Conexao.Close();
                }
                catch (Exception excecao)
                {
                    MessageBox.Show("Uma excecao foi gerada, apresentando a seguinte mensagem:" + Environment.NewLine + excecao.Message);
                }
                finally
                {
                    Comando.Dispose();
                    Conexao.Dispose();
                }


            }

            
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            if (txtCFOPRev.Text == "*")
            {
                Localizar loc = new Localizar();
                loc.Show();
                txtCFOPRev.Text = "";
            }
            if (txtCFOPRev.Text == "")
            {
                lblCFOPForaEsta.Text = "Descrição";
                lblCFOPRev.Text = "Descrição";
                lblCFOPConsu.Text = "Descrição";

            }
            else
            {
                String Configuracao = "server=localhost;userid=root;pwd=nunespc;database=sistemanunespc;";
                MySqlConnection Conexao = new MySqlConnection(Configuracao);
                MySqlCommand Comando = new MySqlCommand("SELECT * FROM natureza_operacao WHERE codigo_cfop =" + txtCFOPRev.Text, Conexao);
                MySqlDataAdapter Adp = new MySqlDataAdapter(Comando);

                try
                {

                    Conexao.Open();


                    MySqlDataReader dr = Comando.ExecuteReader();
                    while (dr.Read())
                    {
                        lblCFOPRev.Text = dr["descricao"].ToString();
                    }
                    Conexao.Close();
                }
                catch (Exception excecao)
                {
                    MessageBox.Show("Uma excecao foi gerada, apresentando a seguinte mensagem:" + Environment.NewLine + excecao.Message);
                }
                finally
                {
                    Comando.Dispose();
                    Conexao.Dispose();
                }
            }

        }

    private void txtCFOPForaEsta_TextChanged(object sender, EventArgs e)
        {

            if (txtCFOPForaEsta.Text == "*")
            {
                Localizar loc = new Localizar();
                loc.Show();
                txtCFOPForaEsta.Text = "";
            }
            if (txtCFOPForaEsta.Text == "")
            {
                lblCFOPForaEsta.Text = "Descrição";
                lblCFOPRev.Text = "Descrição";
                lblCFOPConsu.Text = "Descrição";
            }
            else
            {
                String Configuracao = "server=localhost;userid=root;pwd=nunespc;database=sistemanunespc;";
                MySqlConnection Conexao = new MySqlConnection(Configuracao);
                MySqlCommand Comando = new MySqlCommand("SELECT * FROM natureza_operacao WHERE codigo_cfop =" + txtCFOPForaEsta.Text, Conexao);
                MySqlDataAdapter Adp = new MySqlDataAdapter(Comando);

                try
                {

                    Conexao.Open();


                    MySqlDataReader dr = Comando.ExecuteReader();
                    while (dr.Read())
                    {
                        lblCFOPForaEsta.Text = dr["descricao"].ToString();
                    }
                    Conexao.Close();
                }
                catch (Exception excecao)
                {
                    MessageBox.Show("Uma excecao foi gerada, apresentando a seguinte mensagem:" + Environment.NewLine + excecao.Message);
                }
                finally
                {
                    Comando.Dispose();
                    Conexao.Dispose();
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Localizar loc = new Localizar();
            loc.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Localizar loc = new Localizar();
            loc.Show();
        }

        private void cbxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pnCFOPConsu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }

    class cbxUso
    {
        public static string SelectedItem { get; internal set; }
    }

    public class cbxTipo
    {
        internal static string SelectedItem;
    }

    public class lblCFOPRev
    {
        internal static string Text;
    }

    public class lblCFOPConsu
    {
        internal static string Text;
    }

    public class lblCFOPForaEsta
    {
        internal static string Text;
    }

    public class txtDescricao
    {
        internal static string Text;
    }

    public class checkBoxICMS
    {
        public static bool Checked { get; internal set; }
    }

    public class txtCodigo
    {
        internal static string Text;
    }

    public class txtCFOPRev
    {
        internal static string Text;
    }

    public class txtCFOPForaEsta
    {
        internal static string Text;
    }

    public class txtCFOPConsu
    {
        internal static string Text;
    }
}
