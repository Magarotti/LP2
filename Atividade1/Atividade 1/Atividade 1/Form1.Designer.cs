namespace Atividade_1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblRaio = new System.Windows.Forms.Label();
            this.lblAlt = new System.Windows.Forms.Label();
            this.lblVol = new System.Windows.Forms.Label();
            this.btnCal = new System.Windows.Forms.Button();
            this.btnFech = new System.Windows.Forms.Button();
            this.txtRaio = new System.Windows.Forms.TextBox();
            this.txtAlt = new System.Windows.Forms.TextBox();
            this.txtVol = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblRaio
            // 
            this.lblRaio.AutoSize = true;
            this.lblRaio.Location = new System.Drawing.Point(33, 38);
            this.lblRaio.Name = "lblRaio";
            this.lblRaio.Size = new System.Drawing.Size(29, 13);
            this.lblRaio.TabIndex = 0;
            this.lblRaio.Text = "Raio";
            // 
            // lblAlt
            // 
            this.lblAlt.AutoSize = true;
            this.lblAlt.Location = new System.Drawing.Point(33, 83);
            this.lblAlt.Name = "lblAlt";
            this.lblAlt.Size = new System.Drawing.Size(34, 13);
            this.lblAlt.TabIndex = 1;
            this.lblAlt.Text = "Altura";
            // 
            // lblVol
            // 
            this.lblVol.AutoSize = true;
            this.lblVol.Location = new System.Drawing.Point(33, 136);
            this.lblVol.Name = "lblVol";
            this.lblVol.Size = new System.Drawing.Size(42, 13);
            this.lblVol.TabIndex = 2;
            this.lblVol.Text = "Volume";
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(36, 184);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(75, 23);
            this.btnCal.TabIndex = 3;
            this.btnCal.Text = "Calcular";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // btnFech
            // 
            this.btnFech.Location = new System.Drawing.Point(157, 184);
            this.btnFech.Name = "btnFech";
            this.btnFech.Size = new System.Drawing.Size(75, 23);
            this.btnFech.TabIndex = 4;
            this.btnFech.Text = "Fechar";
            this.btnFech.UseVisualStyleBackColor = true;
            this.btnFech.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtRaio
            // 
            this.txtRaio.Location = new System.Drawing.Point(94, 35);
            this.txtRaio.Name = "txtRaio";
            this.txtRaio.Size = new System.Drawing.Size(100, 20);
            this.txtRaio.TabIndex = 5;
            this.txtRaio.TextChanged += new System.EventHandler(this.txtRaio_TextChanged);
            // 
            // txtAlt
            // 
            this.txtAlt.Location = new System.Drawing.Point(94, 83);
            this.txtAlt.Name = "txtAlt";
            this.txtAlt.Size = new System.Drawing.Size(100, 20);
            this.txtAlt.TabIndex = 6;
            // 
            // txtVol
            // 
            this.txtVol.Location = new System.Drawing.Point(94, 133);
            this.txtVol.Name = "txtVol";
            this.txtVol.Size = new System.Drawing.Size(100, 20);
            this.txtVol.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 247);
            this.Controls.Add(this.txtVol);
            this.Controls.Add(this.txtAlt);
            this.Controls.Add(this.txtRaio);
            this.Controls.Add(this.btnFech);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.lblVol);
            this.Controls.Add(this.lblAlt);
            this.Controls.Add(this.lblRaio);
            this.Name = "Form1";
            this.Text = "Calculo de volume de cilindro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRaio;
        private System.Windows.Forms.Label lblAlt;
        private System.Windows.Forms.Label lblVol;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Button btnFech;
        private System.Windows.Forms.TextBox txtRaio;
        private System.Windows.Forms.TextBox txtAlt;
        private System.Windows.Forms.TextBox txtVol;
    }
}

