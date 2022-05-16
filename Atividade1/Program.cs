using System;
class Programa
{
    static void Main(string[] args)
    {
        double n1, n2, n3, n4, resultado;
        //resultado = n1 = n2 = n3 = n4 = 0;

        Console.Write("Digite a nota 1: ");
        n1 = double.Parse(Console.ReadLine());

        Console.Write("Digite a nota 2: ");
        n2 = double.Parse(Console.ReadLine());

        Console.Write("Digite a nota 3: ");
        n3 = double.Parse(Console.ReadLine());

        Console.Write("Digite a nota 4: ");
        n4 = double.Parse(Console.ReadLine());

        resultado = (n1 + n2 + n3 + n4) / 4;
        Console.WriteLine(resultado);

        if (resultado >= 6) 
        {
            Console.WriteLine("Aprovado!");
        }
        else if (resultado == 5)
        {
            Console.WriteLine("Recuperação...");
        }
        else
        {
            Console.WriteLine("Reprovado!");
        }

        Console.WriteLine("Pressione ENTER para encerrar.");
        Console.ReadLine();
    }

}

