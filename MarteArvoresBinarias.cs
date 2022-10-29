// Gabriel Willian Bartmanovicz - 21234
// João Pedro Ferreira Barbosa - 21687

using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace MarteArvoresBinarias
{
    public partial class MarteArvoresBinarias : Form
    {
        private ArvoreDeBusca<Cidade> arvoreCidades;
        private Cidade cidadeSelecionada;

        public MarteArvoresBinarias()
        {
            InitializeComponent();
        }

        private void MarteArvoresBinarias_Load(object sender, System.EventArgs e)
        {
            VerificarArquivos();

            // se o arquivo de cidades for aberto com sucesso
            if (cidadesOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                // instanicamos a árvore de cidades
                arvoreCidades = new ArvoreDeBusca<Cidade>();
                // e lemos o arquivo
                arvoreCidades.LerArquivoDeRegistros(cidadesOpenFileDialog.FileName);

                // se o arquivo de caminhos for aberto com sucesso
                if (caminhosOpenFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // instanciamos um fluxo de arquivo
                    FileStream fluxoCaminhos = new FileStream(caminhosOpenFileDialog.FileName, FileMode.Open);
                    // e um leitor do arquivo binário
                    BinaryReader arquivoCaminhos = new BinaryReader(fluxoCaminhos);

                    // percorre cada registro dentre os registros do arquivo de caminho
                    for (int registro = 0;
                        registro < (int)fluxoCaminhos.Length / new Caminho().TamanhoRegistro;
                        registro++)
                    {
                        // instancia um caminho vazio
                        Caminho caminho = new Caminho();
                        // lê o registro
                        caminho.LerRegistro(arquivoCaminhos, registro);
                        // e atribui o arquivo de caminhos à instância caminho
                        caminho.NomeArquivo = caminhosOpenFileDialog.FileName;

                        // se a cidade de origem existir na árvore de cidades
                        if (arvoreCidades.Existe(new Cidade(caminho.CidadeOrigem)))
                            // incluímos na lista de caminhos do referente nó o caminho
                             arvoreCidades.Atual.Dado.Caminhos.InserirEmOrdem(caminho);
                    }

                    // limpamos o arquivo para garantir que os dados salvos
                    // são os dados atualizados e evitar duplicação de registros
                    fluxoCaminhos.SetLength(0);
                    arquivoCaminhos.Close();
                    fluxoCaminhos.Close();
                }

                // se existem cidades, populamos os campos
                if (arvoreCidades.QuantosNos() > 0)
                {
                    cidadeSelecionada = arvoreCidades.Raiz.Dado;
                    PopularCampos();
                }
            }
        }

        private void VerificarArquivos()
        {
            // se os arquivos em JSON exisitrem, nós os deletamos
            // para que o "append" das cidades e dos caminhos não
            // duplique as informações já existentes
            if (File.Exists("c:\\temp\\CidadesMarte.json"))
                File.Delete("c:\\temp\\CidadesMarte.json");
            if (File.Exists("c:\\temp\\CaminhoEntreCidadesMarte.json"))
                File.Delete("c:\\temp\\CaminhoEntreCidadesMarte.json");

            // se o arquivo de cidades não existir, criaremos ele
            // e o preencheremos com as cidades "hard coded"
            if (!File.Exists("c:\\temp\\CidadesMarte.dat"))
            {
                // vetor contendo todas as cidades predefinidas
                Cidade[] cidades = new Cidade[]
                    {
                        new Cidade("Acheron", 0.11353, 0.28857),
                        new Cidade("Arena", 0.68726, 0.29248),
                        new Cidade("Arrakeen", 0.05298, 0.48682),
                        new Cidade("Bakhuysen", 0.67456, 0.52002),
                        new Cidade("Bradbury", 0.40747, 0.74365),
                        new Cidade("Burroughs", 0.71265, 0.37939),
                        new Cidade("Cairo", 0.21606, 0.51025),
                        new Cidade("Dumont", 0.55737, 0.48096),
                        new Cidade("Echus Overlook", 0.24194, 0.35498),
                        new Cidade("Esperanca", 0.78906, 0.52588),
                        new Cidade("Gondor", 0.93311, 0.58545),
                        new Cidade("Lakefront", 0.69336, 0.63818),
                        new Cidade("Lowell", 0.89453, 0.38428),
                        new Cidade("Moria", 0.90039, 0.70947),
                        new Cidade("Nicosia", 0.16235, 0.50732),
                        new Cidade("Odessa", 0.63306, 0.67529),
                        new Cidade("Perseveranca", 0.66528, 0.81787),
                        new Cidade("Rowan", 0.56567, 0.66553),
                        new Cidade("Senzeni Na", 0.18921, 0.66260),
                        new Cidade("Sheffield", 0.15894, 0.45849),
                        new Cidade("Temperanca", 0.51343, 0.67822),
                        new Cidade("Tharsis", 0.12964, 0.39502),
                        new Cidade("Underhill", 0.37891, 0.51318)
                    };

                // instanciação do arquivo binário cidades.dat
                BinaryWriter arquivoCidades =
                    new BinaryWriter(new FileStream("c:\\temp\\CidadesMarte.dat", FileMode.OpenOrCreate));

                // gravação individual de cada cidade no arquivo
                foreach (Cidade cidade in cidades)
                    cidade.GravarRegistro(arquivoCidades);

                arquivoCidades.Close();
            }

            // se o arquivo de caminhos não existir, criaremos ele
            // e o preencheremos com as cidades "hard coded"
            if (!File.Exists("c:\\temp\\CaminhoEntreCidadesMarte.dat"))
            {
                // vetor contendo todas os caminhos predefinidos
                Caminho[] caminhos = new Caminho[]
                    {
                        new Caminho("Acheron", "Echus Overlook", 2300, 19, 100),
                        new Caminho("Echus Overlook", "Cairo", 1900, 15, 90),
                        new Caminho("Echus Overlook", "Sheffield", 1700, 13, 80),
                        new Caminho("Sheffield", "Tharsis", 400, 5, 100),
                        new Caminho("Sheffield", "Cairo", 1100, 10, 70),
                        new Caminho("Sheffield", "Nicosia", 300, 2, 30),
                        new Caminho("Cairo", "Senzeni Na", 2000, 13, 80),
                        new Caminho("Cairo", "Underhill", 4000, 20, 120),
                        new Caminho("Senzeni Na", "Gondor", 5500, 30, 200),
                        new Caminho("Nicosia", "Arrakeen", 2200, 14, 75),
                        new Caminho("Arrakeen", "Gondor", 3500, 17, 100),
                        new Caminho("Bradbury", "Underhill", 3000, 18, 110),
                        new Caminho("Underhill", "Rowan", 4140, 21, 130),
                        new Caminho("Underhill", "Dumont", 4050, 20, 110),
                        new Caminho("Bradbury", "Odessa", 4800, 27, 160),
                        new Caminho("Rowan", "Odessa", 1100, 9, 60),
                        new Caminho("Rowan", "Lakefront", 2100, 17, 95),
                        new Caminho("Odessa", "Bakhuysen", 1400, 11, 65),
                        new Caminho("Odessa", "Esperanca", 4030, 21, 100),
                        new Caminho("Odessa", "Lakefront", 1010, 7, 50),
                        new Caminho("Odessa", "Temperanca", 2350, 14, 90),
                        new Caminho("Odessa", "Perseveranca", 1500, 12, 75),
                        new Caminho("Dumont", "Burroughs", 3800, 18, 95),
                        new Caminho("Burroughs", "Arena", 1000, 8, 60),
                        new Caminho("Burroughs", "Lowell", 3980, 20, 120),
                        new Caminho("Temperanca", "Gondor", 3900, 20, 110),
                        new Caminho("Gondor", "Moria", 1200, 10, 60),
                        new Caminho("Gondor", "Lowell", 2000, 16, 80)
                    };

                // instanciação do arquivo binário caminhos.dat
                BinaryWriter arquivoCaminhos = new BinaryWriter(new FileStream("c:\\temp\\CaminhoEntreCidadesMarte.dat", FileMode.OpenOrCreate));

                // gravação individual de cada caminho no arquivo
                foreach (Caminho caminho in caminhos)
                {
                    caminho.NomeArquivo = "c:\\temp\\CaminhoEntreCidadesMarte.dat";
                    caminho.GravarRegistro(arquivoCaminhos);
                }

                arquivoCaminhos.Close();
            }
        }

        private void arvorePictureBox_Paint(object sender, PaintEventArgs e)
        {
            // desenha a árvore no seu respectivo picture box quando houver uma
            // atualização no picture box
            arvoreCidades.DesenharArvore(true, arvoreCidades.Raiz, arvorePictureBox.Width / 2, 0,
               Math.PI / 2, Math.PI / 2.5, 300, e.Graphics);
        }

        private void MarteArvoresBinarias_FormClosing(object sender, FormClosingEventArgs e)
        {
            // se ambos os arquivos de cidades e caminhos foram abertos
            if (cidadesOpenFileDialog.FileName != null && caminhosOpenFileDialog.FileName != null)
            {
                // salvamos a árvore em seu respectivo arquivo e, por conseguinte,
                // cada caminho de sua lista de caminhos
                arvoreCidades.GravarArquivoDeRegistros(cidadesOpenFileDialog.FileName);
            }
        }

        // percorremos a árvore recursivamente e, para cada nó, obtemos o nome e as coordenadas
        // da cidade e a printamos no picture box
        private void cidadePictureBox_Paint(object sender, PaintEventArgs e)
        {
            Percorrer(arvoreCidades.Raiz);

            void Percorrer(NoArvore<Cidade> no)
            {
                if (no == null)
                    return;

                Cidade cidade = no.Dado;

                int x = (int)(cidade.X * cidadePictureBox.Width);
                int y = (int)(cidade.Y * cidadePictureBox.Height);

                // a cidade selecionada fica em destaque na cor vermelha, as demais
                // permanecem na cor preta
                Brush brush = cidade == cidadeSelecionada ? Brushes.Red : Brushes.Black;

                e.Graphics.FillEllipse(brush, new Rectangle(x, y, 6, 6));

                e.Graphics.DrawString(
                    cidade.Nome,
                    new Font("Arial", 10), brush,
                    x - cidade.Nome.Length * 2 - 10,
                    y - 15
                );

                Percorrer(no.Esquerda);
                Percorrer(no.Direita);
            }
        }

        private void LimparCampos()
        {
            nomeCidadeTextBox.Clear();
            xNumericUpDown.Value = yNumericUpDown.Value = 0;
            caminhoCidadeDestinoTextBox.Clear();
            distanciaNumericUpDown.Value = tempoNumericUpDown.Value = custoNumericUpDown.Value = 0;
            caminhosDataGridView.Rows.Clear();
        }

        private void incluirCidadeButton_Click(object sender, EventArgs e)
        {
            string nomeCidade = nomeCidadeTextBox.Text.Trim();
            double xCidade = (double)xNumericUpDown.Value;
            double yCidade = (double)yNumericUpDown.Value;

            if (nomeCidade == "" || xCidade == 0 || yCidade == 0)
                MessageBox.Show("Dados inválidos para inclusão de nova cidade!");

            else
            {
                Cidade cidade = new Cidade(nomeCidade, xCidade, yCidade);

                // se ainda não existe nenhuma cidade com aquele nome
                if (!arvoreCidades.ExisteRegistro(cidade))
                {
                    // a inserimos na árvore
                    arvoreCidades.InserirBalanceado(cidade);
                    cidadeSelecionada = cidade;
                    MessageBox.Show("Cidade incluída com sucesso!");
                    LimparCampos();
                    PopularCampos();
                    arvorePictureBox.Invalidate();
                    cidadePictureBox.Invalidate();
                }

                else
                    MessageBox.Show("Cidade já existente!");
            }
        }

        private void excluirCidadeButton_Click(object sender, EventArgs e)
        {
            string nomeCidade = nomeCidadeTextBox.Text.Trim();

            if (nomeCidade == "")
                MessageBox.Show("Nome inválido para exclusão de cidade!");

            else
            {
                // se a exclusão for confirmada
                if (
                    MessageBox.Show(
                        $"Excluir cidade?",
                        "",
                        MessageBoxButtons.YesNo
                    ) == DialogResult.Yes
                )
                    // se a exclusão deu certo
                    if (arvoreCidades.ApagarNo(new Cidade(nomeCidade)))
                    {
                        cidadeSelecionada = arvoreCidades.Raiz.Dado;
                        LimparCampos();
                        MessageBox.Show("Cidade excluída com sucesso!");
                        PopularCampos();
                        arvorePictureBox.Invalidate();
                        cidadePictureBox.Invalidate();
                    }

                    else
                        MessageBox.Show("Cidade inexistente");
            }
        }

        private void alterarCidadeButton_Click(object sender, EventArgs e)
        {
            string nomeCidade = nomeCidadeTextBox.Text.Trim();

            if (nomeCidade == "")
                MessageBox.Show("Nome inválido para alteração de cidade!");

            else
            {
                Cidade cidade = new Cidade(nomeCidade);

                // se existe alguma cidade com tal nome
                if (arvoreCidades.ExisteRegistro(cidade))
                {
                    double xCidade = (double)xNumericUpDown.Value;
                    double yCidade = (double)yNumericUpDown.Value;

                    if (xCidade == 0 || yCidade == 0)
                        MessageBox.Show("Coordenadas inválidas para alteração de cidade!");

                    else
                    {
                        // atribuímos os novos valores das coordenadas
                        cidade.X = xCidade;
                        cidade.Y = yCidade;
                        // e salvamos os camihnos já existentes no atributo Caminhos
                        cidade.Caminhos = arvoreCidades.Atual.Dado.Caminhos;

                        // apagamos a cidade
                        if (arvoreCidades.ApagarNo(cidade))
                        {
                            // e inserimos novamente com os dados corretos
                            arvoreCidades.InserirBalanceado(cidade);
                            MessageBox.Show("Cidade alterada com sucesso!");
                            LimparCampos();
                            PopularCampos();
                            arvorePictureBox.Invalidate();
                            cidadePictureBox.Invalidate();
                        }

                        else
                            MessageBox.Show("Não foi possível alterar a cidade!");
                    }
                }

                else
                    MessageBox.Show("Cidade inexistente!");
            }
        }

        private void exibirCidadeButton_Click(object sender, EventArgs e)
        {
            string nomeCidade = nomeCidadeTextBox.Text.Trim();

            if (nomeCidade == "")
                MessageBox.Show("Nome inválido para exibição da cidade!");

            else
            {
                // se existe alguma cidade com tal nome
                if (arvoreCidades.ExisteRegistro(new Cidade(nomeCidade)))
                {
                    cidadeSelecionada = arvoreCidades.Atual.Dado;
                    xNumericUpDown.Value = (decimal)cidadeSelecionada.X;
                    yNumericUpDown.Value = (decimal)cidadeSelecionada.Y;
                    LimparCampos();
                    PopularCampos();
                    cidadePictureBox.Invalidate();
                }

                else
                    MessageBox.Show("Cidade inexistente!");
            }
        }

        // populamos os campos com os valores da cidade e seus respectivos
        // caminhos
        private void PopularCampos()
        {
            if (cidadeSelecionada != null)
            {
                nomeCidadeTextBox.Text = cidadeSelecionada.Nome;
                xNumericUpDown.Value = (decimal)cidadeSelecionada.X;
                yNumericUpDown.Value = (decimal)cidadeSelecionada.Y;

                caminhosDataGridView.Rows.Clear();

                if (!cidadeSelecionada.Caminhos.EstaVazia)
                {
                    caminhosDataGridView.RowCount = cidadeSelecionada.Caminhos.QuantosNos;

                    Caminho primeiroCaminho = cidadeSelecionada.Caminhos.Primeiro.Dado;

                    caminhoCidadeDestinoTextBox.Text = primeiroCaminho.CidadeDestino;
                    distanciaNumericUpDown.Value = primeiroCaminho.Distancia;
                    tempoNumericUpDown.Value = primeiroCaminho.Tempo;
                    custoNumericUpDown.Value = primeiroCaminho.Custo;

                    cidadeSelecionada.Caminhos.IniciarPercursoSequencial();

                    int linha = 0;
                    while (cidadeSelecionada.Caminhos.PodePercorrer())
                    {
                        Caminho caminho = cidadeSelecionada.Caminhos.Atual.Dado;

                        caminhosDataGridView.Rows[linha].Cells[0].Value = caminho.CidadeDestino;
                        caminhosDataGridView.Rows[linha].Cells[1].Value = caminho.Distancia;
                        caminhosDataGridView.Rows[linha].Cells[2].Value = caminho.Tempo;
                        caminhosDataGridView.Rows[linha++].Cells[3].Value = caminho.Custo;
                    }
                }
            }
        }

        private void incluirCaminhoButton_Click(object sender, EventArgs e)
        {
            string nomeCidadeOrigem = cidadeSelecionada.Nome;
            string nomeCidadeDestino = caminhoCidadeDestinoTextBox.Text.Trim();
            int distancia = (int)distanciaNumericUpDown.Value;
            int tempo = (int)tempoNumericUpDown.Value;
            int custo = (int)custoNumericUpDown.Value;

            if (nomeCidadeOrigem == "" || nomeCidadeDestino == "" || distancia == 0 || tempo == 0 || custo == 0)
                MessageBox.Show("Dados inválidos para inclusão de novo caminho!");

            else
            {
                // se ambas as cidades existem
                if (arvoreCidades.ExisteRegistro(new Cidade(nomeCidadeDestino)) && arvoreCidades.ExisteRegistro(new Cidade(nomeCidadeOrigem)))
                {
                    Caminho caminho = new Caminho(nomeCidadeOrigem, nomeCidadeDestino, distancia, tempo, custo);
                    caminho.NomeArquivo = caminhosOpenFileDialog.FileName;
                    arvoreCidades.Atual.Dado.Caminhos.InserirEmOrdem(caminho);
                    MessageBox.Show("Caminho incluído com sucesso!");
                    PopularCampos();
                    arvorePictureBox.Invalidate();
                    cidadePictureBox.Invalidate();
                }

                else
                    MessageBox.Show("Não foi possível incluir o caminho!");
            }
        }

        private void excluirCaminhoButton_Click(object sender, EventArgs e)
        {
            string nomeCidadeOrigem = cidadeSelecionada.Nome;
            string nomeCidadeDestino = caminhoCidadeDestinoTextBox.Text.Trim();

            if (nomeCidadeOrigem == "" || nomeCidadeDestino == "")
                MessageBox.Show("Nomes inválidos para exclusão de caminho!");

            else
            {
                // se a exclusão for confirmada
                if (
                    MessageBox.Show(
                        $"Excluir caminho?",
                        "",
                        MessageBoxButtons.YesNo
                    ) == DialogResult.Yes
                )
                    // se ambas as cidades existem
                    if (arvoreCidades.ExisteRegistro(new Cidade(nomeCidadeDestino)) && arvoreCidades.ExisteRegistro(new Cidade(nomeCidadeOrigem)))
                    {
                        // se a exclusão deu certo
                        if (arvoreCidades.Atual.Dado.Caminhos.RemoverDado(new Caminho(nomeCidadeOrigem, nomeCidadeDestino)))
                        {
                            MessageBox.Show("Caminho excluído com sucesso!");
                            LimparCampos();
                            PopularCampos();
                            arvorePictureBox.Invalidate();
                            cidadePictureBox.Invalidate();
                        }

                        else
                            MessageBox.Show("Não foi possível excluir o caminho!");
                    }

                    else
                        MessageBox.Show("Caminho inválido!");
            }
        }

        private void alterarCaminhoButton_Click(object sender, EventArgs e)
        {
            string nomeCidadeOrigem = cidadeSelecionada.Nome;
            string nomeCidadeDestino = caminhoCidadeDestinoTextBox.Text.Trim();

            if (nomeCidadeOrigem == "" || nomeCidadeDestino == "")
                MessageBox.Show("Nomes inválidos para exclusão de caminho!");

            else
            {
                int distancia = (int)distanciaNumericUpDown.Value;
                int tempo = (int)tempoNumericUpDown.Value;
                int custo = (int)custoNumericUpDown.Value;

                if (distancia == 0 || tempo == 0 || custo == 0)
                    MessageBox.Show("Dados inválidos para alteração de caminho!");

                else
                    // se ambas as cidades existem
                    if (arvoreCidades.ExisteRegistro(new Cidade(nomeCidadeDestino)) && arvoreCidades.ExisteRegistro(new Cidade(nomeCidadeOrigem)))
                    {
                        Caminho caminho = new Caminho(nomeCidadeOrigem, nomeCidadeDestino, distancia, tempo, custo);
                        caminho.NomeArquivo = caminhosOpenFileDialog.FileName;

                        // se a exclusão deu certo
                        if (arvoreCidades.Atual.Dado.Caminhos.RemoverDado(caminho))
                        {
                            arvoreCidades.Atual.Dado.Caminhos.InserirEmOrdem(caminho);
                            MessageBox.Show("Caminho alterado com sucesso!");
                            PopularCampos();
                            arvorePictureBox.Invalidate();
                            cidadePictureBox.Invalidate();
                        }

                        else
                            MessageBox.Show("Não foi possível alterar o caminho!");
                    }

                    else
                        MessageBox.Show("Caminho inválido");
            }
        }

        private void exibirCaminhoButton_Click(object sender, EventArgs e)
        {
            string nomeCidadeOrigem = cidadeSelecionada.Nome;
            string nomeCidadeDestino = caminhoCidadeDestinoTextBox.Text.Trim();

            if (nomeCidadeOrigem == "" || nomeCidadeDestino == "")
                MessageBox.Show("Nomes inválidos para exibição do caminho!");

            else
            {
                // se ambas as cidades existem
                if (arvoreCidades.ExisteRegistro(new Cidade(nomeCidadeDestino)) && arvoreCidades.ExisteRegistro(new Cidade(nomeCidadeOrigem)))
                {
                    // se a exclusão deu certo
                    if (arvoreCidades.Atual.Dado.Caminhos.ExisteDado(new Caminho(nomeCidadeOrigem, nomeCidadeDestino)))
                    {
                        Caminho caminho = arvoreCidades.Atual.Dado.Caminhos.Atual.Dado;
                        distanciaNumericUpDown.Value = caminho.Distancia;
                        tempoNumericUpDown.Value = caminho.Tempo;
                        custoNumericUpDown.Value = caminho.Custo;
                        arvorePictureBox.Invalidate();
                        cidadePictureBox.Invalidate();
                    }

                    else
                    {
                        MessageBox.Show("Camninho inexistente!");
                        caminhoCidadeDestinoTextBox.Clear();
                        distanciaNumericUpDown.Value = tempoNumericUpDown.Value = custoNumericUpDown.Value = 0;
                    }
                }

                else
                    MessageBox.Show("Caminho inválido!");
            }
        }

        // se o usuário clicar no cabeçalho da linha, procuramos um caminho com o nome
        // digitado e, se existir, exibimos os dados
        private void caminhosDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string cidadeDestino = (string)caminhosDataGridView.Rows[e.RowIndex].Cells[0].Value;

            if (cidadeSelecionada.Caminhos.ExisteDado(new Caminho(cidadeSelecionada.Nome, cidadeDestino)))
            {
                Caminho caminhoSelecionado = cidadeSelecionada.Caminhos.Atual.Dado;

                caminhoCidadeDestinoTextBox.Text = caminhoSelecionado.CidadeDestino;
                distanciaNumericUpDown.Value = caminhoSelecionado.Distancia;
                tempoNumericUpDown.Value = caminhoSelecionado.Tempo;
                custoNumericUpDown.Value = caminhoSelecionado.Custo;
            }
        }
    }
}
