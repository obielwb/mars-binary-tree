namespace MarteArvoresBinarias
{
    partial class MarteArvoresBinarias
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
            this.marteTabControl = new System.Windows.Forms.TabControl();
            this.cadastroTabPage = new System.Windows.Forms.TabPage();
            this.cidadePictureBox = new System.Windows.Forms.PictureBox();
            this.exibirCaminhoButton = new System.Windows.Forms.Button();
            this.alterarCaminhoButton = new System.Windows.Forms.Button();
            this.excluirCaminhoButton = new System.Windows.Forms.Button();
            this.incluirCaminhoButton = new System.Windows.Forms.Button();
            this.custoLabel = new System.Windows.Forms.Label();
            this.caminhoCustoTextBox = new System.Windows.Forms.TextBox();
            this.tempoLabel = new System.Windows.Forms.Label();
            this.caminhoTempoTextBox = new System.Windows.Forms.TextBox();
            this.distanciaLabel = new System.Windows.Forms.Label();
            this.caminhoDistanciaTextBox = new System.Windows.Forms.TextBox();
            this.cidadeDestinoLabel = new System.Windows.Forms.Label();
            this.caminhoCidadeDestinoTextBox = new System.Windows.Forms.TextBox();
            this.cidadeOrigemLabel = new System.Windows.Forms.Label();
            this.caminhoCidadeOrigemTextBox = new System.Windows.Forms.TextBox();
            this.caminhosLabel = new System.Windows.Forms.Label();
            this.cidadeLabel = new System.Windows.Forms.Label();
            this.exibirCidadeButton = new System.Windows.Forms.Button();
            this.alterarCidadeButton = new System.Windows.Forms.Button();
            this.excluirCidadeButton = new System.Windows.Forms.Button();
            this.incluirCidadeButton = new System.Windows.Forms.Button();
            this.caminhosDataGridView = new System.Windows.Forms.DataGridView();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.nomeCidadeTextBox = new System.Windows.Forms.TextBox();
            this.arvoreTabPage = new System.Windows.Forms.TabPage();
            this.arvorePictureBox = new System.Windows.Forms.PictureBox();
            this.marteTabControl.SuspendLayout();
            this.cadastroTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cidadePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caminhosDataGridView)).BeginInit();
            this.arvoreTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arvorePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // marteTabControl
            // 
            this.marteTabControl.Controls.Add(this.cadastroTabPage);
            this.marteTabControl.Controls.Add(this.arvoreTabPage);
            this.marteTabControl.Location = new System.Drawing.Point(1, 2);
            this.marteTabControl.Name = "marteTabControl";
            this.marteTabControl.SelectedIndex = 0;
            this.marteTabControl.Size = new System.Drawing.Size(1407, 661);
            this.marteTabControl.TabIndex = 0;
            // 
            // cadastroTabPage
            // 
            this.cadastroTabPage.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cadastroTabPage.Controls.Add(this.cidadePictureBox);
            this.cadastroTabPage.Controls.Add(this.exibirCaminhoButton);
            this.cadastroTabPage.Controls.Add(this.alterarCaminhoButton);
            this.cadastroTabPage.Controls.Add(this.excluirCaminhoButton);
            this.cadastroTabPage.Controls.Add(this.incluirCaminhoButton);
            this.cadastroTabPage.Controls.Add(this.custoLabel);
            this.cadastroTabPage.Controls.Add(this.caminhoCustoTextBox);
            this.cadastroTabPage.Controls.Add(this.tempoLabel);
            this.cadastroTabPage.Controls.Add(this.caminhoTempoTextBox);
            this.cadastroTabPage.Controls.Add(this.distanciaLabel);
            this.cadastroTabPage.Controls.Add(this.caminhoDistanciaTextBox);
            this.cadastroTabPage.Controls.Add(this.cidadeDestinoLabel);
            this.cadastroTabPage.Controls.Add(this.caminhoCidadeDestinoTextBox);
            this.cadastroTabPage.Controls.Add(this.cidadeOrigemLabel);
            this.cadastroTabPage.Controls.Add(this.caminhoCidadeOrigemTextBox);
            this.cadastroTabPage.Controls.Add(this.caminhosLabel);
            this.cadastroTabPage.Controls.Add(this.cidadeLabel);
            this.cadastroTabPage.Controls.Add(this.exibirCidadeButton);
            this.cadastroTabPage.Controls.Add(this.alterarCidadeButton);
            this.cadastroTabPage.Controls.Add(this.excluirCidadeButton);
            this.cadastroTabPage.Controls.Add(this.incluirCidadeButton);
            this.cadastroTabPage.Controls.Add(this.caminhosDataGridView);
            this.cadastroTabPage.Controls.Add(this.nomeLabel);
            this.cadastroTabPage.Controls.Add(this.nomeCidadeTextBox);
            this.cadastroTabPage.Location = new System.Drawing.Point(4, 23);
            this.cadastroTabPage.Name = "cadastroTabPage";
            this.cadastroTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.cadastroTabPage.Size = new System.Drawing.Size(1399, 634);
            this.cadastroTabPage.TabIndex = 0;
            this.cadastroTabPage.Text = "Cadastro";
            // 
            // cidadePictureBox
            // 
            this.cidadePictureBox.Location = new System.Drawing.Point(739, 15);
            this.cidadePictureBox.Name = "cidadePictureBox";
            this.cidadePictureBox.Size = new System.Drawing.Size(632, 298);
            this.cidadePictureBox.TabIndex = 24;
            this.cidadePictureBox.TabStop = false;
            // 
            // exibirCaminhoButton
            // 
            this.exibirCaminhoButton.Location = new System.Drawing.Point(271, 290);
            this.exibirCaminhoButton.Name = "exibirCaminhoButton";
            this.exibirCaminhoButton.Size = new System.Drawing.Size(75, 23);
            this.exibirCaminhoButton.TabIndex = 23;
            this.exibirCaminhoButton.Text = "exibir";
            this.exibirCaminhoButton.UseVisualStyleBackColor = true;
            // 
            // alterarCaminhoButton
            // 
            this.alterarCaminhoButton.Location = new System.Drawing.Point(190, 290);
            this.alterarCaminhoButton.Name = "alterarCaminhoButton";
            this.alterarCaminhoButton.Size = new System.Drawing.Size(75, 23);
            this.alterarCaminhoButton.TabIndex = 22;
            this.alterarCaminhoButton.Text = "alterar";
            this.alterarCaminhoButton.UseVisualStyleBackColor = true;
            // 
            // excluirCaminhoButton
            // 
            this.excluirCaminhoButton.Location = new System.Drawing.Point(109, 290);
            this.excluirCaminhoButton.Name = "excluirCaminhoButton";
            this.excluirCaminhoButton.Size = new System.Drawing.Size(75, 23);
            this.excluirCaminhoButton.TabIndex = 21;
            this.excluirCaminhoButton.Text = "excluir";
            this.excluirCaminhoButton.UseVisualStyleBackColor = true;
            // 
            // incluirCaminhoButton
            // 
            this.incluirCaminhoButton.Location = new System.Drawing.Point(28, 290);
            this.incluirCaminhoButton.Name = "incluirCaminhoButton";
            this.incluirCaminhoButton.Size = new System.Drawing.Size(75, 23);
            this.incluirCaminhoButton.TabIndex = 20;
            this.incluirCaminhoButton.Text = "incluir";
            this.incluirCaminhoButton.UseVisualStyleBackColor = true;
            // 
            // custoLabel
            // 
            this.custoLabel.AutoSize = true;
            this.custoLabel.Location = new System.Drawing.Point(454, 247);
            this.custoLabel.Name = "custoLabel";
            this.custoLabel.Size = new System.Drawing.Size(35, 14);
            this.custoLabel.TabIndex = 19;
            this.custoLabel.Text = "Custo";
            // 
            // caminhoCustoTextBox
            // 
            this.caminhoCustoTextBox.Location = new System.Drawing.Point(457, 264);
            this.caminhoCustoTextBox.Name = "caminhoCustoTextBox";
            this.caminhoCustoTextBox.Size = new System.Drawing.Size(221, 20);
            this.caminhoCustoTextBox.TabIndex = 18;
            // 
            // tempoLabel
            // 
            this.tempoLabel.AutoSize = true;
            this.tempoLabel.Location = new System.Drawing.Point(248, 247);
            this.tempoLabel.Name = "tempoLabel";
            this.tempoLabel.Size = new System.Drawing.Size(38, 14);
            this.tempoLabel.TabIndex = 17;
            this.tempoLabel.Text = "Tempo";
            // 
            // caminhoTempoTextBox
            // 
            this.caminhoTempoTextBox.Location = new System.Drawing.Point(251, 264);
            this.caminhoTempoTextBox.Name = "caminhoTempoTextBox";
            this.caminhoTempoTextBox.Size = new System.Drawing.Size(200, 20);
            this.caminhoTempoTextBox.TabIndex = 16;
            // 
            // distanciaLabel
            // 
            this.distanciaLabel.AutoSize = true;
            this.distanciaLabel.Location = new System.Drawing.Point(25, 247);
            this.distanciaLabel.Name = "distanciaLabel";
            this.distanciaLabel.Size = new System.Drawing.Size(51, 14);
            this.distanciaLabel.TabIndex = 15;
            this.distanciaLabel.Text = "Distância";
            // 
            // caminhoDistanciaTextBox
            // 
            this.caminhoDistanciaTextBox.Location = new System.Drawing.Point(28, 264);
            this.caminhoDistanciaTextBox.Name = "caminhoDistanciaTextBox";
            this.caminhoDistanciaTextBox.Size = new System.Drawing.Size(214, 20);
            this.caminhoDistanciaTextBox.TabIndex = 14;
            // 
            // cidadeDestinoLabel
            // 
            this.cidadeDestinoLabel.AutoSize = true;
            this.cidadeDestinoLabel.Location = new System.Drawing.Point(357, 205);
            this.cidadeDestinoLabel.Name = "cidadeDestinoLabel";
            this.cidadeDestinoLabel.Size = new System.Drawing.Size(94, 14);
            this.cidadeDestinoLabel.TabIndex = 13;
            this.cidadeDestinoLabel.Text = "Cidade de Destino";
            // 
            // caminhoCidadeDestinoTextBox
            // 
            this.caminhoCidadeDestinoTextBox.Location = new System.Drawing.Point(360, 222);
            this.caminhoCidadeDestinoTextBox.Name = "caminhoCidadeDestinoTextBox";
            this.caminhoCidadeDestinoTextBox.Size = new System.Drawing.Size(318, 20);
            this.caminhoCidadeDestinoTextBox.TabIndex = 12;
            // 
            // cidadeOrigemLabel
            // 
            this.cidadeOrigemLabel.AutoSize = true;
            this.cidadeOrigemLabel.Location = new System.Drawing.Point(25, 205);
            this.cidadeOrigemLabel.Name = "cidadeOrigemLabel";
            this.cidadeOrigemLabel.Size = new System.Drawing.Size(92, 14);
            this.cidadeOrigemLabel.TabIndex = 11;
            this.cidadeOrigemLabel.Text = "Cidade de Origem";
            // 
            // caminhoCidadeOrigemTextBox
            // 
            this.caminhoCidadeOrigemTextBox.Location = new System.Drawing.Point(28, 222);
            this.caminhoCidadeOrigemTextBox.Name = "caminhoCidadeOrigemTextBox";
            this.caminhoCidadeOrigemTextBox.Size = new System.Drawing.Size(318, 20);
            this.caminhoCidadeOrigemTextBox.TabIndex = 10;
            // 
            // caminhosLabel
            // 
            this.caminhosLabel.AutoSize = true;
            this.caminhosLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caminhosLabel.Location = new System.Drawing.Point(24, 172);
            this.caminhosLabel.Name = "caminhosLabel";
            this.caminhosLabel.Size = new System.Drawing.Size(95, 22);
            this.caminhosLabel.TabIndex = 9;
            this.caminhosLabel.Text = "Caminhos";
            // 
            // cidadeLabel
            // 
            this.cidadeLabel.AutoSize = true;
            this.cidadeLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cidadeLabel.Location = new System.Drawing.Point(24, 29);
            this.cidadeLabel.Name = "cidadeLabel";
            this.cidadeLabel.Size = new System.Drawing.Size(71, 22);
            this.cidadeLabel.TabIndex = 8;
            this.cidadeLabel.Text = "Cidade";
            // 
            // exibirCidadeButton
            // 
            this.exibirCidadeButton.Location = new System.Drawing.Point(271, 109);
            this.exibirCidadeButton.Name = "exibirCidadeButton";
            this.exibirCidadeButton.Size = new System.Drawing.Size(75, 23);
            this.exibirCidadeButton.TabIndex = 7;
            this.exibirCidadeButton.Text = "exibir";
            this.exibirCidadeButton.UseVisualStyleBackColor = true;
            // 
            // alterarCidadeButton
            // 
            this.alterarCidadeButton.Location = new System.Drawing.Point(190, 109);
            this.alterarCidadeButton.Name = "alterarCidadeButton";
            this.alterarCidadeButton.Size = new System.Drawing.Size(75, 23);
            this.alterarCidadeButton.TabIndex = 6;
            this.alterarCidadeButton.Text = "alterar";
            this.alterarCidadeButton.UseVisualStyleBackColor = true;
            // 
            // excluirCidadeButton
            // 
            this.excluirCidadeButton.Location = new System.Drawing.Point(109, 109);
            this.excluirCidadeButton.Name = "excluirCidadeButton";
            this.excluirCidadeButton.Size = new System.Drawing.Size(75, 23);
            this.excluirCidadeButton.TabIndex = 5;
            this.excluirCidadeButton.Text = "excluir";
            this.excluirCidadeButton.UseVisualStyleBackColor = true;
            // 
            // incluirCidadeButton
            // 
            this.incluirCidadeButton.Location = new System.Drawing.Point(28, 109);
            this.incluirCidadeButton.Name = "incluirCidadeButton";
            this.incluirCidadeButton.Size = new System.Drawing.Size(75, 23);
            this.incluirCidadeButton.TabIndex = 4;
            this.incluirCidadeButton.Text = "incluir";
            this.incluirCidadeButton.UseVisualStyleBackColor = true;
            // 
            // caminhosDataGridView
            // 
            this.caminhosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.caminhosDataGridView.Location = new System.Drawing.Point(28, 328);
            this.caminhosDataGridView.Name = "caminhosDataGridView";
            this.caminhosDataGridView.Size = new System.Drawing.Size(650, 286);
            this.caminhosDataGridView.TabIndex = 3;
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Location = new System.Drawing.Point(25, 66);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(37, 14);
            this.nomeLabel.TabIndex = 2;
            this.nomeLabel.Text = "Nome ";
            // 
            // nomeCidadeTextBox
            // 
            this.nomeCidadeTextBox.Location = new System.Drawing.Point(28, 83);
            this.nomeCidadeTextBox.Name = "nomeCidadeTextBox";
            this.nomeCidadeTextBox.Size = new System.Drawing.Size(318, 20);
            this.nomeCidadeTextBox.TabIndex = 0;
            // 
            // arvoreTabPage
            // 
            this.arvoreTabPage.Controls.Add(this.arvorePictureBox);
            this.arvoreTabPage.Location = new System.Drawing.Point(4, 23);
            this.arvoreTabPage.Name = "arvoreTabPage";
            this.arvoreTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.arvoreTabPage.Size = new System.Drawing.Size(1399, 634);
            this.arvoreTabPage.TabIndex = 1;
            this.arvoreTabPage.Text = "Árvore";
            this.arvoreTabPage.UseVisualStyleBackColor = true;
            // 
            // arvorePictureBox
            // 
            this.arvorePictureBox.Location = new System.Drawing.Point(6, 6);
            this.arvorePictureBox.Name = "arvorePictureBox";
            this.arvorePictureBox.Size = new System.Drawing.Size(1387, 622);
            this.arvorePictureBox.TabIndex = 0;
            this.arvorePictureBox.TabStop = false;
            // 
            // MarteArvoresBinarias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1410, 662);
            this.Controls.Add(this.marteTabControl);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MarteArvoresBinarias";
            this.Text = "Marte Árvores Binárias";
            this.marteTabControl.ResumeLayout(false);
            this.cadastroTabPage.ResumeLayout(false);
            this.cadastroTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cidadePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caminhosDataGridView)).EndInit();
            this.arvoreTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.arvorePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl marteTabControl;
        private System.Windows.Forms.TabPage cadastroTabPage;
        private System.Windows.Forms.DataGridView caminhosDataGridView;
        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.TextBox nomeCidadeTextBox;
        private System.Windows.Forms.TabPage arvoreTabPage;
        private System.Windows.Forms.Button exibirCidadeButton;
        private System.Windows.Forms.Button alterarCidadeButton;
        private System.Windows.Forms.Button excluirCidadeButton;
        private System.Windows.Forms.Button incluirCidadeButton;
        private System.Windows.Forms.Label caminhosLabel;
        private System.Windows.Forms.Label cidadeLabel;
        private System.Windows.Forms.Label cidadeOrigemLabel;
        private System.Windows.Forms.TextBox caminhoCidadeOrigemTextBox;
        private System.Windows.Forms.Label distanciaLabel;
        private System.Windows.Forms.TextBox caminhoDistanciaTextBox;
        private System.Windows.Forms.Label cidadeDestinoLabel;
        private System.Windows.Forms.TextBox caminhoCidadeDestinoTextBox;
        private System.Windows.Forms.Label tempoLabel;
        private System.Windows.Forms.TextBox caminhoTempoTextBox;
        private System.Windows.Forms.Label custoLabel;
        private System.Windows.Forms.TextBox caminhoCustoTextBox;
        private System.Windows.Forms.Button exibirCaminhoButton;
        private System.Windows.Forms.Button alterarCaminhoButton;
        private System.Windows.Forms.Button excluirCaminhoButton;
        private System.Windows.Forms.Button incluirCaminhoButton;
        private System.Windows.Forms.PictureBox cidadePictureBox;
        private System.Windows.Forms.PictureBox arvorePictureBox;
    }
}

