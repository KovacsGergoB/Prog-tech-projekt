using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using unitTeszteles;

namespace UnitTeszt
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Teszt_Fibo()
        {
            Algoritmusok szm = new Algoritmusok();
            List<int> teszt = szm.Fibonacci(11);
            //int teszt = fibo[11];

            List<int> fiboertek = new List<int>();
            int[] vart = new int[11] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 };
            fiboertek.AddRange(vart);
            Assert.AreEqual(teszt[5], fiboertek[5]);
        }

        [TestMethod]
        public void Teszt_OtszogKerEsTer()
        {
            Algoritmusok szm = new Algoritmusok();
            double kerTeszt = szm.OtszogKer(7);
            double terTeszt = szm.OtszogTer(7);

            Assert.AreEqual(kerTeszt, 35);
            Assert.AreEqual(terTeszt, 84);
        }
        
        [TestMethod]
        public void Teszt_HatszogKerEsTer()
        {
            Algoritmusok szm = new Algoritmusok();
            double kerTeszt = szm.HatszogKer(12);
            double terTeszt = szm.HatszogTer(12);

            Assert.AreEqual(kerTeszt, 72);
            Assert.AreEqual(terTeszt, 374);
        }

    }
}
