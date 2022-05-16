using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 07 - Condiconais");

        int idadeRafael = 17;
        int quantidadeDePessoas = 2;

        if (idadeRafael >= 18)
        {
            Console.WriteLine("Acesso liberado na balada dos nerds.");
        }
        else
        {
            if (quantidadeDePessoas > 1)
            {
                Console.WriteLine("(Acompanhado de responsável) Acesso liberado na balada dos nerds.");
            }
            else
            {
                Console.WriteLine("Acesso negado na balada dor nerds... :c");
            }

        }

        Console.WriteLine("Pressione ENTER para encerrar.");
        Console.ReadLine();
    }

}
