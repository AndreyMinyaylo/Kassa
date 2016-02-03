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

            string sr = string.Empty;

            int i, j, s;

            var lenth = Convert.ToString(10).Length + 1;
            while (lenth > 0)
            {
                sr = sr + (" ");
                lenth--;
            }

            sr = sr + ("|");
            for (i = 1; i <= 10; i++)
            {
                var LenghtString = Convert.ToString(i).Length;
                var productColumn = 10 * 10;
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
            var lenthHorizont = Convert.ToString(10).Length + 1;
            while (lenthHorizont > 0)
            {
                sr = sr + ("-");
                lenthHorizont--;
            }

            sr = sr + ("+");
            for (i = 1; i <= 10; i++)
            {
                var productEndVar = 10 * 10;
                var LenghtproductEndVar = Convert.ToString(productEndVar).Length + 1;
                while (LenghtproductEndVar > 0)
                {
                    sr = sr + ("-");
                    LenghtproductEndVar--;
                }

            }
            sr = sr + ("\n");
            for (i = 1; i <= 10; i++)
            {
                var lenthI = Convert.ToString(i).Length;
                var lenthForNumber = Convert.ToString(10).Length;
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
                for (j = 1; j <= 10; j++)
                {
                    var Result = i * j;
                    var product = Convert.ToString(Result).Length;
                    var productColumn = 10 * 10;
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
