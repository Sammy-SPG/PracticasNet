using System;
using System.Collections;

namespace estructuraDatos;
public class program
{
    Queue myQ = new Queue();
    public static void Main(string[] args)
    {
        byte option;
        program p = new program();
        do
        {
            Console.WriteLine();
            Console.WriteLine("myQ");
            Console.WriteLine("\t1.- Agregar a la cola: ");
            Console.WriteLine("\t2.- Mostrar cola:");
            Console.WriteLine("\t3.- Eliminar elemento:");
            Console.WriteLine("\t4.- Eliminar cola:");
            Console.WriteLine("\t5.- salir");

            option = byte.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    {
                        p.addQueue();
                        break;
                    }
                case 2:
                    {
                        p.PrintValues();
                        break;
                    }
                case 3:
                    {
                        p.delQueue();
                        break;
                    }
                case 4:
                    {
                        p.ClearQueue();
                        break;
                    }
                default:
                    {
                        Console.Write("\tEliminar cola:");
                        break;
                    }
            }
        } while (option != 5);
    }

    public void addQueue()
    {
        Console.WriteLine("introduce el dato: ");
        var obj = Console.ReadLine();
        myQ.Enqueue(obj);
        Console.WriteLine("Agregado");
    }

    public void delQueue()
    {
        Console.WriteLine("Elemento eliminado: " + myQ.Peek());
        myQ.Dequeue();
    }

    public void ClearQueue()
    {
        myQ.Clear();
        Console.WriteLine("cola eliminada");
    }

    public void PrintValues() //Queue myQ
    {
        foreach (Object obj in myQ)
            Console.Write(" {0}", obj);
        Console.WriteLine();
    }
}
