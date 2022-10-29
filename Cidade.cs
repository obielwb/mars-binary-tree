// Gabriel Willian Bartmanovicz - 21234
// João Pedro Ferreira Barbosa - 21687

using System;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

class Cidade : IComparable<Cidade>, IRegistro
{
    public const int tamanhoNome = 15;

    private string nome;
    private double x, y;
    private ListaSimples<Caminho> caminhos;

    private const int tamanhoRegistro = tamanhoNome + // nome
                                        sizeof(double) + // x
                                        sizeof(double); // y

    public string Nome { get => nome; set => nome = value; }
    public double X { get => x; set => x = value; }
    public double Y { get => y; set => y = value; }
    public int TamanhoRegistro { get => tamanhoRegistro; }
    internal ListaSimples<Caminho> Caminhos { get => caminhos; set => caminhos = value; }

    public Cidade()
    {
        Nome = "";
        X = Y = 0.0d;
        Caminhos = new ListaSimples<Caminho>();
    }

    public Cidade(string nome, double x, double y)
    {
        Nome = nome;
        X = x;
        Y = y;
        Caminhos = new ListaSimples<Caminho>();
    }

    public Cidade(string nome)
    {
        Nome = nome;
    }

    public int CompareTo(Cidade cidade)
    {
        return nome.ToUpperInvariant().CompareTo(cidade.Nome.ToUpperInvariant());
    }

    public override string ToString()
    {
        return Nome + "\n" + Caminhos.QuantosNos + " caminho(s)";
    }

    public void LerRegistro(BinaryReader arquivo, long registro)
    {
        if (arquivo != null)
        {
            try
            {
                long bytes = registro * TamanhoRegistro;
                arquivo.BaseStream.Seek(bytes, SeekOrigin.Begin);

                foreach (char letra in arquivo.ReadChars(tamanhoNome))
                    if (letra != '\0')
                        Nome += letra;

                X = arquivo.ReadDouble();
                Y = arquivo.ReadDouble();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }

    public void GravarRegistro(BinaryWriter arquivo)
    {
        if (arquivo != null)
        {
            char[] nome = new char[tamanhoNome];

            for (int i = 0; i < Nome.Length; i++)
                nome[i] = Nome[i];

            arquivo.Write(nome);
            arquivo.Write(X);
            arquivo.Write(Y);

            // salva a cidade no arquivo predefinido "c:\\temp\\CidadesMarte.json" em formato JSON,
            // a partir do conjunto de dados provenientes do .dat. dessa forma, o JSON é um reflexo das
            // alterações feitas pelo usuário a cada execução do programa, mantendo sempre a versão mais atualizada
            using (StreamWriter jsonCidades = new StreamWriter("c:\\temp\\CidadesMarte.json", true))
            {
                jsonCidades.WriteLine(JsonConvert.SerializeObject(this, Formatting.Indented));
                jsonCidades.Close();
            }

            // iniciamos um percurso sequencial
            Caminhos.IniciarPercursoSequencial();

            while (Caminhos.PodePercorrer())
            {
                // instanciamos um escritor de arquivos binários de acordo com o nome do arquivo do caminho
                BinaryWriter arquivoCaminhos =
                        new BinaryWriter(
                            new FileStream(Caminhos.Atual.Dado.NomeArquivo, FileMode.Append)
                        );

                // e gravamos o registro
                Caminhos.Atual.Dado.GravarRegistro(arquivoCaminhos);

                arquivoCaminhos.Close();
            }
        }
    }
}