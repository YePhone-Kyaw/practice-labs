using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace Lab1
{
    internal class Factorial
    {
        public BigInteger Calculate(BigInteger number)
        {
            BigInteger result = 1;
            for (BigInteger i = 1; i <= number; i++)
            {
                result = result * i;
            }
            return result;
        }
    }
}
