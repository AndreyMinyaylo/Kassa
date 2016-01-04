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
            var st = "  1  2  3\n"+
                     "-+--------\n"+
                     "1|1  2  3  \n"+
                     "2|2  4  6  \n"+
                     "3|3  6  9  \n";

                string sr = string.Empty;

            int i, j;

            for (i = 1; i <= 3; i++)
            {
                sr = sr + ("  " + i);

            }
            sr = sr + "\n";
            sr = sr + "-+--------\n";
            for (i = 1; i <= 3; i++)
            {
                sr = sr + (i + "|");
                for (j = 1; j <= 3; j++)
                {
                    sr = sr + (j * i + "  ");

                    if (j == 3)
                    {
                        sr = sr + "\n";
                    }

                }
            }


            Assert.AreEqual(st, sr);
        }
    }
}
