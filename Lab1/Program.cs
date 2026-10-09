using System.Numerics;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Factorial factorial = new Factorial();
            factorial.WhereToSend += DisplayResult;
            factorial.WhereToSend += DisplayMessageAboutResult;
            Console.WriteLine("Calculation started...");
            Thread thread = new Thread(() => factorial.Calculate(1000));
            thread.Start();
            //BigInteger result = factorial.Calculate(100);
            //Console.WriteLine(result);
            Console.WriteLine("Finished!");
        }

        static void DisplayResult(BigInteger result)
        {
            Console.WriteLine(result);
        }
        static void DisplayMessageAboutResult(BigInteger value)
        {
            if (value > 10000)
            {
                Console.WriteLine("Big value");
            }
            else
            {
                Console.WriteLine("Small value");
            }
        }
    }
}
