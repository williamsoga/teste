using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite uma expressão contendo apenas parênteses:");
        string expressao = Console.ReadLine();

        if (string.IsNullOrEmpty(expressao) || !ContemParenteses(expressao))
        {
            Console.WriteLine("A expressão não contém parênteses.");
        }
        else if (VerificarParentesesBalanceados(expressao))
        {
            Console.WriteLine("A expressão é válida.");
        }
        else
        {
            Console.WriteLine("A expressão não é válida.");
        }
    }

    static bool ContemParenteses(string expressao)
    {
        foreach (char ch in expressao)
        {
            if (ch == '(' || ch == ')')
            {
                return true;
            }
        }
        return false;
    }

    static bool VerificarParentesesBalanceados(string expressao)
    {
        Stack<char> pilha = new Stack<char>();

        foreach (char ch in expressao)
        {
            if (ch == '(')
            {
                pilha.Push(ch);
            }
            else if (ch == ')')
            {
                if (pilha.Count == 0)
                {
                    return false;
                }
                pilha.Pop();
            }
        }

        return pilha.Count == 0;
    }
}