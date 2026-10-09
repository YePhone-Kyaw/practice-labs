using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace Lab1
{
    internal class Factorial
    {
        public delegate void SendResult(BigInteger number);
        public event SendResult WhereToSend;
        public void Calculate(BigInteger number)
        {
            BigInteger result = 1;
            for (BigInteger i = 1; i <= number; i++)
            {
                result = result * i;
            }
            WhereToSend(result);
        }
    }
}
