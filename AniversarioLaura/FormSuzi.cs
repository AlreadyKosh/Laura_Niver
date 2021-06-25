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

namespace AniversarioLaura
{
    public partial class FormSuzi : Form
    {
        #region Variaveis
        bool Esquerda, Direita, Cima, Baixo, Fim;
        
        string Lado = "Cima";
        int VidaPlayer = 150;
        int Velocidade = 12;
        int municao = 10;
        Random Aleatorio = new Random();
        int pontos;
        int velocidadeZumbi = 2;
        List<PictureBox> ListaZumbi = new List<PictureBox>();
        SoundPlayer tiro = new SoundPlayer(Properties.Resources.tiro);
        #endregion

        public int TokenSuzi { get; private set; }

        public FormSuzi()
        {
            InitializeComponent();
            Restart();
        }

        #region Evento Principal
        private void EventoTempoPrincipal(object sender, EventArgs e)
        {
            #region HUD e Morte
            if (VidaPlayer > 1)
            {
                BarraVida.Value = VidaPlayer;
            }
            else
            {
                Fim = true;
                picPlayer.Image = Properties.Resources.LauraMorta;
                Vitoria();
            }

            lblMunição.Text = "Munição: " + municao;
            lblPontos.Text = "Pontos: " + pontos;
            #endregion

          

            #region Limite de Tela
            if (Esquerda == true && picPlayer.Left > 0)
            {
                picPlayer.Left -= Velocidade;
            }

            if (Direita == true && picPlayer.Left + picPlayer.Width < this.ClientSize.Width)
            {
                picPlayer.Left += Velocidade;
            }

            if (Cima == true && picPlayer.Top > 40)
            {
                picPlayer.Top -= Velocidade;
            }

            if (Baixo == true && picPlayer.Top + picPlayer.Height < this.ClientSize.Height)
            {
                picPlayer.Top += Velocidade;
            }
            #endregion

            #region Controles
            foreach (Control x in this.Controls)
            {
                #region Pegar Munição
                if (x is PictureBox && (string)x.Tag == "munição")
                {
                    if (picPlayer.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        ((PictureBox)x).Dispose();
                        municao += 5;
                    }
                }
                #endregion

                #region Movimento Zumbi e Dano
                if (x is PictureBox && (string)x.Tag == "zumbi")
                {
                    if (picPlayer.Bounds.IntersectsWith(x.Bounds))
                    {
                        VidaPlayer -= 1;
                    }

                    if (x.Left > picPlayer.Left)
                    {
                        x.Left -= velocidadeZumbi;
                        ((PictureBox)x).Image = Properties.Resources.DouglasEsquerda;
                    }

                    if (x.Left < picPlayer.Left)
                    {
                        x.Left += velocidadeZumbi;
                        ((PictureBox)x).Image = Properties.Resources.DouglasDireita;
                    }

                    if (x.Top > picPlayer.Top)
                    {
                        x.Top -= velocidadeZumbi;
                        ((PictureBox)x).Image = Properties.Resources.DouglasCima;
                    }

                    if (x.Top < picPlayer.Top)
                    {
                        x.Top += velocidadeZumbi;
                        ((PictureBox)x).Image = Properties.Resources.DouglasBaixo;
                    }

                }
                #endregion

                #region Morte Zumbi
                foreach (Control j in this.Controls)
                {
                    if (j is PictureBox && (string)j.Tag == "bala" && x is PictureBox && (string)x.Tag == "zumbi")
                    {
                        if (x.Bounds.IntersectsWith(j.Bounds))
                        {
                            pontos++;

                            this.Controls.Remove(j);
                            ((PictureBox)j).Dispose();
                            this.Controls.Remove(x);
                            ((PictureBox)x).Dispose();
                            ListaZumbi.Remove((PictureBox)x);
                            CriarZumbi();
                        }
                    }
                }
                #endregion
            }
                
            #endregion
        }
        #endregion

        #region Evento Apertar Tecla
        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (Fim == true)
            {
                return;
            }

            #region Movimento Player
            if (e.KeyCode == Keys.Left)
            {
                Esquerda = true;
                Lado = "Esquerda";
                picPlayer.Image = Properties.Resources.LauraEsquerda;
            }

            if (e.KeyCode == Keys.Right)
            {
                Direita = true;
                Lado = "Direita";
                picPlayer.Image = Properties.Resources.LauraDireita;
            }

            if (e.KeyCode == Keys.Up)
            {
                Cima = true;
                Lado = "Cima";
                picPlayer.Image = Properties.Resources.LauraCima;
            }

            if (e.KeyCode == Keys.Down)
            {
                Baixo = true;
                Lado = "Baixo";
                picPlayer.Image = Properties.Resources.LauraBaixo;
            }
            #endregion
        }
        #endregion

        #region Evento Soltar Tecla
        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            #region Parar Player
            if (e.KeyCode == Keys.Left)
            {
                Esquerda = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                Direita = false;
            }

            if (e.KeyCode == Keys.Up)
            {
                Cima = false;
            }

            if (e.KeyCode == Keys.Down)
            {
                Baixo = false;
            }
            #endregion

            if (e.KeyCode == Keys.Space && municao > 0 && Fim == false)
            {
                municao--;
                Atirar(Lado);

                if(municao < 1)
                {
                    DropMunicao();
                }
            }

            if (e.KeyCode == Keys.Enter || Fim == true)
            {
                
            }
        }
        #endregion

        #region Atirar
        private void Atirar(string direcao)
        {
            tiro.Play();
            Bala atirarBala = new Bala();
            atirarBala.direcao = direcao;
            atirarBala.BalaEsquerda = picPlayer.Left + (picPlayer.Width / 2);
            atirarBala.BalaCima = picPlayer.Top + (picPlayer.Height / 2); 
            atirarBala.CriarBala(this);

        }

        private void FormSuzi_Load(object sender, EventArgs e)
        {

        }

        private void FormSuzi_FormClosed(object sender, FormClosedEventArgs e)
        {
            TempoJogoSuzi.Stop();
        }
        #endregion

        #region CriarZumbi
        private void CriarZumbi()
        {
            PictureBox zumbi = new PictureBox();
            zumbi.Tag = "zumbi";
            zumbi.Image = Properties.Resources.DouglasBaixo;

            zumbi.Left = Aleatorio.Next(0,900);
            zumbi.Top = Aleatorio.Next(0,800);


            zumbi.SizeMode = PictureBoxSizeMode.AutoSize;
            ListaZumbi.Add(zumbi);
            this.Controls.Add(zumbi);
            picPlayer.BringToFront();
        }
        #endregion

        #region Dropar Munição
        private void DropMunicao()
        {
            PictureBox municao = new PictureBox();
            municao.Image = Properties.Resources.ammo_Image;
            municao.SizeMode = PictureBoxSizeMode.AutoSize;
            municao.Left = Aleatorio.Next(30,this.ClientSize.Width - municao.Width);
            municao.Top = Aleatorio.Next(30, ClientSize.Height - municao.Height);
            municao.Tag = "munição";
            this.Controls.Add(municao);
            municao.BringToFront();
            picPlayer.BringToFront();

        }
        #endregion

        #region Recomeçar Jogo
        private void Restart()
        {
            picPlayer.Image = Properties.Resources.LauraCima;

            foreach (PictureBox i  in ListaZumbi)
            {
                this.Controls.Remove(i);
            }

            ListaZumbi.Clear();

            for (int i = 0; i < 3; i++)
            {
                CriarZumbi();
            }

            Cima = false;
            Baixo = false;
            Esquerda = false;
            Direita = false;
            Fim = false;

            VidaPlayer = 100;
            pontos = 0;
            municao = 10;

            TempoJogoSuzi.Start();
        }
        #endregion

        #region Vitoria
        private void Vitoria()
        {
            if (VidaPlayer < 1)
            {
                if (pontos >= 20)
                {
                    TempoJogoSuzi.Stop();
                    MessageBox.Show("Parabens!! Você matou todos os zumbis e conseguiu seu Token");
                    TokenSuzi++;
                    this.Close();
                }
                else
                {
                    TempoJogoSuzi.Stop();
                    MessageBox.Show("Infelizmente você perdeu!!");
                    DialogResult msg = MessageBox.Show("Você perdeu deseja tentar novamente?", "Caixa de Pergunta", MessageBoxButtons.YesNo);

                    if (msg == DialogResult.Yes)
                    {
                        Restart();
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
