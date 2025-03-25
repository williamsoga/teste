using System;
using System.Collections.Generic;

class Restaurante
{
    private Queue<string> fila;

    public Restaurante()
    {
        fila = new Queue<string>();
    }

    public void AdicionarPedido(string pedido)
    {
        fila.Enqueue(pedido);
        Console.WriteLine($"Pedido '{pedido}' adicionado à fila.");
    }

    public void AtenderPedido()
    {
        if (fila.Count > 0)
        {
            string pedido = fila.Dequeue();
            Console.WriteLine($"Pedido '{pedido}' atendido.");
        }
        else
        {
            Console.WriteLine("Nenhum pedido na fila para atender.");
        }
    }

    public void RemoverPedido(string pedido)
    {
        if (fila.Contains(pedido))
        {
            List<string> temp = new List<string>(fila);
            temp.Remove(pedido);
            fila = new Queue<string>(temp);
            Console.WriteLine($"Pedido '{pedido}' removido da fila.");
        }
        else
        {
            Console.WriteLine($"Pedido '{pedido}' não encontrado na fila.");
        }
    }

    public void ExibirPedidos()
    {
        if (fila.Count > 0)
        {
            Console.WriteLine("Pedidos na fila:");
            foreach (string pedido in fila)
            {
                Console.WriteLine($"- {pedido}");
            }
        }
        else
        {
            Console.WriteLine("Nenhum pedido na fila.");
        }
    }
}

// Exemplo de uso
class Program
{
    static void Main()
    {
        Restaurante restaurante = new Restaurante();
        restaurante.AdicionarPedido("Pizza");
        restaurante.AdicionarPedido("Hambúrguer");
        restaurante.ExibirPedidos();
        restaurante.AtenderPedido();
        restaurante.ExibirPedidos();
        restaurante.RemoverPedido("Hambúrguer");
        restaurante.ExibirPedidos();
    }
}