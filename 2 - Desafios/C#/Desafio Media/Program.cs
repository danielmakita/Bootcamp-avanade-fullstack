using System;
using System.Collections.Generic;
using System.Linq;

namespace Desafio_Media
{
    class Program
    {
        static void Main()
        {
            var listaJoias = new List<string>();

            while(true){
                string joia = Console.ReadLine();
                
                if(!string.IsNullOrWhiteSpace(joia))
                    listaJoias.Add(joia);
                else
                    break;
            }

            var contador = listaJoias.Distinct().ToList();

            Console.WriteLine($"{contador.Count}");
        }
    }
}
