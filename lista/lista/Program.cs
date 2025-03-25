using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Criando uma lista de frutas
        List<string> frutas = new List<string> { "maçã", "banana", "laranja", "uva" };

        // Adicionando um item à lista
        frutas.Add("manga");

        // Removendo um item da lista
        frutas.Remove("banana");

        // Acessando um item da lista pelo índice
        string primeiraFruta = frutas[0];

        // Imprimindo a lista e o item acessado
        Console.WriteLine("Lista de frutas: " + string.Join(", ", frutas));
        Console.WriteLine("Primeira fruta: " + primeiraFruta);
    }
}