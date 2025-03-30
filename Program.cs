using System;

class Program
{
    static void Main()
    {
        string frase;
        Console.Write("Digite uma frase: ");
        frase = Console.ReadLine();
        
        string fraseCebolinha = frase.Replace("r", "l").Replace("R", "L");
        
        Console.WriteLine("Cebolinha diz: " + fraseCebolinha);
    }
}