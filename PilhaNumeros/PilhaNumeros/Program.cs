using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<int> numeros = new Stack<int>();
        numeros.Push(1);
        numeros.Push(-6);
        numeros.Push(4);
        numeros.Push(-5);
        numeros.Push(9);

        // Verificando e removendo números negativos
        Stack<int> tempStack = new Stack<int>();
        while (numeros.Count > 0)
        {
            int num = numeros.Pop();
            if (num >= 0)
            {
                tempStack.Push(num);
            }
        }

        // Invertendo a ordem dos números restantes na pilha
        Stack<int> invertedStack = new Stack<int>();
        while (tempStack.Count > 0)
        {
            invertedStack.Push(tempStack.Pop());
        }

        // Transferindo os elementos de volta para a pilha original
        while (invertedStack.Count > 0)
        {
            numeros.Push(invertedStack.Pop());
        }

        // Exibindo os elementos na pilha invertida
        Console.WriteLine("Elementos na pilha invertida:");
        foreach (int num in numeros)
        {
            Console.WriteLine(num);
        }
    }
}