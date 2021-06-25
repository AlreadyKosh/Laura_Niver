using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;



namespace AniversarioLaura
{
    class UsuariosCadastrados
    {
        
        /*

        private static Usuario Usuarios = new Usuario() { Nome = "Laura Lima", Senha = "abacaxi123" };

        private static Usuario Usuarios2 = new Usuario();



        private static Usuario usuarioLogado;

        public static Usuario Logado
        {
            get
            {
                return usuarioLogado;
            }
            private set
            {
                usuarioLogado = value;
            }
        }
        public void ConsultarBanco()
        {
            string strConnection = "Server=127.0.0.1;User ID=root;database=contas_db;password=1213141516.";
            MySqlConnection conexao = new MySqlConnection(strConnection);

            conexao.Open();

            MySqlCommand consulta = new MySqlCommand();
            consulta.Connection = conexao;

            consulta.CommandText = "SELECT * FROM tb_usuarios";

            MySqlDataReader Resultado = consulta.ExecuteReader();

            
            string query = "SELECT * FROM tb_usuarios";

           

        }

        public static bool Login(string nome, string senha)
        {
            if(nome == Usuarios.Nome && senha == Usuarios.Senha)
            {
                usuarioLogado = Usuarios;
                return true;
            }
            return false;
        }

        */
    }
}
