using Microsoft.VisualStudio.TestTools.UnitTesting;
using _190.Reverse_Bits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _190.Reverse_Bits.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        public void Test1()
        {
            Solution mySolution = new Solution();
            uint result = mySolution.reverseBits(0x1);
            Assert.AreEqual(result, (uint)0x80000000);
        }

        [TestMethod()]
        public void Test2()
        {
            Solution mySolution = new Solution();
            uint result = mySolution.reverseBits(0x2);
            Assert.AreEqual(result, (uint)0x40000000);
        }
        [TestMethod()]
        public void Test256()
        {
            Solution mySolution = new Solution();
            uint result = mySolution.reverseBits(0xFF);
            Assert.AreEqual(result, (uint)0xFF000000);
        }
        [TestMethod()]
        public void Test43261596()
        {
            Solution mySolution = new Solution();
            uint t = 43261596;
            uint result = mySolution.reverseBits(t);
            Assert.AreEqual(result, Convert.ToUInt32("00111001011110000010100101000000", 2));
        }
    }
}