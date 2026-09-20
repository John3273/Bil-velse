using System;

namespace Bil;

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
    public static void MCList()
    {
        foreach (Motorcykler m in Motorcykler.MCCatalog)
        {
            Console.WriteLine($"{m.Mærke2} - {m.Årstal2:dd/MM/yyyy}");
            Console.WriteLine();
        }
    }
    public static void BilAdd()
    {
        Console.Write("Indsæt Bil Mærke: ");
        string? Nymærke = Console.ReadLine();
        Console.Write("Indsæt Dato: ");
        DateTime Nydato = Convert.ToDateTime(Console.ReadLine());
        
        Bil.Catalog.Add(new Bil(Nymærke,Nydato));
    }
    public static void MCAdd()
    {
        Console.Write("Indsæt Bil Mærke: ");
        string? Nymærke = Console.ReadLine();
        Console.Write("Indsæt Dato: ");
        DateTime Nydato = Convert.ToDateTime(Console.ReadLine());
        
        Motorcykler.MCCatalog.Add(new Motorcykler(Nymærke,Nydato));
    }
}
