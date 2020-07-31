using System;

namespace Pokenpo {
    class Program {
        static void Main (string[] args) {
            int jogador1 = 0;
            string sair = "";
            do {
                Console.Clear ();
                System.Console.WriteLine ("==========================");
                System.Console.WriteLine ("        Pokenpo");
                System.Console.WriteLine ("==========================");

                Console.WriteLine ("Jogador 1 coloquei sua jogada digite: ");
                System.Console.WriteLine ("1 para pedra");
                System.Console.WriteLine ("2 para tesoura");
                System.Console.WriteLine ("3 para papel");

                jogador1 = int.Parse (Console.ReadLine ());
                Console.ReadLine ();

                Console.WriteLine ("Jogador 2 coloquei sua jogada digite: ");
                System.Console.WriteLine ("1 para pedra");
                System.Console.WriteLine ("2 para tesoura");
                System.Console.WriteLine ("3 para papel");

                int jogador2 = int.Parse (Console.ReadLine ());

                if (jogador1 == 1 && jogador2 == 1 || jogador1 == 2 && jogador2 == 2 || jogador1 == 3 && jogador2 == 3) {
                    System.Console.WriteLine ("Essa partida deu empate jogue denovo!!!");
                } else if (jogador1 == 2 && jogador2 == 1 || jogador1 == 1 && jogador2 == 2) {
                    if (jogador1 == 1) {
                        System.Console.WriteLine ("Jogador 1 ganhou essa partida!!!");
                    } else {
                        System.Console.WriteLine ("Jogador 2 ganhou essa partida!!!");

                    }
                } else if (jogador1 == 3 && jogador2 == 2 || jogador1 == 2 && jogador2 == 3) {
                    if (jogador1 == 2) {
                        System.Console.WriteLine ("Jogador 1 ganhou essa partida!!!");
                    } else {
                        System.Console.WriteLine ("Jogador 2 ganhou essa partida!!!");

                    }
                } else if (jogador1 == 3 && jogador2 == 1 || jogador1 == 1 && jogador2 == 3) {
                    if (jogador1 == 3) {
                        System.Console.WriteLine ("Jogador 1 ganhou essa partida!!!");
                    } else {
                        System.Console.WriteLine ("Jogador 2 ganhou essa partida!!!");

                    }
                }

                System.Console.WriteLine ("desejar sair digite 0 para sair ou entre para continuar");
                sair = Console.ReadLine ();

            } while (sair != "0");
        }

    }
}