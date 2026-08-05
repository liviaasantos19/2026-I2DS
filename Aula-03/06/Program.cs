
internal class Program
{
    private static void Main(string[] args)
    {
        string resposta;

        /* LISTA DE EXERCICIOS - Exercicio 06 */

        // Tabuada do numero informado
            Console.Write("Informe um número e descubra sua tabuada: ");
            int numero = int.Parse(Console.ReadLine());

            for (int n = 1; n <= 10; n++)
            {
                Console.WriteLine(numero + " x " + n + " = " + (numero * n));
            }

            // Deseja continuar

            Console.Write("Deseja continuar? (S/N): ");
            resposta = Console.ReadLine();

        while (resposta == "S") 
        {
            Console.Write("Informe um número e descubra sua tabuada: ");
            numero = int.Parse(Console.ReadLine());

            for (int n = 1; n <= 10; n++)
            {
                Console.WriteLine(numero + " x " + n + " = " + (numero * n));
            }
        }

        Console.WriteLine("lPrograma finaizado com sucesso.");
        
    }
}


