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
            var st = " | 1  2  3  4 \n" +
                     "-+------------\n" +
                     "1| 1  2  3  4 \n" +
                     "2| 2  4  6  8 \n" +
                     "3| 3  6  9 12 \n"+
                     "4| 4  8 12 16 \n";

                string sr = string.Empty;

            int i, j;

            sr = sr + (" |");
            for (i = 1; i <= 4; i++)
            {
                sr = sr + (" " + i + " ");

            }
            sr = sr + "\n";
            sr = sr + "-+------------\n";
            for (i = 1; i <= 4; i++)
            {
                sr = sr + (i + "|");
                for (j = 1; j <= 4; j++)
                {
                    if ((j * i) <= 9)
                    {  
                        sr = sr + (" " + (j * i) + " ");
                    }
                    else 
                    {
                        sr = sr + ((j * i)+" ");
                    }
                    if (j == 4)
                    {
                        sr = sr + "\n";
                    }

                }
            }


            Assert.AreEqual(st, sr);
        }
    }
}
