namespace AT8;

class Program
{
    static void Main(string[] args)
    {
        int x =13;
        for(int i = x-10; i <= x + 15; i++){
          x= x - i +1;
          Console.WriteLine($"i:{i} | {x}");
        }
        
    }
}
