// Gabriel Willian Bartmanovicz - 21234
// João Pedro Ferreira Barbosa - 21687

using System;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

class Caminho : IComparable<Caminho>, IRegistro
{
    public const int tamanhoCidade = 15;

    // nome arquivo é um buffer de string que armazena o local
    // do arquivo de caminhos para a gravação
    private string cidadeOrigem, cidadeDestino, nomeArquivo;
    private int distancia, tempo, custo;

    private const int tamanhoRegistro = tamanhoCidade + // cidade de origem
                                        tamanhoCidade + // cidade de destino
                                        sizeof(int) + // distância
                                        sizeof(int) + // tempo
                                        sizeof(int); // custo

    public string CidadeOrigem { get => cidadeOrigem; set => cidadeOrigem = value; }
    public string CidadeDestino { get => cidadeDestino; set => cidadeDestino = value; }
    public int Distancia { get => distancia; set => distancia = value; }
    public int Tempo { get => tempo; set => tempo = value; }
    public int Custo { get => custo; set => custo = value; }
    public int TamanhoRegistro { get => tamanhoRegistro; }
    public string NomeArquivo { get => nomeArquivo; set => nomeArquivo = value; }

    public Caminho()
    { }

    public Caminho(string cidadeOrigem, string cidadeDestino, int distancia, int tempo, int custo)
    {
        CidadeOrigem = cidadeOrigem;
        CidadeDestino = cidadeDestino;
        Distancia = distancia;
        Tempo = tempo;
        Custo = custo;
    }

    public Caminho(string cidadeOrigem, string cidadeDestino)
    {
        CidadeOrigem = cidadeOrigem;
        CidadeDestino = cidadeDestino;
    }

    public int CompareTo(Caminho outro)
    {
        return (CidadeOrigem + CidadeDestino).CompareTo(outro.CidadeOrigem + outro.CidadeDestino);
    }

    public override string ToString()
    {
        return CidadeOrigem + " " + CidadeDestino + " " + Distancia + " " + Tempo  + " " + Custo;
    }

    public void LerRegistro(BinaryReader arquivo, long registro)
    {
        if (arquivo != null)
        {
            try
            {
                long bytes = registro * TamanhoRegistro;
                arquivo.BaseStream.Seek(bytes, SeekOrigin.Begin);

                foreach (char letra in arquivo.ReadChars(tamanhoCidade))
                    if (letra != '\0')
                        cidadeOrigem += letra;

                foreach (char letra in arquivo.ReadChars(tamanhoCidade))
                    if (letra != '\0')
                        cidadeDestino += letra;

                Distancia = arquivo.ReadInt32();
                Tempo = arquivo.ReadInt32();
                Custo = arquivo.ReadInt32();
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
            char[] cidadeOrigem = new char[tamanhoCidade];

            for (int i = 0; i < CidadeOrigem.Length; i++)
                cidadeOrigem[i] = CidadeOrigem[i];

            char[] cidadeDestino = new char[tamanhoCidade];

            for (int i = 0; i < CidadeDestino.Length; i++)
                cidadeDestino[i] = CidadeDestino[i];

            arquivo.Write(cidadeOrigem);
            arquivo.Write(cidadeDestino);
            arquivo.Write(Distancia);
            arquivo.Write(Tempo);
            arquivo.Write(Custo);

            // salva o caminho no arquivo predefinido "c:\\temp\\CaminhoEntreCidadesMarte.json" em formato JSON,
            // a partir do conjunto de dados provenientes do .dat. dessa forma, o JSON é um reflexo das
            // alterações feitas pelo usuário a cada execução do programa, mantendo sempre a versão mais atualizada
            using (StreamWriter jsonCaminhos = new StreamWriter("c:\\temp\\CaminhoEntreCidadesMarte.json", true))
            {
                jsonCaminhos.WriteLine(JsonConvert.SerializeObject(this, Formatting.Indented));
                jsonCaminhos.Close();
            }
        }
    }
}
