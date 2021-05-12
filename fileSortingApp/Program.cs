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
            // variables list
            string folderForSorting = @"D:\C_Sharp\my projects\files for sorting\"; // initial folder with *.zip files
            string[] filesToSort = Directory.GetFiles(folderForSorting); // files list/array from initial folder

            // main loop
            foreach (string fileName in filesToSort)
            {
                string shortFileName = Path.GetFileNameWithoutExtension(fileName); // getting files name without extension (reqired for folders name)
                string fileNameForCopy = Path.GetFileName(fileName); // file name with extension
                if(!Directory.Exists(folderForSorting + shortFileName)) // existing folder check
                {
                    Directory.CreateDirectory(folderForSorting + shortFileName);
                } 
                else
                {
                    Console.WriteLine($"{shortFileName} folder is already exist");
                }
                string pathForUnzipping = Path.Combine(folderForSorting, shortFileName) + @"\"; // path for unzipping
                ZipFile.ExtractToDirectory(fileName, pathForUnzipping);
                Directory.CreateDirectory(pathForUnzipping + "Pic_files"); // sub-folder in shortFileName folder for picture
                Directory.CreateDirectory(pathForUnzipping + "Data_files"); // sub-folder in shortFileName for data
                string[] filesArray = Directory.GetFiles(pathForUnzipping); // files list in shortFileName folder 

                // loop for sorting files in shortFileName folder to pic_files and data_files sub-folder
                foreach (string fileImageOrData in filesArray)
                {
                    Directory.Move(fileImageOrData, pathForUnzipping + "Data_files");
                    Console.WriteLine(fileImageOrData); 
                }


            }
            

        }
    }
}
