using System;
using System.Collections.Generic;

class ListaDeCompras
{
    private List<string> lista;

    public ListaDeCompras()
    {
        lista = new List<string>();
    }

    public void AdicionarItem(string item)
    {
        lista.Add(item);
        Console.WriteLine($"Item '{item}' adicionado à lista.");
    }

    public void RemoverItem(string item)
    {
        if (lista.Contains(item))
        {
            lista.Remove(item);
            Console.WriteLine($"Item '{item}' removido da lista.");
        }
        else
        {
            Console.WriteLine($"Item '{item}' não encontrado na lista.");
        }
    }

    public void ExibirLista()
    {
        if (lista.Count > 0)
        {
            Console.WriteLine("Itens na lista de compras:");
            foreach (string item in lista)
            {
                Console.WriteLine($"- {item}");
            }
        }
        else
        {
            Console.WriteLine("A lista de compras está vazia.");
        }
    }
}

// Exemplo de uso
class Program
{
    static void Main()
    {
        ListaDeCompras listaDeCompras = new ListaDeCompras();
        listaDeCompras.AdicionarItem("Leite");
        listaDeCompras.AdicionarItem("Pão");
        listaDeCompras.ExibirLista();
        listaDeCompras.RemoverItem("Pão");
        listaDeCompras.ExibirLista();
        listaDeCompras.RemoverItem("Ovos");
        listaDeCompras.ExibirLista();
    }
}