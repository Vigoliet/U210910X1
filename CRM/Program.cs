using System;
using System.Collections.Generic;

namespace CRM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Customer myCustomer; //vi berättar att vi från stack tänker använda ett customer objekt
            myCustomer = new Customer(); //här hamnar ett unikt objekt i minnet (Heap)



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
    public int Age { get; set; }        // Ålder på kund
}
