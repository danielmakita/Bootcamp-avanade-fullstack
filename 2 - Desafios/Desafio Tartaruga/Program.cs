using System;

namespace Desafio_Tartaruga
{
    class Program
    {
        static void Main()
        {
            int NumTartarugas;
            int VelTartarugaInt;
            string VelTartaruga;
            int MaiorVel = 0;

            for(int i = 0; i < 3; i++){
                //Console.Write("Entre com a qtde de tartarugas: ");
                NumTartarugas = Int32.Parse(Console.ReadLine());
                VelTartaruga = (Console.ReadLine());

                string[] VelTartarugaSplited = VelTartaruga.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                for(int j = 0; j < NumTartarugas; j++){
                    //Console.WriteLine(VelTartarugaSplited[j]);
                    VelTartarugaInt = Int32.Parse(VelTartarugaSplited[j]);
                    
                    if(MaiorVel < VelTartarugaInt)
                        MaiorVel = VelTartarugaInt;
                }
                //Console.WriteLine($"{MaiorVel}");
                if(MaiorVel < 10)
                    Console.WriteLine("1");
                else if(MaiorVel >= 10 && MaiorVel < 20)
                    Console.WriteLine("2");
                else
                    Console.WriteLine("3");

                MaiorVel = 0;
            }
        }
    }
}
