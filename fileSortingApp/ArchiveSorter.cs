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
                string[] filesToSort = Directory.GetFiles(folderForSorting); // files list/array from initial folder

                // main loop
                foreach (string fileName in filesToSort)
                {
                    string shortFileName = Path.GetFileNameWithoutExtension(fileName); // getting files name without extension (reqired for folders name)
                    string fileNameForCopy = Path.GetFileName(fileName); // file name with extension

                    pathForUnzipping = pathForUnzipping + @"\";
                    string pathForUnzippingSub = Path.Combine(pathForUnzipping, shortFileName);
                    pathForUnzippingSub = pathForUnzippingSub + @"\";
                    ZipFile.ExtractToDirectory(fileName, pathForUnzippingSub);
                    Directory.CreateDirectory(pathForUnzippingSub + "Data_files");
                    string[] filesArray = Directory.GetFiles(pathForUnzippingSub);
                    string pathForData = Path.Combine(pathForUnzippingSub, "Data_files") + @"\";

                    //pathForUnzipping = pathForUnzipping + @"\";
                    //ZipFile.ExtractToDirectory(fileName, pathForUnzipping);
                    //Directory.CreateDirectory(pathForUnzipping + "Data_files"); // sub-folder in shortFileName for data
                    //string[] filesArray = Directory.GetFiles(pathForUnzipping); // files list in shortFileName folder 
                    //string pathForData = Path.Combine(pathForUnzipping, "Data_files") + @"\";

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
                    var pathForDataRecompression = Path.Combine(pathForUnzippingSub, "dataFiles.zip");
                    ZipFile.CreateFromDirectory(pathForData, pathForDataRecompression, CompressionLevel.Optimal, true);
                    Directory.Delete(pathForData, true);

                    //var pathForDataRecompression = Path.Combine(pathForUnzipping, "dataFiles.zip");
                    //ZipFile.CreateFromDirectory(pathForData, pathForDataRecompression, CompressionLevel.Optimal, true);
                    //Directory.Delete(pathForData, true);
                }
            }
            catch
            {

            }
        }

        // Folder exsist check
        //if (!Directory.Exists(folderForSorting + shortFileName)) // existing folder check
        //{
        //    Directory.CreateDirectory(folderForSorting + shortFileName);
        //}
        //else
        //{
        //    Console.WriteLine($"{shortFileName} folder is already exist");
        //}
        //string pathForUnzipping = Path.Combine(folderForSorting, shortFileName) + @"\"; // path for unzipping
    }
}
