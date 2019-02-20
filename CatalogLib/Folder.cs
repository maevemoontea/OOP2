using System;
using System.IO;

namespace CatalogLib
{
    class Folder : DirectoryPath
    {
        public override void Paste()
        {
            DirectoryInfo dir = new DirectoryInfo(resultPath);
            if (dir.Exists)
            {
                dir.CreateSubdirectory(name);
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
