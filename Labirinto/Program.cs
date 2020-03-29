using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labirinto
{
    class Program
    {
        public static void Main()
        {
            Console.Title = "Labirinto";

            personagem personagem1 = new personagem();
            cenarioJogo cenario = new cenarioJogo();
            SistemaGeral sg = new SistemaGeral();

            cenario.atualizarTela();
            while (true)
            {
                personagem1.controlarPersonagem();
                sg.setVenceu(personagem1.LocalizacaoXPersonagem, personagem1.LocalizacaoYPersonagem);
            }
        }
    }
}
