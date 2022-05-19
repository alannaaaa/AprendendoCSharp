using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 12 - Encadeando For");

        //usando o break:
        //for (int contadorLinha = 1; contadorLinha <= 10; contadorLinha++)
        //{
        //    for (int contadorColuna = 1; contadorColuna <= 10; contadorColuna++)
        //    {
        //        Console.Write("*");
        //        if (contadorColuna >= contadorLinha)
        //            break;

        //    }
        //    Console.WriteLine();
        //}

        for (int contadorLinha = 0; contadorLinha <= 10; contadorLinha++)
        {
            for (int contadorColuna = 0; contadorColuna <= contadorLinha; contadorColuna++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }



        Console.WriteLine("Pressione ENTER para encerrar");
        Console.ReadLine();

    }
}