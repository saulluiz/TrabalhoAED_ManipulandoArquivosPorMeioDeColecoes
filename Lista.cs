
public class Celula
{
    public Celula prox;
    public People value;
    public Celula(People? value = null)
    {
        this.prox = null;
        this.value = value;
    }
}
public class Lista
{
    Celula primeiro, ultimo;
   public int count;

    public People this[int index]
    {
        get { return elementoNaPosicao(index).value; }
    }
    private Celula elementoNaPosicao(int pos)
    {
        Celula aux = primeiro.prox;
        for (int i = 0; i != pos; i++,aux=aux.prox) ;
        return aux;


    }
    public Lista()
    {
        primeiro = new Celula();
        ultimo = primeiro;
        this.count = 0;

    }
    public void InserirInicio(People? value = null)
    {
        if (primeiro == ultimo)
        {
            inserirVazio(value);
        }
        else
        {
            Celula aux = primeiro.prox;
            primeiro.prox = new Celula(value);
            primeiro.prox.prox = aux;
        }
        count++;

    }
    public void inserirVazio(People? value = null)
    {
        primeiro.prox = new Celula(value);
        ultimo = primeiro.prox;
    }
    public void Add(People? value = null)
    {
        if (primeiro == ultimo)
        {
            inserirVazio(value);
        }
        else
        {
            ultimo.prox = new Celula(value);
            ultimo = ultimo.prox;
        }
        count++;

    }
    public void InserirMeio(People value, int pos)
    {
        if (pos < 0 || pos > count)
        {
            throw new Exception("Pos Nao existe");
        }
        if (pos == 0)
        {
            InserirInicio(value);
            return;
        }
        if (pos == count)
        {
            Add(value);
            return;
        }
        Celula j = this.primeiro;
        for (int i = 0; i < pos; i++, j = j.prox) ;
        Celula aux = j.prox;
        j.prox = new Celula(value);
        j.prox.prox = aux;
        count++;
    }
    public void imprimir()
    {
        Celula aux = primeiro.prox;
        while (aux != null)
        {
            Console.WriteLine(aux.value);
            aux = aux.prox;
        }

    }

    public People Remove(int pos)
    {
        if (pos < 0 || pos > count - 1)
        {
            throw new Exception("Posicao nao existe");
        }

        Celula aux = primeiro.prox;
        if (pos == 0)
        {
            primeiro.prox = primeiro.prox.prox;
            count--;
            return aux.value;
        }

        Celula j = primeiro;
        for (int i = 1; i < pos; i++, j = j.prox) ;
        aux = j.prox;
        j.prox = j.prox.prox;
        if (pos == count - 1)
        {
            ultimo = j.prox;
        }
        count--;
        return aux.value;





    }
    public People removeFim(){

       return Remove(count-1);

    }
    public People removeinicio(){
       return Remove(0);
    }
}
