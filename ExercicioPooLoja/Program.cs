﻿using System;
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
            Console.Write("Deseja adicionar ou remover algum produto do estoque? Digite 1 para SIM e 2 para NÃO: ");
            
            p1.ObterDecisao();
            
           
            p1.MostrarDados();
        }
    }
}

