namespace AT7_IMC;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe o seu peso em kg: ");
        float peso = float.Parse(Console.ReadLine());
        Console.WriteLine("Informe a sua altura em metros: ");
        float altura = float.Parse(Console.ReadLine());

        float imc = peso / (altura * altura);
        Console.WriteLine($"Seu IMC é {imc}.");
      c

    }
}
