using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo
{
    class Tablero
    {
        private string[] bingo1;
        private int[,] NumAle;

        public Tablero(string[] bingo, int[,] numAle)
        {
            bingo1 = bingo;
            NumAle = numAle;
        }

        public string[] Bingo1 { get => bingo1; set => bingo1 = value; }
        public int[,] NumAle1 { get => NumAle; set => NumAle = value; }

        public int[,] Tachar(string pos)
        {
            string []split = (pos.Split(','));
            
            for(int i = 0; i <5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    if(i== Convert.ToInt32(split[0]) && j == Convert.ToInt32(split[1]))
                    {
                        NumAle[i, j] = 0;
                    }
                }
            }
            return NumAle;
        }

        public string ImprimirM()
        {
            string nMatriz = "";

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    nMatriz += NumAle[i, j] + " || ";
                }
                nMatriz += "\n";
            }
            return nMatriz;
        }
    }
}
