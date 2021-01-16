using System;

namespace Desafio_R_V
{
    class Program
    {
        static void Main()
        {
            int V, R;
            int Numeros = 1;
            int Soma;
            int Contador;

            R = Int32.Parse(Console.ReadLine());
            Soma = R;
            Contador = Soma + 1;

            do{
                V = Int32.Parse(Console.ReadLine());
            }while(V <= R);

            while(Soma <= V){
                Soma = Soma + Contador;
                Numeros++;
                Contador++;
            }

            Console.WriteLine($"{Numeros}");
        }
    }
}
