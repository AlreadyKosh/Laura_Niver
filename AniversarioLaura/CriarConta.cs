using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AniversarioLaura
{
    public partial class CriarConta : Form
    {
        public CriarConta()
        {
            InitializeComponent();
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            string strConnection = "Server=127.0.0.1;User ID=root;database=contas_db;password=1213141516.";
            MySqlConnection conexao = new MySqlConnection(strConnection);

          
            try
            {
                conexao.Open();

                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexao;
                

                int id_usuario = 0;
                string nome_usuario = txtNome.Text;
                string email_usuario = txtEmail.Text;
                string senha_usuario = txtSenha.Text;
                string cidade_usuario = txtCidade.Text;


                comando.CommandText = "INSERT INTO tb_usuarios VALUES(" + id_usuario + ",'" + nome_usuario + "', '" + email_usuario + "', '" + senha_usuario + "','" + cidade_usuario + "')";
                comando.ExecuteNonQuery();

                MessageBox.Show("Conta Criada com Sucesso","Informação",MessageBoxButtons.OK,MessageBoxIcon.Warning);

                txtNome.Text = "";
                txtEmail.Text = "";
                txtCidade.Text = "";
                txtSenha.Text = "";
                txtNome.Focus();

                comando.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel Criar a conta" + ex.Message);
            }
            finally
            {
                conexao.Close();
            }

        }

       
    }
}
