namespace AT12_NumerosAleatorios;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        // int numero1 = random.Next(1, 100); //Genera un número aleatorio entre 1 e 100
        //  int numero2 = random.Next(1, 100);
        //   int numero3 = random.Next(1, 100);
        //    int numero4 = random.Next(1, 100);

        // Console.WriteLine(numero1+" "+numero2+" "+numero3+" "+numero4);

        int sorteio = random.Next(1, 100);


         for (int i = 1; i <= 10; i++){

            Console.WriteLine($"Sorteio {i}: {sorteio}");
        }



    }
}
