
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== TRABALHANDO COM PILHAS (FILO) ===");

        // 1 - Criar uma nova pilha vazia
        Stack<string> pilhaLivros = new Stack<string>();

        // 2 - Adicionar elementos em uma pilha
        pilhaLivros.Push("Dom Quixote");
        pilhaLivros.Push("O Morro dos Ventos Uivantes");
        pilhaLivros.Push("O Cortiço");

        // 3 - Percorrer todos os elementos de uma pilha
        Console.WriteLine();
        foreach (var livro in pilhaLivros)
        {
            Console.WriteLine(livro);
        }

        // 4 - Remover um elemento da pilha
        string livroRemovido = pilhaLivros.Pop();
        Console.WriteLine();
        Console.WriteLine($"O Livro retirado foi: {livroRemovido}");

        pilhaLivros.Push("Dom Casmurro");
        Console.WriteLine();
        foreach (var livro in pilhaLivros)
        {
            Console.WriteLine(livro);
        }
    }
}