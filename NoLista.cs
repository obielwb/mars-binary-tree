// Gabriel Willian Bartmanovicz - 21234
// João Pedro Ferreira Barbosa - 21687

using System;

public class NoLista<T> where T : IComparable<T>
{
    private T dado;
    private NoLista<T> prox;

    public T Dado { get => dado; set => dado = value; }
    public NoLista<T> Proximo { get => prox; set => prox = value; }

    public NoLista(T dado, NoLista<T> proximo)
    {
        Dado = dado;
        Proximo = proximo;
    }

    public NoLista(T dado)
    {
        Dado = dado;
        Proximo = null;
    }
}
