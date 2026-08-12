internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("\n=== TRABALHANDO COM DICIOÁRIO ===\n");
        /* Sintaxe Dictionary<chave, valor>
                             <key, value> */

        // 1 - Criar um dicionário vazio
        Dictionary <string, string> dicionario = new Dictionary <string, string>();

        // 2 - Adicionar Elementos no dicionário
        dicionario.Add("Casa","Construção destinada à moradia.");
        dicionario.Add("Livro","Conjunto de páginas encadernadas contendo textos, imagens ou informações.");
        dicionario.Add("Amizade","Relação de afeto, confiança e companheirismo entre pessoas.");
        dicionario.Add("Escola","Instituição destinada ao ensino e à educação de crianças, jovens ou adultos.");

        // 3 - Percorrer todos os Elementos de um Dicionário
        Console.WriteLine();
        foreach(var item in dicionario)
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }

        // 4 - Alterar um Elemento do dicionário
        dicionario["Casa"] = "Construção destinada a moradia definitiva ou temporária.";

        Console.WriteLine("\n=== DICIOÁRIO ATUALIZADO ===");
        Console.WriteLine();
        foreach(var item in dicionario)
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }

        // 5 - Verificar se uma chave existe dentor do Dicionário
        string termo;
        bool chaveExiste = dicionario.TryGetValue("Amizade", out termo);
        Console.WriteLine();
        if (chaveExiste)
        {
            Console.WriteLine($"A palavra encontrada: {termo}");
        }
        else
        {
            Console.WriteLine("A palavra não foi encontrada no Dicionário");
        }

        // 6 - Excluir um elemento do dicionário -> Somente por Chave(key)
        dicionario.Remove("Casa");
        Console.WriteLine();
        foreach(var item in dicionario)
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }

        // 7 - Ordenar um Dicionário por chave
        var DicionarioOrdenado = dicionario.OrderBy(i => i.Key);
        Console.WriteLine();
        foreach(var item in DicionarioOrdenado)
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }

    }
}