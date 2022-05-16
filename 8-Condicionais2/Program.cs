using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 08 - Condicionais 2");

        int idadeRafael = 17;
        int quantidadeDePessoas = 2;

        bool acompanhado = quantidadeDePessoas > 1;
        //bool grupo = false;

        if (idadeRafael >= 18 || acompanhado)
        {
            Console.WriteLine("Acesso liberado na balada dos nerds.");
        }
        else
        {
            Console.WriteLine("Acesso negado na balada dor nerds... :c");
        }

        Console.WriteLine("Pressione ENTER para encerrar.");
        Console.ReadLine();
    }

}
