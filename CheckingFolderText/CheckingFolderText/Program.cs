using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CheckingFolderText
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo directory = new DirectoryInfo(@"C:\Users\User\Desktop\PP2Labs");
            DirectoryInfo[] ds = directory.GetDirectories();
            FileInfo[] fs = directory.GetFiles();
            FileSystemInfo[] fss = directory.GetFileSystemInfos();
            foreach(FileSystemInfo f in fss)
            {
                if (f.GetType() == typeof(DirectoryInfo))
                {
                    Console.WriteLine("Directory: " + f.Name);
                }
                else Console.WriteLine("File: " + f.FullName);
            }
            Console.ReadKey();
        }
    }
}
