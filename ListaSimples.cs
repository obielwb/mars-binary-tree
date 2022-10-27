// Gabriel Willian Bartmanovicz - 21234
// João Pedro Ferreira Barbosa - 21687

using System;

class ListaSimples<T> where T : IComparable<T>
{
    NoLista<T> primeiro, ultimo, atual, anterior;
    int quantosNos;
    bool primeiroAcessoDoPercurso;

    public ListaSimples()
    {
        primeiro = ultimo = anterior = atual = null;
        quantosNos = 0;
        primeiroAcessoDoPercurso = false;
    }

    public void InserirAntesDoInicio(NoLista<T> novoNo)
    {
        if (EstaVazia)
            ultimo = novoNo;

        novoNo.Proximo = primeiro;
        primeiro = novoNo;
        quantosNos++;
    }

    public void InserirAposFim(NoLista<T> novoNo)
    {
        if (EstaVazia)
            primeiro = novoNo;
        else
            ultimo.Proximo = novoNo;

        quantosNos++;
        ultimo = novoNo;
        ultimo.Proximo = null;
    }

    public bool ExisteDado(T outroProcurado)
    {
        anterior = null;
        atual = primeiro;

        if (EstaVazia)
            return false;

        if (outroProcurado.CompareTo(primeiro.Dado) < 0)
            return false;

        if (outroProcurado.CompareTo(ultimo.Dado) > 0)
        {
            anterior = ultimo;
            atual = null;
            return false;
        }

        bool achou = false;
        bool fim = false;

        while (!achou && !fim)
            if (atual == null)
                fim = true;

            else
              if (outroProcurado.CompareTo(atual.Dado) == 0)
                achou = true;

            else
                if (atual.Dado.CompareTo(outroProcurado) > 0)
                fim = true;

            else
            {
                anterior = atual;
                atual = atual.Proximo;
            }

        return achou;
    }

    public void InserirEmOrdem(T dado)
    {
        if (!ExisteDado(dado))
        {
            NoLista<T> novo = new NoLista<T>(dado);
            if (EstaVazia)
                InserirAntesDoInicio(novo);
            else
                if (anterior == null && atual != null)
                InserirAntesDoInicio(novo);
            else
                if (anterior != null && atual == null)
                InserirAposFim(novo);
            else
                InserirNoMeio(novo);
        }
    }

    private void InserirNoMeio(NoLista<T> novo)
    {
        anterior.Proximo = novo;
        novo.Proximo = atual;

        if (anterior == ultimo)
            ultimo = novo;

        quantosNos++;
    }

    public bool RemoverDado(T dado)
    {
        if (ExisteDado(dado))
        {
            RemoverNo(ref atual, ref anterior);
            return true;
        }

        return false;
    }

    private void RemoverNo(ref NoLista<T> atual, ref NoLista<T> anterior)
    {
        if (!EstaVazia)
        {
            if (atual == primeiro)
            {
                primeiro = primeiro.Proximo;

                if (EstaVazia)
                    ultimo = null;
            }
            else
                if (atual == ultimo)
            {
                ultimo = anterior;
                ultimo.Proximo = null;
            }
            else
                anterior.Proximo = atual.Proximo;

            quantosNos--;
        }
    }

    public void IniciarPercursoSequencial()
    {
        primeiroAcessoDoPercurso = true;
        atual = primeiro;
        anterior = null;
    }

    public bool PodePercorrer()
    {
        if (!primeiroAcessoDoPercurso)
        {
            anterior = atual;
            atual = atual.Proximo;
        }
        else
            primeiroAcessoDoPercurso = false;

        return atual != null;
    }

    private void ProcurarMenorNo
        (ref NoLista<T> menorAteAgora,
         ref NoLista<T> anteriorAoMenor)
    {
        menorAteAgora = primeiro;
        anteriorAoMenor = null;

        IniciarPercursoSequencial();
        while (PodePercorrer())
        {
            if (atual.Dado.CompareTo(menorAteAgora.Dado) < 0)
            {
                anteriorAoMenor = anterior;
                menorAteAgora = atual;
            }
        }
    }

    public void Ordenar()
    {
        ListaSimples<T> ordenada = new ListaSimples<T>();
        NoLista<T> menorDeTodos = null, antesDoMenor = null;

        while (!EstaVazia)
        {
            ProcurarMenorNo(ref menorDeTodos, ref antesDoMenor);

            NoLista<T> novoNo = menorDeTodos;
            RemoverNo(ref menorDeTodos, ref antesDoMenor);

            ordenada.InserirAposFim(novoNo);
        }
    }

    public NoLista<T> Primeiro { get => primeiro; set => primeiro = value; }
    public NoLista<T> Ultimo { get => ultimo; set => ultimo = value; }
    public NoLista<T> Atual { get => atual; set => atual = value; }
    public NoLista<T> Anterior { get => anterior; set => anterior = value; }
    public bool EstaVazia { get { return primeiro == null; } }
}
