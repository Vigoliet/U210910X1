using System;
using System.Collections.Generic;

namespace CRM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
public class Customer // är nu en datatyp
{
    public string Name { get; set; } //Namn på kund
    public string Address { get; set; } //Adress på kund
    public int Age { get; set; } // Ålder på kund
}
