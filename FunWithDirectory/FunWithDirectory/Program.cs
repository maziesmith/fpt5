using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fun with directory info\n");
            DirectoryInfo dir = new DirectoryInfo(@"D:\Executable");

            #region Fun with directory
            Console.WriteLine("Fullname: {0}", dir.FullName);
            Console.WriteLine("Name: {0}", dir.Name);
            Console.WriteLine("Parent: {0}", dir.Parent);
            Console.WriteLine("Creation: {0}", dir.CreationTime);
            Console.WriteLine("Attributes: {0}", dir.Attributes);
            Console.WriteLine("Root: {0}", dir.Root);
            #endregion

            #region List all exe files
            FileInfo[] exeFiles = dir.GetFiles("*.exe");
            Console.WriteLine("Found {0} *.exe files", exeFiles.Length);
            foreach (FileInfo file in exeFiles)
            {
                Console.WriteLine($"File name: {file.FullName}");
                Console.WriteLine($"File size: {file.Length / 1024 / 1024} MB");
                Console.WriteLine($"Creation: {file.CreationTime}");
                Console.WriteLine($"Attribues: {file.Attributes}");
            }
            #endregion

            #region Write all text
            File.WriteAllText(@"D:\test.txt",
                new StringBuilder().AppendLine("Hello")
                    .AppendLine("World")
                    .AppendLine("!")
                    .ToString());
            Console.WriteLine(File.ReadAllText(@"D:\test.txt"));
            #endregion
        }
    }
}
