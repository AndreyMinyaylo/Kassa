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


            int i, j, h;
            

            Console.WriteLine("Enter x1:");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter x2:");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y1:");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y2:");
            int y2 = Convert.ToInt32(Console.ReadLine());

            /*if (y2 < 10)
            {
                Console.Write(p3 + "|");
            }
            else if(y2 < 100)
            {
                Console.Write(p2 + "|");
            }
            else if(y2 < 1000)
            {
                Console.Write(p1 + "|");
            }*/
            string p = " ", p1 = "  ", p2 = "   ", p3 = "    ";
            Console.Write(p3 + "|");

            
                for (i = x1; i <= x2; i++)
                {
                h = x2 * y2;

                if (h < 10)
                {
                    if(i < 10)
                    {
                        Console.Write(p3 + i);
                    }
                    
                }
                else if (h < 100)
                {
                    if (i < 100)
                    {
                        Console.Write(p2 + i);
                    }
                    
                }
                else if (h < 1000)
                {
                    if (i < 10)
                    {
                        Console.Write(p2 + i);
                    }
                    else if (i < 100)
                    {
                        Console.Write(p1 + i);
                    }
                    else if (i < 1000)
                    {
                        Console.Write(p + i);
                    }
                    
                }
              else if(h < 10000)
                    {
                    if (i < 10)
                    {
                        Console.Write(p3 + i);
                    }
                    else if (i < 100)
                    {
                        Console.Write(p + i);
                    }
                    else
                    {
                        Console.Write(p2 + i);
                    }
                     }
                else if (h < 100000)
                {
                    if (i < 100)
                    {
                        Console.Write(p3 + i);
                    }
                    else
                    {
                        Console.Write(p2 + i);
                    }
                }

            }

            

            Console.Write("\n");
                Console.Write("----+");
            string t = "-------";
            string s = "----";
            string o = "-----";
            string e = "------";

                for (i = x1; i <= x2; i++)
                {
                h = x2 * y2;
                        
                            {
                                 if(h <= 100)
                                {
                                    Console.Write(s);
                                }
                                 else if (h <= 1000)
                                    {
                                            Console.Write(o);
                                    }
                                 
                                 else if (h <= 10000)
                                    {
                                        Console.Write(e);
                                    }
                                 else if (h <= 100000)
                                    {
                                        Console.Write(e);
                                    }

                }
            }
                Console.Write('\n');



                for (i = y1; i <= y2; i++)
                {
                    if (i < 10)
                    {
                        Console.Write(p2 + i + "|");
                    }
                    else if (i < 100)
                    {
                        Console.Write(p1 + i + "|");
                    }
                    else if (i < 1000)
                    {
                        Console.Write(p + i + "|");
                    }
                    /*if (j == y2)
                    {
                        Console.Write("\n");
                    }*/
                    

                    for (j = x1; j <= x2; j++)
                    {
                        if ((j * i) <= 9)
                        {
                            Console.Write(p2 + (j * i));
                        }
                        else if ((j * i) < 100)
                        {
                            Console.Write(p1 + (j * i));
                        }
                        else if ((j * i) < 1000)
                        {
                            Console.Write(p + (j * i));
                        }
                        else if ((j * i) < 10000)
                        {
                            Console.Write(p1 + (j * i));
                        }
                    else if ((j * i) >= 10000)
                    {
                        Console.Write(p + (j * i));
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
