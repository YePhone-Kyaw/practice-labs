namespace FileSearch
{
    public class File
    {
        public delegate void DisplayFileName(string dir);
        public event DisplayFileName sendFileName;
        public void Search(string dirName)
        {
            string[] files = Directory.GetFiles(dirName);
            string[] directories = Directory.GetDirectories(dirName);

            foreach (string file in files)
            {
                sendFileName(file);
                Thread.Sleep(1000);  // sleep after each file
            }

            foreach (string directory in directories)
            {
                Search(directory);
            }
        }
    }
}
