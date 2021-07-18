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
    public partial class CadastroEmpresa : Form
    {
        public CadastroEmpresa()
        {
            InitializeComponent();
            ConsultaCNPJReceita.GetCaptcha(picLetras);

            txtCodigo.Enabled = false;
            txtCnpj.Enabled = false;
            txtLetras.Enabled = false;
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
            txtContatoSintegra.Enabled = false;
            txtIbge.Enabled = false;
            cbxPais.Enabled = false;
            cbxRegime.Enabled = false;
            cbxSituacao.Enabled = false;
            cbxNaturezaPJ.Enabled = false;
            txtPercentRegimeIcms.Enabled = false;
            txtCnae.Enabled = false;
            txtBaseReducaoIcms.Enabled = false;
            ckbRegimeIcms.Enabled = false;
            ckbBaseCalculo.Enabled = false;
            cbxAtividade.Enabled = false;
            ckbEscrituracaoFiscal.Enabled = false;
            cbxRegimePisCofins.Enabled = false;
            txtAliquotaCofins.Enabled = false;
            txtAliquotaPis.Enabled = false;
            btnConsultar.Enabled = false;
            btnExluir.Enabled = false;
            btnSalvar.Enabled = false;
            btnImagem.Enabled = false;
            checkBox2.Enabled = false;
            radioButton1.Enabled = false;
            radioButton3.Enabled = false;
            filialRdButton.Enabled = false;
            btnAlterar.Enabled = false;

            try
            {

                String Configuracao = "server=localhost;userid=root;pwd=nunespc;database=sistemanunespc;";
                MySqlConnection Conexao = new MySqlConnection(Configuracao);
                Conexao.Open();
                MySqlCommand Comando = new MySqlCommand("SELECT * FROM empresa", Conexao);
                MySqlDataAdapter Adp = new MySqlDataAdapter(Comando);
                DataTable dt = new DataTable();
                Adp.Fill(dt);
                dataGridViewEmp.DataSource = dt;

                Conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                String Configuracao = "server=localhost;userid=root;pwd=nunespc;database=sistemanunespc;";
                MySqlConnection Conexao = new MySqlConnection(Configuracao);
                Conexao.Open();
                MySqlCommand Comando = new MySqlCommand("SELECT * FROM pais", Conexao);
                MySqlDataAdapter Adp = new MySqlDataAdapter(Comando);
                DataTable dt = new DataTable();
                Adp.Fill(dt);

                this.cbxPais.ValueMember = "descricao";
                this.cbxPais.DisplayMember = "descricao";

                this.cbxPais.DataSource = dt;

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
                MySqlCommand Comando = new MySqlCommand("SELECT * FROM regime_tributario", Conexao);
                MySqlDataAdapter Adp = new MySqlDataAdapter(Comando);
                DataTable dt = new DataTable();
                Adp.Fill(dt);

                this.cbxRegime.ValueMember = "descricao";
                this.cbxRegime.DisplayMember = "descricao";

                this.cbxRegime.DataSource = dt;

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
                MySqlCommand Comando = new MySqlCommand("SELECT * FROM situacao_tributario", Conexao);
                MySqlDataAdapter Adp = new MySqlDataAdapter(Comando);
                DataTable dt = new DataTable();
                Adp.Fill(dt);

                this.cbxSituacao.ValueMember = "descricao";
                this.cbxSituacao.DisplayMember = "descricao";

                this.cbxSituacao.DataSource = dt;

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
                MySqlCommand Comando = new MySqlCommand("SELECT * FROM indicador_natureza_pj", Conexao);
                MySqlDataAdapter Adp = new MySqlDataAdapter(Comando);
                DataTable dt = new DataTable();
                Adp.Fill(dt);

                this.cbxNaturezaPJ.ValueMember = "descricao";
                this.cbxNaturezaPJ.DisplayMember = "descricao";

                this.cbxNaturezaPJ.DataSource = dt;

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
                MySqlCommand Comando = new MySqlCommand("SELECT * FROM tipo_atividade", Conexao);
                MySqlDataAdapter Adp = new MySqlDataAdapter(Comando);
                DataTable dt = new DataTable();
                Adp.Fill(dt);

                this.cbxAtividade.ValueMember = "descricao";
                this.cbxAtividade.DisplayMember = "descricao";

                this.cbxAtividade.DataSource = dt;

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
                MySqlCommand Comando = new MySqlCommand("SELECT * FROM regime_piscofins", Conexao);
                MySqlDataAdapter Adp = new MySqlDataAdapter(Comando);
                DataTable dt = new DataTable();
                Adp.Fill(dt);

                this.cbxRegimePisCofins.ValueMember = "descricao";
                this.cbxRegimePisCofins.DisplayMember = "descricao";

                this.cbxRegimePisCofins.DataSource = dt;

                Conexao.Close();
            }
            catch
            {
            }


        }
        DataTable dataset;
        private void frmConsultaCNPJ_Load(object sender, EventArgs e)
        {
            CarregaCaptcha();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void CadastroEmpresa_Load(object sender, EventArgs e)
        {
            
        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void txtUf_TextChanged(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void txtTelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void circularProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ConsultaCNPJ();
        }

        private void btnImagem_Click(object sender, EventArgs e)
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
            txtContatoSintegra.Enabled = true;
            txtIbge.Enabled = true;
            cbxPais.Enabled = true;
            cbxRegime.Enabled = true;
            cbxSituacao.Enabled = true;
            cbxNaturezaPJ.Enabled = true;
            txtPercentRegimeIcms.Enabled = true;
            txtCnae.Enabled = true;
            txtBaseReducaoIcms.Enabled = true;
            ckbRegimeIcms.Enabled = true;
            ckbBaseCalculo.Enabled = true;
            cbxAtividade.Enabled = true;
            ckbEscrituracaoFiscal.Enabled = true;
            cbxRegimePisCofins.Enabled = true;
            txtAliquotaCofins.Enabled = true;
            txtAliquotaPis.Enabled = true;
            btnConsultar.Enabled = true;
            btnExluir.Enabled = true;
            btnSalvar.Enabled = true;
            btnImagem.Enabled = true;
            checkBox2.Enabled = true;
            radioButton1.Enabled = true;
            radioButton3.Enabled = true;
            filialRdButton.Enabled = true;
            btnAlterar.Enabled = true;

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
            txtContatoSintegra.Text = "";
            txtIbge.Text = "";
            cbxPais.Text = "";
            cbxRegime.Text = "";
            cbxSituacao.Text = "";
            cbxNaturezaPJ.Text = "";
            txtPercentRegimeIcms.Text = "";
            txtCnae.Text = "";
            txtBaseReducaoIcms.Text = "";
            ckbRegimeIcms.Checked = false;
            ckbBaseCalculo.Checked = false;
            cbxAtividade.Text = "";
            ckbEscrituracaoFiscal.Checked = false;
            cbxRegimePisCofins.Text = "";
            txtAliquotaCofins.Text = "";
            txtAliquotaPis.Text = "";

            String Configuracao = "server=localhost;userid=root;pwd=nunespc;database=sistemanunespc;";
            MySqlConnection Conexao = new MySqlConnection(Configuracao);
            Conexao.Open();
            Carregar car = new Carregar();
            car.ShowDialog();
            MySqlCommand Comando = new MySqlCommand("Select MAX(id+ 1) From empresa", Conexao);
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
            String contato_sintegra = txtContatoSintegra.Text;
            String ibge = txtIbge.Text;
            String pais = cbxPais.SelectedValue.ToString();
            String registro_tributario = cbxRegime.SelectedValue.ToString();
            String situacao_tributaria = cbxSituacao.SelectedValue.ToString();
            String indicador_natureza_pj = cbxNaturezaPJ.SelectedValue.ToString();
            String tipo_atividade = cbxAtividade.SelectedValue.ToString();
            String percentual_regime_icms = txtPercentRegimeIcms.Text;
            String cnae = txtCnae.Text;
            String percentual_base_reducao_icms = txtBaseReducaoIcms.Text;
            String base_calculo_icms_reduzida = ckbBaseCalculo.Checked.ToString();
            String regime_icms = ckbRegimeIcms.Checked.ToString();
            String escrituracao_fiscal = ckbEscrituracaoFiscal.Checked.ToString();
            String aliquota = txtAliquotaPis.Text;
            String aliquota_cofins = txtAliquotaCofins.Text;

            try
            {
                String Configuracao = "server=localhost;userid=root;pwd=nunespc;database=sistemanunespc;";
                MySqlConnection Conexao = new MySqlConnection(Configuracao);
                Conexao.Open();
                MySqlCommand Comando = new MySqlCommand("INSERT INTO empresa (cnpj,razaosocial,nomefantasia,IE,Inscricaomuni,logradouro,cep,numero,bairro,cidade,estado,complemento,telefone,email,contato_sintegra,ibge,pais,registro_tributario,situacao_tributaria,indicador_natureza_pj,tipo_atividade,percentual_regime_icms,cnae,percentual_base_reducao_icms,base_calculo_icms_reduzida,regime_icms,escrituracao_fiscal,regime_pis_cofins,aliquota,aliquota_cofins)" + "VALUES('" + this.txtCnpj.Text + "','" + this.txtRazaoSocial.Text + "','" + this.txtNomeFantasia.Text + "','" + this.txtIE.Text + "','" + this.txtIM.Text + "','" + this.txtLogradouro.Text + "','" + this.txtCep.Text + "','" + this.txtNumero.Text + "','" + this.txtBairro.Text + "','" + this.txtCidade.Text + "','" + this.txtUf.Text + "','" + this.txtComplemento.Text + "','" + this.txtTelefone.Text + "','" + this.txtEmail.Text + "','" + this.txtContatoSintegra.Text + "','" + this.txtIbge.Text + "','" + this.cbxPais.SelectedValue + "','" + this.cbxRegime.SelectedValue + "','" + this.cbxSituacao.SelectedValue + "','" + this.cbxNaturezaPJ.SelectedValue + "','" + this.cbxAtividade.SelectedValue + "','" + this.txtPercentRegimeIcms.Text + "','" + this.txtCnae.Text + "','" + this.txtBaseReducaoIcms.Text + "','" + this.ckbBaseCalculo.Checked.ToString() + "','" + this.ckbRegimeIcms.Checked.ToString() + "','" + this.ckbEscrituracaoFiscal.Checked.ToString() + "','" + this.cbxRegimePisCofins.SelectedValue + "','" + this.txtAliquotaPis.Text + "','" + this.txtAliquotaCofins.Text + "')", Conexao);
                Comando.ExecuteNonQuery();
                Carregar car = new Carregar();
                car.ShowDialog();

                try
                {
                    MySqlCommand Comando1 = new MySqlCommand("SELECT * FROM empresa", Conexao);
                    MySqlDataAdapter Adp = new MySqlDataAdapter(Comando1);
                    DataTable dt = new DataTable();
                    Adp.Fill(dt);
                    dataGridViewEmp.DataSource = dt;
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
                txtLetras.Text = "";
                picLetras.Text = "";
                txtContatoSintegra.Text = "";
                txtIbge.Text = "";
                cbxPais.Text = "";
                cbxRegime.Text = "";
                cbxSituacao.Text = "";
                cbxNaturezaPJ.Text = "";
                txtPercentRegimeIcms.Text = "";
                txtCnae.Text = "";
                txtBaseReducaoIcms.Text = "";
                ckbRegimeIcms.Text = "";
                ckbBaseCalculo.Text = "";
                cbxAtividade.Text = "";
                ckbEscrituracaoFiscal.Text = "";
                cbxRegimePisCofins.Text = "";
                txtAliquotaCofins.Text = "";
                txtAliquotaPis.Text = "";


                Conexao.Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + Convert.ToString(ex), "Aviso");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                String Configuracao = "server=localhost;userid=root;pwd=nunespc;database=sistemanunespc;";
                MySqlConnection Conexao = new MySqlConnection(Configuracao);
                Conexao.Open();
                MySqlCommand Comando = new MySqlCommand("UPDATE empresa SET cnpj = ?, razaosocial = ?, nomefantasia = ?, IE = ?, Inscricaomuni = ?, cep = ?, logradouro = ?, numero = ?, complemento = ?, bairro = ?, estado = ?, cidade = ?, telefone = ?, email = ?, contato_sintegra = ?, ibge = ?, pais= ?, registro_tributario = ?, situacao_tributaria = ?, indicador_natureza_pj = ?, tipo_atividade = ?, percentual_regime_icms = ?, cnae = ?, percentual_base_reducao_icms = ?, base_calculo_icms_reduzida = ?, regime_icms = ?, escrituracao_fiscal = ?, regime_pis_cofins = ?, aliquota = ?, aliquota_cofins = ? WHERE id = ?", Conexao);

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
                Comando.Parameters.Add("@contato_sintegra", MySqlDbType.VarChar, 100).Value = txtContatoSintegra.Text;
                Comando.Parameters.Add("@ibge", MySqlDbType.VarChar, 100).Value = txtIbge.Text.ToString();
                Comando.Parameters.Add("@pais", MySqlDbType.VarChar, 100).Value = cbxPais.SelectedValue;
                Comando.Parameters.Add("@registro_tributario", MySqlDbType.VarChar, 200).Value = cbxRegime.SelectedValue;
                Comando.Parameters.Add("@situacao_tributaria", MySqlDbType.VarChar, 200).Value = cbxSituacao.SelectedValue;
                Comando.Parameters.Add("@indicador_natureza_pj", MySqlDbType.VarChar, 200).Value = cbxNaturezaPJ.SelectedValue;
                Comando.Parameters.Add("@tipo_atividade", MySqlDbType.VarChar, 200).Value = cbxAtividade.SelectedValue;
                Comando.Parameters.Add("@percentual_regime_icms", MySqlDbType.VarChar, 200).Value = txtPercentRegimeIcms.Text;
                Comando.Parameters.Add("@cnae", MySqlDbType.VarChar, 100).Value = txtCnae.Text;
                Comando.Parameters.Add("@percentual_base_reducao_icms", MySqlDbType.VarChar, 200).Value = txtBaseReducaoIcms.Text;
                Comando.Parameters.Add("@base_calculo_icms_reduzida", MySqlDbType.VarChar, 200).Value = ckbBaseCalculo.Checked;
                Comando.Parameters.Add("@regime_icms", MySqlDbType.VarChar, 200).Value = ckbRegimeIcms.Checked;
                Comando.Parameters.Add("@escrituracao_fiscal", MySqlDbType.VarChar, 200).Value = ckbEscrituracaoFiscal.Checked;
                Comando.Parameters.Add("@regime_pis_cofins", MySqlDbType.VarChar, 200).Value = cbxRegimePisCofins.SelectedValue;
                Comando.Parameters.Add("@aliquota", MySqlDbType.VarChar, 200).Value = txtAliquotaPis.Text;
                Comando.Parameters.Add("@aliquota_cofins", MySqlDbType.VarChar, 200).Value = txtAliquotaCofins.Text;
                Comando.Parameters.Add("empresa", MySqlDbType.Int32).Value = txtCodigo.Text;

                 Comando.CommandType = CommandType.Text;
                Comando.ExecuteNonQuery();

                Carregar car = new Carregar();
                car.ShowDialog();

                try
                {
                    MySqlCommand Comando1 = new MySqlCommand("SELECT * FROM empresa", Conexao);
                    MySqlDataAdapter Adp = new MySqlDataAdapter(Comando1);
                    DataTable dt = new DataTable();
                    Adp.Fill(dt);
                    dataGridViewEmp.DataSource = dt;
                    Conexao.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                MessageBox.Show("Empresa Atualizado com Sucesso!");
                Conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Falha ao Atualizar o Empresa" + erro);
            }
        }

        private void dataGridViewEmp_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
            txtContatoSintegra.Enabled = true;
            txtIbge.Enabled = true;
            cbxPais.Enabled = true;
            cbxRegime.Enabled = true;
            cbxSituacao.Enabled = true;
            cbxNaturezaPJ.Enabled = true;
            txtPercentRegimeIcms.Enabled = true;
            txtCnae.Enabled = true;
            txtBaseReducaoIcms.Enabled = true;
            ckbRegimeIcms.Enabled = true;
            ckbBaseCalculo.Enabled = true;
            cbxAtividade.Enabled = true;
            ckbEscrituracaoFiscal.Enabled = true;
            cbxRegimePisCofins.Enabled = true;
            txtAliquotaCofins.Enabled = true;
            txtAliquotaPis.Enabled = true;

            txtCodigo.Text = dataGridViewEmp["codigo", e.RowIndex].Value.ToString();
            txtCnpj.Text = dataGridViewEmp["cnpj", e.RowIndex].Value.ToString();
            txtRazaoSocial.Text = dataGridViewEmp["razaosocial", e.RowIndex].Value.ToString();
            txtNomeFantasia.Text = dataGridViewEmp["nomefantasia", e.RowIndex].Value.ToString();
            txtIE.Text = dataGridViewEmp["IE", e.RowIndex].Value.ToString();
            txtIM.Text = dataGridViewEmp["Inscricaomuni", e.RowIndex].Value.ToString();
            txtCep.Text = dataGridViewEmp["cep", e.RowIndex].Value.ToString();
            txtLogradouro.Text = dataGridViewEmp["logradouro", e.RowIndex].Value.ToString();
            txtNumero.Text = dataGridViewEmp["numero", e.RowIndex].Value.ToString();
            txtComplemento.Text = dataGridViewEmp["complemento", e.RowIndex].Value.ToString();
            txtBairro.Text = dataGridViewEmp["bairro", e.RowIndex].Value.ToString();
            txtUf.Text = dataGridViewEmp["estado", e.RowIndex].Value.ToString();
            txtCidade.Text = dataGridViewEmp["cidade", e.RowIndex].Value.ToString();
            txtTelefone.Text = dataGridViewEmp["telefone", e.RowIndex].Value.ToString();
            txtEmail.Text = dataGridViewEmp["email", e.RowIndex].Value.ToString();
            txtContatoSintegra.Text = dataGridViewEmp["contato_sintegra", e.RowIndex].Value.ToString();
            txtIbge.Text = dataGridViewEmp["ibge", e.RowIndex].Value.ToString();
            cbxPais.Text = dataGridViewEmp["pais", e.RowIndex].Value.ToString();
            cbxRegime.Text = dataGridViewEmp["registro_tributario", e.RowIndex].Value.ToString();
            cbxSituacao.Text = dataGridViewEmp["situacao_tributaria", e.RowIndex].Value.ToString();
            cbxNaturezaPJ.Text = dataGridViewEmp["indicador_natureza_pj", e.RowIndex].Value.ToString();
            txtPercentRegimeIcms.Text = dataGridViewEmp["percentual_regime_icms", e.RowIndex].Value.ToString();
            txtCnae.Text = dataGridViewEmp["cnae", e.RowIndex].Value.ToString();
            txtBaseReducaoIcms.Text = dataGridViewEmp["percentual_base_reducao_icms", e.RowIndex].Value.ToString();
            ckbRegimeIcms.Checked = dataGridViewEmp["regime_icms", e.RowIndex].Value.Equals("True");
            ckbBaseCalculo.Checked = dataGridViewEmp["base_calculo_icms_reduzida", e.RowIndex].Value.Equals("True");
            cbxAtividade.Text = dataGridViewEmp["tipo_atividade", e.RowIndex].Value.ToString();
            ckbEscrituracaoFiscal.Checked = dataGridViewEmp["escrituracao_fiscal", e.RowIndex].Value.Equals("True");
            cbxRegimePisCofins.Text = dataGridViewEmp["regime_pis_cofins", e.RowIndex].Value.ToString();
            txtAliquotaCofins.Text = dataGridViewEmp["aliquota", e.RowIndex].Value.ToString();
            txtAliquotaPis.Text = dataGridViewEmp["aliquota_cofins", e.RowIndex].Value.ToString();
        }

        private void btnExluir_Click(object sender, EventArgs e)
        {
            try
            {
                String Configuracao = "server=localhost;userid=root;pwd=nunespc;database=sistemanunespc;";
                MySqlConnection Conexao = new MySqlConnection(Configuracao);
                Conexao.Open();
                MySqlCommand Comando = new MySqlCommand("DELETE FROM empresa WHERE id ='" + this.txtCodigo.Text + "';", Conexao);
                Comando.Parameters.Clear();
                Comando.CommandType = CommandType.Text;
                Comando.ExecuteNonQuery();
                var dialogResult = MessageBox.Show("Deseja excluir o registro selecionado?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                Carregar car = new Carregar();
                car.ShowDialog();

                try
                {
                    MySqlCommand Comando1 = new MySqlCommand("SELECT * FROM empresa", Conexao);
                    MySqlDataAdapter Adp = new MySqlDataAdapter(Comando1);
                    DataTable dt = new DataTable();
                    Adp.Fill(dt);
                    dataGridViewEmp.DataSource = dt;
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

        private void picLetras_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}
