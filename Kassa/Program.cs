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

            Console.WriteLine("Enter x1:");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter x2:");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y1:");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y2:");
            int y2 = Convert.ToInt32(Console.ReadLine());

            int i, j, h, u, t, k;

            string p = " ", p1 = "  ", p2 = "   ", p3 = "    ", p4 = "     ";

            Console.Write(p3 + p + "|");
            for (i = x1; i <= x2; i++)
            {
                h = x2 * y2;
                string l = Convert.ToString(h);
                u = l.Length;

                if (u < (u + 1))
                {
                    if (i < 10)
                    {
                        Console.Write(p4 + i);
                    }
                    else if (i < 100)
                    {
                        Console.Write(p3 + i);
                    }
                    else if (i < 1000)
                    {
                        Console.Write(p2 + i);
                    }
                    else if (i < 10000)
                    {
                        Console.Write(p1 + i);
                    }
                    else if (i >= 10000)
                    {
                        Console.Write(p + i);

                    }

                }
            }
            Console.Write("\n");
            /*string t = "-------";*/
            string s = "----";
            string o = "-----";
            string e = "------";
            Console.Write("-----+");

            for (i = x1; i <= x2; i++)
            {
                Console.Write(e);
            }
            Console.Write("\n");

            for (i = y1; i <= y2; i++)
            {
                if (i < 10)
                {
                    Console.Write(p3 + i + "|");
                }
                else if (i < 100)
                {
                    Console.Write(p2 + i + "|");
                }
                else if (i < 1000)
                {
                    Console.Write(p1 + i + "|");
                }
                else if (i < 10000)
                {
                    Console.Write(p + i + "|");
                }

                for (j = x1; j <= x2; j++)
                {
                    k = x1 * y1;
                    h = x2 * y2;
                    string l = Convert.ToString(h);
                    u = l.Length;
                    /*Console.Write("  " + u + "  ");*/
                    t = i * j;
                    if (u < (u + 1))
                    {
                        if (t < 10)
                        {
                            Console.Write(p4 + t);
                        }
                        else if (t < 100)
                        {
                            Console.Write(p3 + t);
                        }
                        else if (t < 1000)
                        {
                            Console.Write(p2 + t);
                        }
                        else if (t < 10000)
                        {
                            Console.Write(p1 + t);
                        }
                        else if (t >= 10000)
                        {
                            Console.Write(p + t);

                        }

                    }
                    if (j == x2)
                    {
                        Console.Write("\n");
                    }


                }

            }
            Console.ReadKey();
        }
    }
}