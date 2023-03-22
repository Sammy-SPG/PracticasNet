using System;

namespace metodos;

public class Metodos
{
    public string? name; //esto se hace si el valor puede ser nulo

    public int Suma(params int[] numbers)
    {
        int total = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            total += numbers[i];
        }

        return total;
    }

    //sobre carga de metodos 

    public double Suma(params double[] numbers)
    {
        double total = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            total += numbers[i];
        }

        return total;
    }

    public int Resta(int number1, int number2) => number1 - number2;

    public void adivinaNumero()
    {
        int intentos = 1;
        Random random = new Random();
        int numeroAleatorio = random.Next(1, 100);

        Console.WriteLine("Elije un numero del 1 al 100");
        int numero = int.Parse(Console.ReadLine());

        while (numero != numeroAleatorio)
        {
            intentos++;

            if (numero > numeroAleatorio) Console.WriteLine("Tu numero es mayor al numero aleatorio");

            else if (numero < numeroAleatorio) Console.WriteLine("Tu numero es menor al numero aleatorio");

            Console.WriteLine("Intentalo otra vez: ");
            numero = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Muy bien, lo lograste!! El numero de intentos fue: " + intentos);
    }


    public void setName(string name)
    {
        this.name = name;
    }

    public string getName() => this.name == null ? "No name" : this.name;

    public static void Main(string[] args)
    {
        Metodos metodos = new Metodos();

        metodos.setName("Samuel palomares");

        Console.WriteLine("Tu nombre es: " + metodos.getName());
        Console.WriteLine("suma: " + metodos.Suma(1.2, 2, 3, 4, 5, 6, 7, 8, 9, 10));

        Console.WriteLine("resta: " + metodos.Resta(1, 2));

        Console.WriteLine("Juguemos algo!");

        metodos.adivinaNumero();
    }

}