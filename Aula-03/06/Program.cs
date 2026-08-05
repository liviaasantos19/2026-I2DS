
using System.ComponentModel;

internal class Program
{
    private static void Main(string[] args)
    {
        string resposta;
        /* Operadores Matemáticos 
       + -> Somar
        - -> Subtrair
       * -> Multiplicar
       / -> Divisão  
        % -> Resto da Divisão
       ^ -> Exponenciação
       = -> Atribuição
        */


        {
            Console.Write("Digite um número: ");
           int numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(numero + " x " + i + " = " + (numero * i));
            }

            Console.Write("Deseja continuar? (S/N): ");
            resposta = Console.ReadLine();
          
        } while (resposta == "S" || resposta == "s");

        Console.WriteLine("Programa encerrado.");
    }
}
