
namespace fabrica_de_automoveis
{
    partial class Form0001mn
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
            this.tbModeloAutomovel = new System.Windows.Forms.TextBox();
            this.laModeloAutomovel = new System.Windows.Forms.Label();
            this.laAnoAutomovel = new System.Windows.Forms.Label();
            this.tbAnoAutomovel = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnGravarContinuar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbModeloAutomovel
            // 
            this.tbModeloAutomovel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbModeloAutomovel.Location = new System.Drawing.Point(16, 36);
            this.tbModeloAutomovel.Name = "tbModeloAutomovel";
            this.tbModeloAutomovel.Size = new System.Drawing.Size(394, 20);
            this.tbModeloAutomovel.TabIndex = 0;
            this.tbModeloAutomovel.TextChanged += new System.EventHandler(this.tbNomConvnio_TextChanged);
            // 
            // laModeloAutomovel
            // 
            this.laModeloAutomovel.AutoSize = true;
            this.laModeloAutomovel.Location = new System.Drawing.Point(13, 19);
            this.laModeloAutomovel.Name = "laModeloAutomovel";
            this.laModeloAutomovel.Size = new System.Drawing.Size(109, 13);
            this.laModeloAutomovel.TabIndex = 1;
            this.laModeloAutomovel.Text = "Modelo do automóvel";
            this.laModeloAutomovel.Click += new System.EventHandler(this.label1_Click);
            // 
            // laAnoAutomovel
            // 
            this.laAnoAutomovel.AutoSize = true;
            this.laAnoAutomovel.Location = new System.Drawing.Point(13, 73);
            this.laAnoAutomovel.Name = "laAnoAutomovel";
            this.laAnoAutomovel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.laAnoAutomovel.Size = new System.Drawing.Size(78, 13);
            this.laAnoAutomovel.TabIndex = 3;
            this.laAnoAutomovel.Text = "Ano automóvel";
            // 
            // tbAnoAutomovel
            // 
            this.tbAnoAutomovel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAnoAutomovel.Location = new System.Drawing.Point(16, 90);
            this.tbAnoAutomovel.Name = "tbAnoAutomovel";
            this.tbAnoAutomovel.Size = new System.Drawing.Size(394, 20);
            this.tbAnoAutomovel.TabIndex = 2;
            this.tbAnoAutomovel.Tag = "";
            this.tbAnoAutomovel.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVoltar.Image = global::fabrica_de_automoveis.Properties.Resources.ic_subdirectory_arrow_left_black_18dp;
            this.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltar.Location = new System.Drawing.Point(351, 235);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(62, 23);
            this.btnVoltar.TabIndex = 4;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnGravarContinuar
            // 
            this.btnGravarContinuar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGravarContinuar.Image = global::fabrica_de_automoveis.Properties.Resources.ic_check_black_18dp;
            this.btnGravarContinuar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGravarContinuar.Location = new System.Drawing.Point(147, 235);
            this.btnGravarContinuar.Name = "btnGravarContinuar";
            this.btnGravarContinuar.Size = new System.Drawing.Size(123, 23);
            this.btnGravarContinuar.TabIndex = 4;
            this.btnGravarContinuar.Text = "Gravar e &Continuar";
            this.btnGravarContinuar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGravarContinuar.UseVisualStyleBackColor = true;
            this.btnGravarContinuar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGravar.Image = global::fabrica_de_automoveis.Properties.Resources.ic_check_black_18dp;
            this.btnGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGravar.Location = new System.Drawing.Point(278, 235);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(67, 23);
            this.btnGravar.TabIndex = 4;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // Form0001mn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 270);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnGravarContinuar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.laAnoAutomovel);
            this.Controls.Add(this.tbAnoAutomovel);
            this.Controls.Add(this.laModeloAutomovel);
            this.Controls.Add(this.tbModeloAutomovel);
            this.Name = "Form0001mn";
            this.Text = "DTIFormManutencao1";
            this.Load += new System.EventHandler(this.DTIFormManutencao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbModeloAutomovel;
        private System.Windows.Forms.Label laModeloAutomovel;
        private System.Windows.Forms.Label laAnoAutomovel;
        private System.Windows.Forms.TextBox tbAnoAutomovel;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnGravarContinuar;
        private System.Windows.Forms.Button btnVoltar;
    }
}