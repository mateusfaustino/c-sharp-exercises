namespace tiposDeDados;
class Program
{
    static void Main(string[] args)
    {
        float temperatura = 36.6F;
        decimal salario = 3500.75M;
        double valorAproximado = 2.71828;

        Console.WriteLine($"Temperatura: {temperatura}°C");
        Console.WriteLine($"Salário: R$ {salario}");
        Console.WriteLine($"Valor aproximado de e: {valorAproximado}");
    }
}