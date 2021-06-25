namespace AniversarioLaura
{
    partial class FormPremio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPremio));
            this.btnPremio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPremio
            // 
            this.btnPremio.BackColor = System.Drawing.Color.Gold;
            this.btnPremio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPremio.Location = new System.Drawing.Point(288, 380);
            this.btnPremio.Name = "btnPremio";
            this.btnPremio.Size = new System.Drawing.Size(178, 64);
            this.btnPremio.TabIndex = 0;
            this.btnPremio.Text = "Premio";
            this.btnPremio.UseVisualStyleBackColor = false;
            this.btnPremio.Click += new System.EventHandler(this.btnPremio_Click);
            // 
            // FormPremio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AniversarioLaura.Properties.Resources.vitoria2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(750, 456);
            this.Controls.Add(this.btnPremio);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPremio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPremio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPremio;
    }
}