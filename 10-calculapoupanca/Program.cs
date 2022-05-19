using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 10 - Calcula Poupança");

        double investimento = 1000;
        //Rendimento de 0,5% (0,005) ao mês

        /*//mes 1
        investimento = investimento + investimento * 0.005;
        Console.WriteLine(investimento);
        //mes 2
        investimento = investimento + investimento * 0.005;
        Console.WriteLine(investimento);
        //mes 3
        investimento = investimento + investimento * 0.005;
        Console.WriteLine(investimento);
        //mes 4
        investimento = investimento + investimento * 0.005;
        Console.WriteLine(investimento);*/

        int mes = 1;
        while (mes <= 12)
        {
            investimento = investimento + investimento * 0.005;
            Console.WriteLine(investimento);
            mes++;
        }

        Console.WriteLine("Pressione ENTER para encerrar");
        Console.ReadLine();
    }
}
