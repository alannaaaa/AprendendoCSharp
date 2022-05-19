using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 11 - INVESTIMENTO A LONGO PRAZO");
        Console.WriteLine("***********************");

        double fatordeRendimento = 1.005;
        double investimento = 1000;
        for (int anos = 1; anos <= 5; anos++)
        {

            //Console.WriteLine("");
            Console.WriteLine("      NO ANO " + anos);
            Console.WriteLine("***********************");

            for (int mes = 1; mes <= 12; mes++)
            {
                investimento *= fatordeRendimento;
                Console.WriteLine("No mês " + mes + ": " + investimento.ToString("C"));

            }
            fatordeRendimento += 0.001;
            Console.WriteLine("***********************");

        }
        Console.WriteLine();
        Console.WriteLine("Depois de 5 anos você terá R$ " + investimento.ToString("C") + " de 1000 reais investidos.");

        Console.WriteLine("Pressione ENTER para encerrar");
        Console.ReadLine();
    }
}