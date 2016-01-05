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
            var st = "  |   1   2   3   4   5   6   7   8   9  10\n" +
                     "--+----------------------------------------\n" +
                     " 1|   1   2   3   4   5   6   7   8   9  10\n" +
                     " 2|   2   4   6   8  10  12  14  16  18  20\n" +
                     " 3|   3   6   9  12  15  18  21  24  27  30\n" +
                     " 4|   4   8  12  16  20  24  28  32  36  40\n" +
                     " 5|   5  10  15  20  25  30  35  40  45  50\n" +
                     " 6|   6  12  18  24  30  36  42  48  54  60\n" +
                     " 7|   7  14  21  28  35  42  49  56  63  70\n" +
                     " 8|   8  16  24  32  40  48  56  64  72  80\n" +
                     " 9|   9  18  27  36  45  54  63  72  81  90\n" +
                     "10|  10  20  30  40  50  60  70  80  90 100\n";

            string sr = string.Empty;

            int i, j, s;
            int x1 = 1, x2 = 10, y1 = 1, y2 = 10;
            string p = " ", p1 = "  ", p2 = "   ", p3 = "    ";

            sr = sr + (p1 + "|");

            for (i = x1; i <= x2; i++)
            {
                if (i < 10)
                {
                    sr = sr + (p2 + i);
                }
                else if (i < 100)
                {
                    sr = sr + (p1 + i);
                }
            }
            sr = sr + ("\n");
            sr = sr + ("--+----------------------------------------\n");


            for (i = y1; i <= y2; i++)
            {
                if(i < 10)
                {
                    sr = sr + p + i + "|";
                }
                else
                {
                    sr = sr + i + "|";
                }


                /*if (i == y2)
                {
                    sr = sr + ("\n");
                }*/
                for (j = x1; j <= x2; j++)
                {
                    if ((j * i) <= 9)
                    {
                        sr = sr + (p2 + (j * i));
                    }
                    else if ((j * i) < 100)
                    {
                        sr = sr + (p1 + (j * i));
                    }
                    else if ((j * i) < 1000)
                    {
                        sr = sr + (p + (j * i));
                    }
                    if (j == x2)
                    {
                        sr = sr + ("\n");
                    }
                }
            }
        
    

            Assert.AreEqual(st, sr);
        }
    }
}
