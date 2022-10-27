// Gabriel Willian Bartmanovicz - 21234
// João Pedro Ferreira Barbosa - 21687

using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.IO;

class ArvoreDeBusca<Dado> where Dado : IComparable<Dado>, IRegistro, new()
{
    NoArvore<Dado> raiz, atual, antecessor;
    int quantosNos;
    Panel painelArvore;

    public Panel OndeExibir { get => painelArvore; set => painelArvore = value; }

    public ArvoreDeBusca()
    {
        raiz = null;
        atual = null;
        antecessor = null;
        quantosNos = 0;
    }

    public NoArvore<Dado> Raiz { get => raiz; set => raiz = value; }
    public string InOrdem { get { return FazInOrdem(raiz); } }
    public string PreOrdem { get { return FazPreOrdem(raiz); } }
    public string PosOrdem { get { return FazPosOrdem(raiz); } }
    public NoArvore<Dado> Atual { get => atual; set => atual = value; }

    private string FazInOrdem(NoArvore<Dado> r)
    {
        if (r == null)
            return "";

        return FazInOrdem(r.Esquerda) + " " +
               r.Dado.ToString() + " " +
               FazInOrdem(r.Direita);
    }

    private string FazPreOrdem(NoArvore<Dado> r)
    {
        if (r == null)
            return "";

        return r.Dado.ToString() + " " +
               FazPreOrdem(r.Esquerda) + " " +
               FazPreOrdem(r.Direita);
    }

    private string FazPosOrdem(NoArvore<Dado> r)
    {
        if (r == null)
            return "";

        return FazPosOrdem(r.Esquerda) + " " +
               FazPosOrdem(r.Direita) + " " +
               r.Dado.ToString();
    }

    private bool Eq(NoArvore<Dado> atualA,
                    NoArvore<Dado> atualB)
    {
        if (atualA == null && atualB == null)
            return true;

        if ((atualA == null) != (atualB == null))
            return false;

        if (atualA.Dado.CompareTo(atualB.Dado) != 0)
            return false;

        return Eq(atualA.Esquerda, atualB.Esquerda) &&
               Eq(atualA.Direita, atualB.Direita);
    }

    public bool EquivaleA(ArvoreDeBusca<Dado> arvore)
    {
        return Eq(this.raiz, arvore.Raiz);
    }

    private int QuantosNos(NoArvore<Dado> no)
    {
        if (no == null)
            return 0;

        return 1 +
            QuantosNos(no.Esquerda) +
            QuantosNos(no.Direita);
    }

    public int QuantosNos()
    {
        return QuantosNos(raiz);
    }

    private int QuantasFolhas(NoArvore<Dado> no)
    {
        if (no == null)
            return 0;
        if (no.Esquerda == null && no.Direita == null)
            return 1;

        return QuantasFolhas(no.Esquerda) +
               QuantasFolhas(no.Direita);
    }

    public int QuantasFolhas()
    {
        return QuantasFolhas(raiz);
    }

    private bool EstritamenteBinaria(NoArvore<Dado> no)
    {
        if (no == null)
            return true;

        if (no.Esquerda == null && no.Direita == null)
            return true;

        if (no.Esquerda == null && no.Direita != null)
            return false;

        if (no.Esquerda != null && no.Direita == null)
            return false;

        return EstritamenteBinaria(no.Esquerda) &&
               EstritamenteBinaria(no.Direita);
    }

    public bool EstritamenteBinaria()
    {
        return EstritamenteBinaria(raiz);
    }

    private int Altura(NoArvore<Dado> no)
    {
        int alturaEsquerda,
            alturaDireita;
        if (no == null)
            return 0;
        alturaEsquerda = Altura(no.Esquerda);
        alturaDireita = Altura(no.Direita);
        if (alturaEsquerda >= alturaDireita)
            return 1 + alturaEsquerda;
        return 1 + alturaDireita;
    }

    public int Altura()
    {
        return Altura(raiz);
    }

    private string EntreParenteses(NoArvore<Dado> no)
    {
        string saida = "(";
        if (no != null)
            saida += no.Dado + ":" +
            EntreParenteses(no.Esquerda) +
            "," +
            EntreParenteses(no.Direita);
        saida += ")";
        return saida;
    }

    public string EntreParenteses()
    {
        return EntreParenteses(raiz);
    }

    private void Trocar(NoArvore<Dado> no)
    {
        if (no != null)
        {
            NoArvore<Dado> auxiliar = no.Esquerda;
            no.Esquerda = no.Direita;
            no.Direita = auxiliar;
            Trocar(no.Esquerda);
            Trocar(no.Direita);
        }
    }

    public void Trocar()
    {
        Trocar(raiz);
    }

    private string PercursoPorNiveis(NoArvore<Dado> no)
    {
        string saida = "";

        Queue<NoArvore<Dado>> umaFila = new Queue<NoArvore<Dado>>();
        while (no != null)
        {
            if (no.Esquerda != null)
                umaFila.Enqueue(no.Esquerda);
            if (no.Direita != null)
                umaFila.Enqueue(no.Direita);
            saida += " " + no.Dado;
            if (umaFila.Count == 0)
                no = null;
            else
                no = umaFila.Dequeue();
        }
        return saida;
    }

    public string PercursoPorNiveis()
    {
        return PercursoPorNiveis(raiz);
    }

    int[] quantosNoNivel = new int[1000];
    private int Largura(NoArvore<Dado> no)
    {
        for (int i = 0; i < 1000; i++)
            quantosNoNivel[i] = 0;
        ContarNosNosNiveis(no, 0);

        int indiceMaior = 0;
        for (int i = 0; i < 1000; i++)
            if (quantosNoNivel[i] > quantosNoNivel[indiceMaior])
                indiceMaior = i;
        return quantosNoNivel[indiceMaior];
    }

    public int Largura()
    {
        return Largura(raiz);
    }

    public void ContarNosNosNiveis(NoArvore<Dado> no, int qualNivel)
    {
        if (no != null)
        {
            ++quantosNoNivel[qualNivel];
            ContarNosNosNiveis(no.Esquerda, qualNivel + 1);
            ContarNosNosNiveis(no.Direita, qualNivel + 1);
        }
    }

    bool achou = false;
    private string EscreverAntecessores(NoArvore<Dado> atual, Dado procurado)
    {
        string saida = "";
        if (atual != null)
        {
            if (!achou)
                EscreverAntecessores(atual.Esquerda, procurado);
            if (!achou)
                EscreverAntecessores(atual.Direita, procurado);
            if (atual.Dado.CompareTo(procurado) == 0)
                achou = true;
            if (achou)
                saida += " " + atual.Dado;
        }

        return saida;
    }

    public string PreparaEscritaDosAntecessores(Dado procurado)
    {
        achou = false;
        return EscreverAntecessores(Raiz, procurado);
    }

    public void DesenharArvore(bool primeiraVez, NoArvore<Funcionario> raiz,
                              int x, int y, double angulo, double incremento,
                              double comprimento, Graphics graphics)
    {
        int xf, yf;
        if (raiz != null)
        {
            Pen caneta = new Pen(Color.Red);
            xf = (int)Math.Round(x + Math.Cos(angulo) * comprimento);
            yf = (int)Math.Round(y + Math.Sin(angulo) * comprimento);

            if (primeiraVez)
                yf = 25;

            graphics.DrawLine(caneta, x, y, xf, yf);
            Thread.Sleep(200);
            DesenharArvore(false, raiz.Esquerda, xf, yf, Math.PI / 2 + incremento,
                                   incremento * 0.60, comprimento * 0.8, graphics);
            DesenharArvore(false, raiz.Direita, xf, yf, Math.PI / 2 - incremento,
                                    incremento * 0.6, comprimento * 0.8, graphics);
            Thread.Sleep(100);
            SolidBrush preenchimento = new SolidBrush(Color.MediumAquamarine);
            graphics.FillEllipse(preenchimento, xf - 25, yf - 15, 42, 30);
            graphics.DrawString(Convert.ToString(raiz.Dado.ToString()),
                         new Font("Arial", 10),
                         new SolidBrush(Color.Black), xf - 23, yf - 7);
        }
    }

    public bool Existe(Dado procurado)
    {
        antecessor = null;
        atual = raiz;
        while (atual != null)
        {
            if (atual.Dado.CompareTo(procurado) == 0)
                return true;

            antecessor = atual;
            if (procurado.CompareTo(atual.Dado) < 0)
                atual = atual.Esquerda;
            else
                atual = atual.Direita;
        }

        return false;
    }

    private bool ExisteRec(NoArvore<Dado> local, Dado procurado)
    {
        if (local == null)
            return false;

        if (local.Dado.CompareTo(procurado) == 0)
        {
            atual = local;
            return true;
        }

        antecessor = local;
        if (procurado.CompareTo(local.Dado) < 0)
            return ExisteRec(local.Esquerda, procurado);
        else
            return ExisteRec(local.Direita, procurado);
    }

    public bool ExisteRegistro(Dado procurado)
    {
        return ExisteRec(raiz, procurado);
    }

    public void Incluir(Dado dadoLido)
    {
        Incluir(ref raiz, dadoLido);
    }

    private void Incluir(ref NoArvore<Dado> atual, Dado dadoLido)
    {
        if (atual == null)
        {
            atual = new NoArvore<Dado>(dadoLido);
        }
        else
            if (dadoLido.CompareTo(atual.Dado) == 0)
                throw new Exception("Já existe esse registro!");
        else
            if (dadoLido.CompareTo(atual.Dado) > 0)
            {
                NoArvore<Dado> apDireito = atual.Direita;
                Incluir(ref apDireito, dadoLido);
                atual.Direita = apDireito;
            }
        else
        {
            NoArvore<Dado> apEsquerdo = atual.Esquerda;
            Incluir(ref apEsquerdo, dadoLido);
            atual.Esquerda = apEsquerdo;
        }
    }

    private void Incluir2(ref NoArvore<Dado> atual, Dado dadoLido)
    {
        if (Existe(dadoLido))
            throw new Exception("Já existe esse registro!");

        NoArvore<Dado> novoNo = new NoArvore<Dado>(dadoLido);

        if (raiz == null)
            raiz = novoNo;

        else
          if (dadoLido.CompareTo(antecessor.Dado) < 0)
            antecessor.Esquerda = novoNo;
        else
            antecessor.Direita = novoNo;
    }

    public void LerArquivoDeRegistros(string nomeArquivo)
    {
        raiz = null;
        Dado dado = new Dado();
        FileStream origem = new FileStream(nomeArquivo, FileMode.OpenOrCreate);
        BinaryReader arquivo = new BinaryReader(origem);
        // MessageBox.Show("Tamanho do arquivo =" + origem.Length + "\n\nTamanho do registro = " + dado.TamanhoRegistro);
        int posicaoFinal = (int)origem.Length / dado.TamanhoRegistro - 1;
        Particionar(0, posicaoFinal, ref raiz);
        origem.Close();

        void Particionar(long inicio, long fim, ref NoArvore<Dado> atual)
        {
            if (inicio <= fim)
            {
                long meio = (inicio + fim) / 2;

                dado = new Dado();
                dado.LerRegistro(arquivo, meio);
                atual = new NoArvore<Dado>(dado);
                NoArvore<Dado> novoEsquerdo = atual.Esquerda;
                Particionar(inicio, meio - 1, ref novoEsquerdo);
                atual.Esquerda = novoEsquerdo;
                NoArvore<Dado> novoDireito = atual.Direita;
                Particionar(meio + 1, fim, ref novoDireito);
                atual.Direita = novoDireito;
                atual.Altura = Math.Max(GetAltura(atual.Esquerda), GetAltura(atual.Direita)) + 1;
            }
        }
    }

    public void GravarArquivoDeRegistros(string nomeArquivo)
    {
        FileStream destino = new FileStream(nomeArquivo, FileMode.Create);
        BinaryWriter arquivo = new BinaryWriter(destino);
        GravarInOrdem(raiz);
        arquivo.Close();

        void GravarInOrdem(NoArvore<Dado> r)
        {
            if (r != null)
            {
                GravarInOrdem(r.Esquerda);

                r.Dado.GravarRegistro(arquivo);

                GravarInOrdem(r.Direita);
            }
        }
    }

    public void Inserir(Dado novosDados)
    {
        bool achou = false, fim = false;
        NoArvore<Dado> novoNo = new NoArvore<Dado>(novosDados);
        if (raiz == null)
            raiz = novoNo;
        else
        {
            antecessor = null;
            atual = raiz;
            while (!achou && !fim)
            {
                antecessor = atual;
                if (novosDados.CompareTo(atual.Dado) < 0)
                {
                    atual = atual.Esquerda;
                    if (atual == null)
                    {
                        antecessor.Esquerda = novoNo;
                        fim = true;
                    }
                }
                else
                    if (novosDados.CompareTo(atual.Dado) == 0)
                        achou = true;
                else
                {
                    atual = atual.Direita;
                    if (atual == null)
                    {
                        antecessor.Direita = novoNo;
                        fim = true;
                    }
                }
            }
        }
    }

    public void IncluirNovoRegistro(Dado novoRegistro)
    {
        if (Existe(novoRegistro))
            throw new Exception("Registro com chave repetida!");
        else
        {
            NoArvore<Dado> novoNo = new NoArvore<Dado>(novoRegistro);

            if (raiz == null)
                raiz = novoNo;
            else
              if (novoRegistro.CompareTo(antecessor.Dado) < 0)
                antecessor.Esquerda = novoNo;
            else
                antecessor.Direita = novoNo;

        }
    }
    public bool Excluir(Dado procurado)
    {
        return Excluir(ref raiz);

        bool Excluir(ref NoArvore<Dado> atual)
        {
            NoArvore<Dado> atualAnterior;
            if (atual == null)
                return false;
            else
                if (atual.Dado.CompareTo(procurado) > 0)
                {
                    NoArvore<Dado> temp = atual.Esquerda;
                    bool result = Excluir(ref temp);
                    atual.Esquerda = temp;
                    return result;
                }
            else
                if (atual.Dado.CompareTo(procurado) < 0)
                {
                    NoArvore<Dado> temp = atual.Direita;
                    bool result = Excluir(ref temp);
                    atual.Esquerda = temp;
                    return result;
                }
            else
            {
                atualAnterior = atual;
                if (atual.Direita == null)
                    atual = atual.Esquerda;
                else
                  if (atual.Esquerda == null)
                    atual = atual.Direita;
                else
                {
                    NoArvore<Dado> temp = atual.Esquerda;
                    Rearranjar(ref temp, ref atualAnterior);
                    atual.Esquerda = temp;
                    atualAnterior = null;
                }

                return true;
            }
        }

        void Rearranjar(ref NoArvore<Dado> aux, ref NoArvore<Dado> atualAnterior)
        {
            if (aux.Direita != null)
            {
                NoArvore<Dado> temp = aux.Direita;
                Rearranjar(ref temp, ref atualAnterior);
                aux.Direita = temp;
            }
            else
            {
                atualAnterior.Dado = aux.Dado;
                atualAnterior = aux;
                aux = aux.Esquerda;
            }
        }

    }

    public bool ApagarNo(Dado registroARemover)
    {
        atual = raiz;
        antecessor = null;
        bool ehFilhoEsquerdo = true;
        while (atual.Dado.CompareTo(registroARemover) != 0)
        {
            antecessor = atual;
            if (atual.Dado.CompareTo(registroARemover) > 0)
            {
                ehFilhoEsquerdo = true;
                atual = atual.Esquerda;
            }
            else
            {
                ehFilhoEsquerdo = false;
                atual = atual.Direita;
            }

            if (atual == null)
                return false;
        }

        if ((atual.Esquerda == null) && (atual.Direita == null))
        {
            if (atual == raiz)
                raiz = null;
            else
                if (ehFilhoEsquerdo)
                antecessor.Esquerda = null;
            else
                antecessor.Direita = null;

            atual = antecessor;
        }
        else
            if (atual.Direita == null)
            {
                if (atual == raiz)
                    raiz = atual.Esquerda;
                else
                    if (ehFilhoEsquerdo)
                    antecessor.Esquerda = atual.Esquerda;
                else
                    antecessor.Direita = atual.Esquerda;
                atual = antecessor;
            }
        else
            if (atual.Esquerda == null)
            {
                if (atual == raiz)
                    raiz = atual.Direita;
                else
                    if (ehFilhoEsquerdo)
                    antecessor.Esquerda = atual.Direita;
                else
                    antecessor.Direita = atual.Direita;
                atual = antecessor;
            }
        else
        {
            NoArvore<Dado> menorDosMaiores = ProcuraMenorDosMaioresDescendentes(atual);
            atual.Dado = menorDosMaiores.Dado;
            menorDosMaiores = null;
        }

        return true;
    }

    public NoArvore<Dado> ProcuraMenorDosMaioresDescendentes(NoArvore<Dado> noAExcluir)
    {
        NoArvore<Dado> paiDoSucessor = noAExcluir;
        NoArvore<Dado> sucessor = noAExcluir;
        NoArvore<Dado> atual = noAExcluir.Direita;

        while (atual != null)
        {
            if (atual.Esquerda != null)
                paiDoSucessor = atual;
            sucessor = atual;
            atual = atual.Esquerda;
        }

        if (sucessor != noAExcluir.Direita)
        {
            paiDoSucessor.Esquerda = sucessor.Direita;
            sucessor.Direita = noAExcluir.Direita;
        }

        return sucessor;
    }

    public int AlturaArvore(NoArvore<Dado> atual, ref bool balanceada)
    {
        int alturaDireita, alturaEsquerda, result;
        if (atual != null && balanceada)
        {
            alturaEsquerda = 1 + AlturaArvore(atual.Esquerda, ref balanceada);
            alturaDireita = 1 + AlturaArvore(atual.Direita, ref balanceada);
            result = Math.Max(alturaEsquerda, alturaDireita);

            if (Math.Abs(alturaDireita - alturaEsquerda) > 1)
                balanceada = false;
        }
        else
            result = 0;

        return result;
    }

    public int GetAltura(NoArvore<Dado> no)
    {
        if (no != null)
            return no.Altura;
        else
            return -1;
    }

    public void InserirBalanceado(Dado item)
    {
        raiz = InserirBalanceado(item, raiz);
    }

    private NoArvore<Dado> InserirBalanceado(Dado item, NoArvore<Dado> no)
    {
        if (no == null)
            no = new NoArvore<Dado>(item);
        else
        {
            if (item.CompareTo(no.Dado) < 0)
            {
                no.Esquerda = InserirBalanceado(item, no.Esquerda);
                if (Math.Abs(GetAltura(no.Esquerda) - GetAltura(no.Direita)) == 2)
                    if (item.CompareTo(no.Esquerda.Dado) < 0)
                        no = RotacaoSimplesComFilhoEsquerdo(no);
                    else
                        no = RotacaoDuplaComFilhoEsquerdo(no);
            }
            else
                if (item.CompareTo(no.Dado) > 0)
                {
                    no.Direita = InserirBalanceado(item, no.Direita);
                    if (Math.Abs(GetAltura(no.Direita) - GetAltura(no.Esquerda)) == 2)
                        if (item.CompareTo(no.Direita.Dado) > 0)
                            no = RotacaoSimplesComFilhoDireito(no);
                        else
                            no = RotacaoDuplaComFilhoDireito(no);
                }
            no.Altura = Math.Max(GetAltura(no.Esquerda), GetAltura(no.Direita)) + 1;
        }

        return no;
    }

    private NoArvore<Dado> RotacaoSimplesComFilhoEsquerdo(NoArvore<Dado> no)
    {
        NoArvore<Dado> temp = no.Esquerda;
        no.Esquerda = temp.Direita;
        temp.Direita = no;
        no.Altura = Math.Max(GetAltura(no.Esquerda), GetAltura(no.Direita)) + 1;
        temp.Altura = Math.Max(GetAltura(temp.Esquerda), GetAltura(no)) + 1;
        return temp;
    }

    private NoArvore<Dado> RotacaoSimplesComFilhoDireito(NoArvore<Dado> no)
    {
        NoArvore<Dado> temp = no.Direita;
        no.Direita = temp.Esquerda;
        temp.Esquerda = no;
        no.Altura = Math.Max(GetAltura(no.Esquerda), GetAltura(no.Direita)) + 1;
        temp.Altura = Math.Max(GetAltura(temp.Direita), GetAltura(no)) + 1;
        return temp;
    }

    private NoArvore<Dado> RotacaoDuplaComFilhoEsquerdo(NoArvore<Dado> no)
    {
        no.Esquerda = RotacaoSimplesComFilhoDireito(no.Esquerda);
        return RotacaoSimplesComFilhoEsquerdo(no);
    }

    private NoArvore<Dado> RotacaoDuplaComFilhoDireito(NoArvore<Dado> no)
    {
        no.Direita = RotacaoSimplesComFilhoEsquerdo(no.Direita);
        return RotacaoSimplesComFilhoDireito(no);
    }
}
