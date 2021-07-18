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
    public partial class Localizar : Form
    {
        int tipoPesquisa;
        

        public Localizar()
        {
            InitializeComponent();
            try
            {
                String Configuracao = "server=localhost;userid=root;pwd=nunespc;database=sistemanunespc;";
                MySqlConnection Conexao = new MySqlConnection(Configuracao);
                Conexao.Open();
                MySqlCommand Comando = new MySqlCommand("SELECT * FROM natureza_operacao", Conexao);
                MySqlDataAdapter Adp = new MySqlDataAdapter(Comando);
                DataTable dt = new DataTable();
                Adp.Fill(dt);
                dataGridViewLoca.DataSource = dt;


                Conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        DataTable dataset;

        private void Localizar_Load(object sender, EventArgs e)
        {

        }
        private void ButEnviar_Click(object sender, EventArgs e)
        {
            
        }
        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridViewLoca.SelectedRows.Count == 1)
            {
                //ButEnviar.PerformClick();
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            //carregando o Grid
            var lista1 = new
            {
                id_cfop_consu = 1,
                Nome = "cfop_consumo"
            };
            var lista2 = new
            {
                id_cfop_consu = 2,
                Nome = "cfop_consumo"
            };
            Array listaTotal = Array.CreateInstance(lista1.GetType(), 2);
            listaTotal.SetValue(lista1, 0);
            listaTotal.SetValue(lista2, 1);

            dataGridViewLoca.MultiSelect = false;
            dataGridViewLoca.AutoGenerateColumns = false;
            dataGridViewLoca.DataSource = listaTotal;
            dataGridViewLoca.Update();
            //carregando o Grid
        }
    



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            


            NaturezaOperacao cf = new NaturezaOperacao(lblCFOPConsu.Text = dataGridViewLoca["cfop_consumo", e.RowIndex].Value.ToString());
            cf.Show();
                         

             txtCFOPConsu.Text = dataGridViewLoca["id_cfop_consumo", e.RowIndex].Value.ToString();
             txtCFOPForaEsta.Text = dataGridViewLoca["id_cfop_fora_estado", e.RowIndex].Value.ToString();
             txtCFOPRev.Text = dataGridViewLoca["id_cfop_revenda", e.RowIndex].Value.ToString();
             txtCodigo.Text = dataGridViewLoca["codigo_cfop", e.RowIndex].Value.ToString();
             txtDescricao.Text = dataGridViewLoca["descricao", e.RowIndex].Value.ToString();
             checkBoxICMS.Checked = dataGridViewLoca["destacaricms", e.RowIndex].Value.Equals("True");
             lblCFOPConsu.Text = dataGridViewLoca["cfop_consumo", e.RowIndex].Value.ToString();
             lblCFOPForaEsta.Text = dataGridViewLoca["cfop_fora_estado", e.RowIndex].Value.ToString();
             lblCFOPRev.Text = dataGridViewLoca["cfop_revenda", e.RowIndex].Value.ToString();
             cbxTipo.SelectedItem = dataGridViewLoca["tipo_", e.RowIndex].Value.ToString();
             cbxUso.SelectedItem = dataGridViewLoca["uso_", e.RowIndex].Value.ToString();

             /*CFOP cf = new CFOP();
             cf.ShowDialog();

             txtCFOPConsu.Text = dataGridViewLoca.SelectedRows[0].Cells[0].Value.ToString();
             txtCFOPForaEsta.Text = dataGridViewLoca["id_cfop_fora_estado", e.RowIndex].Value.ToString();
             txtCFOPRev.Text = dataGridViewLoca["id_cfop_revenda", e.RowIndex].Value.ToString();
             txtCodigo.Text = dataGridViewLoca["codigo_cfop", e.RowIndex].Value.ToString();
             txtDescricao.Text = dataGridViewLoca["descricao", e.RowIndex].Value.ToString();
             lblCFOPConsu.Text = dataGridViewLoca["cfop_consumo", e.RowIndex].Value.ToString();
             lblCFOPForaEsta.Text = dataGridViewLoca["cfop_fora_estado", e.RowIndex].Value.ToString();
             lblCFOPRev.Text = dataGridViewLoca["cfop_revenda", e.RowIndex].Value.ToString();
             cbxTipo.SelectedItem = dataGridViewLoca["tipo_", e.RowIndex].Value.ToString();
             cbxUso.SelectedItem = dataGridViewLoca["uso_", e.RowIndex].Value.ToString();

             cf.Close();



                 cf.valor1 = dataGridViewLoca["id", e.RowIndex].Value.ToString();
                 cf.valor2 = dataGridViewLoca["descricao", e.RowIndex].Value.ToString();


             /*cf.txtCFOPConsu = dataGridViewLoca.Rows[e.RowIndex].Cells[0].Value.ToString();
             cf.lblCFOPConsu = dataGridViewLoca.Rows[e.RowIndex].Cells[1].Value.ToString();*/


        }

        private void txtDescricaoLoca_TextChanged(object sender, EventArgs e)
        {
            if (cbxBuscar.Text == "CFOP")
            {
                String Configuracao = "server=localhost;userid=root;pwd=nunespc;database=sistemanunespc;";
                MySqlConnection Conexao = new MySqlConnection(Configuracao);
                Conexao.Open();
                MySqlCommand Comando = new MySqlCommand("SELECT * FROM natureza_operacao", Conexao);
                MySqlDataAdapter dta = new MySqlDataAdapter();
                dta.SelectCommand = Comando;
                dataset = new DataTable();
                dta.Fill(dataset);
                BindingSource bs = new BindingSource();

                bs.DataSource = dataset;
                dataGridViewLoca.DataSource = bs;
                dta.Update(dataset);
                DataView dv = new DataView(dataset);
                dv.RowFilter = String.Format("Convert(id, 'System.String') LIKE '" + txtCriterio.Text + "*'");
                dataGridViewLoca.DataSource = dv;
            }
            if (cbxBuscar.Text == "Descrição")
            {
                String Configuracao = "server=localhost;userid=root;pwd=nunespc;database=sistemanunespc;";
                MySqlConnection Conexao = new MySqlConnection(Configuracao);
                Conexao.Open();
                MySqlCommand Comando = new MySqlCommand("SELECT * FROM natureza_operacao", Conexao);
                MySqlDataAdapter dta = new MySqlDataAdapter();
                dta.SelectCommand = Comando;
                dataset = new DataTable();
                dta.Fill(dataset);
                BindingSource bs = new BindingSource();

                bs.DataSource = dataset;
                dataGridViewLoca.DataSource = bs;
                dta.Update(dataset);
                DataView dv = new DataView(dataset);
                dv.RowFilter = String.Format("Convert(descricao, 'System.String') LIKE '" + txtCriterio.Text + "*'");
                dataGridViewLoca.DataSource = dv;
            }
        }



        private void txtCodigoLoca_TextChanged(object sender, EventArgs e)
        {



        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ButEnviar_Click_1(object sender, EventArgs e)
        {
            //Pegando valores do DataGridView e jogando no formulário que chamou
            //Esse é uma maneira de fazer !!!
            if (dataGridViewLoca.SelectedRows.Count == 1)
            {
                NaturezaOperacao cf= Application.OpenForms["NaturezaOperacao"] as NaturezaOperacao;
                if (cf != null)
                {
                    TextBox txtCFOPConsu = cf.Controls["id_cfop_consu"] as TextBox;
                    TextBox lblCFOPConsu = cf.Controls["cfop_consumo"] as TextBox;
                    /*TextBox txtCFOPForaEsta = cf.Controls["id_cfop_fora_estado"] as TextBox;
                    TextBox txtCFOPRev = cf.Controls["id_cfop_revenda"] as TextBox;
                    TextBox txtCodigo = cf.Controls["codigo_cfop"] as TextBox;
                    TextBox txtDescricao = cf.Controls["descricao"] as TextBox;
                    
                    TextBox lblCFOPForaEsta = cf.Controls["cfop_fora_estado"] as TextBox;
                    TextBox lblCFOPRev = cf.Controls["cfop_revenda"] as TextBox;
                    TextBox cbxTipo = cf.Controls["tipo_"] as TextBox;
                    TextBox cbxUso = cf.Controls["uso_"] as TextBox;*/
                    if (txtCFOPConsu != null && lblCFOPConsu != null )
                    {
                        txtCFOPConsu.Text = dataGridViewLoca.SelectedRows[0].Cells[1].Value.ToString();
                        /*txtCFOPForaEsta.Text = dataGridViewLoca.SelectedRows[0].Cells[1].Value.ToString();
                        txtCFOPRev.Text = dataGridViewLoca.SelectedRows[0].Cells[2].Value.ToString();
                        txtCodigo.Text = dataGridViewLoca.SelectedRows[0].Cells[3].Value.ToString();
                        txtDescricao.Text = dataGridViewLoca.SelectedRows[0].Cells[4].Value.ToString();*/
                        lblCFOPConsu.Text = dataGridViewLoca.SelectedRows[0].Cells[5].Value.ToString();
                        /*lblCFOPForaEsta.Text = dataGridViewLoca.SelectedRows[0].Cells[6].Value.ToString();
                        lblCFOPRev.Text = dataGridViewLoca.SelectedRows[0].Cells[7].Value.ToString();
                        cbxTipo.SelectedText = dataGridViewLoca.SelectedRows[0].Cells[8].Value.ToString();
                        cbxUso.SelectedText = dataGridViewLoca.SelectedRows[0].Cells[9].Value.ToString();*/
                        this.Close();
                    }
                }
            }
            //Esse é uma maneira de fazer !!!
        }
    }
}
