namespace AT15_RaizQuadrada;

class Program
{
    static void Main(string[] args)
    {
        // double raiz = Math.Sqrt(100);// essa biblioteca é necessária para a raiz quadrada
        // Console.WriteLine(raiz);

        Console.WriteLine("Informe o valor de A: ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Informe o valor de B: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Informe o valor de C: ");
        double c = double.Parse(Console.ReadLine());

        double delta = (b*b) - (4 * a * c);


    }
}
