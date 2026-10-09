using System.Numerics;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Factorial factorial = new Factorial();
            Console.WriteLine("Calculation started...");
            Thread thread = new Thread(() => factorial.Calculate(1000));
            thread.Start();
            //BigInteger result = factorial.Calculate(100);
            //Console.WriteLine(result);
            Console.WriteLine("Finished!");
        }
    }
}
