using System;

namespace staticMV;

public class Operacion{
    public static double Suma(params double[] numbers){
        double sum = 0;
        foreach(double num in numbers){
            sum += num;
        }
        return sum;
    }

    public static double Resta(params double[] numbers){
        double res = 0;
        foreach(double num in numbers){
            res -= num;
        }
        return res;
    }

    public static double Multiplicacion(params double[] numbers){
        double multi = 1;
        foreach(double num in numbers){
            multi *= num;
        }
        return multi;
    }

    public static double Division(double dividendo, double divisor){
        double div = dividendo / divisor;
        return div;
    }
}

