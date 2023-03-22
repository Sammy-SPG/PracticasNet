using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            const string MESSAGE = "Hello World!";

            Console.WriteLine(MESSAGE);
            Console.WriteLine("Introduce un valor en la consola: ");
            int valor = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Introduce otro valor: ");
            int valor2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"La suma de {valor} + {valor2} = {valor + valor2}");
    
        }
    }
}
