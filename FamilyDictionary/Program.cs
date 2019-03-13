using System;
using System.Collections.Generic;

namespace FamilyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> myFamilia = new Dictionary<string, Dictionary<string, string>>();

            //relationship is the key, and the stuff to the right is the 'value'
            myFamilia.Add("esposa", new Dictionary<string, string>() { { "nombre", "Jenn" }, { "anos", "32" } });
            myFamilia.Add("perro uno", new Dictionary<string, string>() { { "nombre", "Rigby" }, { "anos", "7"} });
            myFamilia.Add("perro dos", new Dictionary<string, string>() { { "nombre", "Wallenby" }, { "anos", "5" } });

            foreach (var (key, value) in myFamilia)
            {
                Console.WriteLine($"{myFamilia[key]["nombre"]} es mi {key}, y tiene {myFamilia[key]["anos"]}.");
            }

            Console.ReadKey();
        }
    }
}
