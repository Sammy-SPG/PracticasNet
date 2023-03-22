using System;

namespace POO;

public partial class Coche
{
    private string marca;
    private string color;
    private string modelo;
    private string placa;

    public Coche(string marca, string color, string modelo, string placa)
    {
        this.marca = marca;
        this.color = color;
        this.modelo = modelo;
        this.placa = placa;
    }
}