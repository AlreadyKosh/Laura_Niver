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
    public partial class FormCharada : Form
    {
        List<string> Charadas = new List<string>();
        //SoundPlayer som = new SoundPlayer((@"g:\Curso\AniversarioLaura\AniversarioLaura\bin\Debug\Laura Sprites\vitoria.wav"));
        SoundPlayer vitoria = new SoundPlayer(Properties.Resources.vitoria);
        SoundPlayer ponto = new SoundPlayer(Properties.Resources.pontos);

        public FormCharada()
        {
            InitializeComponent();
            Charadas.Add("Instruções \n");
            Charadas.Add("Para começar a charada aperte iniciar, apos o inicio será colocado uma ");
            Charadas.Add("charada neste painel e você deve colocar a resposta ");
            Charadas.Add("na caixa de dialogo embaixo. Ao acertar passara para a proxima.");
            Charadas.Add("Após concluir as três charadas você recebera a Senha.");
            foreach (string i in Charadas)
            {
                listCharada.Items.Add(i);
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Charadas.Clear();
            listCharada.Items.Clear();

            Charadas.Add("Charada 1");
            Charadas.Add("O que é o que é... ");
            Charadas.Add("Possui 4 patas,");
            Charadas.Add("A cada dia que passa fica mais careca,");
            Charadas.Add("Parece um rato...");

            foreach (string i in Charadas)
            {
                listCharada.Items.Add(i);
            }
        }

        private void FormCharada_Load(object sender, EventArgs e)
        {
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string resposta = txtResposta.Text.ToUpper();

            switch (resposta)
            {
                case "SUZI":
                    txtResposta.Clear();
                    txtResposta.Focus();
                    Charadas.Clear();
                    listCharada.Items.Clear();

                    ponto.Play();

                    Charadas.Add("Charada 2");
                    Charadas.Add("O que é o que é... ");
                    Charadas.Add("É chernobylesco...");
                    Charadas.Add("É Tchola...");
                    Charadas.Add("É HORROROSO no Tft...");
                    foreach (string i in Charadas)
                    {
                        listCharada.Items.Add(i);
                    }
                    break;

                case "NICKY NERY":
                    txtResposta.Clear();
                    txtResposta.Focus();
                    Charadas.Clear();
                    listCharada.Items.Clear();

                    ponto.Play();
                    Charadas.Add("Charada 3");
                    Charadas.Add("Finalmente você encontrou a saida de um labirinto.");
                    Charadas.Add("Mas o corredor onde você está termina em três portas.");
                    Charadas.Add("A primeira porta leva para a cozinha infernal da Nathalia.");
                    Charadas.Add("A segunda, para o quarto chernobyl do Nicky Nery.");
                    Charadas.Add("A terceira, para um cão infernal chamado Suzi com fome");
                    Charadas.Add(" Qual das três portas você deve escolher?");

                    foreach (string i in Charadas)
                    {
                        listCharada.Items.Add(i);
                    }
                    break;

                case "A TERCEIRA":
                    txtResposta.Clear();
                    txtResposta.Focus();
                    Charadas.Clear();
                    listCharada.Items.Clear();

                    vitoria.Play();

                    Charadas.Add("VITORIA!!!");
                    Charadas.Add("Parabens você conclui todos os desafios");
                    Charadas.Add("Pegue a senha e vá para a tela de Login");
                    Charadas.Add("Login: Laura Lima");
                    Charadas.Add("Senha: Abacaxi123");
                    foreach (string i in Charadas)
                    {
                        listCharada.Items.Add(i);
                    }
                    break;
                default:
                    MessageBox.Show("Resposta Errada!!!", "Errou!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
