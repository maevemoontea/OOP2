using CatalogLib;
using GlcmLib;
using NUnit.Framework;

namespace OOP2Tests
{
    [TestFixture]
    class GlcmBmpTests
    {
        [Test]
        public void CON_isOutputedString()
        {
            string lookup = "D:\\oop2lab/images";
            string result = "D:\\oop2lab";
            string name = "image.bmp";
            string ext = "bmp";
            ImageFile image = new ImageFile(lookup, result, name, ext);

            string contrast = image.Glcm.CON();

            Assert.That(contrast, Is.EqualTo("contrast"));
        }

        [Test]
        public void ASM_isOutputedString()
        {
            string lookup = "D:\\oop2lab/images";
            string result = "D:\\oop2lab";
            string name = "image.bmp";
            string ext = "bmp";
            ImageFile image = new ImageFile(lookup, result, name, ext);

            string asm = image.Glcm.ASM();

            Assert.That(asm, Is.EqualTo("second angular momentum of the adjacency matrix"));
        }

        [Test]
        public void ENT_isOutputedString()
        {
            string lookup = "D:\\oop2lab/images";
            string result = "D:\\oop2lab";
            string name = "image.bmp";
            string ext = "bmp";
            ImageFile image = new ImageFile(lookup, result, name, ext);

            string entropy = image.Glcm.ENT();

            Assert.That(entropy, Is.EqualTo("entropy"));
        }

        [Test]
        public void COR_isOutputedString()
        {
            string lookup = "D:\\oop2lab/images";
            string result = "D:\\oop2lab";
            string name = "image.bmp";
            string ext = "bmp";
            ImageFile image = new ImageFile(lookup, result, name, ext);

            string correlation = image.Glcm.COR();

            Assert.That(correlation, Is.EqualTo("correlation"));
        }
    }
}
