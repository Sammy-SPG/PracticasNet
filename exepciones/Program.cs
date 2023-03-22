using System;

namespace exepciones;

public class Exepciones
{
    public static void Main(String[] args)
    {
        try
        {
            Console.WriteLine("Exepciones, introduce un numero: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Gracias :)");
        }
        catch (System.Exception ex)
        {
            if (ex.GetType() == typeof(FormatException)) Console.WriteLine("Introdugiste un texto");
            if (ex.GetType() == typeof(OverflowException)) Console.WriteLine("El numero es muy grande");
            else Console.WriteLine(ex.Message);
            throw;
        }
        finally
        {
            Console.WriteLine("Me ejecuto igual al final");
        }
    }
}