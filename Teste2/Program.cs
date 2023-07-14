using System;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        float total = 0;

        int i = 0;

        float media = 0;

        Console.WriteLine("Bem vindo ao Teste2, para iniciarmos qual é o seu nome?");

        List<float> Notas = new List<float>();

        string Nome = Console.ReadLine();

        while (true)
        {

            Console.WriteLine("{0} por favor, nos informe qual foi sua nota na prova?", Nome);

            Notas.Add(float.Parse(Console.ReadLine()));

            total += Notas[i];

            media = total / (i+1);

            Console.WriteLine("Nome: {0}", Nome);
            Console.WriteLine("quantidade de provas: {0}", (i+1));
            Console.WriteLine("total de nota = {0}", total);
            Console.WriteLine("sua média é de: {0}", media);

            i++;
        }
    }
}