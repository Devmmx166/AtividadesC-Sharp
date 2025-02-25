namespace operadoresLogicos;

class Program
{
    static void Main(string[] args)
    {
        int velocidade =110;

        bool resultado01 = velocidade > 0 && velocidade < 120;
        Console.WriteLine(resultado01);

        bool resultado02 = velocidade >= 120 && !(velocidade <= 0);
        Console.WriteLine(resultado02);

        bool resultado03 = velocidade >= 120 && !(velocidade <= 0);
        Console.WriteLine(resultado03);

        bool resultado04 = velocidade < 0 || velocidade >= 110;
        Console.WriteLine(resultado04);

        int idade = 17;
        int hora = 21;
         /* (se hora maior que 4: 

            retorno : verdadeiro

         E idade menor que 0 : 

            retorna : falso

                    ou 

         idade igual a 17:  

          retorna : verdadeiro )

         resultado da expressão : verdadeiro 
        
         e se hora for diferente de 21

         retorna : falso
         
         negação do resultado anterior
         
          retorna : verdadeiro


          resu da expressão : verdadeiro

          verdadeiro e verdadeiro = verdadeiro    
                 
         */
        bool resultado5 = (hora > 4 && idade < 0 || idade == 17)  && !(hora !=21 );
        Console.WriteLine(resultado5);
    }
}
