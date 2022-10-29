// Gabriel Willian Bartmanovicz - 21234
// Jo�o Pedro Ferreira Barbosa - 21687

using System;

class NoArvore<T> : IComparable<NoArvore<T>> where T : IComparable<T>
{
    private T dado;
    private NoArvore<T> esquerda;
    private NoArvore<T> direita;
    private int altura;
    private bool estaMarcadoParaMorrer;

    public NoArvore(T dado, NoArvore<T> esquerdo, NoArvore<T> direito, int altura)
    {
        Dado = dado;
        Esquerda = esquerdo;
        Direita = direito;
        Altura = altura;
    }

    public NoArvore(T dado)
    {
        Dado = dado;
        Esquerda = null;
        Direita = null;
        Altura = 0;
        EstaMarcadoParaMorrer = false;
    }

    public int Altura { get => altura; set => altura = value; }
    public T Dado { get => dado; set => dado = value; }
    public NoArvore<T> Esquerda { get => esquerda; set => esquerda = value; }
    public NoArvore<T> Direita { get => direita; set => direita = value; }
    public bool EstaMarcadoParaMorrer { get => estaMarcadoParaMorrer; set => estaMarcadoParaMorrer = value; }

    public int CompareTo(NoArvore<T> no)
    {
        return Dado.CompareTo(no.Dado);
    }

    public bool Equals(NoArvore<T> no)
    {
        return Dado.Equals(no.Dado);
    }
}
