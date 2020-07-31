using System;

namespace Comercio {
    class Program {
        static void Main (string[] args) {
            float[] num = new float[100];
                float one = 0;
                float two = 0;
                float five = 0;

            for (int i = 0; i < num.Length; i++) {

                System.Console.WriteLine ("Digite o valor dos produtos e aperte 0 para calcular o preço:");
                two = float.Parse (Console.ReadLine ());

                num[i] += two;
                System.Console.WriteLine(num[i]);
                five = one += num[i];
    
                if (two == 0) {

                    System.Console.WriteLine ($"o valor total R${five} coloquei o valor da nota do cliente");
                    float four = float.Parse (Console.ReadLine ());

                    float troco = four -= five;

                    System.Console.WriteLine ($"valor para retornar ao cliente R${troco}");

                }
            }
        }
    }
}