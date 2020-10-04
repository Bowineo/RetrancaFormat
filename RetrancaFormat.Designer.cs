namespace RetrancaFormat
{
    partial class RetrancaFormat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RetrancaFormat));
            this.tbPrefixo = new System.Windows.Forms.TextBox();
            this.lblPrefixo = new System.Windows.Forms.Label();
            this.tbSufixo = new System.Windows.Forms.TextBox();
            this.lblSufixo = new System.Windows.Forms.Label();
            this.tbPathEscolhido = new System.Windows.Forms.TextBox();
            this.lblSaida = new System.Windows.Forms.Label();
            this.btnEscolhePath = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tbInputTexto = new System.Windows.Forms.TextBox();
            this.btnGravarArquivo = new System.Windows.Forms.Button();
            this.lbInput = new System.Windows.Forms.Label();
            this.TbListaRetirar = new System.Windows.Forms.TextBox();
            this.btnAdicionaListaRetirar = new System.Windows.Forms.Button();
            this.lbLsitaExclusao = new System.Windows.Forms.Label();
            this.btnExpande = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbPrefixo
            // 
            this.tbPrefixo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrefixo.Location = new System.Drawing.Point(12, 400);
            this.tbPrefixo.MaxLength = 50;
            this.tbPrefixo.Name = "tbPrefixo";
            this.tbPrefixo.Size = new System.Drawing.Size(350, 24);
            this.tbPrefixo.TabIndex = 2;
            // 
            // lblPrefixo
            // 
            this.lblPrefixo.AutoSize = true;
            this.lblPrefixo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrefixo.Location = new System.Drawing.Point(8, 377);
            this.lblPrefixo.Name = "lblPrefixo";
            this.lblPrefixo.Size = new System.Drawing.Size(110, 18);
            this.lblPrefixo.TabIndex = 2;
            this.lblPrefixo.Text = "Digite o prefixo:";
            // 
            // tbSufixo
            // 
            this.tbSufixo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSufixo.Location = new System.Drawing.Point(12, 449);
            this.tbSufixo.MaxLength = 50;
            this.tbSufixo.Name = "tbSufixo";
            this.tbSufixo.Size = new System.Drawing.Size(350, 24);
            this.tbSufixo.TabIndex = 3;
            // 
            // lblSufixo
            // 
            this.lblSufixo.AutoSize = true;
            this.lblSufixo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSufixo.Location = new System.Drawing.Point(8, 426);
            this.lblSufixo.Name = "lblSufixo";
            this.lblSufixo.Size = new System.Drawing.Size(105, 18);
            this.lblSufixo.TabIndex = 2;
            this.lblSufixo.Text = "Digite o sufixo:";
            // 
            // tbPathEscolhido
            // 
            this.tbPathEscolhido.Enabled = false;
            this.tbPathEscolhido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPathEscolhido.Location = new System.Drawing.Point(12, 501);
            this.tbPathEscolhido.Name = "tbPathEscolhido";
            this.tbPathEscolhido.Size = new System.Drawing.Size(297, 24);
            this.tbPathEscolhido.TabIndex = 3;
            // 
            // lblSaida
            // 
            this.lblSaida.AutoSize = true;
            this.lblSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaida.Location = new System.Drawing.Point(8, 478);
            this.lblSaida.Name = "lblSaida";
            this.lblSaida.Size = new System.Drawing.Size(261, 18);
            this.lblSaida.TabIndex = 4;
            this.lblSaida.Text = "Escolha o local para gravar  o arquivo:";
            // 
            // btnEscolhePath
            // 
            this.btnEscolhePath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEscolhePath.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEscolhePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscolhePath.Location = new System.Drawing.Point(315, 499);
            this.btnEscolhePath.Name = "btnEscolhePath";
            this.btnEscolhePath.Size = new System.Drawing.Size(47, 22);
            this.btnEscolhePath.TabIndex = 4;
            this.btnEscolhePath.Text = "...";
            this.btnEscolhePath.UseVisualStyleBackColor = true;
            this.btnEscolhePath.Click += new System.EventHandler(this.BtnEscolhePath_Click);
            // 
            // tbInputTexto
            // 
            this.tbInputTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInputTexto.Location = new System.Drawing.Point(12, 35);
            this.tbInputTexto.MaxLength = 3000;
            this.tbInputTexto.Multiline = true;
            this.tbInputTexto.Name = "tbInputTexto";
            this.tbInputTexto.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbInputTexto.Size = new System.Drawing.Size(350, 335);
            this.tbInputTexto.TabIndex = 1;
            this.tbInputTexto.WordWrap = false;
            this.tbInputTexto.TextChanged += new System.EventHandler(this.TbInputTexto_TextChanged);
            this.tbInputTexto.DoubleClick += new System.EventHandler(this.TbInputTexto_DoubleClick);
            // 
            // btnGravarArquivo
            // 
            this.btnGravarArquivo.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnGravarArquivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGravarArquivo.Enabled = false;
            this.btnGravarArquivo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGravarArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravarArquivo.Location = new System.Drawing.Point(140, 531);
            this.btnGravarArquivo.Name = "btnGravarArquivo";
            this.btnGravarArquivo.Size = new System.Drawing.Size(83, 25);
            this.btnGravarArquivo.TabIndex = 5;
            this.btnGravarArquivo.Text = "Gravar";
            this.btnGravarArquivo.UseVisualStyleBackColor = false;
            this.btnGravarArquivo.Click += new System.EventHandler(this.BtnGravarArquivo_Click);
            // 
            // lbInput
            // 
            this.lbInput.AutoSize = true;
            this.lbInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInput.Location = new System.Drawing.Point(8, 11);
            this.lbInput.Name = "lbInput";
            this.lbInput.Size = new System.Drawing.Size(197, 18);
            this.lbInput.TabIndex = 11;
            this.lbInput.Text = "Cole aqui ou digite seu texto:";
            // 
            // TbListaRetirar
            // 
            this.TbListaRetirar.Location = new System.Drawing.Point(381, 35);
            this.TbListaRetirar.Multiline = true;
            this.TbListaRetirar.Name = "TbListaRetirar";
            this.TbListaRetirar.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TbListaRetirar.Size = new System.Drawing.Size(112, 490);
            this.TbListaRetirar.TabIndex = 12;
            this.TbListaRetirar.WordWrap = false;
            // 
            // btnAdicionaListaRetirar
            // 
            this.btnAdicionaListaRetirar.Location = new System.Drawing.Point(401, 533);
            this.btnAdicionaListaRetirar.Name = "btnAdicionaListaRetirar";
            this.btnAdicionaListaRetirar.Size = new System.Drawing.Size(69, 23);
            this.btnAdicionaListaRetirar.TabIndex = 13;
            this.btnAdicionaListaRetirar.Text = "Salvar";
            this.btnAdicionaListaRetirar.UseVisualStyleBackColor = true;
            this.btnAdicionaListaRetirar.Click += new System.EventHandler(this.BtnAdicionaListaRetirar_Click);
            // 
            // lbLsitaExclusao
            // 
            this.lbLsitaExclusao.AutoSize = true;
            this.lbLsitaExclusao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLsitaExclusao.Location = new System.Drawing.Point(378, 11);
            this.lbLsitaExclusao.Name = "lbLsitaExclusao";
            this.lbLsitaExclusao.Size = new System.Drawing.Size(107, 18);
            this.lbLsitaExclusao.TabIndex = 14;
            this.lbLsitaExclusao.Text = "Excluir do final:";
            // 
            // btnExpande
            // 
            this.btnExpande.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExpande.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExpande.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpande.Location = new System.Drawing.Point(315, 534);
            this.btnExpande.Name = "btnExpande";
            this.btnExpande.Size = new System.Drawing.Size(47, 22);
            this.btnExpande.TabIndex = 15;
            this.btnExpande.Text = "<";
            this.btnExpande.UseVisualStyleBackColor = true;
            this.btnExpande.Click += new System.EventHandler(this.BtnExpande_Click);
            // 
            // RetrancaFormat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(374, 565);
            this.Controls.Add(this.btnExpande);
            this.Controls.Add(this.lbLsitaExclusao);
            this.Controls.Add(this.btnAdicionaListaRetirar);
            this.Controls.Add(this.TbListaRetirar);
            this.Controls.Add(this.lblPrefixo);
            this.Controls.Add(this.tbPrefixo);
            this.Controls.Add(this.tbSufixo);
            this.Controls.Add(this.lbInput);
            this.Controls.Add(this.lblSufixo);
            this.Controls.Add(this.tbInputTexto);
            this.Controls.Add(this.btnGravarArquivo);
            this.Controls.Add(this.btnEscolhePath);
            this.Controls.Add(this.tbPathEscolhido);
            this.Controls.Add(this.lblSaida);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RetrancaFormat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RetrancaFormat";
            this.Load += new System.EventHandler(this.RetrancaFormat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbPrefixo;
        private System.Windows.Forms.Label lblPrefixo;
        private System.Windows.Forms.TextBox tbSufixo;
        private System.Windows.Forms.Label lblSufixo;
        private System.Windows.Forms.TextBox tbPathEscolhido;
        private System.Windows.Forms.Label lblSaida;
        private System.Windows.Forms.Button btnEscolhePath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox tbInputTexto;
        private System.Windows.Forms.Button btnGravarArquivo;
        private System.Windows.Forms.Label lbInput;
        private System.Windows.Forms.TextBox TbListaRetirar;
        private System.Windows.Forms.Button btnAdicionaListaRetirar;
        private System.Windows.Forms.Label lbLsitaExclusao;
        private System.Windows.Forms.Button btnExpande;
    }
}

