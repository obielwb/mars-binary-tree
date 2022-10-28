// Gabriel Willian Bartmanovicz - 21234
// João Pedro Ferreira Barbosa - 21687

using System;
using System.IO;
using System.Windows.Forms;

class Caminho : IComparable<Caminho>, IRegistro
{
    private int codigoOrigem, codigoDestino, distancia, custo, tempo;

    private const int tamanhoRegistro = sizeof(int) + // código de origem
                                        sizeof(int) + // código de destino
                                        sizeof(int) + // distância
                                        sizeof(int) + // custo
                                        sizeof(int); // tempo

    public int CodigoOrigem { get => codigoOrigem; set => codigoOrigem = value; }
    public int CodigoDestino { get => codigoDestino; set => codigoDestino = value; }
    public int Distancia { get => distancia; set => distancia = value; }
    public int Custo { get => custo; set => custo = value; }
    public int Tempo { get => tempo; set => tempo = value; }
    public int TamanhoRegistro { get => tamanhoRegistro; }

    public Caminho()
    { }

    public Caminho(int codigoOrigem, int codigoDestino, int distancia, int custo, int tempo)
    {
        CodigoOrigem = codigoOrigem;
        CodigoDestino = codigoDestino;
        Distancia = distancia;
        Custo = custo;
        Tempo = tempo;
    }

    public int CompareTo(Caminho outro)
    {
        return (CodigoOrigem.ToString() + CodigoDestino.ToString()).CompareTo(outro.CodigoOrigem.ToString() + outro.CodigoDestino.ToString());
    }

    public override string ToString()
    {
        return CodigoOrigem + " " + CodigoDestino + " " + Distancia + " " + Custo + " " + Tempo;
    }

    public void LerRegistro(BinaryReader arquivo, long registro)
    {
        if (arquivo != null)
        {
            try
            {
                long bytes = registro * TamanhoRegistro;
                arquivo.BaseStream.Seek(bytes, SeekOrigin.Begin);

                CodigoOrigem = arquivo.ReadInt32();
                CodigoDestino = arquivo.ReadInt32();
                Distancia = arquivo.ReadInt32();
                Custo = arquivo.ReadInt32();
                Tempo = arquivo.ReadInt32();
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
            arquivo.Write(CodigoOrigem);
            arquivo.Write(CodigoDestino);
            arquivo.Write(Distancia);
            arquivo.Write(Custo);
            arquivo.Write(Tempo);
        }
    }
}
