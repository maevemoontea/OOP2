using System;
using System.IO;
using GlcmLib;

namespace CatalogLib
{
    public class ImageFile : DirectoryPath
    {
        private FileInfo image;
        private IGlcm glcm;
        public IGlcm Glcm { get { return glcm; } }
        private string extention;
        public override void Paste()
        {
            string fullName = resultPath + "/" + name + ".txt";
            FileInfo image = new FileInfo(fullName);
            image.Create();
            // what if such path doesn't exist? Should I create it?
        }

        public ImageFile(string lookup, string result, string imageName, string extention)
        : base(lookup, result)
        {
            name = imageName;
            this.extention = extention;
            string path = lookup + "/" + imageName;
            image = new FileInfo(path);
            switch (extention)
            {
                case "bmp":
                    glcm = new GlcmBmp();
                    break;
            }
        }
    }
}
