using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_100
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var st = "   |   1   2   3   4   5   6   7   8   9  10\n" +
                     "---+----------------------------------------\n" +
                     "  1|   1   2   3   4   5   6   7   8   9  10\n" +
                     "  2|   2   4   6   8  10  12  14  16  18  20\n" +
                     "  3|   3   6   9  12  15  18  21  24  27  30\n" +
                     "  4|   4   8  12  16  20  24  28  32  36  40\n" +
                     "  5|   5  10  15  20  25  30  35  40  45  50\n" +
                     "  6|   6  12  18  24  30  36  42  48  54  60\n" +
                     "  7|   7  14  21  28  35  42  49  56  63  70\n" +
                     "  8|   8  16  24  32  40  48  56  64  72  80\n" +
                     "  9|   9  18  27  36  45  54  63  72  81  90\n" +
                     " 10|  10  20  30  40  50  60  70  80  90 100\n";

            var sr = string.Empty;

           

            var space = Convert.ToString(10).Length + 1;
            while (space > 0)
            {
                sr = sr + (" ");
                space--;
            }

            sr = sr + ("|");
            for (int i = 1; i <= 10; i++)
            {
                var lenghtI = Convert.ToString(i).Length;
                var symbol = 10 * 10;
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
            var lenthHorizontal = Convert.ToString(10).Length + 1;
            while (lenthHorizontal > 0)
            {
                sr = sr + ("-");
                lenthHorizontal--;
            }

            sr = sr + ("+");
            for (int i = 1; i <= 10; i++)
            {
                var symbol = 10 * 10;
                var symbolLenght = Convert.ToString(symbol).Length + 1;
                while (symbolLenght > 0)
                {
                    sr = sr + ("-");
                    symbolLenght--;
                }

            }
            sr = sr + ("\n");
            for (int i = 1; i <= 10; i++)
            {
                var lenthI = Convert.ToString(i).Length;
                var lastNumberVertical = Convert.ToString(10).Length;
                if (lenthI == lastNumberVertical)
                {
                    lastNumberVertical = 1;
                }
                else if (lenthI < lastNumberVertical)
                {
                    lastNumberVertical = (lastNumberVertical - lenthI) + 1;
                }
                while (lastNumberVertical > 0)
                {
                    sr = sr + (" ");
                    lastNumberVertical--;
                }

                sr = sr + (i + "|");
                for (int j = 1; j <= 10; j++)
                {
                    var result = i * j;
                    var resultLenght = Convert.ToString(result).Length;
                    var symbol = 10 * 10;
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

                    if (j == 10)
                    {
                        sr = sr + ("\n");
                    }
                }
            }
            Assert.AreEqual(st, sr);
        }
    }
}
