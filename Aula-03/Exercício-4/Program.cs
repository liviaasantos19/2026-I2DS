internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Valor: ");
        int valor = int.Parse(Console.ReadLine());

        int notas100 = valor / 100;
        valor = valor % 100;

        int notas50 = valor / 50;
        valor = valor % 50;

        int notas20 = valor / 20;
        valor = valor % 20;

        int notas10 = valor / 10;
        valor = valor % 10;

        int notas2 = valor / 2;
        valor = valor % 2;

        int notas1 = valor;


         Console.WriteLine($"{notas100} nota(s) de 100");
         Console.WriteLine($"{notas50} nota(s) de 50");
         Console.WriteLine($"{notas20} nota(s) de 20");
         Console.WriteLine($"{notas10} nota(s) de 10");
         Console.WriteLine($"{notas2} nota(s) de 2");
         Console.WriteLine($"{notas1} nota(s) de 1");
    }
}