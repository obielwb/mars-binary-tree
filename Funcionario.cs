// Gabriel Willian Bartmanovicz - 21234
// João Pedro Ferreira Barbosa - 21687

using System;
using System.IO;
using System.Windows.Forms;

class Cidade : IComparable<Cidade>, IRegistro
{
    public const int tamanhoNome = 15;

    private int codigo;
    private string nome;
    private decimal x, y;.
    const int tamanhoRegistro = sizeof(int) + // código
                                tamanhoNome + // nome
                                sizeof(decimal) + // x
                                sizeof(decimal); // y

    public int TamanhoRegistro { get => tamanhoRegistro; }
    public int Codigo { get => codigo; set => codigo = value; }
    public string Nome { get => nome; set => nome = value; }
    public decimal X { get => x; set => x = value; }
    public decimal Y { get => y; set => y = value; }

    public Cidade()
    {
        Codigo = 0;
        Nome = "";
        X = Y = 0;
    }

    public Cidade(int codigo, string nome, decimal x, decimal y)
    {
        Codigo = codigo;
        Nome = nome;
        X = x;
        Y = y;
    }

    public Cidade(int codigo)
    {
        Codigo = codigo;
    }

    public int CompareTo(Cidade cidade)
    {
        return nome.ToUpperInvariant().CompareTo(cidade.Nome.ToUpperInvariant());
    }

    public override string ToString()
    {
        return Codigo + " " + Nome + " " + X.ToString().PadLeft(7, ' ') + Y.ToString().PadLeft(7, ' '); ;
    }

    public void LerRegistro(BinaryReader arquivo, long registro)
    {
        if (arquivo != null)
        {
            try
            {
                long bytes = registro * TamanhoRegistro;
                arquivo.BaseStream.Seek(bytes, SeekOrigin.Begin);

                Codigo = arquivo.ReadInt32();

                char[] nome = new char[tamanhoNome];
                nome = arquivo.ReadChars(tamanhoNome);

                foreach (char letra in nome)
                    Nome += letra;

                X = arquivo.ReadDecimal();
                Y = arquivo.ReadDecimal();
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
            arquivo.Write(Codigo);

            char[] nome = new char[tamanhoNome];

            for (int i = 0; i < tamanhoNome; i++)
                nome[i] = Nome[i];

            arquivo.Write(nome);

            arquivo.Write(X);
            arquivo.Write(Y);
        }
    }
}