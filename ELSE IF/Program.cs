namespace ELSE_IF;

class Program
{
    static void Main(string[] args)
    {
      Console.WriteLine("Informe a Hora Atual: ");
      int hora = int.Parse(Console.ReadLine());
      Console.WriteLine("Informe os Minutos Atuais: ");
      int minutos = int.Parse(Console.ReadLine());

      if(hora <6){
        Console.WriteLine($"São exatamente {hora} horas e {minutos} minutos, Boa madrugada!");
      }else if(hora >=6 && hora <12){
        Console.WriteLine($"São exatamente {hora} horas e {minutos} minutos, Bom dia!");
    }else if( hora >=12 && hora <18){
        Console.WriteLine($"São exatamente {hora} horas e {minutos} minutos, Boa Tarde!");
    }else{
        Console.WriteLine($"São exatamente {hora} horas e {minutos} minutos, Boa noite!");
    }
}
}