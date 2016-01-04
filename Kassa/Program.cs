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

            for (i = 1; i <= 3; i++)
            {
                Console.Write("  " + i);

            }
            Console.Write('\n');
            Console.WriteLine("-+--------");
            for (i = 1; i <= 3; i++)
            {
                Console.Write(i + "|");
                for (j = 1; j <= 3; j++)
                {
                        Console.Write(j * i + "  ");
                    
                    if (j == 3)
                    {
                        Console.Write('\n');
                    }

                }
            }





            Console.ReadKey();
        }
    }
}
