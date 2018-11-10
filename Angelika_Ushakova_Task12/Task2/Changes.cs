using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
   public static class Changes
    {
        const string pathRepos = @"..\..\repos";
        const string pathCopy = @"..\..\copy";


        public static void SaveChange(object sender, FileSystemEventArgs e)
        {
            DateTime time = DateTime.Now;

            DirectoryInfo dir = new DirectoryInfo(pathRepos);
            FileInfo[] fileInfo = dir.GetFiles("*.txt", SearchOption.AllDirectories);

            foreach (FileInfo file in fileInfo)
            {
                string nameCatalog = time.ToLocalTime().ToLongTimeString();
                nameCatalog = nameCatalog.Replace(":", ".");
                nameCatalog = $"{pathCopy}\\{nameCatalog}";

                if (!Directory.Exists(nameCatalog))
                {
                    CopyDir(pathRepos, nameCatalog);
                }
            }
            Console.WriteLine("Changes saved.");
        }

        private static void CopyDir(string FromDir, string ToDir)
        {
            if (ToDir == pathRepos)
            {
                Directory.Delete(ToDir, true);
            }
            Directory.CreateDirectory(ToDir);

            foreach (string file in Directory.GetFiles($"{FromDir}", "*.txt"))
            {
                string fileCopy = ToDir + "\\" + Path.GetFileName(file);
                File.Copy(file, fileCopy, true);
            }

            foreach (string derectory in Directory.GetDirectories(FromDir))
            {
                CopyDir(derectory, ToDir + "\\" + Path.GetFileName(derectory));
            }
        }

        public static void RollBack(FileSystemWatcher fileSystemWatcher)
        {
            Console.WriteLine("\nRoll back changes?Y");
            if (Console.ReadLine() == "Y")
            {
                RollBackChanges(fileSystemWatcher);

                RollBack(fileSystemWatcher);
            }
        }

        private static void RollBackChanges(FileSystemWatcher fileSystemWatcher)
        {
            fileSystemWatcher.EnableRaisingEvents = false;

            OutputTime();
            string time = ChooseTime();

            if (Directory.Exists(time))
            {
                CopyDir(time, pathRepos);
                Console.WriteLine("Finish");
            }
            else
            {
                Console.WriteLine("Does not exist!");
            }

            fileSystemWatcher.EnableRaisingEvents = true;
        }

        private static string ChooseTime()
        {
            Console.WriteLine("\nChoose a time:");

            string time = Console.ReadLine();
            time = $"{pathCopy}\\{time}";
            return time;
        }

        private static void OutputTime()
        {
            DirectoryInfo dir = new DirectoryInfo(pathCopy);
            DirectoryInfo[] directoryInfo = dir.GetDirectories();

            Console.WriteLine("\nTime:");

            foreach (DirectoryInfo directory in directoryInfo)
            {
                Console.WriteLine(directory.Name);
            }
        }

    }
}
