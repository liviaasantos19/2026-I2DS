internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== TRABALHANDO COM FILAS (FIFO)===");

        // 1 - Criar uma nova fila vazia
        Queue<string> filaBanco = new Queue<string>();

        // 2 - Adicionar elementos na fila
        filaBanco.Enqueue("Lívia");          // 0
        filaBanco.Enqueue("Simone");         // 1
        filaBanco.Enqueue("Isac");         // 2
        filaBanco.Enqueue("Cacau");      // 3

        // 3 - Percorrer elementos de uma fila 
        foreach (var pessoa in filaBanco)
        {
            Console.WriteLine(pessoa);
        }
        
        // 4 - Retirar um elemento da lista
        string pessoaRetirada = filaBanco.Dequeue();
        Console.WriteLine();
        Console.WriteLine($"O Nome chamado foi: {pessoaRetirada}");

        filaBanco.Enqueue("Lucrécia");

        Console.WriteLine();

        foreach(var pessoa in filaBanco)
        {
            Console.WriteLine(pessoa);
        }

        // 5 - Verificar se existe um determinado elemnto na lista
        string procurar = "Isac";
        bool achou = filaBanco.Contains(procurar);
        Console.WriteLine();
        if (achou)
        {
            Console.WriteLine($"{procurar} está na fila!");
        }
        else
        {
            Console.WriteLine($"{procurar} NÃO está na fila!");
        }
    }
}