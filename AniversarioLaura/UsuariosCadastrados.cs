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
        

        private static Usuario Usuarios = new Usuario() { Nome = "Laura Lima", Senha = "abacaxi123" };

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
       
        public static bool Login(string nome, string senha)
        {
            if(nome == Usuarios.Nome && senha == Usuarios.Senha)
            {
                usuarioLogado = Usuarios;
                return true;
            }
            return false;
        }

        
    }
}
