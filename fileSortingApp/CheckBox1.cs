using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fileSortingApp
{
    public class CheckBox1
    {
        public void FilesDeleter(string folderForSorting)
        {
            string[] filesToDelete = Directory.GetFiles(folderForSorting);
            foreach (string fileName in filesToDelete)
            {
                var fileExtension = Path.GetExtension(fileName);
                if (fileExtension == ".zip")
                {
                    File.Delete(fileName);
                }
            }
        }
        
    }
}
