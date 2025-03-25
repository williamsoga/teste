using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<Cliente> fila = new Queue<Cliente>();

        // Adicionando 5 clientes à fila
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Digite o nome do cliente {i + 1}:");
            string nome = Console.ReadLine();
            Console.WriteLine("O cliente é preferencial? (s/n):");
            bool preferencial = Console.ReadLine().ToLower() == "s";
            Cliente cliente = new Cliente(nome, preferencial);
            AdicionarCliente(fila, cliente);
        }

        // Atendendo os clientes em ordem de chegada
        while (fila.Count > 0)
        {
            Cliente cliente = fila.Dequeue();
            Console.WriteLine($"Atendendo cliente: {cliente.Nome}");
        }

        // Verificando se a fila está vazia
        if (fila.Count == 0)
        {
            Console.WriteLine("Todos os clientes foram atendidos. A fila está vazia.");
        }
    }

    static void AdicionarCliente(Queue<Cliente> fila, Cliente cliente)
    {
        if (cliente.Preferencial)
        {
            // Movendo cliente preferencial para o início da fila
            Queue<Cliente> tempFila = new Queue<Cliente>();
            tempFila.Enqueue(cliente);
            while (fila.Count > 0)
            {
                tempFila.Enqueue(fila.Dequeue());
            }
            while (tempFila.Count > 0)
            {
                fila.Enqueue(tempFila.Dequeue());
            }
        }
        else
        {
            fila.Enqueue(cliente);
        }
    }
}

class Cliente
{
    public string Nome { get; set; }
    public bool Preferencial { get; set; }

    public Cliente(string nome, bool preferencial)
    {
        Nome = nome;
        Preferencial = preferencial;
    }
}