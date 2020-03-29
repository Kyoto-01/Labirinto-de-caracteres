using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Labirinto
{
    class cenarioJogo
    {
        private char[,] ambiente = new char[20, 15];
        personagem personagem1 = new personagem();
        private char preenchimento = '#';
        private ConsoleColor ambienteCor = ConsoleColor.White;

        #region propriedades
        public char[,] Ambiente
        {
            set { this.ambiente = value; }
            get { return this.ambiente; }
        }

        public char Preenchimento
        {
            get { return this.preenchimento; }
        }
        #endregion

        public cenarioJogo()
        {
            desenharAmbiente(ambiente, personagem1.VisualPersonagem);
        }

        public void desenharAmbiente(char[,] matriz, char posicaoInicial)
        {
            for (int coluna = 0; coluna < ambiente.GetLength(1); coluna++)
            {
                for (int linha = 0; linha < ambiente.GetLength(0); linha++)
                {
                    matriz[linha, coluna] = preenchimento;
                    desenharEstrada(matriz, linha, coluna);
                }
            }
            matriz[0, 0] = posicaoInicial;
        }

        private void desenharEstrada(char[,] matriz, int lin, int col)
        {
            int[,] retas = { // estrada principal:
                             {0, 1}, {0, 2}, {0, 3}, {0, 4}, {0, 5}, {0, 6}, {0, 7}, {0, 8},
                             {1, 8}, {2, 8}, {3, 8},
                             {3, 7}, {3, 6}, {3, 5}, {3, 4}, {3, 3}, {3, 2}, {3, 1},
                             {4, 1}, {5, 1}, {6, 1}, {7, 1}, {8, 1},
                             {8, 2}, {8, 3}, {8, 4}, {8, 5}, {8, 6}, {8, 7}, {8, 8}, {8, 9}, {8, 10}, {8, 11},
                             {7, 11}, {6, 11}, {5, 11}, {4, 11},
                             {4, 12}, {4, 13},
                             {5, 13}, {6, 13}, {7, 13}, {8, 13}, {9, 13}, {10, 13}, {11, 13}, {12, 13}, {13, 13}, {14, 13}, {15, 13}, {16, 13},
                             {16, 12}, {16, 11}, {16, 10}, {16, 9}, {16, 8}, {16, 7},
                             {17, 7}, {18, 7}, {19, 7},
                             // desvios:
                             {9, 1}, {10, 1}, {11, 1}, {12, 1}, {13, 1}, {14, 1}, {15, 1}, {16, 1}, {17, 1}, {18, 1},
                             {18, 2}, {18, 3}, {18, 4}, {18, 5},
                             {17, 5}, {16, 5}, {15, 5}, {14, 5}, {13, 5}, {12, 5}, {11, 5}, {10, 5}, {9, 5},
                             {11, 6}, {11, 7}, {11, 8}, {11, 9}, {11, 10}, {11, 11},
                             {12, 11}, {13, 11}, {14, 11},
                             {14, 10}, {14, 9}, {14, 8}, {14, 7}, {14, 6}};

            int retasY = retas.GetLength(1), retasX = retas.GetLength(0);
