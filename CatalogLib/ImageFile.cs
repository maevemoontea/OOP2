using System;
using System.IO;

namespace CatalogLib
{
    public class ImageFile : DirectoryPath
    {
        public override void Paste()
        {

        }

        public ImageFile(string lookup, string result, string imageName, string extention)
        : base(lookup, result)
        {
            name = imageName;
        }
    }
}
