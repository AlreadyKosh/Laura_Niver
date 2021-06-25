using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AniversarioLaura
{
    public partial class FormPremioLogin : Form
    {
        public FormPremioLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string nome = txtUsuario.Text;
            string senha = txtSenha.Text;

            if (UsuariosCadastrados.Login(nome, senha))
            {
                FormPremio Premio = new FormPremio();
                Premio.ShowDialog();
            }
            else
            {
                MessageBox.Show("Acesso Negado", "Não foi Possivel fazer Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Text = "";
                txtSenha.Text = "";
                txtUsuario.Focus();
            }
        }
    }
}
