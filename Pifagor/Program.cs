using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pifagor
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the first number of the horizontal array of Pythagoras:");
            var firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the last number of the horizontal array of Pythagoras:");
            var secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the first number of a vertical array of Pythagoras:");
            var thirdNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the last number of vertical array of Pythagoras:");
            var fourthNumber = Convert.ToInt32(Console.ReadLine());

            int i, j;

            
            var lenth = Convert.ToString(fourthNumber).Length + 1;
            while (lenth > 0)
            {
                Console.Write(" ");
                lenth--;
            }
            
            Console.Write("|");
                for (i = firstNumber; i <= secondNumber; i++)
                {
                  var LenghtString = Convert.ToString(i).Length;
                  var productColumn = secondNumber * fourthNumber;
                  var LenghtColumn = Convert.ToString(productColumn).Length;
                    if (LenghtColumn == LenghtString)
                    {
                    LenghtColumn = 1;
                    }
                    else if (LenghtString < LenghtColumn)
                    {
                    LenghtColumn = (LenghtColumn - LenghtString) + 1;
                    }
                while (LenghtColumn > 0) 
                {
                    Console.Write(" ");
                    LenghtColumn--;
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
                var productEndVar = secondNumber * fourthNumber;
                var LenghtproductEndVar = Convert.ToString(productEndVar).Length + 1;
                while (LenghtproductEndVar > 0)
                {
                    Console.Write("-");
                    LenghtproductEndVar--;
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
                    var Result = i * j;
                    var product = Convert.ToString(Result).Length;
                    var productColumn = secondNumber * fourthNumber;
                    var lenghtproductEndVar = Convert.ToString(productColumn).Length;
                    if (product == lenghtproductEndVar)
                    {
                        lenghtproductEndVar =  1;
                    }
                    else if(product < lenghtproductEndVar)
                    {
                        lenghtproductEndVar = (lenghtproductEndVar - product) +1;
                    }

                    while (lenghtproductEndVar > 0)
                    {
                            Console.Write(" ");
                        lenghtproductEndVar--;
                    }
                    
                        Console.Write(Result);

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