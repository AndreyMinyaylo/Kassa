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

            Console.WriteLine("Enter x1:");
            var x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter x2:");
            var x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y1:");
            var y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y2:");
            var y2 = Convert.ToInt32(Console.ReadLine());

            int i, j;

            
            var lenthY2 = Convert.ToString(y2);
            var lenth = lenthY2.Length + 1;
            while (lenth > 0)
            {
                Console.Write(" ");
                lenth--;
            }
            
            Console.Write("|");
                for (i = x1; i <= x2; i++)
                {
                  var k = Convert.ToString(i);
                  var LenghtString = k.Length;
                    var productColumn = x2 * y2;
                var l = Convert.ToString(productColumn);
                var LenghtColumn = l.Length;
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
            var lenthHorizont = Convert.ToString(y2);
            lenth = lenthHorizont.Length+1;
            while (lenth > 0)
            {
                Console.Write("-");
                lenth--;
            }
            
            Console.Write("+");
            for (i = x1; i <= x2; i++)
            {
                var productEndVar = x2 * y2;
                var l = Convert.ToString(productEndVar);
                var LenghtproductEndVar  = l.Length + 1;

                while (LenghtproductEndVar > 0)
                {
                    Console.Write("-");
                    LenghtproductEndVar--;
                }
                
            }
            Console.Write("\n");
            for (i = y1; i <= y2; i++)
            {
                var c = Convert.ToString(i);
               var lenthI = c.Length;
                var r = Convert.ToString(y2);
                lenth = r.Length;
                if (lenthI == lenth)
                {
                    lenth = 1;
                }
                else if (lenthI < lenth)
                {
                    lenth = (lenth - lenthI) + 1;
                }
                while (lenth > 0)
                {
                    Console.Write(" ");
                    lenth--;
                }
                
                Console.Write(i+"|");
                for (j = x1; j <= x2; j++)
                {
                    var t = i * j;
                    var k = Convert.ToString(t);
                    var product = k.Length;
                    var productColumn = x2 * y2;
                    var l = Convert.ToString(productColumn);
                    var lenghtproductEndVar = l.Length;
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
                    
                        Console.Write(t);

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