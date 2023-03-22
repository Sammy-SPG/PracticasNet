using System;
using POO;

namespace main;

public class Program
{
    public static void Main(string[] args)
    {
        Circulo myCirculo = new Circulo();
        myCirculo.SetArea(5);
        Console.WriteLine(myCirculo.GetArea());

        Coche teslaSammy = new Coche("Tesla", "Gris", "2022", "Sammy-SPG"); /// estado inicial :) 
        teslaSammy.SetColor("red");
        Console.WriteLine(teslaSammy.GetMarca());
    }
}
