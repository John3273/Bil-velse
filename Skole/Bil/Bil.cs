using System;

namespace Bil;

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
