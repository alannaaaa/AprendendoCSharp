using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 13 - Multiplos de 3");

        for (int i = 3; i <= 100; i += 3)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("Pressione ENTER para encerrar");
        Console.ReadLine();

    }
}