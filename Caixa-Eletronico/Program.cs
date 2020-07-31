using System;

namespace Caixa_Eletronico {
    class Program
    {
 
        static void CalcularNotas(int valor)
        {

            int nota2= 0, nota5= 0, nota10=0 , nota20= 0, nota50= 0, nota100= 0 , valorSacado=valor;
            if (valor % 2 == 1)
            {
                valor = valor - 5;
                nota5++;
            }
                while (valor >= 100)
                {                    
                        valor= valor - 100;
                        nota100++;
                }
                while (valor >= 50)
                {
                    valor = valor - 50;
                    nota50++;
                }
                while (valor >= 20)
                {
                    valor = valor - 20;
                    nota20++;
                }
                while (valor >= 10)
                {
                    valor = valor - 10;
                    nota10++;
                }
                while (valor >= 2)
                {
                    valor = valor - 2;
                    nota2++;
                }
                
           

            Console.WriteLine("Valor sacado = " + valorSacado);
            Console.WriteLine("Foram sacada(s) " + nota100 + " nota(s) de 100 reais");
            Console.WriteLine("Foram sacada(s) " + nota50 + " nota(s) de 50 reais");
            Console.WriteLine("Foram sacada(s) " + nota20 + " nota(s) de 20 reais");
            Console.WriteLine("Foram sacada(s) " + nota10 + " nota(s) de 10 reais");
            Console.WriteLine("Foram sacada(s) " + nota5 + " nota(s) de 5 reais");
            Console.WriteLine("Foram sacada(s) " + nota2 + " nota(s) de 2 reais");
        }  
       

        static void Main(string[] args)
        {
            int nValor;
            string key = "a";
       

            while (key!="s")
            {
                            
                Console.WriteLine("Informe o valor");
                nValor = int.Parse(Console.ReadLine());                
                CalcularNotas(nValor);
                Console.WriteLine("------------------------");
                Console.WriteLine("S para sair");
                key = Console.ReadLine();             
            }
        }
    }
}