using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fileSortingApp
{
    public class ArchiveSorter
    {
        public void Sort(string folderForSorting, string pathForUnzipping)
        {
            try
            {
                // variables list
                // string folderForSorting = @"D:\C_Sharp\my projects\files for sorting\"; // initial folder with *.zip files
                string[] filesToSort = Directory.GetFiles(folderForSorting); // files list/array from initial folder

                // main loop
                foreach (string fileName in filesToSort)
                {
                    string shortFileName = Path.GetFileNameWithoutExtension(fileName); // getting files name without extension (reqired for folders name)
                    string fileNameForCopy = Path.GetFileName(fileName); // file name with extension
                                                                         //if (!Directory.Exists(folderForSorting + shortFileName)) // existing folder check
                                                                         //{
                                                                         //    Directory.CreateDirectory(folderForSorting + shortFileName);
                                                                         //}
                                                                         //else
                                                                         //{
                                                                         //    Console.WriteLine($"{shortFileName} folder is already exist");
                                                                         //}
                                                                         //string pathForUnzipping = Path.Combine(folderForSorting, shortFileName) + @"\"; // path for unzipping
                    pathForUnzipping = pathForUnzipping + @"\";
                    ZipFile.ExtractToDirectory(fileName, pathForUnzipping);
                    //Directory.CreateDirectory(pathForUnzipping + "Pic_files"); // sub-folder in shortFileName folder for picture
                    Directory.CreateDirectory(pathForUnzipping + "Data_files"); // sub-folder in shortFileName for data
                    string[] filesArray = Directory.GetFiles(pathForUnzipping); // files list in shortFileName folder 
                                                                                //string pathForImages = Path.Combine(pathForUnzipping, "Pic_files") + @"\";
                    string pathForData = Path.Combine(pathForUnzipping, "Data_files") + @"\";

                    // loop for sorting files in shortFileName folder to pic_files and data_files sub-folder
                    foreach (string fileImageOrData in filesArray)
                    {
                        var fileExtension = Path.GetExtension(fileImageOrData); // get files extension 
                        string fileNameForSorting = Path.GetFileName(fileImageOrData);
                        switch (fileExtension)
                        {
                            case ".jpg":
                            case ".bmp":
                            case ".gif":
                            case ".tif":
                            case ".png":
                                //  File.Move(fileImageOrData, pathForImages + fileNameForSorting); // moving images to folder or leave them in root
                                break;

                            default:
                                File.Move(fileImageOrData, pathForData + fileNameForSorting);
                                break;
                        }
                    }

                    // Re-compress Data_files folder and delete Data_files folder after compression
                    var pathForDataRecompression = Path.Combine(pathForUnzipping, "dataFiles.zip");
                    ZipFile.CreateFromDirectory(pathForData, pathForDataRecompression, CompressionLevel.Optimal, true);
                    Directory.Delete(pathForData, true);
                }
            }
            catch
            {
               
            }
        }
    }
}
