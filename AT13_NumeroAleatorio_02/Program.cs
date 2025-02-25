namespace AT13_NumeroAleatorio_02;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe o numero menor: ");
        int menor = int.Parse(Console.ReadLine());
        Console.WriteLine("Informe o numero maior: ");
        int maior = int.Parse(Console.ReadLine());// Pede para o usuario informar o numero menor e maior

        new Random();
        int numeroSorteado = new Random().Next(menor, maior+1); // Sorteia um numero entre o menor e o maior
        Console.WriteLine($"Numero aleatorio entre {menor} e {maior} numero sorteado é: {numeroSorteado}");// Mostra o numero sorteado
    }
}
// Nessa versão o usuario informa o numero menor e maior, e o programa sorteia um numero entre esses dois numeros e tambem encurtou o comando eliminando a necessidade de criar uma variavel para o Random