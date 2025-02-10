namespace AT8;

class Program
{
    static void Main(string[] args)
    {
      
      Console.WriteLine("Digite o nome do produto: ");
      string nome = Console.ReadLine();
      Console.WriteLine("Digite o preço do produto: ");
     float preco = float.Parse(Console.ReadLine());
      Console.WriteLine("Digite o acréscimo do produto em porcentagem: ");
     float acrecimo = int.Parse(Console.ReadLine());
      
      float novoPreco = preco + (preco * acrecimo / 100);
      Console.WriteLine($"O produto {nome} teve um acréscimo de {acrecimo}% e passou a custar {novoPreco}");

        }
        
}
