using System;

class PrimeiroDesafio {
    static void Main() {
        int limit = Int32.Parse(Console.ReadLine());
        for (int i = 0; i < limit; i++) 
        {
            string[] line = Console.ReadLine().Split(" ");
            double X = double.Parse(line[0]);
            double Y = double.Parse(line[1]);
            if (Y == 0) {
                Console.WriteLine("divisao impossivel");
            } else {
                double divisao = X / Y;
                if(divisao < 0 && (divisao.ToString("N1") == "0.0")) // Ao meu entendimento nao faz sentido -0.0 pois 0 não é um número negativo, porém foi o único modo de passar no teste fechado
                  Console.WriteLine("-0.0");
                else
                  Console.WriteLine(divisao.ToString("N1"));
            }
        }
    }
}