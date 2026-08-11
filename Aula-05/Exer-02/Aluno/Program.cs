internal class Program
{
    private static void Main(string[] args)
    {
        /* Aluno */

        // Aluno 01
        Aluno aluno01 = new Aluno();
        aluno01.RM = 4412;
        aluno01.Nome = "Daphine";
        aluno01.Nascimento = new DateOnly(2009, 10, 16);
        aluno01.Email = "daphininha@gmail.com";

        // Aluno 02
        Aluno aluno02 = new Aluno();
        aluno02.RM = 4840;
        aluno02.Nome = "Lívia";
        aluno02.Nascimento = new DateOnly(2009, 9, 19);
        aluno02.Email = "livinha@gmail.com";

        // Aluno 03
        Aluno aluno03 = new Aluno();
        aluno03.RM = 5722;
        aluno03.Nome = "Sofia";
        aluno03.Nascimento = new DateOnly(2010, 3, 6);
        aluno03.Email = "sofiazinha@gmail.com";


        // Exibindo os Livros na Tela
        Console.WriteLine("\n==== Alunos ====");
        Console.WriteLine($"\nAluno: {aluno01.RM} | Nome: {aluno01.Nome} | Nascimento: {aluno01.Nascimento} | Email: {aluno01.Email}");
        Console.WriteLine($"Aluno: {aluno02.RM} | Nome: {aluno02.Nome} | Nascimento: {aluno02.Nascimento} | Email: {aluno02.Email}");
        Console.WriteLine($"Aluno: {aluno03.RM} | Nome: {aluno03.Nome} | Nascimento: {aluno03.Nascimento} | Email: {aluno03.Email}");

    }

    public class Aluno
    {
        public int RM {get; set;}
        public string Nome {get; set;}
        public DateOnly Nascimento {get; set;}
        public string Email {get; set;}
    }
} 