using SistemaNunesPc;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace SistemaNunesPc
{
    public partial class CadastroFornecedor : Form
    {
        /* string conectarBanco = "SERVER=localhost; DATABASE=sistemanunespc; UID=root; PWD=;nunespc";
         int id = 0;*/
        int tipoPesquisa;

        public CadastroFornecedor()
        {
            InitializeComponent();

            ConsultaCNPJReceita.GetCaptcha(picLetras);

            txtCodigo.Enabled = false;
            txtCnpj.Enabled = false;
            txtRazaoSocial.Enabled = false;
            txtNomeFantasia.Enabled = false;
            txtIE.Enabled = false;
            txtIM.Enabled = false;
            txtCep.Enabled = false;
            txtLogradouro.Enabled = false;
            txtNumero.Enabled = false;
            txtComplemento.Enabled = false;
            txtBairro.Enabled = false;
            txtUf.Enabled = false;
            txtCidade.Enabled = false;
            txtTelefone.Enabled = false;
            txtEmail.Enabled = false;
            txtLetras.Enabled = false;


            /* listViewFornecedor.View = View.Details;

             listViewFornecedor.LabelEdit = true;

             listViewFornecedor.AllowColumnReorder = true;

             listViewFornecedor.FullRowSelect = true;

             listViewFornecedor.GridLines = true;*/


            try
            {

                String Configuracao = "server=localhost;userid=root;pwd=nunespc;database=sistemanunespc;";
                MySqlConnection Conexao = new MySqlConnection(Configuracao);
                Conexao.Open();
                MySqlCommand Comando = new MySqlCommand("SELECT * FROM fornecedor", Conexao);
                MySqlDataAdapter Adp = new MySqlDataAdapter(Comando);
                DataTable dt = new DataTable();
                Adp.Fill(dt);
                dataGridViewFor.DataSource = dt;






                /*MySqlDataReader reader = Comando.ExecuteReader();

                listViewFornecedor.Items.Clear();

                while (reader.Read())
                {
                    String[] row = {reader.GetString(0),
                                reader.GetString(1),
                                reader.GetString(2),
                                reader.GetString(3),
                                reader.GetString(13),
                                reader.GetString(14)
                                };

                    var listViewItem = new ListViewItem(row);

                    listViewFornecedor.Items.Add(listViewItem);

                }*/
                Conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
        DataTable dataset;
        private void frmConsultaCNPJ_Load(object sender, EventArgs e)
        {
            CarregaCaptcha();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ConsultaCNPJ();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            CarregaCaptcha();
        }

        private async void CarregaCaptcha() // METODO ASYNC (ASSINCRONO) // PARA NAO TRAVAR O FORM QUANDO DEMORAR
        {
            LimpaCamposCaptcha();

            // EM MEUS TESTES, APÓS ALGUMAS CONSULTAS A RECEITA BLOQUEOU O IP, MESMO ACESSANDO PELO SITE DA RECEITA. NAO FUNCIONOU ATÉ REINICIAR A INTERNET.
            // DESSA FORMA CONSEGUI IMPLEMENTAR ROTINAS DE QUANDO O SERVIÇO FICA LENTO OU É BLOQUEADO

            // PARA BLOQUEAR O SEU IP NA RECEITA, BASTA CLICAR DIVERSAS VEZES NO BOTAO TROCAR IMAGEM. A CONSULTA VAI DEMORAR PARA DAR RETORNO DE ERRO DEVIDO AO BLOQUEIO.
            // PORÉM, CONFORME O MODO ASSINCRONO IMPLEMENTADO ABAIXO, O SISTEMA NÃO FICARÁ TRAVADO ENQUANTO A CONSULTA NAO RETORNA NADA.

            await Task.Run(() => // EXECUTA O MÉTODO EM UMA NOVA TASK, NAO TRAVANDO A TELA AO INICIAR QUANDO O SERVIÇO NAO ESTA DISPONIVEL OU ESTA MUITO LENTO
            {
                BloqueiaBotaoImagem(true); // BLOQUEIA O BOTAO E EXIBE MENSAGEM CARREGANDO NO BOTAO

                // SIMPLESMENTE CARREGA A IMAGEM NO PICTUREBOX INFORMADO
                if (ConsultaCNPJReceita.GetCaptcha(picLetras) == false)
                {
                    MessageBox.Show(ConsultaCNPJReceita.Mensagem); // MENSAGEM SE TIVER ERRO
                }

                BloqueiaBotaoImagem(false); // RETORNA O BOTAO AO ESTADO ORIGINAL
            });
        }

        private void LimpaCamposCaptcha()
        {
            Invoke((MethodInvoker)(() =>
            {
                txtLetras.Text = "";
                txtLetras.Focus();
            }));
        }

        private void BloqueiaBotaoImagem(bool Bloquear)
        {
            // COMO O ESSE METODO É CHAMADO DENTRO DE UMA TASK (await Task.Run(() =>) PRECISAMOS APENAS CHAMAR INVOKE() PARA MANIPULAR COMPONENTES DO FORM.
            // SEM INVOKE() OCORRERÁ ERRO
            Invoke((MethodInvoker)(() =>
            {
                if (Bloquear == true)
                {
                    btnImagem.Enabled = false;
                    btnImagem.Text = "Carregando Imagem...";
                }
                else
                {
                    btnImagem.Enabled = true;
                    btnImagem.Text = "Trocar Imagem";
                }
            }));
        }

        private void BloqueiaBotaoConsultaCNPJ(bool Bloquear)
        {
            // COMO O ESSE METODO É CHAMADO DENTRO DE UMA TASK (await Task.Run(() =>) PRECISAMOS APENAS CHAMAR INVOKE() PARA MANIPULAR COMPONENTES DO FORM.
            // SEM INVOKE() OCORRERÁ ERRO
            Invoke((MethodInvoker)(() =>
            {
                if (Bloquear == true)
                {
                    btnConsultar.Enabled = false;
                    btnConsultar.Text = "Carregando...";
                }
                else
                {
                    btnConsultar.Enabled = true;
                    btnConsultar.Text = "Consultar CNPJ";
                }
            }));
        }

        private async void ConsultaCNPJ()
        {
            // VERIFICO AQUI OS CAMPOS PARA NAO RECARREGAR O CAPCHA NOVAMENTE
            // A VALIDACAO É FEITA TAMBEM DENTRO DE ConsultaCNPJReceita.Consulta(); PARA CASO O USUARIO NAO IMPLENTE ISSO NO FORMULARIO
            if (ConsultaCNPJReceita.ValidaCampos(txtCnpj.Text, txtLetras.Text) == false)
            {
                MessageBox.Show(ConsultaCNPJReceita.Mensagem);
                return;
            }


            await Task.Run(() => // EXECUTA O MÉTODO EM UMA NOVA TASK, NAO TRAVANDO A TELA QUANDO O SERVIÇO NAO ESTA DISPONIVEL OU ESTA MUITO LENTO
            {
                BloqueiaBotaoConsultaCNPJ(true); //BLOQUEIA O BOTAO E EXIBE MENSAGEM CARREGANDO NO BOTAO

                if (ConsultaCNPJReceita.Consulta(txtCnpj.Text, txtLetras.Text))
                    CarregaDadosNoFormulario();
                else
                    MessageBox.Show(ConsultaCNPJReceita.Mensagem);

                BloqueiaBotaoConsultaCNPJ(false); // RETORNA O BOTAO AO NORMAL
                CarregaCaptcha(); // APÓS UMA CONSULTA, RECARREGA CAPTCHA NOVAMENTE.
            });
        }


        private void CarregaDadosNoFormulario()
        {
            // COMO ESSE METODO É CHAMADO DENTRO DE UMA NOVA TASK (await Task.Run(() =>) PRECISAMOS CHAMAR INVOKE() PARA MEXER COM COMPONENTES DO FORM.
            // SEM INVOKE() OCORRERÁ ERRO
            Invoke((MethodInvoker)(() =>
            {
                Empresa empresaConsultada;

                empresaConsultada = ConsultaCNPJReceita.Empresa;

                txtRazaoSocial.Text = empresaConsultada.RazaoSocial;
                txtNomeFantasia.Text = empresaConsultada.NomeFantasia;

                //Endereco
                txtLogradouro.Text = empresaConsultada.Endereco;
                txtNumero.Text = empresaConsultada.Numero;
                txtComplemento.Text = empresaConsultada.Complemento;
                txtBairro.Text = empresaConsultada.Bairro;
                txtCidade.Text = empresaConsultada.Cidade;
                txtUf.Text = empresaConsultada.UF;
                txtCep.Text = empresaConsultada.CEP;

                //Contato
                txtEmail.Text = empresaConsultada.Email;
                txtTelefone.Text = empresaConsultada.Telefones; // pode ser mais de um


            }));
        }


        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCep_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtComplemento_TextChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void CadastroFornecedor_Load(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {

            txtCodigo.Enabled = true;
            txtCnpj.Enabled = true;
            txtLetras.Enabled = true;
            txtRazaoSocial.Enabled = true;
            txtNomeFantasia.Enabled = true;
            txtIE.Enabled = true;
            txtIM.Enabled = true;
            txtCep.Enabled = true;
            txtLogradouro.Enabled = true;
            txtNumero.Enabled = true;
            txtComplemento.Enabled = true;
            txtBairro.Enabled = true;
            txtUf.Enabled = true;
            txtCidade.Enabled = true;
            txtTelefone.Enabled = true;
            txtEmail.Enabled = true;

            txtCodigo.Text = "";
            txtCnpj.Text = "";
            txtRazaoSocial.Text = "";
            txtNomeFantasia.Text = "";
            txtIE.Text = "";
            txtIM.Text = "";
            txtCep.Text = "";
            txtLogradouro.Text = "";
            txtNumero.Text = "";
            txtComplemento.Text = "";
            txtBairro.Text = "";
            txtUf.Text = "";
            txtCidade.Text = "";
            txtTelefone.Text = "";
            txtEmail.Text = "";
            txtLetras.Text = "";
            picLetras.Text = "";

            String Configuracao = "server=localhost;userid=root;pwd=nunespc;database=sistemanunespc;";
             MySqlConnection Conexao = new MySqlConnection(Configuracao);
             Conexao.Open();
             Carregar car = new Carregar();
             car.ShowDialog();
             MySqlCommand Comando = new MySqlCommand("Select MAX(id+ 1) From fornecedor", Conexao);
             /* txtCodigo.Text = Comando.ExecuteScalar().ToString();*/


            //TextBox Código Recebe o Próximo Código

             txtCodigo.Text = Comando.ExecuteScalar().ToString();


            //Caso o Resultado Seja Nulo

            //Ou seja, é o Primeiro Código

            Conexao.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            
            String cnpj = txtCnpj.Text;
            String razaosocia = txtRazaoSocial.Text;
            String nomefantasia = txtNomeFantasia.Text;
            String IE = txtIE.Text;
            String Inscricaomuni = txtIM.Text;
            String logradouro = txtLogradouro.Text;
            String cep = txtCep.Text;
            String numero = txtNumero.Text;
            String bairro = txtBairro.Text;
            String cidade = txtCidade.Text;
            String estado = txtUf.Text;
            String complemento = txtComplemento.Text;
            String telefone = txtTelefone.Text;
            String email = txtEmail.Text;

            
            try
            {
                String Configuracao = "server=localhost;userid=root;pwd=nunespc;database=sistemanunespc;";
                MySqlConnection Conexao = new MySqlConnection(Configuracao);
                Conexao.Open();
                MySqlCommand Comando = new MySqlCommand("INSERT INTO fornecedor (cnpj,razaosocial,nomefantasia,IE,Inscricaomuni,logradouro,cep,numero,bairro,cidade,estado,complemento,telefone,email)" + "VALUES('" + this.txtCnpj.Text + "','" + this.txtRazaoSocial.Text + "','" + this.txtNomeFantasia.Text + "','" + this.txtIE.Text + "','" + this.txtIM.Text + "','" + this.txtLogradouro.Text + "','" + this.txtCep.Text + "','" + this.txtNumero.Text + "','" + this.txtBairro.Text + "','" + this.txtCidade.Text + "','" + this.txtUf.Text + "','" + this.txtComplemento.Text + "','" + this.txtTelefone.Text + "','" + this.txtEmail.Text + "')", Conexao);
                Comando.ExecuteNonQuery();
                Carregar car = new Carregar();
                car.ShowDialog();

                    try
                    {
                        MySqlCommand Comando1 = new MySqlCommand("SELECT * FROM fornecedor", Conexao);
                        MySqlDataAdapter Adp = new MySqlDataAdapter(Comando1);
                        DataTable dt = new DataTable();
                        Adp.Fill(dt);
                        dataGridViewFor.DataSource = dt;
                        Conexao.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                MessageBox.Show("Cadastrado com Sucesso!", "Sucesso");
                txtCodigo.Text = "";
                txtCnpj.Text = "";
                txtRazaoSocial.Text = "";
                txtNomeFantasia.Text = "";
                txtIE.Text = "";
                txtIM.Text = "";
                txtCep.Text = "";
                txtLogradouro.Text = "";
                txtNumero.Text = "";
                txtComplemento.Text = "";
                txtBairro.Text = "";
                txtUf.Text = "";
                txtCidade.Text = "";
                txtTelefone.Text = "";
                txtEmail.Text = "";


                Conexao.Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + Convert.ToString(ex), "Aviso");
            }

            

        }


        private void txtCnpj_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtIM_TextChanged(object sender, EventArgs e)
        {

        }

        private void listViewFornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnExluir_Click(object sender, EventArgs e)
        {
            try
            {
                String Configuracao = "server=localhost;userid=root;pwd=nunespc;database=sistemanunespc;";
                MySqlConnection Conexao = new MySqlConnection(Configuracao);
                Conexao.Open();
                MySqlCommand Comando = new MySqlCommand("DELETE FROM fornecedor WHERE id ='" + this.txtCodigo.Text + "';", Conexao);
                Comando.Parameters.Clear();
                Comando.CommandType = CommandType.Text;
                Comando.ExecuteNonQuery();
                var dialogResult = MessageBox.Show("Deseja excluir o registro selecionado?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                Carregar car = new Carregar();
                car.ShowDialog();

                try
                    {
                        MySqlCommand Comando1 = new MySqlCommand("SELECT * FROM fornecedor", Conexao);
                        MySqlDataAdapter Adp = new MySqlDataAdapter(Comando1);
                        DataTable dt = new DataTable();
                        Adp.Fill(dt);
                        dataGridViewFor.DataSource = dt;
                        Conexao.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                MessageBox.Show("Fornecedor Deletado Com Sucesso!");

                Conexao.Clone();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Falha ao Deletar o Fornecedor" + erro);
            }
        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged_1(object sender, EventArgs e)
        {
            if (tipoPesquisa == 1)
            {
                String Configuracao = "server=localhost;userid=root;pwd=nunespc;database=sistemanunespc;";
                MySqlConnection Conexao = new MySqlConnection(Configuracao);
                Conexao.Open();
                MySqlCommand Comando = new MySqlCommand("SELECT * FROM fornecedor;", Conexao);
                MySqlDataAdapter dta = new MySqlDataAdapter();
                dta.SelectCommand = Comando;
                dataset = new DataTable();
                dta.Fill(dataset);
                BindingSource bs = new BindingSource();

                bs.DataSource = dataset;
                dataGridViewFor.DataSource = bs;
                dta.Update(dataset);
                DataView dv = new DataView(dataset);
                dv.RowFilter = String.Format("cnpj LIKE '%{0}%'", txtPesquisa.Text);
                dataGridViewFor.DataSource = dv;
            }
                if (tipoPesquisa == 2)
                {
                    String Configuracao2 = "server=localhost;userid=root;pwd=nunespc;database=sistemanunespc;";
                    MySqlConnection Conexao2 = new MySqlConnection(Configuracao2);
                    Conexao2.Open();
                    MySqlCommand Comando2 = new MySqlCommand("SELECT * FROM fornecedor;", Conexao2);
                    MySqlDataAdapter dta2 = new MySqlDataAdapter();
                    dta2.SelectCommand = Comando2;
                    dataset = new DataTable();
                    dta2.Fill(dataset);
                    BindingSource bs2 = new BindingSource();

                    bs2.DataSource = dataset;
                    dataGridViewFor.DataSource = bs2;
                    dta2.Update(dataset);
                    DataView dv2 = new DataView(dataset);
                    dv2.RowFilter = String.Format("razaosocial LIKE '%{0}%'", txtPesquisa.Text);
                    dataGridViewFor.DataSource = dv2;
                }
                if (tipoPesquisa == 3)
                {
                String Configuracao3 = "server=localhost;userid=root;pwd=nunespc;database=sistemanunespc;";
                MySqlConnection Conexao3 = new MySqlConnection(Configuracao3);
                Conexao3.Open();
                MySqlCommand Comando3 = new MySqlCommand("SELECT * FROM fornecedor;", Conexao3);
                MySqlDataAdapter dta3 = new MySqlDataAdapter();
                dta3.SelectCommand = Comando3;
                dataset = new DataTable();
                dta3.Fill(dataset);
                BindingSource bs3 = new BindingSource();

                bs3.DataSource = dataset;
                dataGridViewFor.DataSource = bs3;
                dta3.Update(dataset);
                DataView dv3 = new DataView(dataset);
                dv3.RowFilter = String.Format("nomefantasia LIKE '%{0}%'", txtPesquisa.Text);
                dataGridViewFor.DataSource = dv3;
            }
               

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
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

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            tipoPesquisa = 3;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            
            
        }

        private void dataGridViewFor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Enabled = true;
            txtCnpj.Enabled = true;
            txtRazaoSocial.Enabled = true;
            txtNomeFantasia.Enabled = true;
            txtIE.Enabled = true;
            txtIM.Enabled = true;
            txtCep.Enabled = true;
            txtLogradouro.Enabled = true;
            txtNumero.Enabled = true;
            txtComplemento.Enabled = true;
            txtBairro.Enabled = true;
            txtUf.Enabled = true;
            txtCidade.Enabled = true;
            txtTelefone.Enabled = true;
            txtEmail.Enabled = true;
            /*txtCodigo.Text = dataGridViewFor.Rows[e.RowIndex].Cells["codigo"].Value.ToString();
            txtCnpj.Text = dataGridViewFor.Rows[e.RowIndex].Cells["cnpj"].Value.ToString();
            txtRazaoSocial.Text = dataGridViewFor.Rows[e.RowIndex].Cells["razaosocial"].Value.ToString();
            txtNomeFantasia.Text = dataGridViewFor.Rows[e.RowIndex].Cells["nomefantasia"].Value.ToString();
            txtIE.Text = dataGridViewFor.Rows[e.RowIndex].Cells["IE"].Value.ToString();
            txtIM.Text = dataGridViewFor.Rows[e.RowIndex].Cells["Inscricaomuni"].Value.ToString();
            txtCep.Text = dataGridViewFor.Rows[e.RowIndex].Cells["cep"].Value.ToString();
            txtLogradouro.Text = dataGridViewFor.Rows[e.RowIndex].Cells["logradouro"].Value.ToString();
            txtNumero.Text = dataGridViewFor.Rows[e.RowIndex].Cells["numero"].Value.ToString();
            txtComplemento.Text = dataGridViewFor.Rows[e.RowIndex].Cells["complemento"].Value.ToString();
            txtBairro.Text = dataGridViewFor.Rows[e.RowIndex].Cells["bairro"].Value.ToString();
            txtUf.Text = dataGridViewFor.Rows[e.RowIndex].Cells["estado"].Value.ToString();
            txtCidade.Text = dataGridViewFor.Rows[e.RowIndex].Cells["cidade"].Value.ToString();
            txtTelefone.Text = dataGridViewFor.Rows[e.RowIndex].Cells["telefone"].Value.ToString();
            txtEmail.Text = dataGridViewFor.Rows[e.RowIndex].Cells["email"].Value.ToString();*/

            //ou
            txtCodigo.Text = dataGridViewFor["codigo", e.RowIndex].Value.ToString();
            txtCnpj.Text = dataGridViewFor["cnpj", e.RowIndex].Value.ToString();
            txtRazaoSocial.Text = dataGridViewFor["razaosocial", e.RowIndex].Value.ToString();
            txtNomeFantasia.Text = dataGridViewFor["nomefantasia", e.RowIndex].Value.ToString();
            txtIE.Text = dataGridViewFor["IE", e.RowIndex].Value.ToString();
            txtIM.Text = dataGridViewFor["Inscricaomuni", e.RowIndex].Value.ToString();
            txtCep.Text = dataGridViewFor["cep", e.RowIndex].Value.ToString();
            txtLogradouro.Text = dataGridViewFor["logradouro", e.RowIndex].Value.ToString();
            txtNumero.Text = dataGridViewFor["numero", e.RowIndex].Value.ToString();
            txtComplemento.Text = dataGridViewFor["complemento", e.RowIndex].Value.ToString();
            txtBairro.Text = dataGridViewFor["bairro", e.RowIndex].Value.ToString();
            txtUf.Text = dataGridViewFor["estado", e.RowIndex].Value.ToString();
            txtCidade.Text = dataGridViewFor["cidade", e.RowIndex].Value.ToString();
            txtTelefone.Text = dataGridViewFor["telefone", e.RowIndex].Value.ToString();
            txtEmail.Text = dataGridViewFor["email", e.RowIndex].Value.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                String Configuracao = "server=localhost;userid=root;pwd=nunespc;database=sistemanunespc;";
                MySqlConnection Conexao = new MySqlConnection(Configuracao);
                Conexao.Open();
                MySqlCommand Comando = new MySqlCommand("UPDATE fornecedor SET cnpj = ?, razaosocial = ?, nomefantasia = ?, IE = ?, Inscricaomuni = ?, cep = ?, logradouro = ?, numero = ?, complemento = ?, bairro = ?, estado = ?, cidade = ?, telefone = ?, email = ? WHERE id = ?", Conexao);

                Comando.Parameters.Clear();
                Comando.Parameters.Add("@cnpj", MySqlDbType.VarChar, 100).Value = txtCnpj.Text;
                Comando.Parameters.Add("@razaosocial", MySqlDbType.VarChar, 100).Value = txtRazaoSocial.Text;
                Comando.Parameters.Add("@nomefantasia", MySqlDbType.VarChar, 100).Value = txtNomeFantasia.Text;
                Comando.Parameters.Add("@IE", MySqlDbType.VarChar, 100).Value = txtIE.Text;
                Comando.Parameters.Add("@Inscricaomuni", MySqlDbType.VarChar, 100).Value = txtIM.Text;
                Comando.Parameters.Add("@cep", MySqlDbType.VarChar, 100).Value = txtCep.Text;
                Comando.Parameters.Add("@logradouro", MySqlDbType.VarChar, 100).Value = txtLogradouro.Text;
                Comando.Parameters.Add("@numero", MySqlDbType.VarChar, 100).Value = txtNumero.Text;
                Comando.Parameters.Add("@completo", MySqlDbType.VarChar, 100).Value = txtComplemento.Text;
                Comando.Parameters.Add("@bairro", MySqlDbType.VarChar, 100).Value = txtBairro.Text;
                Comando.Parameters.Add("@estado", MySqlDbType.VarChar, 100).Value = txtUf.Text;
                Comando.Parameters.Add("@cidade", MySqlDbType.VarChar, 100).Value = txtCidade.Text;
                Comando.Parameters.Add("@telefone", MySqlDbType.VarChar, 100).Value = txtTelefone.Text;
                Comando.Parameters.Add("@email", MySqlDbType.VarChar, 100).Value = txtEmail.Text;
                Comando.Parameters.Add("fornecedor", MySqlDbType.Int32).Value = txtCodigo.Text;


                Comando.CommandType = CommandType.Text;
                Comando.ExecuteNonQuery();

                Carregar car = new Carregar();
                car.ShowDialog();

                    try
                    {
                        MySqlCommand Comando1 = new MySqlCommand("SELECT * FROM fornecedor", Conexao);
                        MySqlDataAdapter Adp = new MySqlDataAdapter(Comando1);
                        DataTable dt = new DataTable();
                        Adp.Fill(dt);
                        dataGridViewFor.DataSource = dt;
                        Conexao.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                MessageBox.Show("Fornecedor Atualizado com Sucesso!");
                Conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Falha ao Atualizar o Fornecedor" + erro);
            }
        }

        private void txtLogradouro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCnpj_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtCep_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}




