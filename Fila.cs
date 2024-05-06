
public class Celula
{
    public Celula prox;
    public int value;
    public Celula(int value = 0)
    {
        this.prox = null;
        this.value = value;
    }
}
class Lista
{
    Celula primeiro, ultimo;
    int count;


    public Lista()
    {
        primeiro = new Celula();
        ultimo = primeiro;
        this.count = 0;

    }
    public void InserirInicio(int value)
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
    public void inserirVazio(int value = 0)
    {
        primeiro.prox = new Celula(value);
        ultimo = primeiro.prox;
    }
    public void InserirFinal(int value)
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
    public void InserirMeio(int value, int pos)
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
            InserirFinal(value);
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
    public int Remove(int pos)
    {
        if (pos < 0 || pos > count - 1)
        {
            throw new Exception("Posicao nao existe");
        }

        Celula aux = primeiro;
        if (pos == 0)
        {
            primeiro.prox = primeiro.prox.prox;
            count--;
            return aux.value;
        }

        Celula j = primeiro;
        for (int i = 0; i < pos; i++, j = j.prox) ;
        aux = j.prox;
        j.prox = j.prox.prox;
        if (pos == count - 1)
        {
            ultimo = j.prox;
        }
        count--;
        return aux.value;





    }
}
class ListaSemCabeca
{
    Celula primeiro, ultimo;
    int count;
    public ListaSemCabeca()
    {
        primeiro = null;
        ultimo = null;
        count = 0;


    }
    public void InserirVazio(int value)
    {
        primeiro = new Celula(value);
        ultimo = primeiro;
        count++;
    }
    public void InserirInicio(int value)
    {
        if (primeiro == null)
        {
            InserirVazio(value);
            return;
        }
        Celula aux = primeiro;
        primeiro = new Celula(value);
        primeiro.prox = aux;
        count++;


    }
    public void InserirFinal(int value)
    {
        if (ultimo == null)
        {
            InserirVazio(value);
            return;
        }
        ultimo.prox = new Celula(value);
        ultimo = ultimo.prox;
        count++;

    }
    public void InserirMeio(int value, int pos)
    {
        if (pos > count || pos < 0)
        {
            throw new Exception("Posicao Nao existe");
        }
        if (pos == count)
        {
            InserirFinal(value);
            return;
        }
        if (pos == 0)
        {
            InserirInicio(value);
            return;
        }
        Celula J = primeiro;
        for (int i = 1; i < pos; i++, J = J.prox) ;
        Celula aux = J.prox;
        J.prox = new Celula(value);
        J.prox.prox = aux;
        count++;




    }
    public void Imprimir()
    {
        Celula aux = primeiro;
        while (aux != null)
        {
            System.Console.WriteLine(aux.value);
            aux = aux.prox;
        }
    }
    public int RemoverInicio()
    {
        if (count == 0)
        {
            throw new Exception("Lista vazia");

        }
        if (primeiro == ultimo)
        {
            ultimo = null;
        }

        Celula aux = primeiro;
        primeiro = primeiro.prox;
        count--;
        return aux.value;

    }
    public int RemoverFinal()
    {
        if (primeiro == ultimo)
        {
            RemoverInicio();
        }
        Celula J = primeiro;
        while (J.prox.prox != null)
        {
            J = J.prox;
        }
        Celula aux = J.prox;
        J.prox = null;
        ultimo = J;
        count--;
        return aux.value;


    }
    public int Remove(int pos)
    {
        if (pos == 0)
        {
            return RemoverInicio();
        }
        if (pos == count - 1)
        {
            return RemoverFinal();
        }
        Celula J = primeiro;
        for (int i = 1; i < pos; i++, J = J.prox) ;
        Celula aux = J.prox;
        J.prox = J.prox.prox;
        count--;
        return aux.value;



    }

}

class CelulaDupla
{
    public CelulaDupla prox;
    public CelulaDupla ant;
    public int value;
    public CelulaDupla(int value = 0)
    {
        this.prox = null;
        this.ant = null;
        this.value = value;
    }
}
class ListaDupla
{
    CelulaDupla primeiro, ultimo;
    public int count;
    public ListaDupla()
    {
        this.primeiro = new CelulaDupla();
        ultimo = primeiro;
        count = 0;



    }
    public void inserirVazio(int value)
    {
        primeiro.prox = new CelulaDupla(value);
        ultimo = primeiro.prox;
        primeiro.prox.ant = primeiro;
        count++;
        return;
    }
    public void inserirInicio(int value)
    {
        if (primeiro == ultimo)
        {
            inserirVazio(value);
            return;
        }
        CelulaDupla aux = primeiro.prox;
        primeiro.prox = new CelulaDupla(value);
        primeiro.prox.ant = primeiro;
        primeiro.prox.prox = aux;
        aux.ant = primeiro.prox;
        count++;

    }
    public void inserirFinal(int value)
    {
        if (primeiro == ultimo)
        {
            inserirVazio(value);
            return;
        }
        ultimo.prox = new CelulaDupla(value);
        CelulaDupla aux = ultimo;
        ultimo = ultimo.prox;
        ultimo.ant = aux;
        count++;


    }
    public void inserir(int value, int pos)
    {
        if (pos > count || pos < 0)
        {
            throw new Exception("Nao existe pos");

        }
        if (pos == 0)
        {
            inserirInicio(value);
            return;
        }
        if (count == pos)
        {
            inserirFinal(value);
            return;
        }
        var j = primeiro.prox;
        for (int i = 1; i < pos; i++, j = j.prox) ;
        var aux = j.prox;
        j.prox = new CelulaDupla(value);
        j.prox.prox = aux;
        j.prox.ant = j;
        aux.ant = j.prox;
        count++;



    }
    public void imprimir()
    {
        CelulaDupla aux = primeiro.prox;
        while (aux != null)
        {
            Console.WriteLine(aux.value);
            aux = aux.prox;

        }
    }

    public void imprimirReverso()
    {
        CelulaDupla aux = ultimo;
        while (aux != primeiro)
        {
            Console.WriteLine(aux.value);
            aux = aux.ant;

        }
    }
    public int RemoverInicio()
    {
        if (count == 0) throw new Exception("Nao existe elementos na lista");
        CelulaDupla aux;
        if (primeiro.prox == ultimo)
        {
            aux = primeiro.prox;
            primeiro.prox = null;
            ultimo = primeiro;
            count--;
            return aux.value;


        }
        aux = primeiro.prox;
        aux.prox.ant = primeiro;
        primeiro.prox = aux.prox;
        count--;
        return aux.value;

    }
    public int RemoverFinal()
    {
        if (count == 0) throw new Exception("Nao existem elementos");
        CelulaDupla aux = ultimo;
        ultimo = ultimo.ant;
        ultimo.prox = null;
        count--;
        return aux.value;

    }
    public int remover(int pos)
    {
        if (pos == 0) return RemoverInicio();
        if (pos == count - 1) return RemoverFinal();
        var j = primeiro.prox;
        for (int i = 0; i < pos; i++, j = j.prox) ;

        j.ant.prox = j.prox;
        j.prox.ant = j.ant;
        count--;
        return j.value;


    }

}
class ListaDuplaSemCabeca
{
    CelulaDupla primeiro, ultimo;
    public int count;
    public ListaDuplaSemCabeca()
    {
        this.primeiro = null;
        ultimo = primeiro;
        count = 0;



    }
    public void inserirVazio(int value)
    {
        primeiro = new CelulaDupla(value);
        ultimo = primeiro;

        count++;
        return;
    }
    public void inserirInicio(int value)
    {
        if (primeiro == null)
        {
            inserirVazio(value);
            return;
        }
        CelulaDupla aux = primeiro;
        primeiro = new CelulaDupla(value);
        primeiro.prox = aux;
        aux.ant = primeiro;
        count++;

    }
    public void inserirFinal(int value)
    {
        if (primeiro == ultimo)
        {
            inserirVazio(value);
            return;
        }
        ultimo.prox = new CelulaDupla(value);
        CelulaDupla aux = ultimo;
        ultimo = ultimo.prox;
        ultimo.ant = aux;
        count++;


    }
    public void inserir(int value, int pos)
    {
        if (pos > count || pos < 0)
        {
            throw new Exception("Nao existe pos");

        }
        if (pos == 0)
        {
            inserirInicio(value);
            return;
        }
        if (count == pos)
        {
            inserirFinal(value);
            return;
        }
        var j = primeiro;
        for (int i = 1; i < pos; i++, j = j.prox) ;
        var aux = j.prox;
        j.prox = new CelulaDupla(value);
        j.prox.prox = aux;
        j.prox.ant = j;
        aux.ant = j.prox;
        count++;



    }
    public void imprimir()
    {
        CelulaDupla aux = primeiro;
        while (aux != null)
        {
            Console.WriteLine(aux.value);
            aux = aux.prox;

        }
    }

    public void imprimirReverso()
    {
        CelulaDupla aux = ultimo;
        while (aux != null)
        {
            Console.WriteLine(aux.value);
            aux = aux.ant;

        }
    }
    public int RemoverInicio()
    {
        if (count == 0) throw new Exception("Nao existe elementos na lista");
        CelulaDupla aux;
        if (primeiro == ultimo)
        {
            aux = primeiro;
            primeiro = null;
            ultimo = primeiro;
            count--;
            return aux.value;


        }
        aux = primeiro;
        aux.prox.ant = null;
        primeiro = aux.prox;
        count--;
        return aux.value;

    }
    public int RemoverFinal()
    {
        if (count == 0) throw new Exception("Nao existem elementos");
        CelulaDupla aux = ultimo;
        ultimo = ultimo.ant;
        ultimo.prox = null;
        count--;
        return aux.value;

    }
    public int remover(int pos)
    {
        if (pos == 0) return RemoverInicio();
        if (pos == count - 1) return RemoverFinal();
        var j = primeiro;
        for (int i = 0; i < pos; i++, j = j.prox) ;

        j.ant.prox = j.prox;
        j.prox.ant = j.ant;
        count--;
        return j.value;


    }

}




