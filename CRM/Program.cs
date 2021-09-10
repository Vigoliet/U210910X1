using System;
using System.Collections.Generic;

namespace CRM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

           
            List<Customer> myCustomer = new List<Customer>();


            //skapa en meny 1-Skapa ny kund, 2-Visa antal kunder, 3-Visa lista över alla kunder, 4-Avsluta
            while (true)
            { 
                Console.WriteLine("Skriv ett av följande tal:\n" +
                              "1-Skapa en ny Kund \n" + 
                              "2-Visa antal kunder \n" +
                              "3-Visa lista över alla kunder \n" +
                              "4-Avsluta");
                 string word = Console.ReadLine();


                if (word == "1") 
                {
                    Console.WriteLine("Skriv namn:"); 
                    string name = Console.ReadLine();

                    Console.WriteLine("Skriv address:");
                    string address = Console.ReadLine();

                    Console.WriteLine("Skriv ålder:");
                    string age = Console.ReadLine();
                    myCustomer.Add(new Customer() { Name = name, Address = address, Age = age });

                }
                if (word == "2") 
                {

                }
                if (word == "3")
                {

                }
                if (word == "4")
                {
                    break;
                }
            }
               
        }
    }
}
public class Customer                   // är nu en datatyp
{
    public string Name { get; set; }    //Namn på kund
    public string Address { get; set; } //Adress på kund
    public string Age { get; set; }     // Ålder på kund
}
