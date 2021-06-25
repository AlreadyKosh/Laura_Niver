namespace AniversarioLaura
{
    partial class FormDesafios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDesafios));
            this.btnJokenpo = new System.Windows.Forms.Button();
            this.btnFinal = new System.Windows.Forms.Button();
            this.btnMemoria = new System.Windows.Forms.Button();
            this.btnRescue = new System.Windows.Forms.Button();
            this.lblTokens = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trocarContaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.criarNovaContaMenuBar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.buscarContaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.placarDeLideresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rescueSuzyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.jokenpoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.jogoDaMemoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contaPremioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoginMenuBar = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenuBar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.editarContaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.mimlauTokensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnJokenpo
            // 
            this.btnJokenpo.AutoEllipsis = true;
            this.btnJokenpo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJokenpo.Location = new System.Drawing.Point(230, 196);
            this.btnJokenpo.Name = "btnJokenpo";
            this.btnJokenpo.Size = new System.Drawing.Size(178, 69);
            this.btnJokenpo.TabIndex = 0;
            this.btnJokenpo.Text = "Jokenpo";
            this.btnJokenpo.UseVisualStyleBackColor = true;
            this.btnJokenpo.Click += new System.EventHandler(this.btnJokenpo_Click);
            // 
            // btnFinal
            // 
            this.btnFinal.AutoEllipsis = true;
            this.btnFinal.BackColor = System.Drawing.Color.Gold;
            this.btnFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinal.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnFinal.Location = new System.Drawing.Point(230, 99);
            this.btnFinal.Name = "btnFinal";
            this.btnFinal.Size = new System.Drawing.Size(178, 69);
            this.btnFinal.TabIndex = 1;
            this.btnFinal.Text = "Charada";
            this.btnFinal.UseVisualStyleBackColor = false;
            this.btnFinal.Visible = false;
            this.btnFinal.Click += new System.EventHandler(this.btnFinal_Click);
            // 
            // btnMemoria
            // 
            this.btnMemoria.AutoEllipsis = true;
            this.btnMemoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemoria.Location = new System.Drawing.Point(428, 196);
            this.btnMemoria.Name = "btnMemoria";
            this.btnMemoria.Size = new System.Drawing.Size(178, 69);
            this.btnMemoria.TabIndex = 2;
            this.btnMemoria.Text = "Jogo da Memoria";
            this.btnMemoria.UseVisualStyleBackColor = true;
            this.btnMemoria.Click += new System.EventHandler(this.btnMemoria_Click);
            // 
            // btnRescue
            // 
            this.btnRescue.AutoEllipsis = true;
            this.btnRescue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRescue.Location = new System.Drawing.Point(19, 196);
            this.btnRescue.Name = "btnRescue";
            this.btnRescue.Size = new System.Drawing.Size(178, 69);
            this.btnRescue.TabIndex = 3;
            this.btnRescue.Text = "Rescue Suzy";
            this.btnRescue.UseVisualStyleBackColor = true;
            this.btnRescue.Click += new System.EventHandler(this.btnRescue_Click);
            // 
            // lblTokens
            // 
            this.lblTokens.AutoSize = true;
            this.lblTokens.BackColor = System.Drawing.Color.Transparent;
            this.lblTokens.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTokens.ForeColor = System.Drawing.Color.Violet;
            this.lblTokens.Location = new System.Drawing.Point(2, 27);
            this.lblTokens.Name = "lblTokens";
            this.lblTokens.Size = new System.Drawing.Size(258, 37);
            this.lblTokens.TabIndex = 4;
            this.lblTokens.Text = "mimlauTokens: ";
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.Teal;
            this.menu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem,
            this.contaPremioToolStripMenuItem,
            this.HelpMenuBar});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(628, 24);
            this.menu.TabIndex = 6;
            this.menu.Text = "menuStrip1";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criarNovaContaMenuBar,
            this.toolStripSeparator4,
            this.editarContaToolStripMenuItem,
            this.toolStripSeparator1,
            this.trocarContaToolStripMenuItem,
            this.toolStripSeparator2,
            this.buscarContaToolStripMenuItem,
            this.toolStripSeparator6,
            this.placarDeLideresToolStripMenuItem});
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // trocarContaToolStripMenuItem
            // 
            this.trocarContaToolStripMenuItem.Name = "trocarContaToolStripMenuItem";
            this.trocarContaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.trocarContaToolStripMenuItem.Text = "Trocar Conta";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
            // 
            // criarNovaContaMenuBar
            // 
            this.criarNovaContaMenuBar.Name = "criarNovaContaMenuBar";
            this.criarNovaContaMenuBar.Size = new System.Drawing.Size(180, 22);
            this.criarNovaContaMenuBar.Text = "Criar Nova Conta";
            this.criarNovaContaMenuBar.Click += new System.EventHandler(this.criarNovaContaMenuBar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // buscarContaToolStripMenuItem
            // 
            this.buscarContaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1});
            this.buscarContaToolStripMenuItem.Name = "buscarContaToolStripMenuItem";
            this.buscarContaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.buscarContaToolStripMenuItem.Text = "Buscar Conta";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // placarDeLideresToolStripMenuItem
            // 
            this.placarDeLideresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rescueSuzyToolStripMenuItem,
            this.toolStripSeparator3,
            this.jokenpoToolStripMenuItem,
            this.toolStripSeparator5,
            this.jogoDaMemoriaToolStripMenuItem,
            this.toolStripSeparator7,
            this.mimlauTokensToolStripMenuItem});
            this.placarDeLideresToolStripMenuItem.Name = "placarDeLideresToolStripMenuItem";
            this.placarDeLideresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.placarDeLideresToolStripMenuItem.Text = "Placar de Lideres";
            // 
            // rescueSuzyToolStripMenuItem
            // 
            this.rescueSuzyToolStripMenuItem.Name = "rescueSuzyToolStripMenuItem";
            this.rescueSuzyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rescueSuzyToolStripMenuItem.Text = "Rescue Suzy";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // jokenpoToolStripMenuItem
            // 
            this.jokenpoToolStripMenuItem.Name = "jokenpoToolStripMenuItem";
            this.jokenpoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.jokenpoToolStripMenuItem.Text = "Jokenpo";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(177, 6);
            // 
            // jogoDaMemoriaToolStripMenuItem
            // 
            this.jogoDaMemoriaToolStripMenuItem.Name = "jogoDaMemoriaToolStripMenuItem";
            this.jogoDaMemoriaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.jogoDaMemoriaToolStripMenuItem.Text = "Jogo da Memoria";
            // 
            // contaPremioToolStripMenuItem
            // 
            this.contaPremioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoginMenuBar});
            this.contaPremioToolStripMenuItem.Name = "contaPremioToolStripMenuItem";
            this.contaPremioToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.contaPremioToolStripMenuItem.Text = "Conta Premio";
            // 
            // LoginMenuBar
            // 
            this.LoginMenuBar.Name = "LoginMenuBar";
            this.LoginMenuBar.Size = new System.Drawing.Size(180, 22);
            this.LoginMenuBar.Text = "Login";
            this.LoginMenuBar.Click += new System.EventHandler(this.LoginMenuBar_Click);
            // 
            // HelpMenuBar
            // 
            this.HelpMenuBar.Name = "HelpMenuBar";
            this.HelpMenuBar.Size = new System.Drawing.Size(50, 20);
            this.HelpMenuBar.Text = "Ajuda";
            this.HelpMenuBar.Click += new System.EventHandler(this.HelpMenuBar_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(177, 6);
            // 
            // editarContaToolStripMenuItem
            // 
            this.editarContaToolStripMenuItem.Name = "editarContaToolStripMenuItem";
            this.editarContaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editarContaToolStripMenuItem.Text = "Editar Conta";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(177, 6);
            // 
            // mimlauTokensToolStripMenuItem
            // 
            this.mimlauTokensToolStripMenuItem.Name = "mimlauTokensToolStripMenuItem";
            this.mimlauTokensToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mimlauTokensToolStripMenuItem.Text = "Mimlau Tokens";
            // 
            // FormDesafios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AniversarioLaura.Properties.Resources.Laura_fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(628, 290);
            this.Controls.Add(this.lblTokens);
            this.Controls.Add(this.btnRescue);
            this.Controls.Add(this.btnMemoria);
            this.Controls.Add(this.btnFinal);
            this.Controls.Add(this.btnJokenpo);
            this.Controls.Add(this.menu);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.Name = "FormDesafios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Desafios";
            this.Load += new System.EventHandler(this.FormDesafios_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnJokenpo;
        private System.Windows.Forms.Button btnFinal;
        private System.Windows.Forms.Button btnMemoria;
        private System.Windows.Forms.Button btnRescue;
        private System.Windows.Forms.Label lblTokens;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem HelpMenuBar;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trocarContaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem criarNovaContaMenuBar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem buscarContaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem placarDeLideresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rescueSuzyToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem jokenpoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem jogoDaMemoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contaPremioToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem LoginMenuBar;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editarContaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem mimlauTokensToolStripMenuItem;
    }
}