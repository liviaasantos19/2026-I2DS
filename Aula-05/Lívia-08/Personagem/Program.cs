
internal class Program
{
    private static void Main(string[] args)
    {
        // Criando os personagens

        Herois mago = new Herois(
            "Mago theo",
            2,
            15,
            0.5,
            3,
            100
        );

        Herois elfo = new Herois(
            "Elfo Jude",
            4,
            10,
            10,
            2,
            100
        );

        Herois cavaleiro = new Herois(
            "Cavaleiro Richard",
            3,
            0,
            10,
            1,
            100
        );

        // Seleção do personagem

        Console.WriteLine("===== SELEÇÃO DE PERSONAGEM =====");
        Console.WriteLine("1 - Mago Theo");
        Console.WriteLine("2 - Elfo jude");
        Console.WriteLine("3 - Cavaleiro Richard");

        Console.Write("\nEscolha seu personagem: ");
        int escolha = int.Parse(Console.ReadLine());

        Herois personagem = null;

        switch (escolha)
        {
            case 1:
                personagem = mago;
                break;

            case 2:
                personagem = elfo;
                break;

            case 3:
                personagem = cavaleiro;
                break;

            default:
                Console.WriteLine("Opção inválida!");
                return;
        }

        // Menu principal

        int opcao = 0;

        while (opcao != 5)
        {
            Console.WriteLine("\n===== MENU PRINCIPAL =====");
            Console.WriteLine("1 - Ver personagem");
            Console.WriteLine("2 - Evoluir");
            Console.WriteLine("3 - Atacar");
            Console.WriteLine("4 - Defender");
            Console.WriteLine("5 - Sair");

            Console.Write("\nDigite uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    personagem.Apresentar();
                    break;

                case 2:
                    personagem.Evoluir();
                    break;

                case 3:
                    Console.WriteLine("\n===== ESCOLHA O INIMIGO =====");
                    Console.WriteLine("1 - Mago Theo");
                    Console.WriteLine("2 - Elfo Jude");
                    Console.WriteLine("3 - Cavaleiro Richard");

                    Console.Write("\nDigite o número do alvo: ");
                    int escolhaAlvo = int.Parse(Console.ReadLine());

                    Herois alvo = null;

                    switch (escolhaAlvo)
                    {
                        case 1:
                            alvo = mago;
                            break;

                        case 2:
                            alvo = elfo;
                            break;

                        case 3:
                            alvo = cavaleiro;
                            break;

                        default:
                            Console.WriteLine("Alvo inválido!");
                            continue;
                    }

                    personagem.Atacar(alvo);
                    break;

                case 4:
                    personagem.Defender();
                    break;

                case 5:
                    Console.WriteLine("\nJogo encerrado!");
                    break;

                default:
                    Console.WriteLine("\nOpção inválida!");
                    break;
            }
        }
    }


    // Classe base
    public class Personagem
    {
        public string Nome { get; protected set; }
    }


   

