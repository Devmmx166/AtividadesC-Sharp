namespace AT21_Calculadora;

class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("Informe a operação desejada: ");
       

       Console.WriteLine("A - Soma | B - Subtração | C - Multiplicação | D - Divisão");

       //Console.WriteLine("1 - Soma | 2 - Subtração | 3 - Multiplicação | 4 - Divisão");
              string opcao = Console.ReadLine();
        if(opcao  == "a" || opcao == "A"){        
          Console.WriteLine("Informe o primeiro número: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo número: ");
            int n2 = int.Parse(Console.ReadLine());
            int soma = n1 + n2;
            Console.WriteLine($"O resultado da soma é: {soma}");

        }else if(opcao == "b" || opcao == "B"){
          Console.WriteLine("Informe o primeiro número: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo número: ");
            int n2 = int.Parse(Console.ReadLine());
            int subtracao = n1 - n2;
            Console.WriteLine($"O resultado da subtração é: {subtracao}");
    }else if(opcao == "c" || opcao == "C"){
          Console.WriteLine("Informe o primeiro número: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo número: ");
            int n2 = int.Parse(Console.ReadLine());
            int multiplicacao = n1 * n2;
            Console.WriteLine($"O resultado da multiplicação é: {multiplicacao}");
}else if(opcao == "d" || opcao == "D"){
            Console.WriteLine("Informe o primeiro número: ");
                int n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe o segundo número: ");
                int n2 = int.Parse(Console.ReadLine());
                int divisao = n1 / n2;
                Console.WriteLine($"O resultado da divisão é: {divisao}");
}else{
    Console.WriteLine("Opção inválida");
}

    }

// switch (opcao){
//     case 1:
//         Console.WriteLine("Informe o primeiro número: ");
//         int n1 = int.Parse(Console.ReadLine());
//         Console.WriteLine("Informe o segundo número: ");
//         int n2 = int.Parse(Console.ReadLine());
//         int soma = n1 + n2;
//         Console.WriteLine($"O resultado da soma é: {soma}");
//         break;
//     case 2:
//         Console.WriteLine("Informe o primeiro número: ");
//         int n3 = int.Parse(Console.ReadLine());
//         Console.WriteLine("Informe o segundo número: ");
//         int n4 = int.Parse(Console.ReadLine());
//         int subtracao = n3 - n4;
//         Console.WriteLine($"O resultado da subtração é: {subtracao}");
//         break;
//     case 3: 
//         Console.WriteLine("Informe o primeiro número: ");
//         int n5 = int.Parse(Console.ReadLine());
//         Console.WriteLine("Informe o segundo número: ");
//         int n6 = int.Parse(Console.ReadLine());
//         int multiplicacao = n5 * n6;
//         Console.WriteLine($"O resultado da multiplicação é: {multiplicacao}");
//         break;
  
        
//     default:
//     Console.WriteLine("Informe o primeiro número: ");
//         int n7 = int.Parse(Console.ReadLine());
//         Console.WriteLine("Informe o segundo número: ");
//         int n8 = int.Parse(Console.ReadLine());
//         int divisao = n7 / n8;
//         Console.WriteLine($"O resultado da divisão é: {divisao}");
//         break;
// }

}



