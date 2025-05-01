using System;
using System.Globalization;
using ExercicioPooLoja;

namespace ExercicioPoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Produtos p1 = new Produtos();
            Console.WriteLine("Bem-vindo ao sistema de estoque da nossa loja, escolha um produto e confira suas informações!\n");

            p1.LerDados();
            Console.WriteLine("Deseja adicionar ou remover o produto do estoque? digite Adicionar ou Remover");
            p1.ObterDecisao();
            p1.MostrarDados();
        }
    }
}

