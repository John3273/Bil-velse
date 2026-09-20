// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;
namespace Bil;
public class Program
{
    public static void Main()
    {
        while(true)
        {
        Console.WriteLine("1 = Bil List, 2 = Tilføj Bil, 3 = Motorcykler Liste, 4 = Tilføj Motorcykler");
        Console.Write("> ");
        string? command = Console.ReadLine();
        switch(command)
        {
            case "1":
            List.BilList();
            break;
            case "2":
            List.BilAdd();
            break;
            case "3":
            List.MCList();
            break;
            case "4":
            List.MCAdd();
            break;

        }
        
    }
}
} 