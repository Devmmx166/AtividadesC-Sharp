using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um Numero: ");
            float numero1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Iforme um segundo Numero:");
            float numero2 = float.Parse(Console.ReadLine());





            float soma = numero1 + numero2;
            float subtracao = numero1 - numero2;
            float multiplicacao  = numero1 * numero2;
            float divisao = numero1 / numero2;



            Console.WriteLine($"Soma: {numero1} + {numero2} = {soma} ");
            Console.WriteLine($"Subtração: {numero1} - {numero2} = {subtracao} ");
            Console.WriteLine($"Multiplicação: {numero1} * {numero2} = {multiplicacao}");
            Console.WriteLine($"Divisão: {numero1} / {numero2} = {divisao}");

        }
    }
}
