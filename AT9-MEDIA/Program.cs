namespace AT9;

class Program
{
    static void Main(string[] args)
    {
      Console.WriteLine("Informe O valor da nota da promeira unidade: "); float nota1 = float.Parse(Console.ReadLine());
      
      Console.WriteLine("informe o valor da nota da segunda unidade: "); float nota2 = float.Parse(Console.ReadLine());
      
      Console.WriteLine("Informe o valor da nota da terceira Unidade: ");float nota3 = float.Parse(Console.ReadLine());
      
      Console.WriteLine("Informe o valor da nota da quarta unidade: ");float nota4 = float.Parse(Console.ReadLine()); 6
       

       float media = (nota1 + nota2 + nota3 + nota4) / 4;

         if(media >= 7)
         {
              Console.WriteLine($"Aprovado com média {media}");
         }

         //O operador && é o operador lógico "E" que só retorna verdadeiro se as duas condições forem verdadeiras.
         else if(media >= 5 && media < 7)
         {
              Console.WriteLine($"Recuperação com média {media}");
         }
         else
         {
              Console.WriteLine($"Reprovado com média {media}");
         }
    }
}
