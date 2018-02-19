using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _190.Reverse_Bits
{

    public class Solution
    {
        public uint reverseBits(uint n)
        {
            uint result = 0;
            for (int i = 31; i >=0; i--)
            {
                result = result | (uint) ((n & (0x1<<i) ) >>i) << (31-i) ;
            }
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
