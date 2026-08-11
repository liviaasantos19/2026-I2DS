
internal class Program
{
    private static void Main(string[] args)
    {
        /* Personagem */

        // Mago
        Herois mago = new Herois(
            "Mago Gui",// nome
            2,// nível
            15,// força
            0.5,// agilidade
            3,// inteligência
            100// vida
        );

        // Elfo
        Herois elfo = new Herois(
            "Elfo Perosa",// nome
            4, // nível
            10,// força
            10, // agilidade
            2,// inteligência
            100// vida
        );

        // Cavaleiro
        Herois cavaleiro = new Herois(
            "Cavaleiro Gi", // nome
            3, // nível
            0, // força
            10, // agilidade
            1, // inteligência
            100 // vida
        );


        // Escolhendo o personagem pelo nome

        Console.WriteLine("=== PERSONAGENS ===");

        Console.WriteLine("Mago Gui");
        Console.WriteLine("Elfo Perosa");
        Console.WriteLine("Cavaleiro Gi");

        Console.Write("\nDigite o nome do personagem: ");
        string escolha = Console.ReadLine();

        Herois personagemEscolhido = null;

        if (escolha.ToLower() == mago.Nome.ToLower())
        {
            personagemEscolhido = mago;
        }
        else if (escolha.ToLower() == elfo.Nome.ToLower())
        {
            personagemEscolhido = elfo;
        }
        else if (escolha.ToLower() == cavaleiro.Nome.ToLower())
        {
            personagemEscolhido = cavaleiro;
        }
        else
        {
            Console.WriteLine("Personagem não encontrado!");
            return;
        }


        // Menu de ações

        int opcao = 0;

        while (opcao != 6)
        {
            Console.WriteLine("\n=== MENU ===");
            Console.WriteLine("1 - Apresentar personagem");
            Console.WriteLine("2 - Evoluir personagem");
            Console.WriteLine("3 - Atacar personagem");
            Console.WriteLine("4 - Defender");
            Console.WriteLine("5 - Sair");

            Console.Write("\nEscolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());


            // Apresentar

            if (opcao == 1)
            {
                personagemEscolhido.Apresentar();
            }


            // Evoluir

            else if (opcao == 2)
            {
                personagemEscolhido.Evoluir();
            }


            // Atacar

            else if (opcao == 3)
            {
                Console.WriteLine("\n=== ESCOLHA O ALVO ===");

                Console.WriteLine("Mago Gui");
                Console.WriteLine("Elfo Perosa");
                Console.WriteLine("Cavaleiro Gi");

                Console.Write("\nDigite o nome do alvo: ");
                string alvoNome = Console.ReadLine();

                Herois alvo = null;

                if (alvoNome.ToLower() == mago.Nome.ToLower())
                {
                    alvo = mago;
                }
                else if (alvoNome.ToLower() == elfo.Nome.ToLower())
                {
                    alvo = elfo;
                }
                else if (alvoNome.ToLower() == cavaleiro.Nome.ToLower())
                {
                    alvo = cavaleiro;
                }
                else
                {
                    Console.WriteLine("Personagem não encontrado!");
                    continue;
                }

                personagemEscolhido.Atacar(alvo);
            }


            // Defender

            else if (opcao == 4)
            {
                personagemEscolhido.Defender();
            }

            // Sair

            else if (opcao == 6)
            {
                Console.WriteLine("Jogo encerrado!");
            }


            else
            {
                Console.WriteLine("Opção inválida!");
            }
        }
    }


    public class Personagem
    {
        public string Nome { get; protected set; }
    }


    public class Herois : Personagem
    {
        public int Nivel { get; protected set; }
        public int Forca { get; protected set; }
        public double Agilidade { get; protected set; }
        public int Inteligencia { get; protected set; }
        public int Vida { get; protected set; }

        // Indica se o personagem está se defendendo
        protected bool EstaDefendendo { get; set; }


        public Herois(
            string nome,
            int nivel,
            int forca,
            double agilidade,
            int inteligencia,
            int vida)
        {
            Nome = nome;
            Nivel = nivel;
            Forca = forca;
            Agilidade = agilidade;
            Inteligencia = inteligencia;
            Vida = vida;
        }


        // Método para apresentar o personagem

        public void Apresentar()
        {
            Console.WriteLine("\n=== APRESENTAÇÃO ===");

            Console.WriteLine("Olá! Eu sou " + Nome + "!");
            Console.WriteLine("Meu nível é " + Nivel);
            Console.WriteLine("Minha força é " + Forca);
            Console.WriteLine("Minha agilidade é " + Agilidade);
            Console.WriteLine("Minha inteligência é " + Inteligencia);
            Console.WriteLine("Minha vida é " + Vida);
        }


        // Método para evoluir

        public void Evoluir()
        {
            Nivel++;
            Forca += 5;
            Agilidade += 1;
            Inteligencia += 1;
            Vida += 20;

            Console.WriteLine("\n" + Nome + " evoluiu!");
            Console.WriteLine("Novo nível: " + Nivel);
            Console.WriteLine("Força: " + Forca);
            Console.WriteLine("Agilidade: " + Agilidade);
            Console.WriteLine("Inteligência: " + Inteligencia);
            Console.WriteLine("Vida: " + Vida);
        }


        // Método para atacar

        public void Atacar(Herois alvo)
        {
            if (Vida <= 0)
            {
                Console.WriteLine(Nome + " não pode atacar porque está derrotado!");
                return;
            }

            if (alvo.Vida <= 0)
            {
                Console.WriteLine(alvo.Nome + " já está derrotado!");
                return;
            }

            if (alvo == this)
            {
                Console.WriteLine("Você não pode atacar a si mesmo!");
                return;
            }

            int dano = Forca;

            if (alvo.EstaDefendendo)
            {
                dano = dano / 2;

                Console.WriteLine(
                    alvo.Nome + " está se defendendo! O dano foi reduzido."
                );

                alvo.EstaDefendendo = false;
            }

            alvo.ReceberDano(dano);

            Console.WriteLine(
                Nome + " atacou " + alvo.Nome +
                " causando " + dano + " de dano!"
            );
        }


        // Método para receber dano

        protected void ReceberDano(int dano)
        {
            Vida -= dano;

            if (Vida < 0)
            {
                Vida = 0;
            }

            Console.WriteLine(
                Nome + " agora possui " + Vida + " de vida."
            );

            if (Vida == 0)
            {
                Console.WriteLine(Nome + " foi derrotado!");
            }
        }


        // Método para defender

        public void Defender()
        {
            EstaDefendendo = true;

            Console.WriteLine(
                "\n" + Nome + " está se defendendo!"
            );

            Console.WriteLine(
                "O próximo ataque recebido terá o dano reduzido pela metade."
            );
        }
    }
}
