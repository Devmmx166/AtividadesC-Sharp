namespace AT11_SalarioSemanal;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe o valor da hora trabalhada: ");
        float horasTrabalhadas = float.Parse(Console.ReadLine());

        Console.WriteLine("infome o valor pago por hora: ");
        float valorHora = float.Parse(Console.ReadLine());

        float salarioSemanal = valorHora * horasTrabalhadas;
        float salarioMensal = salarioSemanal * 4;
                                 
        Console.WriteLine($"O salário semanal é de: {Math.Round(salarioSemanal,2)}"); //Math.Round para arredondar o valor, e o 2 é a quantidade de casas decimais 

        Console.WriteLine($"O salário mensal é de: {Math.Round(salarioMensal,2)}");
    }
}
