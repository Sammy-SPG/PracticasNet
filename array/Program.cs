using System;

namespace array;

public class program{
    public static void Main(string[] args)
    {
        var arrayObj = new[] {new {name = "sammy", age = 19}, new {name = "Alfredito", age = 18}};
        for(int i = 0; i < arrayObj.Length; i++){
            Console.WriteLine(arrayObj[i]);
        }
    }
}