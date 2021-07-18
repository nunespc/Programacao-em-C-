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
    public partial class Login : Form
    {
       public Login()
        {
            
            InitializeComponent();
            txtSenha.Text = "";
            txtSenha.PasswordChar = '*';
            txtUsuario.Text.ToUpper();
        }
        public static string userConectado;
        public static string nivelAcesso;

        private void button1_Click(object sender, EventArgs e)
        {
            String usuario = txtUsuario.Text.ToUpper();
            String senha = txtSenha.Text;

            String Configuracao = "server=localhost;userid=root;pwd=nunespc;database=sistemanunespc;";
            MySqlConnection Conexao = new MySqlConnection(Configuracao);
            try
            {

                MySqlCommand Comando = new MySqlCommand("SELECT * FROM usuario WHERE usuario=@usuario and senha=@senha", Conexao);
                Comando.Parameters.Add("@usuario", MySqlDbType.VarChar).Value = txtUsuario.Text;
                Comando.Parameters.Add("@senha", MySqlDbType.VarChar).Value = txtSenha.Text;
                Conexao.Open();
                MySqlDataReader reader = Comando.ExecuteReader();
                if (reader.Read())
                {
                    this.Hide();
                    userConectado = txtUsuario.Text.ToUpper();
                    Carregar c = new Carregar();
                    c.ShowDialog();
                    frInicio f = new frInicio();
                    f.Show();
                }
                else
                {
                    MessageBox.Show("Usuario e/ou Senha Invalido");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + Convert.ToString(ex), "Aviso");
            }
            Conexao.Close();
         }  
        

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
