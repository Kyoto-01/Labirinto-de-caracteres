using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labirinto
{
    class SistemaGeral
    {
        public void setVenceu(int personagemX, int personagemY)
        {
            if (personagemX == 19 && personagemY == 7)
            {
                fazerSeVencer();
            }
        }

        private void fazerSeVencer()
        {
            Console.Clear();
            Console.WriteLine("PARABÉNS, VOCÊ VENCEU!\n");
            menuFinal();
        }

        private void menuFinal()
        {
            byte opcao = 0;

            Console.WriteLine("1 p/ Jogar novamente");
            Console.WriteLine("2 p/ Sair\n");

            Console.Write("O que deseja fazer? ");
            byte.TryParse(Console.ReadLine(), out opcao);

            if (opcao == 1)
            {
                jogarNovamente();
            }
            else if (opcao == 2)
            {
                Environment.Exit(0);
            }
            fazerSeVencer();
        }

        private void jogarNovamente()
        {
            Console.Clear();
            Program.Main();
            return;
        }
    }
}
