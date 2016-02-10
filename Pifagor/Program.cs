using System;

namespace Pifagor
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the first number (horizontal): ");
            var firstNumberHorizontal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the last number (horizontal): ");
            var lastNumberHorizontal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the first number (vertical): ");
            var firstNumberVertical = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the last number (vertical): ");
            var lastNumberVertical = Convert.ToInt32(Console.ReadLine());


            var space = Convert.ToString(lastNumberVertical).Length + 1;
            while (space > 0)
            {
                Console.Write(" ");
                space--;
            }
            
            Console.Write("|");
                for (int i = firstNumberHorizontal; i <= lastNumberHorizontal; i++)
                {
                  var lenghtI = Convert.ToString(i).Length;
                  var symbol = lastNumberHorizontal * lastNumberVertical;
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
            for (int i = firstNumberHorizontal; i <= lastNumberHorizontal; i++)
            {
                var symbol = lastNumberHorizontal * lastNumberVertical;
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
                
                Console.Write(i+"|");
                for (int j = firstNumberHorizontal; j <= lastNumberHorizontal; j++)
                {
                    var result = i * j;
                    var resultLenght = Convert.ToString(result).Length;
                    var symbol = lastNumberHorizontal * lastNumberVertical;
                    var symbolLenght = Convert.ToString(symbol).Length;
                    if (resultLenght == symbolLenght)
                    {
                        symbolLenght =  1;
                    }
                    else if(resultLenght < symbolLenght)
                    {
                        symbolLenght = (symbolLenght - resultLenght) +1;
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