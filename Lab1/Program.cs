using System.Numerics;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Factorial factorial = new Factorial();
            factorial.WhereToSend = DisplayResult;
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
    }
}
