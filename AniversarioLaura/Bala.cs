using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace AniversarioLaura
{
    class Bala
    {
        public string direcao;
        public int BalaEsquerda;
        public int BalaCima;

        private int velocidade = 20;
        private PictureBox bala = new PictureBox();
        private Timer balaTempo = new Timer();

        public void CriarBala(Form form)
        {
            bala.BackColor = Color.White;
            bala.Size = new Size(8,8);
            bala.Tag = "bala";
            bala.Left = BalaEsquerda;
            bala.Top = BalaCima;
            bala.BringToFront();

            form.Controls.Add(bala);

            balaTempo.Interval = velocidade;
            balaTempo.Tick += new EventHandler(balaTempoEvent);
            balaTempo.Start();
        }

        private void balaTempoEvent(object sender, EventArgs e)
        {
            if(direcao == "Esquerda")
            {
                bala.Left -= velocidade;
            }
            if(direcao == "Direita")
            {
                bala.Left += velocidade;
            }

            if (direcao == "Cima")
            {
                bala.Top -= velocidade;
            }
            if (direcao == "Baixo")
            {
                bala.Top += velocidade;
            }

            if (bala.Left < 10 || bala.Left > 906 || bala.Top < 10 || bala.Top > 672)
            {
                balaTempo.Stop();
                balaTempo.Dispose();
                bala.Dispose();
                balaTempo = null;
                bala = null;
            }
        }
    }
}
