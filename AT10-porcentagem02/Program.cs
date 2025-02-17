namespace AT10;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe o valor da compra: ");
        float valorCompra = float.Parse(Console.ReadLine());

        float valorVenda = valorCompra * 1.12f;

        Console.WriteLine($"Valor de venda é : R$ {Math.Round(valorVenda,2)}");
    }
}

/*Explicação: O código acima é um programa em C# que calcula o valor de venda de um produto considerando um aumento de 12%. O usuário informa o valor da compra e o programa retorna o valor de venda com acrescimo. A função Math.Round() é utilizada para arredondar o valor de venda para duas casas decimais.*/
