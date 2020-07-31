using System;

namespace Caixa_Eletronico {
    class Program {
        static void Main (string[] args) {
            decimal[] num = new decimal[100];
            decimal one = 0;
            decimal two = 0;
            decimal five = 0;

            for (int i = 0; i < num.Length; i++) {

                System.Console.WriteLine ("Digite o valor dos produtos e aperte 0 para calcular o preço:");
                two = decimal.Parse (Console.ReadLine ());

                num[i] += two;

                five += num[i];
                System.Console.WriteLine ((decimal)five);

                if (two == 0) {

                    System.Console.WriteLine ($"o valor total R${(decimal)five} coloquei o valor da nota do cliente");
                    decimal four = decimal.Parse (Console.ReadLine ());

                    decimal troco = four -= five;

                    System.Console.WriteLine ($"valor para retornar ao cliente R${troco}");

                }
            }
        }
    }
}