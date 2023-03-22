using System;

namespace POO;

public class Circulo
{
    private const double PI = Math.PI;
    private double area;
    private double radio;

    public void SetArea(int radio)
    {
        this.radio = radio;
        this.area = PI * Math.Pow(radio, 2);

    }

    public double GetArea() => this.area;

}