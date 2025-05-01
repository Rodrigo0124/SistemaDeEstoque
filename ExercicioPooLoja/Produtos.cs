using System;
using System.Globalization;

namespace ExercicioPooLoja
{
    public class Produtos
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public void LerDados()
        {
            Console.WriteLine("Digite o nome do produto: ");
            Nome = Console.ReadLine();
            Console.WriteLine("Informar o preço do produto: ");

            while (!double.TryParse(Console.ReadLine(), CultureInfo.InvariantCulture, out Preco))
            {
                Console.WriteLine("Dados inválidos! Digite novamente:");
            }
            Console.WriteLine("Quantidade do produto em estoque: ");
            while (!int.TryParse(Console.ReadLine(), out Quantidade))
            {
                Console.WriteLine("Dados inválidos! Digite novamente:");
            }
            MostrarDados();
        }
        public double ValorTotal()
        {

            return Preco * Quantidade;

        }

        public void AdicionarEstoque(int quantidade)
        {
            Quantidade += quantidade;
            MostrarDados();
        }


        public void RemoverEstoque(int quantidade)
        {
            Quantidade -= quantidade;
            MostrarDados();
        }
        public void ObterDecisao()
        {

            String decisao = Console.ReadLine();
            int controlador = 1;
            while (controlador == 1)
            {
                while (decisao != "Adicionar" && decisao != "adicionar" && decisao != "Remover" && decisao != "remover")
                {
                    Console.WriteLine("Comando inserido incorretamente! Digite novamente se você deseja adicionar ou remover.");
                    decisao = Console.ReadLine();
                }

                if (decisao == "Adicionar" || decisao == "adicionar")
                {
                    Console.WriteLine("\nDigite quantos produtos você quer adicionar no estoque: ");
                    int adicionarEstoque;
                    while (!int.TryParse(Console.ReadLine(), out adicionarEstoque))
                    {
                        Console.WriteLine("Dados inválidos! Digite novamente:");
                    }
                    AdicionarEstoque(adicionarEstoque);
                }
                else
                {
                    Console.WriteLine("\nDigite quantos produtos você quer remover no estoque: ");
                    int removerEstoque;
                    while (!int.TryParse(Console.ReadLine(), out removerEstoque))
                    {
                        Console.WriteLine("Dados inválidos! Digite novamente:");
                    }
                    RemoverEstoque(removerEstoque);
                }
                Console.WriteLine("Deseja adicionar ou remover mais produtos? Digite 1 para Sim e 2 para Não: ");

                while (!int.TryParse(Console.ReadLine(), out controlador) || controlador != 1 && controlador != 2)
                {

                    Console.WriteLine("Código inválido, digite novamente! Digite 1 para Sim e 2 para Não");

                }
                if (controlador == 1)
                {

                    Console.WriteLine("Deseja adicionar ou remover o produto do estoque? digite Adicionar ou Remover");
                    decisao = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Estoque atualizado com sucesso!");
                }
            }
        }
        public void MostrarDados()
        {
            Console.WriteLine("Dados do produto: ");
            Console.WriteLine("Nome do produto: " + Nome);
            Console.WriteLine("Preço: " + Preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Quantidade em estoque: " + Quantidade);
            Console.WriteLine("Valor total do produto em estoque: R$" + ValorTotal().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();
        }





    }
}
