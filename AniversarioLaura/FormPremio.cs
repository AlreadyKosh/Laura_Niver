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
    public partial class FormPremio : Form
    {
        SoundPlayer vitoria = new SoundPlayer(Properties.Resources.Musica_fundo);

        public FormPremio()
        {
            InitializeComponent();
            vitoria.Play();
        }

        private void btnPremio_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.nickneryfundo;
        }
    }
}
