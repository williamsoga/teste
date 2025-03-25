using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<int> pilha = new Stack<int>();

        // Adicionando elementos à pilha
        pilha.Push(10);
        pilha.Push(20);
        pilha.Push(30);

        // Exibindo o elemento do topo
        Console.WriteLine("Elemento no topo: " + pilha.Peek());

        // Removendo elementos da pilha
        Console.WriteLine("Elemento removido: " + pilha.Pop());
        Console.WriteLine("Elemento removido: " + pilha.Pop());

        // Verificando se a pilha está vazia
        Console.WriteLine("A pilha está vazia? " + (pilha.Count == 0));
    }
}