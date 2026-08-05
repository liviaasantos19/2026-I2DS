internal class Program
{
    private static void Main(string[] args)
    {




        Console.Write("Digite o nome do produto: ");
        string produto = (Console.ReadLine());

        Console.Write("Digite o preço do produto: ");
        double preco = double.Parse(Console.ReadLine());


        string[] produtos = {"Teclado", "Caixa de som", "Monitor", "Headphone", "Computador"}; 

         Console.WriteLine("Alterar o segundo elemento da lista");
         produtos[1] = "Mouse";

            Console.WriteLine("1 - Teclado");
            Console.WriteLine("2 - Mouse");
            Console.WriteLine("3 - Monitor");
            Console.WriteLine("4 - Headphone");
            Console.WriteLine("5 - Computador");


            Console.WriteLine("Consulte o preço: ");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
        {
            case 1:
            Console.WriteLine("Preço: $90.00");
            break;

            case 2:
            Console.WriteLine("Preço: $65.99");
            break;

            case 3:
            Console.WriteLine("Preço: $3000");
            break;

             case 4:
            Console.WriteLine("Preço: $250.00");
            break;

            case 5:
            Console.WriteLine("Preço: $7000");
            break;

             

        }


       }

}