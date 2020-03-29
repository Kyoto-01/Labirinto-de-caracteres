using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labirinto
{
    class personagem
    {
        private int localizacaoXPersonagem = 0;
        private int localizacaoYPersonagem = 0;
        private char visualPersonagem = '@';

        #region propriedades
        public char VisualPersonagem
        {
            get { return this.visualPersonagem; }
        }
        public int LocalizacaoXPersonagem
        {
            get{ return this.localizacaoXPersonagem; }
        }
        public int LocalizacaoYPersonagem
        {
            get{ return this.localizacaoYPersonagem; }
        }
        #endregion

        public void controlarPersonagem()
        {
            ConsoleKeyInfo tecla = Console.ReadKey();
            int codigo = (int)tecla.Key;

            if (codigo == 37 || codigo == 39)
            {
                moverPersonagemNoAmbiente(codigo - 38, 0);
                return;
            }
            moverPersonagemNoAmbiente(0, codigo - 39);
        }

        private void moverPersonagemNoAmbiente(int movimentoX, int movimentoY)
        {
            cenarioJogo interacaoCenario = new cenarioJogo();

            int cenarioX = interacaoCenario.Ambiente.GetLength(0);
            int cenarioY = interacaoCenario.Ambiente.GetLength(1);
            char[,] frame = new char[cenarioX, cenarioY];

            interacaoCenario.desenharAmbiente(frame, interacaoCenario.Preenchimento);
            mudarPersonagemDeLugar(frame, interacaoCenario,movimentoX, movimentoY);

            interacaoCenario.Ambiente = frame;
            Console.Clear();
            interacaoCenario.atualizarTela();
        }

        private void mudarPersonagemDeLugar(char[,] frame, cenarioJogo interacaoCenario, int movimentoX, int movimentoY)
        {
            localizacaoXPersonagem += movimentoX;
            localizacaoYPersonagem += movimentoY;

            try
            {
                if (frame[localizacaoXPersonagem, localizacaoYPersonagem] == interacaoCenario.Preenchimento)
                {
                    throw new Exception();
                } 
                frame[localizacaoXPersonagem, localizacaoYPersonagem] = visualPersonagem;
            }
            catch
            {
                localizacaoXPersonagem -= movimentoX;
                localizacaoYPersonagem -= movimentoY;
                frame[localizacaoXPersonagem, localizacaoYPersonagem] = visualPersonagem;
            }
        }
    }
}
