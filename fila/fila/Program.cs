using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<int> fila = new Queue<int>();

        // Adicionando elementos à fila
        fila.Enqueue(10);
        fila.Enqueue(20);
        fila.Enqueue(30);

        // Exibindo o elemento do início
        Console.WriteLine("Elemento no início: " + fila.Peek());

        // Removendo elementos da fila
        Console.WriteLine("Elemento removido: " + fila.Dequeue());
        Console.WriteLine("Elemento removido: " + fila.Dequeue());

        // Verificando se a fila está vazia
        Console.WriteLine("A fila está vazia? " + (fila.Count == 0));
    }
}