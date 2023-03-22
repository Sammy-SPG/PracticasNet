using System;
namespace staticMV;

public class Program
{
    public static void Main(string[] args)
    {
        var newObject = new {name = "sammy", edad = 19};
        Console.WriteLine(Operacion.Division(9, 3));
        Console.WriteLine(newObject.name);
    }
}