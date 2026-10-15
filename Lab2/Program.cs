using FileSearch;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the directory");
            string dir = Console.ReadLine();
            FileSearch.File fileSearch = new FileSearch.File();
            fileSearch.sendFileName += DisplayFileName;
            Thread thread = new Thread(() => fileSearch.Search(dir));
            thread.Start();
            Console.Read();
        }

        private static void DisplayFileName(string fileName)
        {
            Console.WriteLine(fileName);
        }
    }
}

