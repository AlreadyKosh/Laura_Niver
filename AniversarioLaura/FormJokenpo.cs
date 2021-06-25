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
    public partial class FormJokenpo : Form
    {
        public int pontos = 0, movimentos = 0;
        public int TokenJokenpo { get; private set; }

        public FormJokenpo()
        {
            InitializeComponent();
        }

        private void FormJokenpo_Load(object sender, EventArgs e)
        {

        }

        private void btnPedra_Click(object sender, EventArgs e)
        {
            StartGame(0);
        }

        private void btnPapel_Click(object sender, EventArgs e)
        {
            StartGame(2);
        }

        private void btnTesoura_Click(object sender, EventArgs e)
        {
            StartGame(1);
        }

        private void StartGame(int opcao)
        {
            labelResultado.Visible = false;

            Joken jogo = new Joken();

            switch (jogo.Jogar(opcao))
            {
                case Joken.Resultado.Ganhar:
                    picResultado.BackgroundImage = Properties.Resources.Ganhar;
                    pontos++;
                    goto default;
                case Joken.Resultado.Perder:
                    picResultado.BackgroundImage = Properties.Resources.Perder;

                    goto default;
                case Joken.Resultado.Empatar:
                    picResultado.BackgroundImage = Properties.Resources.Empatar;
                    goto default;
                
                default:
                    pictureBox1.Image = jogo.ImgJogador;
                    pictureBox2.Image = jogo.ImgPC;
                    movimentos++;
                    lblPontos.Text = "Pontos: " + pontos;
                    break;
            }

            if(movimentos == 10)
            {
                if(pontos >= 5)
                {
                    MessageBox.Show("Parabens Você venceu e ganhou seu mimlau Token");
                    TokenJokenpo++;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Infelizmente você perdeu!!");
                    DialogResult msg = MessageBox.Show("Deseja tentar novamente?", "Caixa de Pergunta", MessageBoxButtons.YesNo);


                    if (msg == DialogResult.Yes)
                    {
                        pontos = 0;
                        movimentos = 0;
                        lblPontos.Text = "Pontos: " + pontos;
                    }
                    else
                    {
                        if (msg == DialogResult.No)
                        {
                            MessageBox.Show("Obrigado por Jogar");
                            this.Close();
                        }
                    }
                }
            }
        }

    }
}
