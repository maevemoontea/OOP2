using System;
using System.IO;
using System.Collections.Generic;

namespace CatalogLib
{
    public class Folder : DirectoryPath
    {
        private List<ImageFile> childImages = new List<ImageFile>();
        // for test purpose only:
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

        public void SetImages()
        {
            string[] files = Directory.GetFiles(lookupPath);
            foreach (string s in files)
            {
                FileInfo file = new FileInfo(s);
                if (file.Extension == ".bmp")
                {
                    string imageName = file.Name;
                    ImageFile image = new ImageFile(s, mirrorDir, imageName, "bmp");
                    childImages.Add(image);
                }
            }
        }

        private List<Folder> childFolders = new List<Folder>();
        public void SetFolders()
        {
            string[] subdirs = Directory.GetDirectories(lookupPath);
            foreach (string s in subdirs)
            {
                DirectoryInfo dir = new DirectoryInfo(s);
                string subdirName = dir.Name;
                Folder subdir = new Folder(s, mirrorDir, subdirName);
                childFolders.Add(subdir);
            }
        }

        public override void Paste()
        {
            DirectoryInfo dir = new DirectoryInfo(resultPath);
            if (dir.Exists)
            {
                DirectoryInfo sub = dir.CreateSubdirectory(name);
                mirrorDir = sub.FullName;
            }
            // what if such path doesn't exist? Should I create it?
        }

        public Folder(string lookup, string result, string folderName)
            : base(lookup, result)
        {
            name = folderName;
        }

        public void RunExecution()
        {
            Paste();
            SetImages();
            foreach (ImageFile image in childImages)
            {
                image.Paste();
            }
            SetFolders();
            foreach (Folder dir in childFolders)
            {
                dir.RunExecution();
            }
        }
    }
}
