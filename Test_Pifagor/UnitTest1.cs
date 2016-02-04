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

            var space = Convert.ToString(4).Length + 1;
            while (space > 0)
            {
                sr = sr + (" ");
                space--;
            }

            sr = sr + ("|");
            for (i = 1; i <= 4; i++)
            {
                var lenghtI = Convert.ToString(i).Length;
                var symbol = 4 * 4;
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
                    sr = sr + (" ");
                    symbolLenght--;
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
                var symbol = 4 * 4;
                var symbolLenght = Convert.ToString(symbol).Length + 1;
                while (symbolLenght > 0)
                {
                    sr = sr + ("-");
                    symbolLenght--;
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
                    var result = i * j;
                    var resultLenght = Convert.ToString(result).Length;
                    var symbol = 4 * 4;
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
                        sr = sr + (" ");
                        symbolLenght--;
                    }

                    sr = sr + (result);

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

