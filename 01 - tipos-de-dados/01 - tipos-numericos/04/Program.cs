using static System.Net.Mime.MediaTypeNames;

namespace tiposNumericos;

class Program
{
    static void Main(string[] args)
    {
        double numero1 = 5.5;
        float numero2 = 2.2F;

        var resultado = numero1 + (double)numero2;

        Console.WriteLine($"O resultado a soma é: {(float)resultado}");
    }
}