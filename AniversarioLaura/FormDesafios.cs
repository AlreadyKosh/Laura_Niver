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
    public partial class FormDesafios : Form
    {
        public int TokenFinal { get; private set; }
        public FormDesafios()
        {
            InitializeComponent();
        }

        #region Suzi
        private void btnRescue_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ATENÇÃO!! PARA CONSEGUIR O TOKEN VOCÊ PRECISAR MATAR 30 ZUMBIS","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
            
            FormSuzi Suzi = new FormSuzi();
            Suzi.ShowDialog();

            if (Suzi.TokenSuzi >= 1)
            {
                TokenFinal++;
                lblTokens.Text = "mimlau Tokens: " + TokenFinal;
                Final();
            }
        }
        #endregion

        #region Memoria

        private void btnMemoria_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ATENÇÃO!! PARA CONSEGUIR O TOKEN VOCÊ PRECISAR TERMINAR O JOGO EM 17 MOVIMENTOS OU MENOS", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            FormMemoria Memoria = new FormMemoria();
            Memoria.ShowDialog();

            if (Memoria.TokenMemoria >= 1) 
            {
                TokenFinal++;
                lblTokens.Text = "mimlau Tokens: "+TokenFinal;
                Final();

            }
        }
        #endregion

        #region Jokenpo
        private void btnJokenpo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ATENÇÃO!! PARA CONSEGUIR O TOKEN VOCÊ PRECISA GANHAR 5 VEZES EM 10 MOVIMENTOS", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            FormJokenpo jokenpo = new FormJokenpo();
            jokenpo.ShowDialog();

            if(jokenpo.TokenJokenpo >= 1)
            {
                TokenFinal++;
                lblTokens.Text = "mimlau Tokens: " + TokenFinal;
                Final();
               
            }
        }
        #endregion

        #region Final
        private void Final()
        {

            if (TokenFinal >= 3)
            {
                btnFinal.Visible = true;
            }
        }
        #endregion



        private void btnFinal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ATENÇÃO!! PARA CONSEGUIR O PREMIO, ACERTE TODAS AS CHARADAS!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FormCharada charada = new FormCharada();
            charada.ShowDialog();
        }

        private void FormDesafios_Load(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.ShowDialog();
        }
    }
}
