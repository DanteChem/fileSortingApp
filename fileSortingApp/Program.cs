using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.IO.Compression;

namespace fileSortingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string dirName = @"D:\C_Sharp\my projects\files for sorting\";
            string[] files = Directory.GetFiles(dirName);
            foreach (string fileName in files)
            {
                string shortFileName = Path.GetFileNameWithoutExtension(fileName);
                string fileNameForCopy = Path.GetFileName(fileName);
                if(!Directory.Exists(dirName + shortFileName))
                {
                    Directory.CreateDirectory(dirName + shortFileName);
                } 
                else
                {
                    Console.WriteLine($"Folder {shortFileName} is already exist");
                }
                string fileFinalPath = Path.Combine(dirName, shortFileName, fileNameForCopy);
                File.Copy(fileName, fileFinalPath);
            }
            
            





            //string dirPath = @"D:\C_Sharp\my projects\files for sorting\";
            //DirectoryInfo _directory = new DirectoryInfo(dirPath);
            //FileInfo[] _files = _directory.GetFiles();
            //foreach (FileInfo file in _files)
            //{
            //    Console.WriteLine(file.Name);
            //}
        }
    }
}
