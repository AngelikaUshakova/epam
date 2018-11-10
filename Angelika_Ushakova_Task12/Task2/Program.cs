using System;
using System.IO;

namespace Task2
{
    class Program
    {
        const string pathRepos = @"..\..\repos";
        const string pathCopy = @"..\..\copy";

        static void Main(string[] args)
        {
            Console.WriteLine("Do you enable tracking?Y/N");

            if (Console.ReadLine() == "Y")
            {
                FileSystemWatcher fileSystemWatcher = new FileSystemWatcher(pathRepos)
                {
                    Filter = "*.txt",
                    IncludeSubdirectories = true
                };

                fileSystemWatcher.Changed += new FileSystemEventHandler(Changes.SaveChange);
                fileSystemWatcher.Deleted += new FileSystemEventHandler(Changes.SaveChange);
                fileSystemWatcher.Renamed += new RenamedEventHandler(Changes.SaveChange);
                fileSystemWatcher.EnableRaisingEvents = true;

                Changes.RollBack(fileSystemWatcher);
            }
            Console.ReadKey();
        }
    }
}
