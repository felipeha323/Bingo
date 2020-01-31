using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] bingo = new string[] { "B  ", " I  ", " N  ", " G  ", " O  " };
            int[,] NumAle = new int[5, 5];
            int min = 1, max = 15;
            var random = new Random();
            string tachar;
            Console.WriteLine("************************************************************************************************************************");
            Console.WriteLine(bingo[0] + bingo[1] + bingo[2] + bingo[3] + bingo[4]);
            Console.WriteLine("\n");

            for (int i=0; i < 5; i++){

                for(int j = 0; j < 5; j++){

                    if (i == 2 && j == 2)
                    {
                        NumAle[i, j] = 0;
                    }
                    else
                    {                      
                        NumAle[j, i] = random.Next(min, max);
                    }
                    
                }
                min += 15;
                max += 15;
                
            }
            
            Tablero bingo1 = new Tablero(bingo, NumAle);
            
            Console.WriteLine(bingo1.ImprimirM());

            while (1 == 1)
            {
                Console.WriteLine("Ingrese la posicion ganadora: ");
                tachar = Console.ReadLine();
                bingo1.Tachar(tachar);
                Console.WriteLine("\n");
                Console.WriteLine("************************************************************************************************************************");
                Console.WriteLine(bingo[0] + bingo[1] + bingo[2] + bingo[3] + bingo[4]);
                Console.WriteLine("\n");
                Console.WriteLine(bingo1.ImprimirM());
            }

           
               

        }
    }
}
