using System.IO.Compression;

namespace AT23_Ingresso;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("informe o valor do ingresso: ");
        float valorIngresso = float.Parse(Console.ReadLine());
        Console.WriteLine("informe o valor das despesas: ");
        float despesas = float.Parse(Console.ReadLine());
       float arrecadacao = valorIngresso * 120;
      

        if(arrecadacao >= despesas )
        {
            float lucro = arrecadacao - despesas;
             Console.WriteLine($"Valor do ingresso de R$ {valorIngresso}.");
             Console.WriteLine($"Arrecadação de R$ {arrecadacao}.");
             Console.WriteLine($"Despesas de R$ {despesas}.");
             Console.WriteLine($"Lucro de R$ {lucro}.");
        }
        else
        {
            Console.WriteLine($"Valor do ingresso de R$ {valorIngresso}.");
            Console.WriteLine($"Arrecadação de R$ {arrecadacao}.");
            Console.WriteLine($"Não haverá lucro, falta R$ {despesas - arrecadacao} para cobrir despeas.");
           
        }


    }
}
