// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;

public class Bil
{
    public string Mærke { get; set; }
    public DateTime Årstal { get; set; }
    
    public Bil(string mærke, DateTime årstal)
    {
        Mærke = mærke;
        Årstal = årstal;
    }
    public static List<Bil> Catalog = new List<Bil>
    {
            new Bil("BMW", new DateTime(2026, 9, 19)),
            new Bil("Audi", new DateTime(2001, 12, 26))
        };
}

public class List
{
    public static void BilList()
    {
        foreach (Bil g in Bil.Catalog)
        {
            Console.WriteLine($"{g.Mærke} - {g.Årstal:dd/MM/yyyy}");
            Console.WriteLine();
        }
    }
    public static void Add()
    {
        Console.Write("Indsæt Bil Mærke: ");
        string? Nymærke = Console.ReadLine();
        Console.Write("Indsæt Dato: ");
        DateTime Nydato = Convert.ToDateTime(Console.ReadLine());
        
        Bil.Catalog.Add(new Bil(Nymærke,Nydato));


    }
}
public class Program
{
    public static void Main()
    {
        while(true)
        {
        Console.WriteLine("1 = List, 2 = Tilføj");
        Console.Write("> ");
        string? command = Console.ReadLine();
        switch(command)
        {
            case "1":
            List.BilList();
            break;
            case "2":
            List.Add();
            break;

        }
        
    }
}
} 