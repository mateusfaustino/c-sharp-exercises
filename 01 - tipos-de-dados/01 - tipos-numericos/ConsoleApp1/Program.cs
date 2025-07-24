namespace tiposNumericos;

class Program
{
    static void Main(string[] args)
    {
        // Definición de variables
        int idade = 25;
        long populacaoMundial = 8_000_000_000;
        float altura = 1.75f;
        double pi = 3.14159;
        decimal precoProduto = 199.99m;

        // Imprimir valores
        Console.WriteLine($"Idade: {idade}");
        Console.WriteLine($"População Mundial: {populacaoMundial}");
        Console.WriteLine($"Altura: {altura}");
        Console.WriteLine($"Valor de Pi: {pi}");
        Console.WriteLine($"Preço do Produto: {precoProduto}");
    }
}
