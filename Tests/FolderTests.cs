using CatalogLib;
using GlcmLib;
using NUnit.Framework;

namespace OOP2Tests
{
    [TestFixture]
    public class FolderTests
    {
        [Test]
        public void Folder_lookupResultFolderName_setItsLookupResultFolderName()
        {
            string lookup = "D:\\oop2lab/images";
            string result = "D:\\oop2lab";
            string name = "execution_folder";

            Folder testFolder = new Folder(lookup, result, name);

            Assert.That(testFolder.OriginPath, Is.EqualTo(lookup));
            Assert.That(testFolder.NewParentPath, Is.EqualTo(result));
            Assert.That(testFolder.Name, Is.EqualTo(name));
        }

        [Test]
        public void SetImages_isWorking()
        {
            string lookup = "D:\\oop2lab/images";
            string result = "D:\\oop2lab";
            string name = "execution_folder";

            Folder testFolder = new Folder(lookup, result, name);
            testFolder.SetImages();

            Assert.That(testFolder.testString, Is.EqualTo("1"));
        }

        [Test]
        public void SetImages_onMyFolder_filledChildImages()
        {
            string lookup = "D:\\oop2lab/images";
            string result = "D:\\oop2lab";
            string name = "execution_folder";

            Folder testFolder = new Folder(lookup, result, name);
            testFolder.SetImages();

            Assert.That(testFolder.ChildImages, Is.EqualTo("swirl_effect.bmp "));
        }
    }
}
