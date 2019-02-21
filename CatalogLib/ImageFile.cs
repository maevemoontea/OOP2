using System;
using System.IO;

namespace CatalogLib
{
    public class ImageFile : DirectoryPath
    {
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
        }
    }
}
