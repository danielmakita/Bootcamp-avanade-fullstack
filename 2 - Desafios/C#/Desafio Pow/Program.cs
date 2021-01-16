using System;

class Desafio
{
    static void Main()
    {
        int N;
        int Result;
        N = Int32.Parse(Console.ReadLine());

        for(int i=1; i<=N; i++){
            for(int j=1; j<=3; j++){
                Result = (int)Math.Pow(i, j);
                Console.Write($"{Result} ");
            }
            Console.WriteLine();
        }
    }
}                            
