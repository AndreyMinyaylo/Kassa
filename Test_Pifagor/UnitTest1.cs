using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Pifagor
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var st = "  |  1  2  3  4\n" +
                     "--+------------\n" +
                     " 1|  1  2  3  4\n" +
                     " 2|  2  4  6  8\n" +
                     " 3|  3  6  9 12\n"+
                     " 4|  4  8 12 16\n";

                var sr = string.Empty;

            int i, j;

            var lenth = Convert.ToString(4).Length + 1;
            while (lenth > 0)
            {
                sr = sr + (" ");
                lenth--;
            }

            sr = sr + ("|");
            for (i = 1; i <= 4; i++)
            {
                var LenghtString = Convert.ToString(i).Length;
                var productColumn = 4 * 4;
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
                    sr = sr + (" ");
                    LenghtColumn--;
                }

                sr = sr + (i);
            }
            sr = sr + ("\n");
            var lenthHorizont = Convert.ToString(4).Length + 1;
            while (lenthHorizont > 0)
            {
                sr = sr + ("-");
                lenthHorizont--;
            }

            sr = sr + ("+");
            for (i = 1; i <= 4; i++)
            {
                var productEndVar = 4 * 4;
                var LenghtproductEndVar = Convert.ToString(productEndVar).Length + 1;
                while (LenghtproductEndVar > 0)
                {
                    sr = sr + ("-");
                    LenghtproductEndVar--;
                }

            }
            sr = sr + ("\n");
            for (i = 1; i <= 4; i++)
            {
                var lenthI = Convert.ToString(i).Length;
                var lenthForNumber = Convert.ToString(4).Length;
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
                    sr = sr + (" ");
                    lenthForNumber--;
                }

                sr = sr + (i + "|");
                for (j = 1; j <= 4; j++)
                {
                    var Result = i * j;
                    var product = Convert.ToString(Result).Length;
                    var productColumn = 4 * 4;
                    var lenghtproductEndVar = Convert.ToString(productColumn).Length;
                    if (product == lenghtproductEndVar)
                    {
                        lenghtproductEndVar = 1;
                    }
                    else if (product < lenghtproductEndVar)
                    {
                        lenghtproductEndVar = (lenghtproductEndVar - product) + 1;
                    }

                    while (lenghtproductEndVar > 0)
                    {
                        sr = sr + (" ");
                        lenghtproductEndVar--;
                    }

                    sr = sr + (Result);

                    if (j == 4)
                    {
                        sr = sr + ("\n");
                    }
                }
            }
            Assert.AreEqual(st, sr);
        }
    }
}

