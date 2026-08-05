internal class Program
{
    private static void Main(string[] args)
    {
        /* LISTA DE EXERCICIOS - Execicio3 */

        Console.Write("Digite o nome do Aluno: ");
        string nome = Console.ReadLine();

        Console.Write("Digite a Primeira Nota: ");
        double nota1 = double.Parse(Console.ReadLine());

        Console.Write("Digite a Segunda Nota: ");
        double nota2 = double.Parse(Console.ReadLine());

        Console.Write("Digite a Terceira Nota: ");
        double nota3 = double.Parse(Console.ReadLine());


        double media = (nota1 + nota2 + nota3) /3;

        if (media >= 7)
        {
            Console.WriteLine(nome + " Aprovado!!");
        }
        else if (media >= 5)
        {
            Console.WriteLine(nome + " Recuperação!!");
        }
        else
        {
            Console.WriteLine(nome + " Reprovado!!");
        }
        
    }
}