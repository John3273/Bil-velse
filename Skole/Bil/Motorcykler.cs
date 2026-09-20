using System;

namespace Bil;

public class Motorcykler
{
    public string Mærke2 { get; set;}
    public DateTime Årstal2 { get; set; }

    public Motorcykler(string mærke2, DateTime årstal2)
    {
        Mærke2 = mærke2;
        Årstal2 = årstal2;
    }
    public static List<Motorcykler> MCCatalog = new List<Motorcykler>();
}