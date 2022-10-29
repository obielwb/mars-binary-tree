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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MarteArvoresBinarias));
            this.marteTabControl = new System.Windows.Forms.TabControl();
            this.cadastroTabPage = new System.Windows.Forms.TabPage();
            this.yNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.xNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.yLabel = new System.Windows.Forms.Label();
            this.xLabel = new System.Windows.Forms.Label();
            this.custoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.tempoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.distanciaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.cidadePictureBox = new System.Windows.Forms.PictureBox();
            this.exibirCaminhoButton = new System.Windows.Forms.Button();
            this.alterarCaminhoButton = new System.Windows.Forms.Button();
            this.excluirCaminhoButton = new System.Windows.Forms.Button();
            this.incluirCaminhoButton = new System.Windows.Forms.Button();
            this.custoLabel = new System.Windows.Forms.Label();
            this.tempoLabel = new System.Windows.Forms.Label();
            this.distanciaLabel = new System.Windows.Forms.Label();
            this.cidadeDestinoLabel = new System.Windows.Forms.Label();
            this.caminhoCidadeDestinoTextBox = new System.Windows.Forms.TextBox();
            this.caminhosLabel = new System.Windows.Forms.Label();
            this.cidadeLabel = new System.Windows.Forms.Label();
            this.exibirCidadeButton = new System.Windows.Forms.Button();
            this.alterarCidadeButton = new System.Windows.Forms.Button();
            this.excluirCidadeButton = new System.Windows.Forms.Button();
            this.incluirCidadeButton = new System.Windows.Forms.Button();
            this.caminhosDataGridView = new System.Windows.Forms.DataGridView();
            this.destinoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distanciaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.nomeCidadeTextBox = new System.Windows.Forms.TextBox();
            this.arvoreTabPage = new System.Windows.Forms.TabPage();
            this.arvorePictureBox = new System.Windows.Forms.PictureBox();
            this.cidadesOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.caminhosOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.marteTabControl.SuspendLayout();
            this.cadastroTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.custoNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempoNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distanciaNumericUpDown)).BeginInit();
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
            this.marteTabControl.Size = new System.Drawing.Size(1261, 677);
            this.marteTabControl.TabIndex = 0;
            // 
            // cadastroTabPage
            // 
            this.cadastroTabPage.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cadastroTabPage.Controls.Add(this.yNumericUpDown);
            this.cadastroTabPage.Controls.Add(this.xNumericUpDown);
            this.cadastroTabPage.Controls.Add(this.yLabel);
            this.cadastroTabPage.Controls.Add(this.xLabel);
            this.cadastroTabPage.Controls.Add(this.custoNumericUpDown);
            this.cadastroTabPage.Controls.Add(this.tempoNumericUpDown);
            this.cadastroTabPage.Controls.Add(this.distanciaNumericUpDown);
            this.cadastroTabPage.Controls.Add(this.cidadePictureBox);
            this.cadastroTabPage.Controls.Add(this.exibirCaminhoButton);
            this.cadastroTabPage.Controls.Add(this.alterarCaminhoButton);
            this.cadastroTabPage.Controls.Add(this.excluirCaminhoButton);
            this.cadastroTabPage.Controls.Add(this.incluirCaminhoButton);
            this.cadastroTabPage.Controls.Add(this.custoLabel);
            this.cadastroTabPage.Controls.Add(this.tempoLabel);
            this.cadastroTabPage.Controls.Add(this.distanciaLabel);
            this.cadastroTabPage.Controls.Add(this.cidadeDestinoLabel);
            this.cadastroTabPage.Controls.Add(this.caminhoCidadeDestinoTextBox);
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
            this.cadastroTabPage.Size = new System.Drawing.Size(1253, 650);
            this.cadastroTabPage.TabIndex = 0;
            this.cadastroTabPage.Text = "Cadastro";
            // 
            // yNumericUpDown
            // 
            this.yNumericUpDown.DecimalPlaces = 5;
            this.yNumericUpDown.Font = new System.Drawing.Font("Arial", 8.25F);
            this.yNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.yNumericUpDown.Location = new System.Drawing.Point(509, 84);
            this.yNumericUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.yNumericUpDown.Name = "yNumericUpDown";
            this.yNumericUpDown.Size = new System.Drawing.Size(148, 20);
            this.yNumericUpDown.TabIndex = 33;
            // 
            // xNumericUpDown
            // 
            this.xNumericUpDown.DecimalPlaces = 5;
            this.xNumericUpDown.Font = new System.Drawing.Font("Arial", 8.25F);
            this.xNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.xNumericUpDown.Location = new System.Drawing.Point(360, 84);
            this.xNumericUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.xNumericUpDown.Name = "xNumericUpDown";
            this.xNumericUpDown.Size = new System.Drawing.Size(143, 20);
            this.xNumericUpDown.TabIndex = 32;
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(506, 67);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(15, 14);
            this.yLabel.TabIndex = 31;
            this.yLabel.Text = "Y";
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(357, 67);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(14, 14);
            this.xLabel.TabIndex = 30;
            this.xLabel.Text = "X";
            // 
            // custoNumericUpDown
            // 
            this.custoNumericUpDown.Location = new System.Drawing.Point(457, 265);
            this.custoNumericUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.custoNumericUpDown.Name = "custoNumericUpDown";
            this.custoNumericUpDown.Size = new System.Drawing.Size(200, 20);
            this.custoNumericUpDown.TabIndex = 27;
            // 
            // tempoNumericUpDown
            // 
            this.tempoNumericUpDown.Location = new System.Drawing.Point(251, 265);
            this.tempoNumericUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.tempoNumericUpDown.Name = "tempoNumericUpDown";
            this.tempoNumericUpDown.Size = new System.Drawing.Size(200, 20);
            this.tempoNumericUpDown.TabIndex = 26;
            // 
            // distanciaNumericUpDown
            // 
            this.distanciaNumericUpDown.Location = new System.Drawing.Point(28, 265);
            this.distanciaNumericUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.distanciaNumericUpDown.Name = "distanciaNumericUpDown";
            this.distanciaNumericUpDown.Size = new System.Drawing.Size(217, 20);
            this.distanciaNumericUpDown.TabIndex = 25;
            // 
            // cidadePictureBox
            // 
            this.cidadePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("cidadePictureBox.Image")));
            this.cidadePictureBox.Location = new System.Drawing.Point(682, 29);
            this.cidadePictureBox.Name = "cidadePictureBox";
            this.cidadePictureBox.Size = new System.Drawing.Size(565, 326);
            this.cidadePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cidadePictureBox.TabIndex = 24;
            this.cidadePictureBox.TabStop = false;
            this.cidadePictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.cidadePictureBox_Paint);
            // 
            // exibirCaminhoButton
            // 
            this.exibirCaminhoButton.Location = new System.Drawing.Point(271, 290);
            this.exibirCaminhoButton.Name = "exibirCaminhoButton";
            this.exibirCaminhoButton.Size = new System.Drawing.Size(75, 23);
            this.exibirCaminhoButton.TabIndex = 23;
            this.exibirCaminhoButton.Text = "exibir";
            this.exibirCaminhoButton.UseVisualStyleBackColor = true;
            this.exibirCaminhoButton.Click += new System.EventHandler(this.exibirCaminhoButton_Click);
            // 
            // alterarCaminhoButton
            // 
            this.alterarCaminhoButton.Location = new System.Drawing.Point(190, 290);
            this.alterarCaminhoButton.Name = "alterarCaminhoButton";
            this.alterarCaminhoButton.Size = new System.Drawing.Size(75, 23);
            this.alterarCaminhoButton.TabIndex = 22;
            this.alterarCaminhoButton.Text = "alterar";
            this.alterarCaminhoButton.UseVisualStyleBackColor = true;
            this.alterarCaminhoButton.Click += new System.EventHandler(this.alterarCaminhoButton_Click);
            // 
            // excluirCaminhoButton
            // 
            this.excluirCaminhoButton.Location = new System.Drawing.Point(109, 290);
            this.excluirCaminhoButton.Name = "excluirCaminhoButton";
            this.excluirCaminhoButton.Size = new System.Drawing.Size(75, 23);
            this.excluirCaminhoButton.TabIndex = 21;
            this.excluirCaminhoButton.Text = "excluir";
            this.excluirCaminhoButton.UseVisualStyleBackColor = true;
            this.excluirCaminhoButton.Click += new System.EventHandler(this.excluirCaminhoButton_Click);
            // 
            // incluirCaminhoButton
            // 
            this.incluirCaminhoButton.Location = new System.Drawing.Point(28, 290);
            this.incluirCaminhoButton.Name = "incluirCaminhoButton";
            this.incluirCaminhoButton.Size = new System.Drawing.Size(75, 23);
            this.incluirCaminhoButton.TabIndex = 20;
            this.incluirCaminhoButton.Text = "incluir";
            this.incluirCaminhoButton.UseVisualStyleBackColor = true;
            this.incluirCaminhoButton.Click += new System.EventHandler(this.incluirCaminhoButton_Click);
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
            // tempoLabel
            // 
            this.tempoLabel.AutoSize = true;
            this.tempoLabel.Location = new System.Drawing.Point(248, 247);
            this.tempoLabel.Name = "tempoLabel";
            this.tempoLabel.Size = new System.Drawing.Size(38, 14);
            this.tempoLabel.TabIndex = 17;
            this.tempoLabel.Text = "Tempo";
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
            // cidadeDestinoLabel
            // 
            this.cidadeDestinoLabel.AutoSize = true;
            this.cidadeDestinoLabel.Location = new System.Drawing.Point(25, 207);
            this.cidadeDestinoLabel.Name = "cidadeDestinoLabel";
            this.cidadeDestinoLabel.Size = new System.Drawing.Size(94, 14);
            this.cidadeDestinoLabel.TabIndex = 13;
            this.cidadeDestinoLabel.Text = "Cidade de Destino";
            // 
            // caminhoCidadeDestinoTextBox
            // 
            this.caminhoCidadeDestinoTextBox.Location = new System.Drawing.Point(28, 224);
            this.caminhoCidadeDestinoTextBox.Name = "caminhoCidadeDestinoTextBox";
            this.caminhoCidadeDestinoTextBox.Size = new System.Drawing.Size(318, 20);
            this.caminhoCidadeDestinoTextBox.TabIndex = 12;
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
            this.exibirCidadeButton.Click += new System.EventHandler(this.exibirCidadeButton_Click);
            // 
            // alterarCidadeButton
            // 
            this.alterarCidadeButton.Location = new System.Drawing.Point(190, 109);
            this.alterarCidadeButton.Name = "alterarCidadeButton";
            this.alterarCidadeButton.Size = new System.Drawing.Size(75, 23);
            this.alterarCidadeButton.TabIndex = 6;
            this.alterarCidadeButton.Text = "alterar";
            this.alterarCidadeButton.UseVisualStyleBackColor = true;
            this.alterarCidadeButton.Click += new System.EventHandler(this.alterarCidadeButton_Click);
            // 
            // excluirCidadeButton
            // 
            this.excluirCidadeButton.Location = new System.Drawing.Point(109, 109);
            this.excluirCidadeButton.Name = "excluirCidadeButton";
            this.excluirCidadeButton.Size = new System.Drawing.Size(75, 23);
            this.excluirCidadeButton.TabIndex = 5;
            this.excluirCidadeButton.Text = "excluir";
            this.excluirCidadeButton.UseVisualStyleBackColor = true;
            this.excluirCidadeButton.Click += new System.EventHandler(this.excluirCidadeButton_Click);
            // 
            // incluirCidadeButton
            // 
            this.incluirCidadeButton.Location = new System.Drawing.Point(28, 109);
            this.incluirCidadeButton.Name = "incluirCidadeButton";
            this.incluirCidadeButton.Size = new System.Drawing.Size(75, 23);
            this.incluirCidadeButton.TabIndex = 4;
            this.incluirCidadeButton.Text = "incluir";
            this.incluirCidadeButton.UseVisualStyleBackColor = true;
            this.incluirCidadeButton.Click += new System.EventHandler(this.incluirCidadeButton_Click);
            // 
            // caminhosDataGridView
            // 
            this.caminhosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.caminhosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.destinoColumn,
            this.distanciaColumn,
            this.tempoColumn,
            this.custoColumn});
            this.caminhosDataGridView.Location = new System.Drawing.Point(28, 328);
            this.caminhosDataGridView.Name = "caminhosDataGridView";
            this.caminhosDataGridView.Size = new System.Drawing.Size(629, 286);
            this.caminhosDataGridView.TabIndex = 3;
            this.caminhosDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.caminhosDataGridView_RowHeaderMouseClick);
            // 
            // destinoColumn
            // 
            this.destinoColumn.HeaderText = "Destino";
            this.destinoColumn.Name = "destinoColumn";
            // 
            // distanciaColumn
            // 
            this.distanciaColumn.HeaderText = "Distância";
            this.distanciaColumn.Name = "distanciaColumn";
            // 
            // tempoColumn
            // 
            this.tempoColumn.HeaderText = "Tempo";
            this.tempoColumn.Name = "tempoColumn";
            // 
            // custoColumn
            // 
            this.custoColumn.HeaderText = "Custo";
            this.custoColumn.Name = "custoColumn";
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Location = new System.Drawing.Point(25, 66);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(34, 14);
            this.nomeLabel.TabIndex = 2;
            this.nomeLabel.Text = "Nome";
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
            this.arvoreTabPage.Size = new System.Drawing.Size(1253, 650);
            this.arvoreTabPage.TabIndex = 1;
            this.arvoreTabPage.Text = "Árvore";
            this.arvoreTabPage.UseVisualStyleBackColor = true;
            // 
            // arvorePictureBox
            // 
            this.arvorePictureBox.Location = new System.Drawing.Point(6, 6);
            this.arvorePictureBox.Name = "arvorePictureBox";
            this.arvorePictureBox.Size = new System.Drawing.Size(1241, 638);
            this.arvorePictureBox.TabIndex = 0;
            this.arvorePictureBox.TabStop = false;
            this.arvorePictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.arvorePictureBox_Paint);
            // 
            // cidadesOpenFileDialog
            // 
            this.cidadesOpenFileDialog.FileName = "CidadesMarte.dat";
            this.cidadesOpenFileDialog.Filter = "DAT files (.dat)|*.dat";
            // 
            // caminhosOpenFileDialog
            // 
            this.caminhosOpenFileDialog.FileName = "CaminhoEntreCidadesMarte.dat";
            this.caminhosOpenFileDialog.Filter = "DAT files (.dat)|*.dat";
            // 
            // MarteArvoresBinarias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.marteTabControl);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "MarteArvoresBinarias";
            this.Text = "Marte Árvores Binárias";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MarteArvoresBinarias_FormClosing);
            this.Load += new System.EventHandler(this.MarteArvoresBinarias_Load);
            this.marteTabControl.ResumeLayout(false);
            this.cadastroTabPage.ResumeLayout(false);
            this.cadastroTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.custoNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempoNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distanciaNumericUpDown)).EndInit();
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
        private System.Windows.Forms.Label distanciaLabel;
        private System.Windows.Forms.Label cidadeDestinoLabel;
        private System.Windows.Forms.TextBox caminhoCidadeDestinoTextBox;
        private System.Windows.Forms.Label tempoLabel;
        private System.Windows.Forms.Label custoLabel;
        private System.Windows.Forms.Button alterarCaminhoButton;
        private System.Windows.Forms.Button excluirCaminhoButton;
        private System.Windows.Forms.Button incluirCaminhoButton;
        private System.Windows.Forms.PictureBox cidadePictureBox;
        private System.Windows.Forms.PictureBox arvorePictureBox;
        private System.Windows.Forms.OpenFileDialog cidadesOpenFileDialog;
        private System.Windows.Forms.OpenFileDialog caminhosOpenFileDialog;
        private System.Windows.Forms.NumericUpDown tempoNumericUpDown;
        private System.Windows.Forms.NumericUpDown distanciaNumericUpDown;
        private System.Windows.Forms.NumericUpDown custoNumericUpDown;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.NumericUpDown xNumericUpDown;
        private System.Windows.Forms.NumericUpDown yNumericUpDown;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn distanciaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custoColumn;
        private System.Windows.Forms.Button exibirCaminhoButton;
    }
}

