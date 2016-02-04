using System;

namespace Pifagor
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the first number (horizontal): ");
            var firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the last number (horizontal): ");
            var secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the first number (vertical): ");
            var thirdNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the last number (vertical): ");
            var fourthNumber = Convert.ToInt32(Console.ReadLine());

            int i, j;

            
            var space = Convert.ToString(fourthNumber).Length + 1;
            while (space > 0)
            {
                Console.Write(" ");
                space--;
            }
            
            Console.Write("|");
                for (i = firstNumber; i <= secondNumber; i++)
                {
                  var lenghtI = Convert.ToString(i).Length;
                  var symbol = secondNumber * fourthNumber;
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
            var lenthHorizont = Convert.ToString(fourthNumber).Length + 1;
            while (lenthHorizont > 0)
            {
                Console.Write("-");
                lenthHorizont--;
            }
            
            Console.Write("+");
            for (i = firstNumber; i <= secondNumber; i++)
            {
                var symbol = secondNumber * fourthNumber;
                var symbolLenght = Convert.ToString(symbol).Length + 1;
                while (symbolLenght > 0)
                {
                    Console.Write("-");
                    symbolLenght--;
                }
                
            }
            Console.Write("\n");
            for (i = thirdNumber; i <= fourthNumber; i++)
            {
                var lenthI = Convert.ToString(i).Length;
                var lenthForNumber = Convert.ToString(fourthNumber).Length;
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
                for (j = firstNumber; j <= secondNumber; j++)
                {
                    var result = i * j;
                    var resultLenght = Convert.ToString(result).Length;
                    var symbol = secondNumber * fourthNumber;
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

                    if (j == secondNumber)
                    {
                        Console.Write("\n");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}