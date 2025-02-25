namespace AT8_02_Desconto;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o nome do produto: ");
         string nomeProduto = Console.ReadLine();
        Console.WriteLine("Digite o Preço do produto: ");
         float preco = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite o desconto do produto %: ");
         float desconto = float.Parse(Console.ReadLine());
         float ValorDesconto = ( preco * desconto)/100;
         float PrecoComDesconto = preco - ValorDesconto;

         Console.WriteLine($"O produto {nomeProduto} custa R$ {preco} e com desconto de {desconto}% custa R$ {PrecoComDesconto}");


    }
}
