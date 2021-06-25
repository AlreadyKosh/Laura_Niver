namespace AniversarioLaura
{
    partial class FormSuzi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSuzi));
            this.lblMunição = new System.Windows.Forms.Label();
            this.lblPontos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BarraVida = new System.Windows.Forms.ProgressBar();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.TempoJogoSuzi = new System.Windows.Forms.Timer(this.components);
            this.teste = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMunição
            // 
            this.lblMunição.AutoSize = true;
            this.lblMunição.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMunição.ForeColor = System.Drawing.Color.Transparent;
            this.lblMunição.Location = new System.Drawing.Point(20, 9);
            this.lblMunição.Name = "lblMunição";
            this.lblMunição.Size = new System.Drawing.Size(113, 24);
            this.lblMunição.TabIndex = 0;
            this.lblMunição.Text = "Munição: 0";
            // 
            // lblPontos
            // 
            this.lblPontos.AutoSize = true;
            this.lblPontos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPontos.ForeColor = System.Drawing.Color.Transparent;
            this.lblPontos.Location = new System.Drawing.Point(302, 9);
            this.lblPontos.Name = "lblPontos";
            this.lblPontos.Size = new System.Drawing.Size(97, 24);
            this.lblPontos.TabIndex = 1;
            this.lblPontos.Text = "Pontos: 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(573, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vidas: ";
            // 
            // BarraVida
            // 
            this.BarraVida.Location = new System.Drawing.Point(654, 9);
            this.BarraVida.Name = "BarraVida";
            this.BarraVida.Size = new System.Drawing.Size(224, 23);
            this.BarraVida.TabIndex = 3;
            this.BarraVida.Value = 100;
            // 
            // picPlayer
            // 
            this.picPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlayer.Image = global::AniversarioLaura.Properties.Resources.LauraCima;
            this.picPlayer.Location = new System.Drawing.Point(367, 166);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(120, 150);
            this.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPlayer.TabIndex = 4;
            this.picPlayer.TabStop = false;
            // 
            // TempoJogoSuzi
            // 
            this.TempoJogoSuzi.Enabled = true;
            this.TempoJogoSuzi.Interval = 20;
            this.TempoJogoSuzi.Tick += new System.EventHandler(this.EventoTempoPrincipal);
            // 
            // teste
            // 
            this.teste.AutoSize = true;
            this.teste.Location = new System.Drawing.Point(521, 67);
            this.teste.Name = "teste";
            this.teste.Size = new System.Drawing.Size(35, 13);
            this.teste.TabIndex = 5;
            this.teste.Text = "label1";
            // 
            // FormSuzi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(890, 633);
            this.Controls.Add(this.teste);
            this.Controls.Add(this.picPlayer);
            this.Controls.Add(this.BarraVida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPontos);
            this.Controls.Add(this.lblMunição);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSuzi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resgate a Suzi!";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormSuzi_FormClosed);
            this.Load += new System.EventHandler(this.FormSuzi_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMunição;
        private System.Windows.Forms.Label lblPontos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar BarraVida;
        private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.Timer TempoJogoSuzi;
        private System.Windows.Forms.Label teste;
    }
}