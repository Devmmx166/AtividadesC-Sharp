namespace AT24_media;

class Program
{
    static void Main(string[] args)
    {
        /*
        ler tres numeros ---
        calcular a media ---
        ler a frequencia do aluno ---
        ler se a frequencia esta igual ou maior que 70--
        o programa deve verificar se está aprovado
        aprovação tem que ser igual ou maior que 60
        para esta de recuperação  o aluno deve estar maior ou igual a 40
        programa deve informar o final da situação do aluno    
               
      */

        Console.WriteLine("infrome a primeira nota");
        float nota1 = float.Parse(Console.ReadLine());
        Console.WriteLine("infrome a segunda nota");
        float nota2 = float.Parse(Console.ReadLine());
        Console.WriteLine("infrome a terceira nota");
        float nota3 = float.Parse(Console.ReadLine());
        Console.WriteLine("infrome a frequencia do aluno em %");
        float frequencia = float.Parse(Console.ReadLine());
        float media = (nota1 + nota2 + nota3) / 3;

        if(media >=60 && frequencia >=70)
        {
            Console.WriteLine($"Aluno aprovado com nota de {media} e frequencia de {frequencia}%");
        }
        else if(media >=60 && frequencia < 70)
        {
            Console.WriteLine($"Aluno possui media de {media} e frequencia de {frequencia}% foi reporvado por falta");
        }
        else if(media >=40 && media <60 && frequencia >=70)
        {
            Console.WriteLine($"Aluno esta de recuperação com media de {media} e frequencia de {frequencia}%");
        }
        else if(media <40 && frequencia < 70)
        {
            Console.WriteLine($"Aluno reprovado por media com nota de {media} e frequencia de {frequencia}%");
        }
        else
        {
            Console.WriteLine("dados invalidos");
        }




    }
}
