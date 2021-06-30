using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using MySql.Data.MySqlClient;

namespace AniversarioLaura
{
    public partial class FormLogin : Form
    {
        public int token;
        public SoundPlayer inicio = new SoundPlayer(Properties.Resources.Musica_fundo);
        public bool Logado { get; private set; } = false;



        public FormLogin()
        {
            InitializeComponent();
            
            inicio.Play();
        }



        #region Botão Entrar
        private void btnEntrar_Click(object sender, EventArgs e)
        {
           

            bool resultado = VerificaLogin();

            Logado = resultado;

            if (resultado)
            {

                MessageBox.Show("Seja bem vindo!","Login feito com Sucesso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();

            }
            else
            {
                MessageBox.Show("Usuário ou Senha incorreto!","Não foi possivel fazer login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion


        #region Help Button
        private void FormLogin_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            Hide();

            FormHelp help = new FormHelp();
            help.ShowDialog();

            Show();
        }
        #endregion


        private void btnCriar_Click(object sender, EventArgs e)
        {
            Hide();

            CriarConta criar = new CriarConta();
            inicio.Stop();
            criar.ShowDialog();
            inicio.Play();
            Show();

        }

        #region LOGIN
        private bool VerificaLogin()
        {
            bool resultado = false;
            string strConnection = "Server=127.0.0.1;User ID=root;database=contas_db;password=1213141516.";
            MySqlConnection conexao = new MySqlConnection(strConnection);


            try
            {
                MySqlCommand comando = new MySqlCommand("SELECT * FROM tb_usuarios WHERE nome_usuario LIKE '" + txtUsuario.Text + "' AND senha_usuario LIKE'" + txtSenha.Text + "'");
                conexao.Open();
                comando.Connection = conexao;


                MySqlDataReader dados = comando.ExecuteReader();
                resultado = dados.HasRows;
                comando.Dispose();

            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conexao.Close();
            }

            return resultado;
        }
        #endregion

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Logado)
            {
                this.Close();
            }
            else
            {
                Application.Exit();
            }

            inicio.Stop();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }

}
