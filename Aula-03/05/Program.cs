using System;

class Program
{
    static void Main(string[] args)
    {
        string[] produtos = new string[10];
        double[] precos = new double[10];

        int qtd = 0;
        int opcao;

        do
        {
            Console.WriteLine("1 - Cadastrar");
            Console.WriteLine("2 - Listar");
            Console.WriteLine("3 - Pesquisar");
            Console.WriteLine("0 - Sair");
            Console.Write("Opção: ");
            opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                Console.Write("Produto: ");
                produtos[qtd] = Console.ReadLine(); 

                Console.Write("Preço: ");
                precos[qtd] = double.Parse(Console.ReadLine());

                qtd++;

                Console.WriteLine("Produto cadastrado!");
            }
            else if (opcao == 2)
            {
                for (int i = 0; i < qtd; i++)
                {
                    Console.WriteLine(produtos[i] + " - R$ " + precos[i]);
                }
            }
            else if (opcao == 3)
            {
                Console.Write("Digite o nome do produto: ");
                string nome = Console.ReadLine();

                bool achou = false;

                for (int i = 0; i < qtd; i++)
                {
                    if (produtos[i].ToLower() == nome.ToLower())
                    {
                        Console.WriteLine("Produto: " + produtos[i]);
                        Console.WriteLine("Preço: R$ " + precos[i]);
                        achou = true;
                    }
                }

                if (achou == false)
                {
                    Console.WriteLine("Produto não encontrado.");
                }
            }

            Console.WriteLine();

        } while (opcao != 0);
    }
}