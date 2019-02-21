using System;
using System.Text;
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
            FileInfo imageInfoFile = new FileInfo(fullName);
           // imageInfoFile.Create();
            // what if such path does exist?
            string parameters = GetGlcmParametrs();
            using (FileStream fs = new FileStream(fullName, FileMode.OpenOrCreate))
            {
                byte[] input = Encoding.Default.GetBytes(parameters);
                // запись массива байтов в файл
                fs.Write(input, 0, input.Length);
            }
        }
        public string GetGlcmParametrs()
        {
            string text = "";
            text += Glcm.CON() + "; ";
            text += Glcm.ASM() + "; ";
            text += Glcm.ENT() + "; ";
            text += Glcm.COR() + "; ";
            return text;
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
