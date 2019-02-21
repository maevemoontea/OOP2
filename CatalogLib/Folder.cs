using System;
using System.IO;
using System.Collections.Generic;

namespace CatalogLib
{
    public class Folder : DirectoryPath
    {
        private List<ImageFile> childImages = new List<ImageFile>();
        public string ChildImages {
            get {
                string namesOfImages = "";
                foreach (DirectoryPath image in childImages)
                {
                    namesOfImages += image.Name + " ";
                }
                return namesOfImages;
            }
        }
        private string mirrorDir;
        public string testString = "";

        public void SetImages()
        {
            testString = "1";

            string[] files = Directory.GetFiles(lookupPath);
            foreach (string s in files)
            {
                FileInfo file = new FileInfo(s);
                if (file.Extension == ".bmp")
                {
                    string imageName = file.Name;
                    ImageFile image = new ImageFile(s, mirrorDir, imageName, "bmp");
                    childImages.Add(item: image);
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
