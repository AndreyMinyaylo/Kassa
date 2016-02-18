using System;
using System.Security.Permissions;
using Microsoft.Win32;
using System.Text;

namespace Pifagor
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var firtNumberHorizontal = -1;
            var lastNumberHorizontal = -1;
            var firstNumberVertical = -1;
            var lastNumberVertical = -1;
            string key;
            Console.WriteLine("You must enter numbers above than 0");

            do
            { 
                Console.WriteLine("Enter the first number (horizontal): ");
                key = Console.ReadLine();
                if (firtNumberHorizontal < 0)
                {
                    Console.WriteLine("The firstNumberVertical isnt above or equally 0");
                   
                }

            }
            while (!Int32.TryParse(key, out firtNumberHorizontal) || (firtNumberHorizontal < 0));
           
            do
                    {
                        Console.WriteLine("Enter the last number (horizontal): ");
                        key = Console.ReadLine();
                        if (lastNumberHorizontal < 0)
                        {
                            Console.WriteLine("The lastNumberHorizontal isnt above or equally 0");

                        }
                    } while (!Int32.TryParse(key, out lastNumberHorizontal) || (lastNumberHorizontal < 0));

                do
                {
                    Console.WriteLine("Enter the first number (vertical): ");
                    key = Console.ReadLine();
                    if (firstNumberVertical < 0)
                    {
                        Console.WriteLine("The firstNumberVertical isnt above or equally 0");

                    }
                } while (!Int32.TryParse(key, out firstNumberVertical) || (firstNumberVertical < 0));

                do
                {
                    Console.WriteLine("Enter the last number (vertical): ");
                    key = Console.ReadLine();
                    if (lastNumberVertical < 0)
                    {
                        Console.WriteLine("The lastNumberVertical isnt above or equally 0");

                    }
                } while (!Int32.TryParse(key, out lastNumberVertical) || (lastNumberVertical < 0));
            
                var space = Convert.ToString(lastNumberVertical).Length + 1;
                while (space > 0)
                {
                    Console.Write(" ");
                    space--;
                }

                Console.Write("|");
                for (int i = firtNumberHorizontal; i <= lastNumberHorizontal; i++)
                {
                    var lenghtI = Convert.ToString(i).Length;
                    var symbol = lastNumberHorizontal*lastNumberVertical;
                    var symbolLenght = Convert.ToString(symbol).Length;
                    if (symbolLenght == lenghtI)
                    {
                        symbolLenght = 1;
                    }
                    else if (lenghtI < symbolLenght)
                    {
                        symbolLenght = (symbolLenght - lenghtI) + 1;
                    }
                    while (symbolLenght > 0)
                    {
                        Console.Write(" ");
                        symbolLenght--;
                    }

                    Console.Write(i);
                }
                Console.Write("\n");
                var lenthHorizontal = Convert.ToString(lastNumberVertical).Length + 1;
                while (lenthHorizontal > 0)
                {
                    Console.Write("-");
                    lenthHorizontal--;
                }

                Console.Write("+");
                for (int i = firtNumberHorizontal; i <= lastNumberHorizontal; i++)
                {
                    var symbol = lastNumberHorizontal*lastNumberVertical;
                    var symbolLenght = Convert.ToString(symbol).Length + 1;
                    while (symbolLenght > 0)
                    {
                        Console.Write("-");
                        symbolLenght--;
                    }

                }
                Console.Write("\n");
                for (int i = firstNumberVertical; i <= lastNumberVertical; i++)
                {
                    var lenthI = Convert.ToString(i).Length;
                    var lenthForNumber = Convert.ToString(lastNumberVertical).Length;
                    if (lenthI == lenthForNumber)
                    {
                        lenthForNumber = 1;
                    }
                    else if (lenthI < lenthForNumber)
                    {
                        lenthForNumber = (lenthForNumber - lenthI) + 1;
                    }
                    while (lenthForNumber > 0)
                    {
                        Console.Write(" ");
                        lenthForNumber--;
                    }

                    Console.Write(i + "|");
                    for (int j = firtNumberHorizontal; j <= lastNumberHorizontal; j++)
                    {
                        var result = i*j;
                        var resultLenght = Convert.ToString(result).Length;
                        var symbol = lastNumberHorizontal*lastNumberVertical;
                        var symbolLenght = Convert.ToString(symbol).Length;
                        if (resultLenght == symbolLenght)
                        {
                            symbolLenght = 1;
                        }
                        else if (resultLenght < symbolLenght)
                        {
                            symbolLenght = (symbolLenght - resultLenght) + 1;
                        }

                        while (symbolLenght > 0)
                        {
                            Console.Write(" ");
                            symbolLenght--;
                        }

                        Console.Write(result);

                        if (j == lastNumberHorizontal)
                        {
                            Console.Write("\n");
                        }
                    }
                }
                Console.ReadKey();
            } 
        }
    }


                