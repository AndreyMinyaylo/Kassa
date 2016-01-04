using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kassa
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;

            Console.Write(" |");
            for (i = 1; i <= 4; i++)
            {
                Console.Write(" " + i + " ");

            }
            Console.Write("\n");
            Console.Write("-+------------\n");
            for (i = 1; i <= 4; i++)
            {
                Console.Write(i + "|");
                for (j = 1; j <= 4; j++)
                {
                    if ((j * i) <= 9)
                    {
                        Console.Write(" " + (j * i) + " ");
                    }
                    else
                    {
                        Console.Write((j * i) + " ");
                    }
                    if (j == 4)
                    {
                        Console.Write("\n");
                    }

                }
            }





            Console.ReadKey();
        }
    }
}
