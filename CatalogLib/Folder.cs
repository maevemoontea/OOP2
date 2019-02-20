using System;
using System.IO;
using System.Collections.Generic;

namespace CatalogLib
{
    public class Folder : DirectoryPath
    {
        private List<DirectoryPath> childImages;
        private string mirrorDir;

        public void SetImages()
        {

            string[] files = Directory.GetFiles(lookupPath);
            foreach (string s in files)
            {
                FileInfo file = new FileInfo(s);
                if (file.Extension == "bmp")
                {
                    string imageName = file.Name;
                    ImageFile image = new ImageFile(s, mirrorDir, imageName, "bmp");
                    childImages.Add(image);
                }
            }
        }
        public override void Paste()
        {
            DirectoryInfo dir = new DirectoryInfo(resultPath);
            if (dir.Exists)
            {
                dir.CreateSubdirectory(name);
                mirrorDir = dir.FullName;
            }
            // what if such path doesn't exist?
        }

        public Folder(string lookup, string result, string folderName)
            : base(lookup, result)
        {
            name = folderName;
        }
    }
}
