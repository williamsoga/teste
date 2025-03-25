using System;
using System.Collections.Generic;
using System.Linq;

class ProgramaNotas
{
    private List<double> notas;
    private List<string> alunos;

    public ProgramaNotas()
    {
        notas = new List<double>();
        alunos = new List<string>();
    }

    public void InserirNotas()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Digite o nome do aluno {i + 1}: ");
            string aluno = Console.ReadLine();
            alunos.Add(aluno);

            Console.Write($"Digite a nota do aluno {aluno}: ");
            double nota = Convert.ToDouble(Console.ReadLine());
            notas.Add(nota);
        }
    }

    public double CalcularMedia()
    {
        return notas.Average();
    }

    public void ExibirAlunosAcimaDaMedia(double media)
    {
        Console.WriteLine($"Média da turma: {media:F2}");
        Console.WriteLine("Alunos com notas acima da média:");
        for (int i = 0; i < notas.Count; i++)
        {
            if (notas[i] > media)
            {
                Console.WriteLine($"- {alunos[i]}: {notas[i]:F2}");
            }
        }
    }
}

// Exemplo de uso
class Program
{
    static void Main()
    {
        ProgramaNotas programaNotas = new ProgramaNotas();
        programaNotas.InserirNotas();
        double media = programaNotas.CalcularMedia();
        programaNotas.ExibirAlunosAcimaDaMedia(media);
    }
}