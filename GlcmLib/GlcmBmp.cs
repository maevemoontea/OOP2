using System.IO;

namespace GlcmLib
{
    public class GlcmBmp : IGlcm
    {
        private int[,] glcm;
        public void GetGlcm(FileInfo image)
        {
            glcm = new int[,] { { 0, 1, 2 }, { 3, 4, 5 } };
        }

        // contrast:
        public string CON()
        {
            string contrast;
            contrast = "contrast";
            return contrast;
        }
        // second angular momentum of the adjacency matrix:
        public string ASM()
        {
            string secondAngMomentum;
            secondAngMomentum = "second angular momentum of the adjacency matrix";
            return secondAngMomentum;
        }
        // entropy:
        public string ENT()
        {
            string entropy;
            entropy = "entropy";
            return entropy;
        }
        // correlation
        public string COR()
        {
            string correlation;
            correlation = "correlation";
            return correlation;
        }
    }
}
