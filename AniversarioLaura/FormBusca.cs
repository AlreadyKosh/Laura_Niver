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
    public partial class FormBusca : Form
    {
        public FormBusca()
        {
            InitializeComponent();
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            Resultado.Rows.Clear();

            string strConnection = "Server=127.0.0.1;User ID=root;database=contas_db;password=1213141516.";
            MySqlConnection conexao = new MySqlConnection(strConnection);

            try
            {
              
                string query = "SELECT nome_usuario, email_usuario, cidade_usuario FROM tb_usuarios";
                
                if (txtProcurar.Text != "")
                {
                    query = "SELECT nome_usuario, email_usuario, cidade_usuario FROM tb_usuarios WHERE nome_usuario LIKE '" + txtProcurar.Text + "'";
                }


                DataTable dados = new DataTable();
                MySqlDataAdapter adaptador = new MySqlDataAdapter(query, strConnection);

                conexao.Open();

                adaptador.Fill(dados);

                foreach (DataRow linha in dados.Rows)
                {
                    Resultado.Rows.Add(linha.ItemArray);
                }

            }
            catch (Exception ex)
            {
                Resultado.Rows.Clear();
                MessageBox.Show("Dado não encontrado " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
