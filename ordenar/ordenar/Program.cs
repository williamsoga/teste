using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Lê a lista de números inteiros
        Console.WriteLine("Digite a quantidade de números:");
        int n = int.Parse(Console.ReadLine());
        List<int> numeros = new List<int>();

        Console.WriteLine("Digite os números:");
        for (int i = 0; i < n; i++)
        {
            numeros.Add(int.Parse(Console.ReadLine()));
        }

        // Ordenando a lista usando o algoritmo Bubble Sort em ordem decrescente
        BubbleSort(numeros);

        // Exibindo os números ordenados
        Console.WriteLine("\nLista ordenada em ordem decrescente:");
        foreach (var num in numeros)
        {
            Console.Write(num + " ");
        }

        // Exibindo os três maiores números
        Console.WriteLine("\nTrês maiores números:");
        int count = Math.Min(3, numeros.Count); // Se houver menos de 3 números
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(numeros[i]);
        }

        // Verificando e removendo o número 100
        if (numeros.Contains(100))
        {
            numeros.Remove(100);
            Console.WriteLine("\nNúmero 100 removido da lista.");
        }
        else
        {
            Console.WriteLine("\nNúmero 100 não encontrado na lista.");
        }

        // Exibindo a lista final após a remoção do 100
        Console.WriteLine("\nLista final:");
        foreach (var num in numeros)
        {
            Console.Write(num + " ");
        }
    }

    // Método para ordenar a lista usando Bubble Sort
    static void BubbleSort(List<int> lista)
    {
        int n = lista.Count;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (lista[j] < lista[j + 1])
                {
                    // Troca os elementos
                    int temp = lista[j];
                    lista[j] = lista[j + 1];
                    lista[j + 1] = temp;
                }
            }
        }
    }
}
