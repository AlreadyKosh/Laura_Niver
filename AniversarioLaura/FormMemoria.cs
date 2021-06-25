using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace AniversarioLaura
{
    public partial class FormMemoria : Form
    {

        #region Variaveis
        int movimentos, cliques, Pontos, tagI, Pares;
        Image[] img = new Image[9];
        List<string> listP = new List<string>();
        int[] tags = new int[2];
        #endregion

        public int TokenMemoria { get; private set; }

        public FormMemoria()
        {
            InitializeComponent();
            Inicio();
        }

        #region Inicio
        private void Inicio()
        {
            foreach (PictureBox i in Controls.OfType<PictureBox>())
            {
                int tagI = int.Parse(string.Format("{0}", i.Tag));
                img[tagI] = i.Image;
                i.Image = Properties.Resources.LauraMemoriaVerso;
                i.Enabled = true;
            }

            Aleatorio();
        }
        #endregion

        #region Random
        private void Aleatorio()
        {
            foreach (PictureBox i in Controls.OfType<PictureBox>())
            {
                Random random = new Random();

                int[] xP = { 30, 182, 334, 486, 638, 790 };
                int[] yP = { 71, 221, 379 };

            Repeat:

                var x = xP[random.Next(0, xP.Length)];
                var y = yP[random.Next(0, yP.Length)];

                string verificacao = x.ToString() + y.ToString();

                if (listP.Contains(verificacao))
                {
                    goto Repeat;
                }
                else
                {
                    i.Location = new Point(x, y);
                    listP.Add(verificacao);
                }

            }

        }

        private void FormMemoria_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region Clicar Imagem
        private void ClicarImagem(object sender, EventArgs e)
        {
            bool parigual = false;

            PictureBox pic = (PictureBox)sender;
            cliques++;
            tagI = int.Parse(string.Format("{0}", pic.Tag));
            pic.Image = img[tagI];
            pic.Refresh();

            if (cliques == 1)
            {
                tags[0] = int.Parse(string.Format("{0}", pic.Tag));
            }
            else
            {
                movimentos++;
                lblMovimentos.Text = "Movimentos: " + movimentos.ToString();
                tags[1] = int.Parse(string.Format("{0}", pic.Tag));
                parigual = checagemPares();
                Desvirar(parigual);
            }
        }
        #endregion

        #region Checar Correto
        private bool checagemPares()
        {
            cliques = 0;
            if (tags[0] == tags[1])
            {
                Pontos++;
                lblPontos.Text = "Pontos:" + Pontos;
                return true;

            }
            else
            {
                return false;
            }
        }
        #endregion

        #region Virar Errado
        private void Desvirar(bool checar)
        {
            Thread.Sleep(500);
            foreach (PictureBox i in Controls.OfType<PictureBox>())
            {
                if (int.Parse(string.Format("{0}", i.Tag)) == tags[0] || int.Parse(string.Format("{0}", i.Tag)) == tags[1])
                {
                    if (checar == true)
                    {
                        i.Enabled = false;
                        Pares++;
                    }
                    else
                    {
                        i.Image = Properties.Resources.LauraMemoriaVerso;
                        i.Refresh();
                    }
                }
            }
            final();
        }
        #endregion

        #region Fim do Jogo
        private void final()
        {
            if (Pares == (img.Length * 2))
            {
                if (movimentos <= 17)
                {
                    MessageBox.Show("Parabens Você Terminou o Desafio da Memoria em: " + movimentos + " movimentos e conseguiu seu mimlauToken!!");
                    TokenMemoria++;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Você Terminou o Desafio da Memoria em: " +movimentos+" movimentos, mas não foi suficiente para garantir o token.");

                    DialogResult msg = MessageBox.Show("Deseja tentar novamente?", "Caixa de Pergunta", MessageBoxButtons.YesNo);

                    if (msg == DialogResult.Yes)
                    {
                        cliques = 0; movimentos = 0; Pares = 0; Pontos = 0;
                        lblPontos.Text = "Pontos:" + Pontos;
                        lblMovimentos.Text = "Movimentos: " + movimentos.ToString();

                        listP.Clear();
                        Inicio();
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

        #endregion
    }
}
